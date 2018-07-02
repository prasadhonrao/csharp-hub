using Coding4Fun.Toolkit.Audio;
using Coding4Fun.Toolkit.Audio.Helpers;
using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json;
using SoundJabber.Resources;
using SoundJabber.ViewModels;
using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Navigation;

namespace SoundJabber
{
    public partial class RecordAudio : PhoneApplicationPage
    {
        MicrophoneRecorder recorder;
        IsolatedStorageFileStream audioStream;
        string tempFile = "tempwav.wav";

        public RecordAudio()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
            recorder = new MicrophoneRecorder();
            RecordToggleButton.Content = AppResources.StartRecordingText;
        }

        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton saveButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/save.png", UriKind.Relative));
            saveButton.Text = AppResources.AppBarSaveButtonText;
            saveButton.Click += SaveButton_Click;
            ApplicationBar.Buttons.Add(saveButton);
            ApplicationBar.IsVisible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            InputPrompt prompt = new InputPrompt();
            prompt.Message = "Enter the sound name";
            prompt.Title = "Sound Name";
            prompt.Completed += Prompt_Completed;
            prompt.Show();
        }

        private void Prompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            if (e.PopUpResult == PopUpResult.Ok)
            {
                SoundData sound = new SoundData();
                sound.FilePath = string.Format("/customAudio/{0}.wav", DateTime.Now.ToFileTime());
                sound.Title = e.Result;

                var respose = ValidateCustomSound(sound);
                if (respose.IsValid)
                {

                    using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
                    {
                        if (!isoStore.DirectoryExists("/customAudio/"))
                        {
                            isoStore.CreateDirectory("/customAudio/");
                        }

                        isoStore.MoveFile(tempFile, sound.FilePath);

                        App.ViewModel.CustomSounds.Items.Add(sound);

                        // save to applicationsettings
                        var data = JsonConvert.SerializeObject(App.ViewModel.CustomSounds);
                        IsolatedStorageSettings.ApplicationSettings[Constants.CustomSoundKey] = data;
                        IsolatedStorageSettings.ApplicationSettings.Save();

                        NavigationService.Navigate(new Uri("/MainPage.xaml?pivotItem=custom", UriKind.RelativeOrAbsolute));
                    }
                }
                else
                {
                    var messagePrompt = new MessagePrompt
                    {
                        Title = AppResources.ApplicationTitle,
                        Message = respose.Message
                    };
                    messagePrompt.Show();
                }
            }
        }

        private ValidateCustomSoundResponse ValidateCustomSound(SoundData customSound)
        {
            var response = new ValidateCustomSoundResponse { IsValid = true, Message = SoundValidation.ValidSoundMessage };

            #region Custom sound name validation - Empty string
            if (customSound.Title.Trim().Length == 0)
            {
                response.IsValid = false;
                response.Message = SoundValidation.EmptySoundMessage;
                return response;
            }
            #endregion

            #region Custom sound name validation - Length
            if (customSound.Title.Length > 10)
            {
                response.IsValid = false;
                response.Message = SoundValidation.InvalidLengthSoundMessage;
                return response;
            }
            #endregion

            #region Special character handling in Sound Title
            foreach (char c in customSound.Title)
            {
                if (Char.IsWhiteSpace(c))
                    continue;
                else if (!Char.IsLetterOrDigit(c))
                {
                    response.IsValid = false;
                    response.Message = SoundValidation.SpecialCharacterSoundMessage;
                    return response;
                }
            }
            #endregion

            #region Check for duplicate sound
            SoundGroup group = null;
            string dataFromAppSettings;
            if (IsolatedStorageSettings.ApplicationSettings.TryGetValue(Constants.CustomSoundKey, out dataFromAppSettings))
            {
                group = JsonConvert.DeserializeObject<SoundGroup>(dataFromAppSettings);
            }

            if (group != null)
            {
                foreach (var item in group.Items)
                {
                    if (customSound.Title.Equals(item.Title))
                    {
                        response.IsValid = false;
                        response.Message = SoundValidation.DuplicateCustomSoundMessage;
                        return response;
                    }
                }
            }
            #endregion

            #region Check for available space in store
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (tempFile.Length > isoStore.AvailableFreeSpace)
                {
                    response.IsValid = false;
                    response.Message = SoundValidation.StorageErrorSoundMessage;
                    return response;
                }
            }

            #endregion

            return response;
        }

        private void RecordToggleButton_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            PlayAudioButton.IsEnabled = false;
            ApplicationBar.IsVisible = false;
            RotateAudioGrid.Begin();
            recorder.Start();
            RecordToggleButton.Content = AppResources.StopRecordingText;
        }

        private void RecordToggleButton_Unchecked(object sender, System.Windows.RoutedEventArgs e)
        {
            recorder.Stop();
            RotateAudioGrid.Stop();
            SaveAudioFile(recorder.Buffer);

            PlayAudioButton.IsEnabled = true;
            ApplicationBar.IsVisible = true;
            RecordToggleButton.Content = AppResources.StartRecordingText;
        }

        private void SaveAudioFile(MemoryStream buffer)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(SoundValidation.NoSoundToSaveMessage);
            }

            if (audioStream != null)
            {
                AudioPlayer.Stop();
                AudioPlayer.Source = null;
                audioStream.Dispose();
            }

            var bytes = buffer.GetWavAsByteArray(recorder.SampleRate);


            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (isoStore.FileExists(tempFile))
                    isoStore.DeleteFile(tempFile);

                tempFile = string.Format("{0}.wav", DateTime.Now.ToFileTime());

                audioStream = isoStore.CreateFile(tempFile);
                audioStream.Write(bytes, 0, bytes.Length);
                AudioPlayer.SetSource(audioStream);
            }
        }

        private void PlayAudioButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AudioPlayer.Play();
        }
    }
}
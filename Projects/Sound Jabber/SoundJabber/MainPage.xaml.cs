using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json;
using SoundJabber.Resources;
using SoundJabber.ViewModels;
using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SoundJabber
{
    public partial class MainPage : PhoneApplicationPage
    {
        public SoundData CurrentItem { get; set; }
        bool canTerminateApp = false;

        public MainPage()
        {
            InitializeComponent();

            DataContext = App.ViewModel;

            BuildLocalizedApplicationBar();

            AudioPlayer.MediaEnded += AudioPlayer_MediaEnded;
        }

        void AudioPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (this.canTerminateApp)
                Application.Current.Terminate();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            #region Play sound from Phone start screen and then navigate to specific pivot item

            canTerminateApp = false;

            if (this.NavigationContext.QueryString.ContainsKey("audioFile"))
            {
                var soundFile = this.NavigationContext.QueryString["audioFile"].ToString();

                if (File.Exists(soundFile))
                {
                    AudioPlayer.Source = new Uri(soundFile, UriKind.RelativeOrAbsolute);
                    AudioPlayer.Play();
                    canTerminateApp = true;
                }
                else
                {
                    using (var storageFolder = IsolatedStorageFile.GetUserStoreForApplication())
                    {
                        using (var stream = new IsolatedStorageFileStream(soundFile, FileMode.Open, storageFolder))
                        {
                            AudioPlayer.SetSource(stream);
                            AudioPlayer.Play();
                        }
                    }
                }
            }

            #endregion

            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            else
            {
                if (this.NavigationContext.QueryString.ContainsKey("pivotItem"))
                {
                    // Navigate to custom pivot item
                    if (this.NavigationContext.QueryString["pivotItem"].Equals("custom"))
                    {
                        Pivot.SelectedItem = CustomPivotItem;
                    }
                }
            }

            if (this.NavigationContext.QueryString.ContainsKey("pivotItemIndex"))
            {
                int index = Convert.ToInt32(this.NavigationContext.QueryString["pivotItemIndex"]);
                Pivot.SelectedIndex = index; ;
            }
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector selector = sender as LongListSelector;
            if (selector == null)
                return;

            SoundData data = selector.SelectedItem as SoundData;
            if (data == null)
            {
                return;
            }
            else
            {
                // store it for context menu
                this.CurrentItem = data;
            }

            if (File.Exists(data.FilePath))
            {
                AudioPlayer.Source = new Uri(data.FilePath, UriKind.RelativeOrAbsolute);
            }
            else
            {
                try
                {
                    using (var storageFolder = IsolatedStorageFile.GetUserStoreForApplication())
                    {
                        using (var stream = new IsolatedStorageFileStream(data.FilePath, FileMode.Open, storageFolder))
                        {
                            AudioPlayer.SetSource(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    string s = ex.Message;
                }
            }

            // to replay the sound if same tile click multiple times
            selector.SelectedItem = null;
        }

        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton recordButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/microphone.png", UriKind.Relative));
            recordButton.Text = AppResources.AppBarRecordButtonText;
            recordButton.Click += RecordButton_Click;
            ApplicationBar.Buttons.Add(recordButton);

            ApplicationBarMenuItem settingsMenuItem = new ApplicationBarMenuItem(AppResources.SettingsPageTitle);
            settingsMenuItem.Click += SettingsMenuItem_Click;
            ApplicationBar.MenuItems.Add(settingsMenuItem);

            ApplicationBarMenuItem aboutAuthorMenuItem = new ApplicationBarMenuItem(AppResources.AppBarAboutAuthorMenuItemText);
            aboutAuthorMenuItem.Click += AboutAuthorMenuItem_Click;
            ApplicationBar.MenuItems.Add(aboutAuthorMenuItem);
        }

        private void AboutAuthorMenuItem_Click(object sender, EventArgs e)
        {
            //AboutPrompt aboutMe = new AboutPrompt();
            //aboutMe.Show("Prasad Honrao", "PrasadHonrao", websiteUrl: "http://PrasadHonrao.com");`
            NavigationService.Navigate(new Uri("/AboutAuthorPage.xaml", UriKind.Relative));
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/SettingsPage.xaml", UriKind.Relative));
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/RecordAudio.xaml", UriKind.Relative));
        }

        private void Pin_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SoundData data = (sender as MenuItem).DataContext as SoundData;

            //StandardTileData standardTileData = new StandardTileData();
            //standardTileData.BackgroundImage = new Uri("/Assets/ApplicationIcon.png", UriKind.RelativeOrAbsolute);
            //standardTileData.Title = data.Title;
            //standardTileData.BackTitle = data.Title;
            //standardTileData.BackContent = AppResources.ApplicationTitle;
            //standardTileData.BackBackgroundImage = null;

            //IconicTileData tile = new IconicTileData();
            //tile.IconImage = new Uri("/Assets/Tiles/TileImageMedium.png", UriKind.RelativeOrAbsolute);
            //tile.SmallIconImage = new Uri("/Assets/Tiles/TileImageSmall.png", UriKind.RelativeOrAbsolute);
            //tile.Title = data.Title;

            FlipTileData tile = new FlipTileData();
            tile.BackContent = data.Title;
            tile.BackgroundImage = new Uri("/Assets/Tiles/TileImageMedium.png", UriKind.RelativeOrAbsolute);
            tile.SmallBackgroundImage = new Uri("/Assets/Tiles/TileImageSmall.png", UriKind.RelativeOrAbsolute);
            tile.Title = data.Title;

            var navUrl = "/MainPage.xaml?audioFile=" + data.FilePath + "&pivotItemIndex=" + Pivot.SelectedIndex;

            Uri u = new Uri(navUrl, UriKind.Relative);

            ShellTile tiletopin = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.ToString().Contains(u.OriginalString));

            if (tiletopin == null)
            {
                ShellTile.Create(u, tile, false);
            }
            else
            {
                MessageBox.Show(string.Format("{0} sound already pinned!", data.Title));
            }
        }

        private void Delete_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SoundData data = (sender as MenuItem).DataContext as SoundData;
            SoundGroup group = null;
            string dataFromAppSettings;

            if (IsolatedStorageSettings.ApplicationSettings.TryGetValue(Constants.CustomSoundKey, out dataFromAppSettings))
            {
                group = JsonConvert.DeserializeObject<SoundGroup>(dataFromAppSettings);
            }

            foreach (var item in group.Items)
            {
                if (data.Title.Equals(item.Title))
                {
                    group.Items.Remove(item);
                    App.ViewModel.CustomSounds.Items.Remove(item);

                    // Delete sound file from store
                    using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
                    {
                        if (isoStore.FileExists(item.FilePath))
                        {
                            isoStore.DeleteFile(item.FilePath);
                            break;
                        }
                    }
                }
            }

            // Update ApplicationSettings
            var newData = JsonConvert.SerializeObject(group);
            IsolatedStorageSettings.ApplicationSettings[Constants.CustomSoundKey] = newData;
            IsolatedStorageSettings.ApplicationSettings.Save();

            App.ViewModel.LoadData();
            NavigationService.Navigate(new Uri("/NavigationPage.xaml", UriKind.Relative));
        }

        private void ContextMenu_Load(object sender, System.Windows.RoutedEventArgs e)
        {
            ContextMenu c = sender as ContextMenu;

            PivotItem item = Pivot.SelectedItem as PivotItem;
            if (!item.Header.Equals("Custom"))
            {
                MenuItem deleteMenuItem = c.Items[1] as MenuItem;
                deleteMenuItem.IsEnabled = false;
            }
        }
    }
}
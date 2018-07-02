
using Newtonsoft.Json;
using System.IO.IsolatedStorage;
namespace SoundJabber.ViewModels
{
    public class SoundModel
    {
        public SoundGroup Animals { get; set; }
        public SoundGroup Cartoons { get; set; }
        public SoundGroup Warnings { get; set; }
        public SoundGroup CustomSounds { get; set; }
        public SoundGroup Taunts { get; set; }
        public SoundGroup Vehicles { get; set; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData()
        {
            Animals = CreateAnimalsGroup();
            Cartoons = CreateCartoonsGroup();
            Taunts = CreateTauntsGroup();
            Vehicles = CreateVehiclesGroup();
            Warnings = CreateWarningsGroup();
            CustomSounds = LoadCustomSounds();

            IsDataLoaded = true;
        }

        private SoundGroup CreateVehiclesGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Vehicles";
            string basePath = "assets/audio/vehicles/";

            data.Items.Add(new SoundData
            {
                Title = "Bicycle Bell",
                FilePath = basePath + "Bicycle Bell.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Car Horn",
                FilePath = basePath + "Car Horn.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Car Start",
                FilePath = basePath + "Car Start.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Motorcycle",
                FilePath = basePath + "Motorcycle.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Motorcycle Harley",
                FilePath = basePath + "Motorcycle Harley.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Old Horn",
                FilePath = basePath + "Old Horn.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Train Crossing",
                FilePath = basePath + "Train Crossing.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Truck Backing Up",
                FilePath = basePath + "Truck Backing Up.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Truck Horn",
                FilePath = basePath + "Truck Horn.wav"
            });

            return data;
        }

        private SoundGroup LoadCustomSounds()
        {
            SoundGroup data;
            string dataFromAppSettings;

            if (IsolatedStorageSettings.ApplicationSettings.TryGetValue(Constants.CustomSoundKey, out dataFromAppSettings))
            {
                data = JsonConvert.DeserializeObject<SoundGroup>(dataFromAppSettings);
            }
            else
            {
                data = new SoundGroup();
                data.Title = "Custom";
            }

            return data;
        }

        private SoundGroup CreateWarningsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "warnings";
            string basePath = "assets/audio/warnings/";

            data.Items.Add(new SoundData
            {
                Title = "Air horn",
                FilePath = basePath + "Air horn.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Air Raid",
                FilePath = basePath + "Air Raid.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Alarm Clock - Electric",
                FilePath = basePath + "Alarm Clock - Electric.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Alarm Clock - Bell",
                FilePath = basePath + "Alarm Clock - Bell.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Backing up",
                FilePath = basePath + "Backing up.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Bell - Church",
                FilePath = basePath + "Bell - Church.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Bell - School",
                FilePath = basePath + "Bell - School.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Fog horn",
                FilePath = basePath + "Fog horn.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Glass breaking",
                FilePath = basePath + "Glass breaking.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Missle alert",
                FilePath = basePath + "Missle alert.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Police - UK",
                FilePath = basePath + "Police - UK.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Police - US",
                FilePath = basePath + "Police - US.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Vuvuzela",
                FilePath = basePath + "Vuvuzela.wav"
            });

            return data;
        }

        private SoundGroup CreateTauntsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "taunts";
            string basePath = "assets/audio/taunts/";

            data.Items.Add(new SoundData
            {
                Title = "Cackle",
                FilePath = basePath + "Cackle.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Clock Ticking",
                FilePath = basePath + "Clock Ticking.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Dial up",
                FilePath = basePath + "Dial up.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Drum roll",
                FilePath = basePath + "Drum roll.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Elevator Music",
                FilePath = basePath + "Elevator Music.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Laugh",
                FilePath = basePath + "Laugh.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Laugh - Evil",
                FilePath = basePath + "Laugh - Evil.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Wrong Price",
                FilePath = basePath + "Wrong Price.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sad Trombone",
                FilePath = basePath + "Sad Trombone.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sarcastic Ooo",
                FilePath = basePath + "Sarcastic Ooo.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sigh",
                FilePath = basePath + "Sigh.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Snore",
                FilePath = basePath + "Snore.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Yawn",
                FilePath = basePath + "Yawn.wav"
            });

            return data;
        }

        private SoundGroup CreateCartoonsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "cartoons";
            string basePath = "assets/audio/cartoons/";

            data.Items.Add(new SoundData
            {
                Title = "Boing",
                FilePath = basePath + "Boing.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Bronk",
                FilePath = basePath + "Bronk.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Bugle charge",
                FilePath = basePath + "Bugle charge.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Laser",
                FilePath = basePath + "Laser.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Out Here",
                FilePath = basePath + "Out Here.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Splat",
                FilePath = basePath + "Splat.wav"
            });

            return data;
        }

        private SoundGroup CreateAnimalsGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "animals";
            string basePath = "assets/audio/animals/";

            data.Items.Add(new SoundData
            {
                Title = "Cat Kitten",
                FilePath = basePath + "Cat Kitten.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cat Meow",
                FilePath = basePath + "Cat Meow.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Chimpanzee",
                FilePath = basePath + "Chimpanzee.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cow",
                FilePath = basePath + "Cow.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Crickets",
                FilePath = basePath + "Crickets.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Dog",
                FilePath = basePath + "Dog.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Dolphin",
                FilePath = basePath + "Dolphin.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Duck",
                FilePath = basePath + "Duck.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Horse Gallop",
                FilePath = basePath + "Horse Gallop.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Horse Walk",
                FilePath = basePath + "Horse Walk.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Lion",
                FilePath = basePath + "Lion.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Pig",
                FilePath = basePath + "Pig.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Rooster",
                FilePath = basePath + "Rooster.wav"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sheep",
                FilePath = basePath + "Sheep.wav"
            });

            return data;
        }
    }
}

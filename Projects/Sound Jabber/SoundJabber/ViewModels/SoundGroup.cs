using System.Collections.Generic;

namespace SoundJabber.ViewModels
{
    public class SoundGroup
    {
        public SoundGroup()
        {
            Items = new List<SoundData>();
        }
        public string Title { get; set; }

        public List<SoundData> Items { get; set; }
    }
}

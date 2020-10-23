using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory soundCategory)
        {
            Name = name;

            Category = soundCategory;
            AudioFile = String.Format("/Assets/Audio/{0}/{1}.mp3", Category, name);
            ImageFile = String.Format("/Assets/Images/{0}/{1}.jpg", Category, name);

        }
    }
   

    public enum SoundCategory
    {
        Beethoven,
        Pop,
        Rap
    }
}

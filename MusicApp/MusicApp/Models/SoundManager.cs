using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class SoundManager
    {
        public static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Beethoven", SoundCategory.Beethoven));
            sounds.Add(new Sound("Flaming", SoundCategory.Beethoven));
            sounds.Add(new Sound("BaiNayChillPhet", SoundCategory.Pop));
            sounds.Add(new Sound("BanhMiKhong", SoundCategory.Pop));
            sounds.Add(new Sound("Beethoven", SoundCategory.Rap));
            sounds.Add(new Sound("ThienDang", SoundCategory.Rap));
            return sounds;
        }
        public static void GetAllSound(ObservableCollection<Sound> sounds)
        {
            var allSounds = GetSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundByCategory(SoundCategory category, ObservableCollection<Sound> sounds)
        {
            var allSounds = GetSounds();
            var filterSound = allSounds.Where(p => p.Category == category).ToList();
            sounds.Clear();
            filterSound.ForEach(p => sounds.Add(p));
        }
    }
}

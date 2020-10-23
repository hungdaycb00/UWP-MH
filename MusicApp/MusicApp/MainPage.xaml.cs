using MusicApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MusicApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Sound> sounds;
        private List<NewItem> newItems;
        public MainPage()
        {
            this.InitializeComponent();
            sounds = new ObservableCollection<Sound>();
            SoundManager.GetAllSound(sounds);
            newItems = new List<NewItem>();
            newItems.Add(new NewItem { iconFile = "Assets/Icons/piano.jpg", category = SoundCategory.Beethoven });
            newItems.Add(new NewItem { iconFile = "Assets/Icons/pop.jpg" ,category = SoundCategory.Pop});
            newItems.Add(new NewItem { iconFile = "Assets/Icons/rap.jpg", category = SoundCategory.Rap });
            
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void SoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sound = (Sound)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, sound.AudioFile);
            if (SoundGridView.IsItemClickEnabled)
            {
                
            }
           
        }

        private void MenuItemListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (NewItem)e.ClickedItem;
            TitleTextBlock.Text = menuItem.category.ToString();
            SoundManager.GetSoundByCategory(menuItem.category, sounds );

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {

            SoundManager.GetAllSound(sounds);
            TitleTextBlock.Text = "All Songs";
        }

      
    }
}

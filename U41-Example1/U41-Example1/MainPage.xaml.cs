using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using U41_Example1.Models;
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

namespace U41_Example1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<IconSS> Icons;
        //private List<Contact< Contacts;
        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<IconSS>();
   
            Icons.Add(new IconSS { iconPath = "Assets/female-01.png" });
            Icons.Add(new IconSS { iconPath = "Assets/female-02.png" });
            Icons.Add(new IconSS { iconPath = "Assets/female-03.png" });
            Icons.Add(new IconSS { iconPath = "Assets/male-01.png" });
            Icons.Add(new IconSS { iconPath = "Assets/male-02.png" });
            Icons.Add(new IconSS { iconPath = "Assets/male-03.png" });
          

            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { FirstName = "Manh", LastName = "Hung", AvataPath = "Assets/male-01.png" });

        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((IconSS)AvatarComboBox.SelectedValue).iconPath;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, AvataPath = avatar });

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AvatarComboBox.SelectedItem = -1;
            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}

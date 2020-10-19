using System;
using System.Collections.Generic;
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
using u41_BookApp.Models;
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace u41_BookApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Book> Books;
        private ObservableCollection<BookChoice> BookChoices;
        public MainPage()
        {
            this.InitializeComponent();
            Books = ManagerBook.GetBooks();

            BookChoices = new ObservableCollection<BookChoice>();
          
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var book = (Book)e.ClickedItem;
            //ImageClick.Source = new BitmapImage(new Uri("ms-appx:///" + book.coverPath));
            //TitleClick.Text = book.name;
            //PriceClick.Text = book.price.ToString();
            BookChoices.Add(new BookChoice { name = book.name, price = book.price, coverPath = book.coverPath, quantity = book.quantity });
            
        }
    }
}

using ProductCategory.Models;
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

namespace ProductCategory
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();
            Products = new ObservableCollection<Product>();
           
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AllProduct.IsSelected)
            {
                TitleTextBlock.Text = "All Products";
                NewManager.GetAll(Products);
            }
            if (Iphone.IsSelected)
            {
                TitleTextBlock.Text = "Iphone";
                NewManager.GetNews("Iphone", Products);
                
            }
            else if (Samsung.IsSelected)
            {
                TitleTextBlock.Text = "Samsung";
                NewManager.GetNews("Samsung", Products);
                
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MysplitView.IsPaneOpen = !MysplitView.IsPaneOpen;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AllProduct.IsSelected = true;
        }
    }
}

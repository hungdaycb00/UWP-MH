﻿using System;
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
using ProductHomeWork.Model;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductHomeWork
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<ListProduct> listProducts;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();
            Icons.Add(new Icon { ImagePath = "Assets/food1.jpg" });
            Icons.Add(new Icon { ImagePath = "Assets/food2.jpg" });
            Icons.Add(new Icon { ImagePath = "Assets/finacial1.png" });
            Icons.Add(new Icon { ImagePath = "Assets/finacial2.jpg" });
            listProducts = new ObservableCollection<ListProduct>();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icon)ComboBox.SelectedValue).ImagePath;
            listProducts.Add(new ListProduct { nameProduct = NameTextBox.Text, ImagePath = image });


        }
    }
}

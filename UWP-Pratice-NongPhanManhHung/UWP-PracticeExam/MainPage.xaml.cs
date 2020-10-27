using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using UWP_PracticeExam.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_PracticeExam
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<ImageProduct> ImageProducts;
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();
            ImageProducts = new List<ImageProduct>();
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/aokhoac.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/quandui.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/quandai.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/aochongnang.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/aophihanhgia.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/giaygucci.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/giaysnaker.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/quanboi.jpg" });
            ImageProducts.Add(new ImageProduct { ImageProductPath = "Assets/aokhoac.jpg" });
            Products = new ObservableCollection<Product>();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string imageproduct = ((ImageProduct)ImageComboBox.SelectedValue).ImageProductPath;
            Products.Add(new Product { Name = NameProductTextBox.Text, Description = DescTextBox.Text, ImageProductPath = imageproduct });

            NameProductTextBox.Text = "";
            DescTextBox.Text = "";
            ImageComboBox.SelectedItem = -1;
            NameProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}

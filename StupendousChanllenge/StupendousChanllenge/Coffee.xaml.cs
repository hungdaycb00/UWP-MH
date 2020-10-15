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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousChanllenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffee : Page
    {
        private string _roast;
        private string _sweeter;
        private string _scream;

        public Coffee()
        {
            this.InitializeComponent();
        }

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            displayResult();

        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweeter = selected.Text;
            displayResult();
        }

        private void Scream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _scream = selected.Text;
            displayResult();
        }
        private void displayResult()
        {
            if(_roast == null || string.IsNullOrEmpty(_roast))
            {
                ResultTextBlock.Text = "None";
                return;
            }
            ResultTextBlock.Text = _roast;
            if(_scream != "None" && !String.IsNullOrEmpty(_scream))
            {
                ResultTextBlock.Text += " + " + _scream;
            }
            if (_sweeter != "None" && !String.IsNullOrEmpty(_sweeter))
            {
                ResultTextBlock.Text += " + " + _sweeter;
            }
        }
    }
}

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

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace CalcGitFinaly
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            numb3.Text = (Convert.ToInt32(numb1.Text) + Convert.ToInt32(numb2.Text)).ToString();
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            numb3.Text = (Convert.ToInt32(numb1.Text) - Convert.ToInt32(numb2.Text)).ToString();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

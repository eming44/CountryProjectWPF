using CountryWPF.Assets;
using CountryWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CountryWPF.Views
{
    /// <summary>
    /// Interaction logic for AddCountry.xaml
    /// </summary>
    public partial class AddCountry : UserControl
    {
        public AddCountry()
        {
            InitializeComponent();

            this.countryName.Clear();
            this.capitalName.Clear();
            this.countryInfo.Clear();
            this.countryPath.Clear();
        }
        private void ResetTextBoxes(object sender, RoutedEventArgs e)
        {
            this.countryName.Clear();
            this.capitalName.Clear();
            this.countryInfo.Clear();
            this.countryPath.Clear();
        }
        private void EnterRussiaInfo(object sender, RoutedEventArgs e)
        {
            this.countryName.Text = "Russia";
            countryName.CaretIndex = 4;
            this.capitalName.Text = "Moscow";
            this.countryInfo.Text =
            "Official languages: Russian\n" +
            "Government: Federal dominant-party semi-presidential constitutional republic\n" +
            "Area: 17,125,191 km2\n" +
            "Population: 146,793,744";
            this.countryPath.Text = "Images\\Countries\\russia.png";

            MessageBox.Show("Please click every text box at the end of the text to add the info before you save the country.");
        }
    }
}

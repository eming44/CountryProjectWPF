using CountryWPF.ViewModel;
using CountryWPF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace CountryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private AddCountry addControl = new AddCountry();
        private CountryUserControl countryUserCtrl = new CountryUserControl();

        public MainWindow()
        {
            InitializeComponent();
            GridPrincipal.Children.Add(countryUserCtrl);

            //GridPrincipal.Children.Add(new CountryUserControl());
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    //GridPrincipal.Children.Add(new CountryUserControl());
                    GridPrincipal.Children.Add(countryUserCtrl);
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new CountryList());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    //gridprincipal.children.add(new addcountry());
                    GridPrincipal.Children.Add(addControl);
                    
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TransitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }
    }
}

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

namespace wpf_10_03_2023_aplikacja_jakas_tam_kwadrat_rysowanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
            double bok, bok2;
            if (double.TryParse(txtBok.Text, out bok) && bok <= 400 && double.TryParse(txtBok2.Text, out bok2) && bok2 <= 400)
            {
                rectangle.Height = bok;
                rectangle.Width = bok2;
                SolidColorBrush color = (SolidColorBrush) new BrushConverter().ConvertFromString(cmbKolory.Text);
                rectangle.Stroke = color;
                rectangle.Fill = color;

                rectangle.Opacity = (cbPrzezr.IsChecked.Value) ? 0.5 : 1;
            }
            else
            {
                lblKomunikat.Content = "brak danych lub zbyt duzy wymiar";
            }
        }

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtPole.Text = String.Empty;
            txtObwod.Text = String.Empty;
            lblKomunikat.Content = "Wpisz wymiar boku";
        }

        private void cbPrzezr_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cmbKolory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtObwod_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPole_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok, bok2;
            if (double.TryParse(txtBok.Text, out bok) && bok >= 0 && double.TryParse(txtBok2.Text, out bok2) && bok2 >= 0)
            {
                lblKomunikat.Content = String.Empty;
                txtPole.Text = (bok * bok2).ToString();
                txtObwod.Text = ((bok * 2) + (bok2 * 2)).ToString();
                lblKomunikat.Content = "";
            }
            else
            {
                lblKomunikat.Content = "Wpisz liczbę dodatnia";
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            rectangle.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            rectangle.Visibility = Visibility.Visible;
        }
    }
}

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

namespace lab3
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

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(boxA.Text);
                double b = Convert.ToDouble(boxB.Text);
                textWynik.Text = "Suma " + a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane!", "Uwaga", MessageBoxButton.OK);
            }
        }

        private void btnRoznica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(boxA.Text);
                double b = Convert.ToDouble(boxB.Text);
                textWynik.Text = "Różnica " + a.ToString() + " - " + b.ToString() + " = " + (a - b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane!", "Uwaga", MessageBoxButton.OK);
            }
        }

        private void btnIloczyn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(boxA.Text);
                double b = Convert.ToDouble(boxB.Text);
                textWynik.Text = "Iloczyn " + a.ToString() + " * " + b.ToString() + " = " + (a * b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane!", "Uwaga", MessageBoxButton.OK);
            }
        }

        private void btnIloraz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(boxA.Text);
                double b = Convert.ToDouble(boxB.Text);
                if (b == 0)
                {
                    textWynik.Text = "Nie można dzielić przez zero!";
                    MessageBox.Show("Nie można dzielić przez zero!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    textWynik.Text = "Iloraz " + a.ToString() + " / " + b.ToString() + " = " + (a / b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane!", "Uwaga", MessageBoxButton.OK);
            }
        }
    }
}


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

namespace Arkusz1
{
   
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string postalCode = KodPocztowy.Text;
            if (postalCode.Length == 5)
            {
                try
                {
                    int numericPostalCode = Convert.ToInt32(KodPocztowy.Text);
                    MessageBox.Show("Dane prawidłowe");
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("W kodzie pocztowym powinny byc tylko cyfry!");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa długość kodu pocztowego!");
            }
        }
    }
}
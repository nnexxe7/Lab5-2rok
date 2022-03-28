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

namespace Lab5
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CenaKoncowa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Decimal num1;
            Decimal num2;
            bool success = Decimal.TryParse(Cena.Text, out num1);
            bool success2 = Decimal.TryParse(IloscDni.Text, out num2);
            if (!success || !success2)
            {
                CenaKoncowa.Text = "Wpisz poprawne liczby!";
            }
            else
            {
                CenaKoncowa.Text = (num1 * num2).ToString();
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string fname = Imie.Text;
            string lname = Nazwisko.Text;
            string days = IloscDni.Text;
            string price = Cena.Text;

            double txt1 = Convert.ToDouble(IloscDni.Text);
            double txt2 = Convert.ToDouble(Cena.Text);
            double txt3 = txt1 * txt2;

            Person.Items.Add("Imie: " + fname + "," + " Nazwisko: " + lname + "," + " Dlugosc: " + days + "," + " Cena: " + price + "," + " Cena koncowa: " + txt3);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}

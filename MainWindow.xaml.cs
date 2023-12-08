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

namespace WpfListy3Ppiatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> Slowa { get; set; }
        public List<Produkt>Produkty { get; set; }
        public Produkt ZaznaczonyElement { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Slowa = new List<string>();
            Slowa.Add("Ala");
            Slowa.Add("ma");
            Slowa.Add("kota");
            Slowa.Add("a");
            Slowa.Add("ma");
            Slowa.Add("Alę");
            DataContext = this;
            lista3.ItemsSource = Slowa;
            przygotujDane();

        }
        private void przygotujDane()
        {
            Produkty = new List<Produkt>();
            Produkty.Add(new Produkt("Chleb","włoski wypieczony",4.7,true,"Pieczywo"));
            Produkty.Add(new Produkt("Chleb","pełnoziarnisty wypieczony",6.7,true,"Pieczywo"));
            Produkty.Add(new Produkt("Mleko","3,2%",3.7,true,"Nabiał"));
            Produkty.Add(new Produkt("Ser","Chudy",5.7,true,"Nabiał"));
            Produkty.Add(new Produkt("Ser biały","Półtłusty",5.7,true,"Nabiał"));
        }
    }
}

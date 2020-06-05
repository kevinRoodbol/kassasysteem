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

namespace kassasysteem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            Grid.Children.Clear();
        }

        private void bestellingbtn_click(object sender, RoutedEventArgs e)
        {
            BestelControl mw = new BestelControl();
            Grid.Children.Clear();
            Grid.Children.Add(mw);

        }
        private void Productbtn_click(object sender, RoutedEventArgs e)
        {
            ProductControl mw = new ProductControl();
            Grid.Children.Clear();
            Grid.Children.Add(mw);
        }

        private void Klantbtn_click(object sender, RoutedEventArgs e)
        {
            KlantControl mw = new KlantControl();
            Grid.Children.Clear();
            Grid.Children.Add(mw);
        }
    }
}
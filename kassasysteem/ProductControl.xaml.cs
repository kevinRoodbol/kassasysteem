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
    /// Interaction logic for ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public PRODUCT hetItem;
        public ProductControl()
        {
            InitializeComponent();
            DGProduct.ItemsSource = db.PRODUCTs.ToList();
        }
        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            var item = (PRODUCT)DGProduct.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Weet u het zeker dat u: " + item.productnaam + " wilt verwijderen?", "Warnig!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.PRODUCTs.DeleteOnSubmit(item);

                db.SubmitChanges();
                DGProduct.ItemsSource = db.PRODUCTs.ToList();
            }
        }
        private void toevoegen_Click(object sender, RoutedEventArgs e)
        {
            GridProduct.Children.Clear();
            GridProduct.Children.Add(new Toevoegen(db));
        }

        private void DGProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (PRODUCT)DGProduct.SelectedItem;

            GridProduct.Children.Clear();
            GridProduct.Children.Add(new Wijzigen(item, db));
        }
    }
}

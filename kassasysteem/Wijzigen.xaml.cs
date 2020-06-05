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
    /// Interaction logic for Wijzigen.xaml
    /// </summary>
    public partial class Wijzigen : UserControl
    {
        private DataClasses2DataContext db;
        public PRODUCT hetItem;
        public Wijzigen(PRODUCT prt, DataClasses2DataContext db)
        {
            InitializeComponent();
            this.db = db;
            hetItem = prt;
            txtPnaam.Text = prt.productnaam;
            txtPrijs.Text = prt.prijs;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (hetItem != null)
            {
                hetItem.productnaam = txtPnaam.Text;
                hetItem.prijs = txtPrijs.Text.ToString();
                db.SubmitChanges();

            }
        }
    }
}

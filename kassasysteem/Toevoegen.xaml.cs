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
    /// Interaction logic for Toevoegen.xaml
    /// </summary>
    public partial class Toevoegen : UserControl
    {
        private DataClasses2DataContext db;
        public PRODUCT hetItem;
        public Toevoegen(DataClasses2DataContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            PRODUCT hetItem = new PRODUCT();
            hetItem.productnaam = txtPnaam.Text;
            hetItem.prijs = txtPrijs.Text;

            db.PRODUCTs.InsertOnSubmit(hetItem);

            db.SubmitChanges();
        }
    }
}

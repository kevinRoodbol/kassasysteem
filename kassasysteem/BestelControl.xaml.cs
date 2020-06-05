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
    /// Interaction logic for BestelControl.xaml
    /// </summary>
    public partial class BestelControl : UserControl
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public BestelControl()
        {
            InitializeComponent();
            DGproducten.ItemsSource = db.PRODUCTs.ToList();
            KlantCMB.ItemsSource = db.CUSTOMERs.ToList();
        }
        private void DGproducten_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = DGproducten.SelectedItem;
            if (item != null)
            {
                PRODUCT hetItem = (PRODUCT)item;
                DGbestel.Items.Add(hetItem);
            }
        }

        private void opslaanbtn_Click(object sender, RoutedEventArgs e)
        {
            var deKlant = (CUSTOMER)KlantCMB.SelectedItem;
            if (deKlant != null)
            {
                item bestel = new item();
                bestel.ORDER = new ORDER();
                //koppelen klant aan bestelling
                bestel.ORDER.CUSTOMER = deKlant;
                ItemCollection ic = DGbestel.Items;
                foreach (var i in ic)
                {
                    bestel.PRODUCT = (PRODUCT)i;
                    db.items.InsertOnSubmit(bestel);
                }
                db.SubmitChanges();
                MessageBox.Show("Het is opgeslagen");
            }
            else MessageBox.Show("U heeft geen Klant geselecteerd!");
        }
    }
}

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
    /// Interaction logic for KlantControl.xaml
    /// </summary>
    public partial class KlantControl : UserControl
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public CUSTOMER PublicKlant;
        public KlantControl()
        {
            InitializeComponent();
            DGKlant.ItemsSource = db.CUSTOMERs.ToList();
        }
        private void btnVerwijderenKlant_Click_1(object sender, RoutedEventArgs e)
        {
            var item = (CUSTOMER)DGKlant.SelectedItem;

            MessageBoxResult mbr = MessageBox.Show("Weet je het zeker dat u " + item.firstname + " wilt verwijderen?", "Warning!", MessageBoxButton.YesNo);

            if (MessageBoxResult.Yes == mbr)
            {
                db.CUSTOMERs.DeleteOnSubmit(item);

                db.SubmitChanges();
                DGKlant.ItemsSource = db.CUSTOMERs.ToList();
            }
        }
        private void DGKlant_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (CUSTOMER)DGKlant.SelectedItem;
            PublicKlant = item;
            KlantNaamBox.Text = item.firstname;
            KlantAchterBox.Text = item.lastname;
            StadBox.Text = item.city;
            MobielBox.Text = item.phonenumber;
            EmailBox.Text = item.email;
        }

        private void Opslaanklantbtn_Click(object sender, RoutedEventArgs e)
        {
            CUSTOMER DeKlant = new CUSTOMER();
            DeKlant.firstname = KlantNaamBox.Text;
            DeKlant.lastname = KlantAchterBox.Text;
            DeKlant.city = StadBox.Text;
            DeKlant.phonenumber = MobielBox.Text.ToString();
            DeKlant.email = EmailBox.Text;

            db.CUSTOMERs.InsertOnSubmit(DeKlant);

            db.SubmitChanges();

            DGKlant.ItemsSource = db.CUSTOMERs.ToList();
        }

        private void UpdateKlantbtn_Click(object sender, RoutedEventArgs e)
        {
            if (PublicKlant != null)
            {
                PublicKlant.firstname = KlantNaamBox.Text;
                PublicKlant.lastname = KlantAchterBox.Text;
                PublicKlant.city = StadBox.Text;
                PublicKlant.phonenumber = MobielBox.Text;
                PublicKlant.email = EmailBox.Text;
                db.SubmitChanges();
            }
        }
    }
}
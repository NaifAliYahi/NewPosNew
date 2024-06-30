using NewPos.Core;
using NewPos.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewPos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDBNewPos<AdmUserData> op;
        public MainWindow(IDBNewPos<AdmUserData> rep)
        {
            InitializeComponent();

            op = rep;
        }

        private void btnsav_Click(object sender, RoutedEventArgs e)
        {
            AdmUserData ad = new AdmUserData
            {
                UserName = txtusername.Text,
                UserPass = txtUserPass.Text,
                FiscalYear = txtFiscalYear.Text,
                OrganizationId = txtOrganizationId.Text,
            }       
            ;
            op.AddAsync(ad).ConfigureAwait(true);
           
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
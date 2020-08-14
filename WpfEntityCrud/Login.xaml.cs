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
using System.Windows.Shapes;
using WpfEntityCRUD;

namespace WpfEntityCrud
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            string UserName = txtUserName.Text;
            MainWindow usl = new MainWindow();
            usl.Show();
            this.Close();
        }
    }
}

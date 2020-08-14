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
using WpfEntityCrud;

namespace WpfEntityCRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        wpfCrudEntities _db = new wpfCrudEntities();
        public static DataGrid datagrid;

        public MainWindow()
        {
            
            InitializeComponent();
            Load();
        }

        private void Load()
        {

            DataGridView.ItemsSource = _db.CDPUsers.ToList();
            datagrid = DataGridView;
        }

        private void ViewBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (DataGridView.SelectedItem as CDPUser).Id;
            int UserId = Convert.ToInt32((DataGridView.SelectedItem as CDPUser).UserId);
            string title = (DataGridView.SelectedItem as CDPUser).title;
            string completed = (DataGridView.SelectedItem as CDPUser).completed;
            ViewUserDetails view = new ViewUserDetails(Id, UserId, title, completed);
            view.Show();
        }



        //private void updateBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    int Id = (myDataGrid.SelectedItem as member).id;
        //    UpdatePage Upage = new UpdatePage(Id);
        //    Upage.ShowDialog();
        //}


    }
}

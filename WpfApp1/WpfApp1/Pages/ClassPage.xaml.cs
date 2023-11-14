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
using WpfApp1.Model;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClassPage.xaml
    /// </summary>
    public partial class ClassPage : Page
    {
        public ClassPage()
        {
            InitializeComponent();
            DataGridClassPage.ItemsSource = App.DB.@class.ToList();
        }


        private void AddDataGridButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewClassPage());
        }

       

        private void BDeleteGrid_Click(object sender, RoutedEventArgs e)
        {
            var selClient = DataGridClassPage.SelectedItem as @class;
            if(selClient != null)
            {
                App.DB.@class.Remove(selClient);
                App.DB.SaveChanges();
                DataGridClassPage.ItemsSource = App.DB.@class.ToList();
            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
                
            }
        }
    }
}

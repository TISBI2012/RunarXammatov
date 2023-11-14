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
using WpfApp1.Pages;
using WpfApp1.Model;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ComputersPage.xaml
    /// </summary>
    public partial class ComputersPage : Page
    {
        public ComputersPage()
        {
            InitializeComponent();
            DataGridComputersPage.ItemsSource = App.DB.Computers.ToList();
        }

        private void AddDataGridButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewComputerPage());
        }

        private void DeleteDataGridButton_Click(object sender, RoutedEventArgs e)
        {
            var selClient = DataGridComputersPage.SelectedItem as Computers;
            if(selClient != null)
            {
                App.DB.Computers.Remove(selClient);
                App.DB.SaveChanges();
                DataGridComputersPage.ItemsSource = App.DB.Computers.ToList();
            }
            else {
          
                MessageBox.Show("Ничего не выбрано");
                
            }
        }
    }
}

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
    /// Логика взаимодействия для NewComputerPage.xaml
    /// </summary>
    public partial class NewComputerPage : Page
    {
       
        public NewComputerPage()
        {
            InitializeComponent();
        }

        private void BAddComputer_Click(object sender, RoutedEventArgs e)
        {
            var computer = new Computers();
            computer.ip = Bip.Text;
            computer.@class = Bclass.Text;
            computer.id = int.Parse(Bid.Text);
            computer.status = Bstatus.IsChecked;
            App.DB.Computers.Add(computer);
            App.DB.SaveChanges();
            NavigationService.Navigate(new ComputersPage());
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClassPage());
        }
    }
}

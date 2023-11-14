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
using WpfApp1;
using WpfApp1.Model;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewClassPage.xaml
    /// </summary>
    public partial class NewClassPage : Page
    {
        
        public NewClassPage()
        {
            InitializeComponent();
            
        }

        private void BAddClass_Click(object sender, RoutedEventArgs e)
        {
            var newClass = new @class();
            newClass.id = int.Parse(Bid.Text);
            newClass.placces = int.Parse(Bplacces.Text);
            App.DB.@class.Add(newClass);
            App.DB.SaveChanges();
            NavigationService.Navigate(new ClassPage());
        }


        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClassPage());
        }
    }
}

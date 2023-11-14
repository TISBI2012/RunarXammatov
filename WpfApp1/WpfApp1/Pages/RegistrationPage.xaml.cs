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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            var password = RegPasswordTB.Password;

            try { 
                using (var context = new testXammatovEntities())
                {
                    var user = new users
                    {
                        login = RegLoginTB.Text,
                        password = password
                    };
                    context.users.Add(user);
                    MessageBox.Show("Вы успешно вошли");
                }
                NavigationService.Navigate(new FirstPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ваша ошибка: {ex.Message}");
                
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}

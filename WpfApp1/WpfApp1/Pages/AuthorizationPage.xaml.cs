using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.users.FirstOrDefault(x => x.login == UsernameTextBox.Text);

            if(user == null || user.password != PasswordTextBox.Text)
            {
                MessageBox.Show("Данные для входа неверны");
                return;
            }

            App.LoginUser = user;
            NavigationService.Navigate(new Main());

        
        }
    }
}

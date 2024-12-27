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

namespace Tournament_421_AlyusevaSofyaViktorovna.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void AuthButt_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTbx.Text.Length == 0 || PasswordTbx.Password.Length == 0) MessageBox.Show("Логин или пароль пустые");
            else
            {
                if (App.db.Users.Where(x => LoginTbx.Text == x.Login && x.Password == PasswordTbx.Password).Count() > 0)
                {
                    App.user = App.db.Users.First(x => LoginTbx.Text == x.Login && x.Password == PasswordTbx.Password);
                    MessageBox.Show("Вы успешно вошли");
                    NavigationService.Navigate(new MainPage());
                }
                else MessageBox.Show("Ошибка входа");
            }
        }
    }
}

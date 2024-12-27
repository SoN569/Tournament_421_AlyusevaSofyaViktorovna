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
using Tournament_421_AlyusevaSofyaViktorovna.Components;

namespace Tournament_421_AlyusevaSofyaViktorovna.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
            List<Roles> roles = App.db.Roles.ToList();
            roles.RemoveAt(1);
            RoleCbx.ItemsSource = roles;
            RoleCbx.DisplayMemberPath = "Name";
        }

        private void AuthButt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());

        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            if (NameTbx.Text.Length == 0 || LoginTbx.Text.Length == 0 || PasswordTbx.Password.Length == 0 || RoleCbx.SelectedIndex == -1) MessageBox.Show("");
            else
            {
                int role = 1;
                if (RoleCbx.SelectedIndex == 1) role = 3;
                Users user = new Users()
                {
                    IdRole = role,
                    Name = NameTbx.Text,
                    Login = LoginTbx.Text,
                    Password = PasswordTbx.Password,
                };
                App.db.Users.Add(user);
                App.db.SaveChanges();
                App.user = user;
                MessageBox.Show("");
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}

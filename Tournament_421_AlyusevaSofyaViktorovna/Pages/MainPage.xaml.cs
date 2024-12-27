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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            if (App.user.IdRole == 1)
            {
                PagesFrame.NavigationService.Navigate(new PlayerInfoPage());
                PlayerSP.Visibility = Visibility.Visible;
            }
            else if (App.user.IdRole == 2)
            {
                OrganisatorSP.Visibility = Visibility.Visible;
                PagesFrame.NavigationService.Navigate(new CreateTournamentPage());
            }
        }

        private void InfoButt_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.NavigationService.Navigate(new PlayerInfoPage());
        }

        private void RegForTourButt_Click(object sender, RoutedEventArgs e)
        {
            PagesFrame.NavigationService.Navigate(new PlayerRegTourPage());
        }
    }
}

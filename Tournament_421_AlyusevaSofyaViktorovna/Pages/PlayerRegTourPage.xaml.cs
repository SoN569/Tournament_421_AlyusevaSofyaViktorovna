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
    /// Логика взаимодействия для PlayerRegTourPage.xaml
    /// </summary>
    public partial class PlayerRegTourPage : Page
    {
        public PlayerRegTourPage()
        {
            InitializeComponent();
            TournamentCbx.ItemsSource = App.db.Tournaments.ToList();
            TournamentCbx.DisplayMemberPath = "Name";

            NamePlayerCbx.ItemsSource = App.db.Users.Where(x => x.IdRole == 1).ToList();
            NamePlayerCbx.DisplayMemberPath = "Name";

            RolePlayerCbx.ItemsSource = App.db.GroupRole.ToList();
            RolePlayerCbx.DisplayMemberPath = "Name";

            TournamentRoleCbx.ItemsSource = App.db.GroupRole.ToList();
            TournamentRoleCbx.DisplayMemberPath = "Name";

            RoleSP.Visibility = Visibility.Collapsed;
            GroupSP.Visibility = Visibility.Collapsed;
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TournamentCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TournamentCbx.SelectedItem != null)
            {
                Tournaments tour = TournamentCbx.SelectedItem as Tournaments;
                    //App.db.Tournaments.First(x => TournamentCbx.SelectedIndex + 1 == x.IdTour);
                if (tour.IdCategory == 1)
                {
                    RoleSP.Visibility = Visibility.Visible;
                    GroupSP.Visibility = Visibility.Collapsed;
                }
                else
                {
                    GroupSP.Visibility = Visibility.Visible;
                    RoleSP.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void AddPlayerButt_Click(object sender, RoutedEventArgs e)
        {
            if (NamePlayerCbx.SelectedIndex == -1 || RolePlayerCbx.SelectedIndex == -1) MessageBox.Show("Добавлять некого");
            else
            {
                List<string> item = new List<string>();
                item.Add(NamePlayerCbx.Text);  
                item.Add(RolePlayerCbx.Text);
                PlayersLV.Items.Add(item.ToArray()); 
            }
        }
    }
}

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
    /// Логика взаимодействия для CreateTournamentPage.xaml
    /// </summary>
    public partial class CreateTournamentPage : Page
    {
        public CreateTournamentPage()
        {
            InitializeComponent();
            MinLvlTbx.Visibility = Visibility.Collapsed;
            RegionTbx.Visibility = Visibility.Collapsed;
            ExcludeTbx.Visibility = Visibility.Collapsed;
            CategoryCbx.ItemsSource = App.db.Category.ToList();
            CategoryCbx.DisplayMemberPath = "Name";
        }

        private void MinLvlCheck_Checked(object sender, RoutedEventArgs e)
        {
            if (MinLvlCheck.IsChecked == true) MinLvlTbx.Visibility = Visibility.Visible;
            else MinLvlTbx.Visibility = Visibility.Collapsed;
        }

        private void RegionCheck_Checked(object sender, RoutedEventArgs e)
        {
            if (RegionCheck.IsChecked == true) RegionTbx.Visibility = Visibility.Visible;
            else RegionTbx.Visibility = Visibility.Collapsed;
        }

        private void ExcludeCheck_Checked(object sender, RoutedEventArgs e)
        {
            if (ExcludeCheck.IsChecked == true) ExcludeTbx.Visibility = Visibility.Visible;
            else ExcludeTbx.Visibility = Visibility.Collapsed;
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            if (NameTbx.Text.Length == 0 || DateDP.Text.Length == 0 || TimeTbx.Text.Length == 0 || GameNameTbx.Text.Length == 0 || CategoryCbx.SelectedIndex == -1 ||
                PlayerAmountTbx.Text.Length == 0 || PrizeTbx.Text.Length == 0)
            {
                MessageBox.Show("");
            }
            else
            {
                try
                {
                    DateTime date = new DateTime();
                    date = date.AddYears(DateDP.SelectedDate.Value.Year - 1);
                    date = date.AddMonths(DateDP.SelectedDate.Value.Month - 1);
                    date = date.AddDays(DateDP.SelectedDate.Value.Day - 1);
                    date = date.AddHours(int.Parse(TimeTbx.Text));

                    Tournaments tournaments = new Tournaments()
                    {
                        Name = NameTbx.Text,
                        DateTimeStart = date,
                        GameName = GameNameTbx.Text,
                        IdCategory = CategoryCbx.SelectedIndex + 1,
                        PlayersAmount = int.Parse(PlayerAmountTbx.Text),
                        Prize = decimal.Parse(PrizeTbx.Text),
                    };
                    if (MinLvlCheck.IsChecked == true) tournaments.MinPlayerLvl = int.Parse(MinLvlTbx.Text);
                    if (RegionCheck.IsChecked == true) tournaments.Region = RegionTbx.Text;
                    if (ExcludeCheck.IsChecked == true) tournaments.ExcludeCharWeapon = ExcludeTbx.Text;

                    App.db.Tournaments.Add(tournaments);
                    App.db.SaveChanges();
                    MessageBox.Show("+");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Возникла ошибка. Проверьте данные");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

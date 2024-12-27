using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_421_AlyusevaSofyaViktorovna.Components;

namespace Tournament_421_AlyusevaSofyaViktorovna
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_421_AlyusevaSofyaEntities db = new TournamentDB_421_AlyusevaSofyaEntities();
        public static Users user;
    }
}

using Microsoft.EntityFrameworkCore;
using SoldierTracker.Data;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SoldierTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SoldierTracker;Integrated Security=True";

        protected override void OnStartup(StartupEventArgs e)
        {

            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(CONNECTION_STRING).Options;
            ApplicationDbContext context = new ApplicationDbContext(options);
            context.Database.Migrate();

            base.OnStartup(e);
        }

    }

}

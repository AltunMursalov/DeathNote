using System.IO;
using ToDoEF.Droid.Services.EF;
using DeathNote.Services.EF;
using Xamarin.Forms;
using DeathNote;

[assembly: Dependency(typeof(DatabaseService))]
namespace ToDoEF.Droid.Services.EF
{
    public class DatabaseService : IDatabaseService
    {
        public string GetDatabasePath()
        {
            return Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                AppSettings.DatabaseName);
        }
    }
}
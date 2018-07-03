using System;
using System.IO;
using DeathNote.iOS.Services.EF;
using DeathNote.Services.EF;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseService))]
namespace DeathNote.iOS.Services.EF
{
    public class DatabaseService : IDatabaseService
    {
        public string GetDatabasePath()
        {
            return Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
                "..",
                "Library",
                AppSettings.DatabaseName);
        }
    }
}
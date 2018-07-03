using DeathNote.Model;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace DeathNote.Services.EF
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IDatabaseService>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasOne(n => n.Person)
                .WithOne(p => p.Note)
                .HasForeignKey<Person>(p => p.NoteId);

            modelBuilder.Entity<Note>().Ignore(n => n.BindingContext).Ignore(n => n.Person);
            modelBuilder.Entity<Person>().Ignore(p => p.Note).Ignore(p => p.BindingContext);
        }
    }
}
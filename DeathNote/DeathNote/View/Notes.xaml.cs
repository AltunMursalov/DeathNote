using DeathNote.Model;
using DeathNote.Services.EF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeathNote.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notes : ContentPage
    {
        public ObservableCollection<Note> DeathNotes { get; set; }
        public Notes()
        {
            InitializeComponent();
            this.BindingContext = this;
            DeathNotes = new ObservableCollection<Note>();
            Note note = new Note() {
                Date = DateTime.Now,
                Description = "Default",
                Person = new Person() {
                    Name = "Dawn",
                    Surname = "Dawnech",
                    NoteId = 1,
                    Image = "Default"
                }
            };
            this.DeathNotes.Add(note);
            using (DatabaseContext context = new DatabaseContext()) {
                context.Notes.Add(note);
                var random = context.Notes.FirstOrDefault(n => n.Description == "Default");
                this.DisplayAlert(random.Date.ToShortDateString(), random.Description, "OK");
                context.SaveChanges();
            }
        }
    }
}
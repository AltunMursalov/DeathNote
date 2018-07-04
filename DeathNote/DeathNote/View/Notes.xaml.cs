using DeathNote.Model;
using Newtonsoft.Json;
using DeathNote.Services.EF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
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
            DeathNotes = new ObservableCollection<Note>();
            InitializeComponent();
            this.BindingContext = this;

        }

        private async void GetData()
        {
            using (HttpClient client = new HttpClient()) {
                var res = await client.GetAsync("http://localhost:64786/api/values/hakuna");
                var data = await res.Content.ReadAsStringAsync();
                var notes = JsonConvert.DeserializeObject<List<Note>>(data);
                foreach (var note in notes) {
                    this.DeathNotes.Add(note);
                }
            }
        }

        private async void PostData()
        {

        }
    }
}
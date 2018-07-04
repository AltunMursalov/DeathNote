using Xamarin.Forms;

namespace DeathNote.Model
{
    public class Person : BindableObject
    {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; base.OnPropertyChanged(); }
        }

        private string name;
        public string Name {
            get { return name; }
            set { name = value; base.OnPropertyChanged(); }
        }

        private string surname;
        public string Surname {
            get { return surname; }
            set { surname = value; base.OnPropertyChanged(); }
        }

        private string image;
        public string Image {
            get { return image; }
            set { image = value; base.OnPropertyChanged(); }
        }

        public Note Note { get; set; }
    }
}

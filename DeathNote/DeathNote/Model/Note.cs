using System;
using Xamarin.Forms;

namespace DeathNote.Model
{
    public class Note : BindableObject
    {
        private int id;
        public int Id {
            get { return id; }
            set { id = value; base.OnPropertyChanged(); }
        }

        private string description; 
        public string Description {
            get { return description; }
            set { description = value; base.OnPropertyChanged(); }
        }

        private DateTime date;
        public DateTime Date {
            get { return date; }
            set { date = value; base.OnPropertyChanged(); }
        }

        private int personId;
        public int PersonId {
            get { return personId; }
            set { personId = value; base.OnPropertyChanged(); }
        }

        public virtual Person Person { get; set; }
    }
}
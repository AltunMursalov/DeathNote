using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xamarin.Forms;

namespace DeathNote.Model
{
    public class Note : BindableObject
    {
        private int id;
        [Key]
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

        public virtual Person Person { get; set; }
    }
}

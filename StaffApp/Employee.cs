using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using StaffApp.Annotations;

namespace StaffApp
{
    public class Employee : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private int age;
        private double experience;
        private string position;
        private string bookmark;

        
        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }


       
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
 
        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public double Experience
        {
            get => experience;
            set
            {
                experience = (int) value;
                OnPropertyChanged(nameof(Experience));
            }
        }


        
        public string Position
        {
            get => position;
            set
            {
                position = value;
                OnPropertyChanged(nameof(Position));
            }
        }


        
        public string Bookmark
        {
            get => bookmark; set
            {
                bookmark = value;
                OnPropertyChanged(nameof(Bookmark));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}


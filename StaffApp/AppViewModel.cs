using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StaffApp.Annotations;

namespace StaffApp
{
    class AppViewModel : INotifyPropertyChanged
    {
        private Employee selectedEmployee;

        public Employee SelectedPhone
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedPhone));
            }
        }
        public ObservableCollection<Employee> Employees { get; set; }
        public AppViewModel()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee()
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
    }
}

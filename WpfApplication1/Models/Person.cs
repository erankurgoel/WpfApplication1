using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public class Person : INotifyPropertyChanged
    {
        string _lastName = "GOel";

        public event PropertyChangedEventHandler PropertyChanged;
        private string  firstName;

        public string  FirstName
        {
            get { return firstName; }
            set { firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public Person()
        {
            
        }
        public string Gender { get; set; }

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

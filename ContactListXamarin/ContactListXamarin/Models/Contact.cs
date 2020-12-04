using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContactListXamarin.Models
{
    public class Contact : INotifyPropertyChanged
    {
        String nameVar, phoneVar;
        public String Name { 
            get
            {
                return nameVar;
            }
            set 
            {
                nameVar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            } 
        }
        public String Phone { 
            get 
            {
                return phoneVar;
            }
            set
            {
                phoneVar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Phone)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Contact(String name, String phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}

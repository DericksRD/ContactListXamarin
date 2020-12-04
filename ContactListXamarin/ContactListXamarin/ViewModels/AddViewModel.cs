using ContactListXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactListXamarin.ViewModels
{
    class AddViewModel : BaseViewModel
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        public Contact NewContact => new Contact(Name, Phone);
        public ObservableCollection<Contact> AddList { get; set; }
        public ICommand AddCommand => new Command(AddButton);

        public AddViewModel(ObservableCollection<Contact> list)
        {
            AddList = list;
        }

        public async void AddButton()
        {
            AddList.Add(NewContact);
            await App.Current.MainPage.DisplayAlert(
                "Usuario Agregado exitosamente!", "", "Ok");
            await App.Current.MainPage.Navigation.PopModalAsync();
        }
        
    }
}

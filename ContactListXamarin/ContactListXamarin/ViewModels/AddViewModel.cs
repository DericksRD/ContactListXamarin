using ContactListXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactListXamarin.ViewModels
{
    class AddViewModel
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        public Contact NewContact => new Contact(Name, Phone);

        public ICommand AddCommand => new Command(AddButton);

        public async void AddButton()
        {
            ListViewModel viewModel = new ListViewModel();
            viewModel.Add(NewContact);
            await App.Current.MainPage.DisplayAlert(
                "Usuario Agregado exitosamente!", "",
                "Ok");
            await App.Current.MainPage.Navigation.PopModalAsync();
        }
        
    }
}

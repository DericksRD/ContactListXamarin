﻿using ContactListXamarin.Models;
using ContactListXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactListXamarin.ViewModels
{
    public class ListViewModel : BaseViewModel
    {
        public ObservableCollection<Contact> ContactList { get; private set; }
        public ListView ListObject;
        public ListViewModel()
        {
            ContactList = new ObservableCollection<Contact>();
        }

        public ICommand AddCommand => new Command(AddClicked);

        private async void AddClicked(object obj)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new AddPage(ContactList));
        }

        public ICommand DeleteCommand => new Command(DeleteClicked);

        private async void DeleteClicked(Object contact)
        {
            var answer = await App.Current.MainPage.DisplayAlert("Estás seguro que deseas eliminarlo?",
                                                     "", "Sí", "Cancelar");
            if (answer == true) 
                ContactList.Remove((Contact)contact);

        }
    }
}

using ContactListXamarin.Models;
using ContactListXamarin.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactListXamarin.ViewModels
{
    class ListViewModel : BaseViewModel
    {
        public IList<Contact> ContactList { get; private set; }

        public ListViewModel()
        {
            ContactList = new List<Contact>()
            {
                new Contact("Erick Sánchez", "829-439-7453")
            };
        }

        public ICommand AddCommand => new Command(AddClicked);

        private async static void AddClicked(object obj)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new AddPage());
            //throw new NotImplementedException();
        }
        public void Add(Contact newContact)
        {
            ContactList.Add(newContact);
        }
    }
}

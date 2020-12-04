using ContactListXamarin.Models;
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

        public ListViewModel()
        {
            ContactList = new ObservableCollection<Contact>()
            {
                new Contact("Erick Sánchez", "809-594-2978")
            };
            
        }

        public ICommand AddCommand => new Command(AddClicked);

        private async void AddClicked(object obj)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new AddPage(ContactList));
            //throw new NotImplementedException();
        }
        public void Add(Contact newContact)
        {
            ContactList.Add(newContact);
        }
    }
}

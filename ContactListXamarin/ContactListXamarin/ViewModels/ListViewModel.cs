using ContactListXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}

using ContactListXamarin.Models;
using ContactListXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactListXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage(ObservableCollection<Contact> list)
        {
            InitializeComponent();
            BindingContext = new AddViewModel(list);
        }
    }
}
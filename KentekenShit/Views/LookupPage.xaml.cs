using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KentekenShit.Models;
using KentekenShit.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KentekenShit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LookupPage : ContentPage
    {
        LookupViewModel viewModel;
        
        public LookupPage()
        {
            InitializeComponent();
            
            BindingContext = viewModel = new LookupViewModel();
        }

        private void SearchClicked(object sender, EventArgs e)
        {
            var item = new Item
            {
                Plate = "48XRFF",
                Make = "Toyota",
                Seets = "5",
                Cylinders = "4",
                Doors = "4",
                Wheels = "4",
                Price = "5",
                TaxiSign = "No",
                InFavoirites = false
            };

            viewModel.addItemAsync(item);
        }
    }
}
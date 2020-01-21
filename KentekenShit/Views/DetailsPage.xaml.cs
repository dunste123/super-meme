using KentekenShit.Models;
using KentekenShit.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KentekenShit.Views
{
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public DetailsPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public DetailsPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "48XRFF"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}
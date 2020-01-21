using KentekenShit.Models;
using KentekenShit.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KentekenShit.Views
{
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public DetailsPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

        public DetailsPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "48XRFF"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private void FavItemClickedDSte(object sender, EventArgs e)
        {
            // viewModel is null but BindingContext isn't ????

            var ctx = BindingContext as ItemDetailViewModel;

            if (ctx == null) return;
            
            var item = ctx.Item;

            if (item == null)
            {
                return;
            }

            item.InFavoirites = !item.InFavoirites;

            ctx.UpdateItemAsync(item);
        }
    }
}
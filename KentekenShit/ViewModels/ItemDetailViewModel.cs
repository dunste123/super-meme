using System;

using KentekenShit.Models;
using Xamarin.Forms;

namespace KentekenShit.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = "Licnce plate " + item?.Plate;
            Item = item;
        }

        public string FavText => Item?.InFavoirites ?? false ? "Remove from favorites" : "Add to favorites";
        public Color BtnColor => Item?.InFavoirites ?? false ? Color.Gold : Color.LightGray;
    }
}

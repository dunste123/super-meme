using System;
using System.Reflection;
using KentekenShit.Models;
using Xamarin.Forms;

namespace KentekenShit.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private Assembly assembly => typeof(ItemDetailViewModel).GetTypeInfo().Assembly;
    
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = "Licnce plate " + item?.Plate;
            Item = item;
            
            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }
            
            FileName = Item?.InFavoirites ?? false ? "KentekenShit.Assets.star_solid.png" : "KentekenShit.Assets.star_regular.png";
            // FileName = Item?.InFavoirites ?? false ? "star_regular.png" : "star_solid.png";
            ImgSource = ImageSource.FromResource(FileName);
        }

        public string FavText => Item?.InFavoirites ?? false ? "Remove from favorites" : "Add to favorites";

        public string FileName { get; set; }

        // public string FileName => Item?.InFavoirites ?? false ? "star_regular.png" : "star_solid.png";
        public ImageSource ImgSource { get; set; }
        public Color BtnColor => Item?.InFavoirites ?? false ? Color.Gold : Color.LightGray;
    }
}

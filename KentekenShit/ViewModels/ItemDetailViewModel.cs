using System;
using System.Reflection;
using KentekenShit.Models;
using Xamarin.Forms;

namespace KentekenShit.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private Assembly assembly => typeof(ItemDetailViewModel).GetTypeInfo().Assembly;

        private Item localItem;
        public Item Item
        {
            get { return localItem; }
            set { SetProperty(ref localItem, value); }
        }

        private string localFileName;
        public string FileName
        {
            get { return localFileName; }
            set { SetProperty(ref localFileName, value); }
        }

        private ImageSource localImageSource;
        public ImageSource ImgSource {
            get { return localImageSource; }
            set { SetProperty(ref localImageSource, value); }
        }

        public ItemDetailViewModel(Item item = null)
        {
            Title = "Licnce plate " + item?.Plate;
            localItem = item;

            foreach (var res in assembly.GetManifestResourceNames())
            {
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
            }

            // FileName = Item?.InFavoirites ?? false ? "KentekenShit.Assets.star_solid.png" : "KentekenShit.Assets.star_regular.png";
            // FileName = Item?.InFavoirites ?? false ? "star_solid.png" : "star_regular.png";
            // ImgSource = ImageSource.FromResource(FileName);
            // ImgSource = ImageSource.FromFile(FileName);

            UpdateImages();
        }

        public string FavText => Item?.InFavoirites ?? false ? "Remove from favorites" : "Add to favorites";

        // public string FileName => Item?.InFavoirites ?? false ? "star_solid.png" : "star_regular.png";
        // public ImageSource ImgSource => ImageSource.FromFile(FileName);

        public Color BtnColor => Item?.InFavoirites ?? false ? Color.Gold : Color.LightGray;

        public async void UpdateItemAsync(Item item)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            Item = item;

            await DataStore.UpdateItemAsync(item);

            UpdateImages();

            IsBusy = false;
        }

        private void UpdateImages()
        {
            // public string FileName => Item?.InFavoirites ?? false ? "star_solid.png" : "star_regular.png";
            // ImgSource = ImageSource.FromResource(FileName);

            FileName = Item?.InFavoirites ?? false ? "star_solid.png" : "star_regular.png";
            ImgSource = ImageSource.FromFile(FileName);
        }
    }
}
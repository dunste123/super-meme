using KentekenShit.Models;

namespace KentekenShit.ViewModels
{
    public class LookupViewModel : BaseViewModel
    {
        public LookupViewModel()
        {
            Title = "Licence Plate Thing";
        }

        public async void addItemAsync(Item item)
        {
            // Items.Add(item);
            await DataStore.AddItemAsync(item);
        }
    }
}
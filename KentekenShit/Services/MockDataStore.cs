using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KentekenShit.Models;

namespace KentekenShit.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Plate = "48XRFF",
                    Make = "Toyota",
                    Seets = "5",
                    Cylinders = "4",
                    Doors = "4",
                    Wheels = "4",
                    Price = "5",
                    TaxiSign = "No",
                    InFavoirites = false
                },
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.FirstOrDefault(arg => arg.Id == item.Id);
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.FirstOrDefault(arg => arg.Id == id);
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<List<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
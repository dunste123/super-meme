using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using KentekenShit.Models;

namespace KentekenShit.Services
{
    public class SQLiteDataStore : IDataStore<Item>
    {
        public SQLiteDataStore()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");
        }

        public Task<bool> AddItemAsync(Item item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Item> GetItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new System.NotImplementedException();
        }
    }
}
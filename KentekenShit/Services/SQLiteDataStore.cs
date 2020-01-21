using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using KentekenShit.Models;
using SQLite;

namespace KentekenShit.Services
{
    public class SQLiteDataStore : IDataStore<Item>
    {
        private readonly SQLiteAsyncConnection _database;

        public SQLiteDataStore()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");

            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Item>().Wait();
        }

        public Task<bool> AddItemAsync(Item item)
        {
            return Task.Run(() => _database.InsertAsync(item).Result > 0);
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            return Task.Run(() => _database.UpdateAsync(item).Result > 0);
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            return _database.Table<Item>()
                .DeleteAsync((i) => i.Id == id)
                .ContinueWith((a) => a.Result > 0);
        }

        public Task<Item> GetItemAsync(string id)
        {
            return _database.Table<Item>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<List<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return _database.Table<Item>().ToListAsync();
        }
    }
}
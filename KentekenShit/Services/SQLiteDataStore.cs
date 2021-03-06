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
            Console.WriteLine("HELMOND");
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db");

            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Item>().Wait();
        }

        public Task<bool> AddItemAsync(Item item)
        {
            return _database.InsertAsync(item)
                .ContinueWith((a) => a.Result > 0);
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            return _database.UpdateAsync(item)
                .ContinueWith((a) => a.Result > 0);
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            return _database.Table<Item>()
                .DeleteAsync((i) => i.Id == id)
                .ContinueWith((a) => a.Result > 0);
        }

        public Task<Item> GetItemAsync(int id)
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
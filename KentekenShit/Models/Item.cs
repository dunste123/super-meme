using SQLite;
using System;

namespace KentekenShit.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public string Plate { get; set; }
        public string Make { get; set; }
        public string Seets { get; set; }
        public string Cylinders { get; set; }
        public string Doors { get; set; }
        public string Wheels { get; set; }
        public string Price { get; set; }
        public string TaxiSign { get; set; }

        public bool InFavoirites { get; set; }
    }
}
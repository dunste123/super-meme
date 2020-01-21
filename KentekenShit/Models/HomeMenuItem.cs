using System;
using System.Collections.Generic;
using System.Text;

namespace KentekenShit.Models
{
    public enum MenuItemType
    {
        Home,
        Details,
        History,
        Favorites,
        Settings,
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

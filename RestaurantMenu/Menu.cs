using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();
        public List<MenuItem> menuItems
        {
            get { return MenuItems; }
        } 
        public DateTime LastUpdated { get; set; }

        public Menu()
        {
            LastUpdated = DateTime.Now;
        }

        public void AddItem (MenuItem food)
        {
            if (this.MenuItems is null)
            {
                this.MenuItems.Add(food);
                this.LastUpdated = DateTime.Now;
            }
            else
            {
                if (this.MenuItems.Contains(food))
                {
                    Console.WriteLine("This item is already in the menu!");
                }
                else
                {
                    this.MenuItems.Add(food);
                    this.LastUpdated = DateTime.Now;
                }
            }
        }

        public void RemoveItem (MenuItem food)
        {
            MenuItems.RemoveAt(MenuItems.IndexOf(food));
        }

        public override string ToString()
        {
            string output = "";
            foreach (MenuItem food in this.MenuItems)
            {
                output += food.ToString() + "\n";
            }
            return output;
        }

        public override bool Equals(object obj)
        {
            return obj is Menu menu &&
                   EqualityComparer<List<MenuItem>>.Default.Equals(MenuItems, menu.MenuItems) &&
                   LastUpdated == menu.LastUpdated;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MenuItems, LastUpdated);
        }
    }
}


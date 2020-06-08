using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (Array.IndexOf(FoodCategory, value) != -1)
                {
                    _category = value;
                }
                else
                {
                    _category = "Unknown";
                }
            }
        }
        public bool IsNew { get; set; }

        private string[] FoodCategory = { "appetizer", "main course", "dessert" };

        public MenuItem(string name, double price = 0, string description="", string category="", bool isNew = true)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public override string ToString()
        {
            string yay;
            if (this.IsNew)
            {
                yay = "NEW!";
            }
            else
            {
                yay = "";
            }
            return $"{this.Name} ({this.Category}) ({this.Description}). {yay}";
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Description == item.Description &&
                   Category == item.Category;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description, Category);
        }
    }
}
using System;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem food1 = new MenuItem("Pizza", 9.99, "Flatbread with Tomato Sauce topped with cheeze", "main course", true);
            MenuItem food2 = new MenuItem("Cannoli", 2.99, "Crunchy shell with sweet cream center", "dessert", false);
            MenuItem food3 = new MenuItem("Shoe");

            Menu menu = new Menu();
            menu.AddItem(food1);
            menu.AddItem(food2);
            menu.AddItem(food1);

            Console.WriteLine(menu.ToString());
            //Console.WriteLine();
            //Console.WriteLine(food3);

        }
    }
}

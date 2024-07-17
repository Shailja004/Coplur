using System;
namespace Restaurant_Management_System
{
    abstract class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display();
    }

    class FoodItem : MenuItem
    {
        public FoodItem(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine("Food:" + Name + "  " + " Price:" + Price);
        }
    }


    class DrinkItem : MenuItem
    {
        public DrinkItem(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine("Drink:" + Name + "  " + "Price:" + Price);
        }
    }
    class Restaurant
    {
        public List<MenuItem> menuitems;

        public Restaurant()
        {
            menuitems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item)
        {
            menuitems.Add(item);
        }



        public void UpdateMenuItem(string itemName)
        {

            foreach (var item in menuitems)
            {
                if (item.Name.Contains(itemName))
                {
                    menuitems.Remove(item);
                    Console.WriteLine("Item Blackcoffe is removed.");
                    Console.WriteLine("*-------------------------------------------------------------*");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Then Menu Items are:");

            Console.WriteLine("*-------------------------------------------------------------*");
            foreach (var item in menuitems)
            {
                item.Display();
            }

        }

        public double CalculateTotalOrderCost(List<MenuItem> orderItems)
        {
            double totalCost = 0;
            foreach (var item in orderItems)
            {
                totalCost += item.Price;

            }
            return totalCost;

        }
    }
    class Program
    {
        static void Main()
        {

            Restaurant restaurant = new Restaurant();

            restaurant.AddMenuItem(new FoodItem("Burger", 40));
            restaurant.AddMenuItem(new FoodItem("Fries", 50));
            restaurant.AddMenuItem(new FoodItem("Samosa", 40));
            restaurant.AddMenuItem(new FoodItem("Momos", 60));
            restaurant.AddMenuItem(new FoodItem("Pizza", 250));
            restaurant.AddMenuItem(new DrinkItem("Tea", 20));
            restaurant.AddMenuItem(new DrinkItem("Coffee", 120));
            restaurant.AddMenuItem(new DrinkItem("MangoShek", 80));
            restaurant.AddMenuItem(new DrinkItem("BananaShek", 150));
            restaurant.AddMenuItem(new DrinkItem("BlackCoffe", 220));
            restaurant.UpdateMenuItem("BlackCoffe");


            restaurant.DisplayMenu();
            Console.WriteLine("*-------------------------------------------------------------*");


            List<MenuItem> orderItems = new List<MenuItem>();
            {
                orderItems.Add(new FoodItem("Burger", 40));
                orderItems.Add(new FoodItem("Pizza", 250));
                orderItems.Add(new DrinkItem("Tea", 20));


            }

            double totalCost = restaurant.CalculateTotalOrderCost(orderItems);
            Console.WriteLine("Total Cost of Order in rupees: " + "  " + totalCost);
            Console.WriteLine("*-------------------------------------------------------------*");
            Console.ReadLine();
        }
    }
}



using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Menu Restauraunt = new Menu();
        MenuItem ItemA = new MenuItem(500.00m, "Water...", "Appetizer", true);
        MenuItem ItemB = new MenuItem(300.00m, "Filet Mignon", "Main", true);
        MenuItem ItemC = new MenuItem(100.00m, "Chocolate Fondue", "Dessert", true);

        Restauraunt.AddMenu(ItemA);
        Restauraunt.AddMenu(ItemB);
        Restauraunt.AddMenu(ItemC);

        Restauraunt.DisplayMenu();
    }
}
public class MenuItem
{
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public bool NewItem { get; set; }

    public MenuItem(decimal price, string description, string category, bool newitem)
    {
        Price = price; 
        Description = description;
        Category = category;
        NewItem = newitem;
    }
}

public class Menu
{
    private List<MenuItem> MenuItems { get; } = new List<MenuItem>();
    private DateTime UpdatedTime { get; set; } = DateTime.Now;
    public void AddMenu(MenuItem item)
    {
        MenuItems.Add(item);
        UpdatedTime = DateTime.Now;
    }

    public void DisplayMenu()
    {
        Console.WriteLine($"$hey - {UpdatedTime}");
        foreach (var item in MenuItems)
        {
            Console.WriteLine($"Price: {item.Price}$, Description: {item.Description}, Item: {item.Category}, {item.NewItem}");
        }

    }
    
}

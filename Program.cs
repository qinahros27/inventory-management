﻿internal class Program
{
    private static void Main(string[] args)
    {
        Item item1 = new Item("12345", "Item A", 5); 
        Item item2 = new Item("67890", "Item B", 6); 
        Inventory inventory = Inventory.Instance;
        Printer printer = new Printer();

        Console.WriteLine("Add item");
        inventory.AddItem(item1, 2);
        inventory.AddItem(item2, 1);
        inventory.ViewInventory();

        Console.WriteLine("Increase the quantity of item2 by AddItem function");
        inventory.AddItem(item2, 1);

        Console.WriteLine("Check if the quantity increased or not");
        printer.PrintItem(item2);

        Console.WriteLine("Increase quantities for item1 and decrease quantities for item2");
        inventory.IncreaseQuantity(3, "12345");
        inventory.DecreaseQuantity(2, "67890");

        Console.WriteLine("View all items in the inventory");
        inventory.ViewInventory();
        
        Console.WriteLine("View the amount of unique items and total number of items");
        printer.PrintInventory(inventory);
        
        Console.WriteLine("Remove item2");
        inventory.RemoveItem("67890");

        Console.WriteLine("View again to check if the item2 removed or not");
        inventory.ViewInventory();  
    }
}

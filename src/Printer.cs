using System;

class Printer {
    public void PrintItem(Item item) {
       Console.WriteLine($"Barcode: {item.Barcode} , Name: {item.Name}, Quantities: {item.Quantity}");
    }

    public void PrintInventory(Inventory inventory) {
        int uniqueItems = inventory.GetUniqueItemCount();
        int totalItems = inventory.GetTotalItemCount();

        Console.WriteLine($"Unique Items: {uniqueItems}");
        Console.WriteLine($"Total Items: {totalItems}");
    }
}
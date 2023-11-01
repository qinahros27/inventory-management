using System;
using System.Text;

 class Inventory {

    private static Inventory instance; 
    private List<Item> items ;
    private int maxCapacity; 

    public Inventory(int maxCapacity) {
        this.maxCapacity = maxCapacity;
        this.items = new List<Item>();
    }

    public static Inventory Instance {
        get{
            if(instance == null) {
                instance = new Inventory(100);
            }
            return instance;
        }
    }

    public bool AddItem(Item item, int quantity) {
        if(items.Count >= maxCapacity) {
            return false;
        }
        var existingItem = items.FirstOrDefault(i => i.Barcode == item.Barcode);
        if(existingItem != null) {
            existingItem.IncreaseQuantity(quantity);
        }
        else {
            items.Add(item);
        }
        return true;
    }

    public bool RemoveItem(string barcode) {
        var existingItem = items.FirstOrDefault(i => i.Barcode == barcode);
        if(existingItem == null) {
            return false;
        }
        else {
            items.Remove(existingItem);
            return true;
        }
    }

    public void IncreaseQuantity(int amount, string barcode) {
        var existingItem = items.FirstOrDefault(i => i.Barcode == barcode);
        if(existingItem != null) {
            existingItem.IncreaseQuantity(amount);
        }
    }

    public void DecreaseQuantity(int amount, string barcode) {
        var existingItem = items.FirstOrDefault(i => i.Barcode == barcode);
        if(existingItem != null) {
            existingItem.DecreaseQuantity(amount);
        }
    }

    public void ViewInventory() {
        foreach(var item in items) {
            Console.WriteLine($"Barcode: {item.Barcode} , Name: {item.Name}, Quantities: {item.Quantity}");
        }
    }

    public int GetUniqueItemCount()
    {
        return items.Count;
    }

    public int GetTotalItemCount()
    {
        int totalCount = 0;
        foreach (var item in items)
        {
            totalCount += item.Quantity;
        }
        return totalCount;
    }

    ~Inventory() {
        Console.WriteLine("The inventory is destroyed");
    }
 }
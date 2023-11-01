using System;

class Item {
    private readonly string _barcode;
    private readonly string _name;
    private int _quantity;

    public Item(string barcode, string name, int quantity) {
        this._barcode = barcode;
        this._name = name;
        this._quantity = quantity;
    }

    public string Barcode {
        get{return _barcode;}
    }

    public string Name {
        get{return _name;}
    }

    public int Quantity {
        get{return _quantity;}
    }

    public void IncreaseQuantity(int amount) {
        if(amount < 0) {
            throw new ArgumentException("Quantity must be a positive integer.");
        }
        _quantity += amount;
    }

    public void DecreaseQuantity(int amount) {
        if(amount < 0) {
            throw new ArgumentException("Quantity must be a positive integer.");
        }
        else if(amount > _quantity) {
            throw new ArgumentException("Insufficient quantity to decrease.");
        }

        _quantity -= amount;
    }
} 
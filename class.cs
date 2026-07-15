using System;

public class Product
{
    // fields
    private string _name;
    private decimal _price;
    private int _quantity;

    // properties
    public string Name
    {
        get => _name;
        set => _name = !string.IsNullOrEmpty(value) ? value
                        : throw new ArgumentException("Required name");
    }

    public decimal Price
    {
        get => _price;
        set => _price = value >= 0 ? value
                        : throw new ArgumentException("The price cannot be negative");
    }

    public int Quantity { get; private set; } // auto-property

    // constructor
    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // methods
    public void Sold(int pieces)
    {
        if (pieces > Quantity)
            throw new InvalidOperationException("Missing required quantity");
        Quantity -= pieces;
    }

    public decimal WarehouseValue() => Price * Quantity;

    public override string ToString()
        => $"[{Name}] price: {Price:C}, condition: {Quantity} pc.";
}

// create objects
class Program
{
    static void Main()
    {
        var laptop = new Product("Laptop Dell", 3499.99M, 15);
        var phone = new Product("iPhone 11", 4999.00M, 8);

        Console.WriteLine(laptop); // [Laptop Dell] price: 3499,99, condition: 15 pc.
        laptop.Sold(3);
        Console.WriteLine(laptop.Quantity);  // 12
        Console.WriteLine(laptop.WarehouseValue()); // 41 999,88
    }
}
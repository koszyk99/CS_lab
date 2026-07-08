using System;

// optional parameters - have a default value
static void Order(string product, int quantity = 1, bool express = false)
{
    Console.WriteLine($"Order: {product} x {quantity}, express={express}");
}

Order("Laptop");
Order("Telephone", 2);
Order("Headphones", 1, true);

// named parameters - the order does not matter
Order(express: true, product: "Keyboards");
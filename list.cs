using System.Collections.Generic;

// create list
List<string> products = new List<string>();

// add elements
products.Add("Laptop");
products.Add("Mouse");
products.Add("Keyboard");
products.AddRange(new[] { "Monitor", "Headphones" });

// operations
Console.WriteLine(products.Count); // 5
Console.WriteLine(products.Contains("Mouse")); // True

products.Remove("Mouse");
products.RemoveAt(0); // remove by index

// iteration
foreach (string p in products)
    Console.WriteLine($"- {p}");

// collection initializer
var numbers = new List<int> { 10, 20, 30, 40 };
numbers.Sort();
Console.WriteLine(string.Join(", ", numbers)); // 10, 20, 30, 40
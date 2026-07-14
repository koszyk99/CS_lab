using System;
using System.Collections.Generic;

// dictionary - key-value
var price_list = new Dictionary<string, decimal>
{
    { "Coffee", 8.50M },
    { "Tea", 6.00M },
    { "Juice", 9.00M}
};

Console.WriteLine(price_list["Coffee"]); // 8.50

// safety download
if (price_list.TryGetValue("Water", out decimal price))
    Console.WriteLine(price);
else
    Console.WriteLine("Not on the menu");

// iteration over a dictionary
foreach (var item in price_list)
    Console.WriteLine($"{item.Key}: {item.Value:C}");
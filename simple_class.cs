using System;

// create object key word "new"
Dog rex = new Dog { Name = "Rex", Breed = "Shepherd", Age = 3 };

Console.WriteLine(rex.Name); // Rex

// definie class
public class Dog
{
    public required string Name { get; set; }
    public required string Breed { get; set; }
    public required int Age { get; set; }
}
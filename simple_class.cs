using System;

public class Dog
{
    public string Name;
    public string Breed;
    public int Age;
}

// create object key word "new"
Dog rex = new Dog();
rex.Name = "Rex";
rex.Breed = "Shepherd";
rex.Age = 3;

Console.WriteLine(rex.Name); // Rex
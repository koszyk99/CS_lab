using System;

var rex = new Dog("Rex", 3);
Console.WriteLine(rex.Age); // 3

rex.Age = -5; // ArgumentException

public class Dog
{
    // private field - inaccessible from the outside
    private int _age;

    // public property - control access to field
    public int Age
    {
        get { return _age; } // getter - read
        set                  // setter - save
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative");
            _age = value;
        }
    }

    public string Name { get; set; }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

}
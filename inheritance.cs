using System;

Animal[] home = {
    new Dog("Rex"),
    new Cat("Filemon"),
    new Dog("Azor")
};

// same loop - each object invokes their own version MakeSound()
foreach (Animal h in home)
    h.MakeSound();

// base class - define everything shared by animals
public class Animal
{
    public string Name{ get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    // virtual - derived classes can override this 
    public virtual void MakeSound()
    {
        Console.WriteLine("...");
    }
}

// derived classes - each animal can make different sound, 'override' overrides a method from the base class
public class Dog : Animal // ": Animal" inheritance
{
    // "base(...)" invokes the base class constructor
    public Dog(string name) : base(name) { }

    public override void MakeSound() // override
    {
        Console.WriteLine($"{Name}: HAU");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: MIAU");
    }
}
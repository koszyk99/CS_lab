using System;
using System.Collections.Generic;

// using interface
static void Play(ISound instrument)
{
    Console.WriteLine($"I am plaing: {instrument.FetchDescription()}");
    instrument.MakeSound();
}

Play(new Guitar());
Play(new Trumpet());

// list of instruments - different types, one common interface
List<ISound> orchestra = new() 

// define interface - always starts with I (convention)
public interface ISound
{
    void MakeSound(); // without body and modifiers
    string FetchDescription();
}

// interface implementation
public class Guitar : ISound
{
    public void MakeSound()
    {
        Console.WriteLine("Guitar sound");
    }
    public string FetchDescription() => "Acoustic guitar";
}

public class Trumpet : ISound
{
    public void MakeSound()
    {
        Console.WriteLine("Trumpet sound");
    }
    public string FetchDescription() => "Trumpet";
}


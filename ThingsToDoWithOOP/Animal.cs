﻿namespace ThingsToDoWithOOP;

internal class Animal
{
    // Attributes
    private string _name;
    private int _age;
    private string? _sound;

    // Public constructor to instantiate an animal object using all attributes
    public Animal(string name, int age, string sound)
    {
        this._name = name;
        this._age = age;
        this._sound = sound;
    }

    // Public constructor to instantiate an animal object without sound [OVERLOADING]
    public Animal(string name, int age)
    {
        this._name = name;
        this._age = age;
        this._sound ="No sound";
    }


    // Getter and Setter for Name
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getter and Setter for Sound
    public string Sound
    {
        get { return _sound; }
        set { _sound = value; }
    }

    // Getter for Age
    public int Age
    { 
        get { return _age; }
    }

    // Behaviour methods
    public void growsOlder()
    {
        _age++;
    }

    public void makeSound()
    {
        Console.WriteLine($"{ _name} makes a { _sound} sound!");
    }
}
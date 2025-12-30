using System;
using System.Collections.Generic;
using System.Linq;

class Animal
{
    public string Name { get; set; }
}

class Cat : Animal
{
    public Cat(string name)
    {
        Name = name;
    }
}

class Dog : Animal
{
    public Dog(string name)
    {
        Name = name;
    }
}

class Program5
{
    static void Main5(string[] args)
    {
        List<Animal> animals = new List<Animal>
    {
      new Cat("Tom"),
      new Dog("Spike"),
      new Cat("Jerry"),
      new Dog("Max"),
    };
        var cats = animals.Where(an => an is Cat).Cast<Cat>().ToList();
        cats.ForEach(c => Console.Write(c.Name + " "));
    }

    
}
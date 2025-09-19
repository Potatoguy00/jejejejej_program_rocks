using System;
using System.Collections.Generic;

class Animal
{
    public virtual void Speak() // virtual method to be overriden if there are animals
    {
        Console.WriteLine("Nothing is heard.");
    }
}

class Dog : Animal
{
    public override void Speak() // override the speak method
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void Speak() // override the speak method
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal> //list of animals
        {
            new Dog(),
            new Cat(),
        };

        Console.WriteLine("Is the person in the house? (Yes or no)"); //writes this into the console

        if (Console.ReadLine().ToLower() == "yes") // sees if the input is yes
        {

            foreach (var animal in animals) // loops through the list of animals
            {
                animal.Speak(); // Polymorphism: calls the correct Speak() method
            }

        }

        else //if yes is not the input this runs
        {

            Animal a = new Animal(); // turns the class into a object to call its methods
            a.Speak(); // prints nothing is heard
            return; // exists the program

        }
    }
}
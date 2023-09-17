using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            Cat b = new Cat();
            Bird c = new Bird();
            
            c.sleep();
        }
    }
}

interface IAnimal {
    void makeSound();
    void sleep();
}

interface ILandAnimal
{
    void walk();
}

interface IAirAnimal: ILandAnimal{
    void fly();
}

class Dog : IAnimal, ILandAnimal{
    public void makeSound()
    {
        Console.WriteLine("Arf arf!");
    }
    public void sleep()
    {

    }
    public void walk()
    {

    }
}

class Cat : IAnimal, ILandAnimal{ 
    public void makeSound()
    {

    }
    public void sleep() 
    { 
    
    }

    public void walk()
    {

    }
}

class Bird : IAnimal, IAirAnimal {
    public void makeSound() { 
    
    }

    public void sleep() { 
    
    }

    public void walk() { 
    
    }

    public void fly() {
        Console.WriteLine("I can fly!");
    }
}



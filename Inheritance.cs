using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public void Sleep() 
        {
            Console.WriteLine("Animal is not sleeping");
        }
    }
    class Dog:Animal
    {
        public void Bark() 
        { Console.WriteLine("Dog is barking"); }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Sleep();
            dog.Bark();
        }
    }
}

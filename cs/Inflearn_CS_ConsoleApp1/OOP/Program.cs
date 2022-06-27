using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.animalSound();

            animal = new Dog();
            animal.animalSound();

            //Dog dog = new Dog();
            //dog.animalSound();
            //Cat cat = new Cat();
            //cat.animalSound();
            //Owl owl = new Owl();
            //owl.animalSound();


        }
    }
}

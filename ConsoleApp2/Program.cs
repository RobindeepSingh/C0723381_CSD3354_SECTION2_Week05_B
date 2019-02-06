using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.WalkOverTheList();
        }
    }
    class Dog
    {
        public static int NumberOfDogs = 0;
        public Dog()
        {
            // A constructor is Method
            // that creates OBJECTS from a TYPE
            Dog.NumberOfDogs++;

        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
    }
    class LinkedList
    {
        public Dog current;
        public Dog Head;
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();

        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Peanut.nextDog = Fifi;

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";
            Fifi.nextDog = Jordan;

            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "Jerman Sheppard";
            Jordan.nextDog = Fido;

            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";
            Fido.nextDog = null;
        }
        public void WalkOverTheList()
        {
            current = Head;
            while (current != null)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;
            }

        }
    }
}

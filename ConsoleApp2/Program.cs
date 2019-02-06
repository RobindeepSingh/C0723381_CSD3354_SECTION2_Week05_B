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
                Dog.NumberOfDogs++;
            }
            public String DogName;
            public String DogBreed;
            public Dog nextDog;
            public Dog prevDog;
        }

        class LinkedList
        {
            public Dog current;
            public Dog Head;
            public Dog Tail;
            public Dog Peanut = new Dog();
            public Dog Fifi = new Dog();
            public Dog Jordan = new Dog();
            public Dog Fido = new Dog();
            public Dog Roy = new Dog();
            public Dog Coco = new Dog();

            public void run()
            {
                Head = Peanut;
                Tail = Fido;
                Peanut.DogName = "Peanut";
                Peanut.DogBreed = "Bichon";
                Peanut.nextDog = Fifi;
                Peanut.prevDog = null;

                Fifi.DogName = "Fifi";
                Fifi.DogBreed = "Poodle";
                Fifi.nextDog = Roy;
                Fifi.prevDog = Fifi;

                Roy.DogName = "Roy";
                Roy.DogBreed = "Beagle";
                Roy.nextDog = Coco;
                Roy.prevDog = Roy;

                Coco.DogName = "Coco";
                Coco.DogBreed = "Border Collie";
                Coco.nextDog = Jordan;
                Coco.prevDog = null;

                Jordan.DogName = "Jordan";
                Jordan.DogBreed = "Germansheppard";
                Jordan.nextDog = Fido;
                Jordan.prevDog = Coco;

                Fido.DogName = "Fido";
                Fido.DogBreed = "Spaniel";
                Fido.nextDog = null;
                Fido.prevDog = Jordan;


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
            public void WalkOverTheList_REVERSE()

            {
                current = Tail;
                while (current != null)
                {
                    Console.WriteLine(current.DogName);
                    current = current.prevDog;

                }

            }
        }
    }
using System;
using System.Collections.Generic;

namespace Övning6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in tangenten D eller N");

            List<Animal> forest = new List<Animal>();


            Animal animal1 = new Animal();
            animal1.Name = "Varg";
            animal1.Nocturnal = true;

            Animal animal2 = new Animal();
            animal2.Name = "Fladdermus";
            animal2.Nocturnal = true;

            Animal animal3 = new Animal();
            animal3.Name = "Delfin";
            animal3.Nocturnal = false;

            Animal animal4 = new Animal();
            animal4.Name = "Örn";
            animal4.Nocturnal = false;

            Animal animal5 = new Animal();
            animal5.Name = "Häst";
            animal5.Nocturnal = false;


            forest.Add(animal1);
            forest.Add(animal2);
            forest.Add(animal3);
            forest.Add(animal4);
            forest.Add(animal5);

            ConsoleKeyInfo consoleKey = Console.ReadKey();
            ConsoleKey key = consoleKey.Key;

            Console.Clear();

            switch (key)
            {

                case ConsoleKey.D:

                    foreach (Animal d in forest)
                    {
                        if (d.Nocturnal == true)
                            Console.WriteLine($"{d.Name} smyger omkring och letar sitt byte, och {d.Name} flyger runt bland träden");
                    }
                    break;

                case ConsoleKey.N:
                    Console.WriteLine("Dina djur under natten ");
                    foreach (Animal n in forest)
                    {
                        if (n.Nocturnal == false)
                            Console.WriteLine($"{n.Name} sover, {n.Name} sover ");

                    }
                    break;

                default:
                    Console.WriteLine("Fel tangent" );
                    break;
            }

            Console.ReadKey();

            
        }

        public class Animal
        {

            public string Name { get; set; }
            public bool Nocturnal { get; set; }
        }
    }
}

   




using System;
using System.Collections.Generic;

namespace Övning_Klädbutiken
{
    class Program
    {
        static void Main(string[] args)
        {
            Plagg plagg = default;

            Console.Write("Tryck 1 för Pants: ");
            Console.Write("Tryck 2 för Shirt: ");
            Console.Write("Tryck 3 för Shoes: ");
            int plaggTyp = int.Parse(Console.ReadLine());
            plagg.Type = (Enum.GetName(typeof(Type), plaggTyp));

            Console.Write("Tryck 1 för Xs: ");
            Console.Write("Tryck 2 för S: ");
            Console.Write("Tryck 3 för M: ");
            int storlek = int.Parse(Console.ReadLine());
            plagg.Size = (Enum.GetName(typeof(Size), storlek));

            Console.Write("Tryck 1 för Blue: ");
            Console.Write("Tryck 2 för Green: ");
            Console.Write("Tryck 3 för Yellow: ");
            int färg = int.Parse(Console.ReadLine());
            plagg.Color = (Enum.GetName(typeof(Color), färg));

            Console.Write("Tryck 1 för 100kr: ");
            Console.Write("Tryck 2 för 200kr: ");
            Console.Write("Tryck 3 för 300kr: ");
            int pris = int.Parse(Console.ReadLine());
            int one = (int)Price.OneHundred;
            int two = (int)Price.TwoHundred;
            int three = (int)Price.ThreeHundred;

            if (pris == 1)
            {
                pris = one;
            }
            else if (pris == 2)
            {
                pris = two;
            }
            else if (pris == 3)
            {
                pris = three;
            }
            plagg.Price = (Enum.GetName(typeof(Price), pris));

            List<Plagg> butik = new List<Plagg>();
            butik.Add(plagg);


            Console.WriteLine($"{plagg.Type}, {plagg.Size}, {plagg.Color}, {plagg.Price}");
            

            //List<Type> type = new List<Type>();

            //Console.Write("Lägg in TYP: Välj 1 för Pants, Välj 2 för Shirt, Välj 3 för Shoes ");
            //string plaggTyp = Console.ReadLine();
            //foreach (Type p in plaggTyp)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.Write("Välj Plagg: ");
            //string plaggTyp = Console.ReadLine();

            //Console.Write("Välj Storlek: ");
            //string storlek = Console.ReadLine();

            //Console.Write("Välj Färg: ");
            //string färg = Console.ReadLine();

            //Console.Write("Välj Pris: ");
            //int pris = int.Parse(Console.ReadLine());

            //List<Plagg> clothes = new List<Plagg>();

            Console.ReadKey();
        }

    }

    struct Plagg
    {
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }

        public Plagg(string type, string size, string color, string price)
        {
            Type = type;
            Size = size;
            Color = color;
            Price = price;
        }
    }

    enum Type
    {
        Pants = 1,
        Shirt = 2,
        Shoes = 3,
    }
    enum Size
    {
        Xs = 1,
        S = 2,
        M = 3,
    }
    enum Color
    {
        Blue = 1,
        Green = 2,
        Yellow = 3,
    }
    enum Price
    {
        OneHundred = 100,
        TwoHundred = 200,
        ThreeHundred = 300,
    }
}

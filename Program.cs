using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace InlämningUppgift
{
    class Program
    {
        static Random randomWeight = new Random();
        static Random randomSpeed = new Random();
        static Random randomRoddbåtPassenger = new Random();
        static Random randomMotorbåtHorsePower = new Random();
        static Random randomSegelbåtLenght = new Random();
        static Random randomLastfartygContainers = new Random();
        static void Main(string[] args)
        {
            

            //Roddbåt roddbåt = new Roddbåt(RandomID(), randomWeight.Next(100, 300), randomSpeed.Next(1, 3), randomRoddbåtPassenger.Next(1, 6));

            //Motorbåt motorbåt = new Motorbåt(RandomID(), randomWeight.Next(200, 3000), randomSpeed.Next(1, 6), randomMotorbåtHorsePower.Next(10, 1000));

            //Segelbåt segelbåt = new Segelbåt(RandomID(), randomWeight.Next(800, 6000), randomSpeed.Next(1, 12), randomSegelbåtLenght.Next(10, 60));

            //Lastfartyg lastfartyg = new Lastfartyg(RandomID(), randomWeight.Next(3000, 20000), randomSpeed.Next(1, 20), randomLastfartygContainers.Next(1, 500));

            Console.WriteLine($"Plats\tBåttyp\tID\tVikt\tMaxhastighet\tÖvrigt");
            Båt[] båtArray = new Båt[10];


        }






        //To get Random ID for all Boats.
        public static string RandomID()
        {
            Random randomID = new Random();
            string b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = 3;
            string random = "";

            for (int i = 0; i < length; i++)
            {
                int a = randomID.Next(26);
                random = random + b.ElementAt(a);
            }
            return random;
            //Console.WriteLine($"L-{random}");
        }
    }
}

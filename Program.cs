using System;
using System.Collections.Generic;

namespace InlämningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tjuv> bibliotekTjuv = new List<Tjuv>();

            int X = 100;
            int Y = 25;
            String[,] spelplan = new string[X, Y];


            for (int t = 0; t < 20; t++)
            {
                bibliotekTjuv.Add(new Tjuv(t, t, 1, 1));
                Console.WriteLine(bibliotekTjuv);
            }

            List<Polis> bibliotekPolis = new List<Polis>();
            for (int p = 0; p < 10; p++)
            {
                bibliotekPolis.Add(new Polis(p, p, 6, 6));
            }

            List<Medborgare> bibliotekMedborgare = new List<Medborgare>();
            for (int m = 0; m < 30; m++)
            {
                bibliotekMedborgare.Add(new Medborgare(m, m, 3, 3));
            }

            Console.ReadKey();



        }



        class Person
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public int DirectionX { get; set; }
            public int DirectionY { get; set; }
            //Inventory? 

            public void Move()
            {
                // Denna är för att Position X och Y ska ändras, för det behöver vi plussa DirectionX,Y.
                PositionX = PositionX + DirectionX;
                PositionY = PositionY + DirectionY;

                if (PositionX < 0)
                {
                    PositionX = DirectionX;
                }
                if (PositionY < 0)
                {
                    PositionY = DirectionY;
                }
            }

            public virtual char GetBoardChar()
            {
                return '?';
            }

        }

        class Tjuv : Person
        {
            public Tjuv(int positionX, int positionY, int directionX, int directionY)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
            }

            public override char GetBoardChar()
            {
                return 'T';
            }

            //gör en metod med STEAL
        }

        class Polis : Person
        {
            public Polis(int positionX, int positionY, int directionX, int directionY)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
            }

            public override char GetBoardChar()
            {
                return 'P';
            }

            ///Gör en metod med beslagtaget
        }

        class Medborgare : Person
        {
            public Medborgare(int positionX, int positionY, int directionX, int directionY)
            {
                PositionX = positionX;
                PositionY = positionY;
                DirectionX = directionX;
                DirectionY = directionY;
            }

            public override char GetBoardChar()
            {
                return 'M';
            }

        }
    }
}


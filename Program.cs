using System;
using System.Collections.Generic;

namespace Övning8._1Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar en lista av Bok, och döper till bibliotek
            List<Bok> bibliotek = new List<Bok>();

            //Nu ska jag skapa böckerna och lägga i listan
            Faktabok faktabok = new Faktabok("Bilbok", "KaanGolcuk", 30, "BMW", 2);
            bibliotek.Add(faktabok);
            Faktabok faktabok2 = new Faktabok("MC", "Rickard", 90, "Att köra snabbt", 3);
            bibliotek.Add(faktabok2);

            Barnbok barnbok = new Barnbok("Pippi", "Astrid", 15, true, true);
            bibliotek.Add(barnbok);
            Barnbok barnbok2 = new Barnbok("Sonic", "Kalle Kula", 5, false, true);
            bibliotek.Add(barnbok2);

            Underhållning underhållning = new Underhållning("Att rita rätt", "Håkan", 60, "Konst", true);
            bibliotek.Add(underhållning);
            Underhållning underhållning2 = new Underhållning("Skriva rätt", "Mikael", 20, "Måla", false);
            bibliotek.Add(underhållning2);

            Console.WriteLine("Välj i menyn om du vill se en specifik bok");
            Console.WriteLine("1. Fakta");
            Console.WriteLine("2. Barn");
            Console.WriteLine("3. Underhållning");
            Console.WriteLine("4. All böcker");
            int menu = int.Parse(Console.ReadLine());

            while (true)
            {

                switch (menu)
                {
                    case 1:
                        foreach (Faktabok item in bibliotek)
                        {
                            Console.WriteLine($"\nTitel: {item.Titel}");
                            Console.WriteLine($"Förefattare: {item.Författare}");
                            Console.WriteLine($"Sidor: {item.Sidor}");
                            item.Move();

                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        foreach (Bok item in bibliotek)
                        {
                            Console.Clear();

                            Console.WriteLine($"\nTitel: {item.Titel}");
                            Console.WriteLine($"Förefattare: {item.Författare}");
                            Console.WriteLine($"Sidor: {item.Sidor}");
                            item.Move();
                        }
                        break;
                }
                Console.ReadKey();

            }
        }

    }

    class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int Sidor { get; set; }

        public virtual void Move()
        {
            Console.WriteLine();
        }
    }

    class Faktabok : Bok
    {
        public string Ämne { get; set; }
        public int Svårighetsgrad { get; set; }

        //Skapar Construktor
        public Faktabok(string titel, string författare, int sidor, string ämne, int svårighetsgrad)
        {
            Titel = titel;
            Författare = författare;
            Sidor = sidor;
            Ämne = ämne;
            Svårighetsgrad = svårighetsgrad;
        }

        public override void Move()
        {
            Console.WriteLine($"Ämne: {Ämne}");
            Console.WriteLine($"Svårighetsgrad: {Svårighetsgrad}");

        }
    }

    class Barnbok : Bok
    {
        public bool BarnUngdom { get; set; }
        public bool Bildbok { get; set; }

        //Skapar Construktor
        public Barnbok(string titel, string författare, int sidor, bool barnungdom, bool bildbok)
        {
            Titel = titel;
            Författare = författare;
            Sidor = sidor;
            BarnUngdom = barnungdom;
            Bildbok = bildbok;

        }

        public override void Move()
        {
            Console.WriteLine($"Barn eller Ungdom: {(BarnUngdom ? "Barnbok" : "Ungdomsbok")} ");
            Console.WriteLine($"Bildbok?: {(Bildbok ? "Ja" : "Nej")} ");

        }
    }

    class Underhållning : Bok
    {
        public string Typ { get; set; }
        public bool RomanElrAntologi { get; set; }

        //Skapa Construktor
        public Underhållning(string titel, string författare, int sidor, string typ, bool romanelrantologi)
        {
            Titel = titel;
            Författare = författare;
            Sidor = sidor;
            Typ = typ;
            RomanElrAntologi = romanelrantologi;
        }

        public override void Move()
        {
            Console.WriteLine($"Type: {Typ}");
            Console.WriteLine($"Roman eller Antologi? {(RomanElrAntologi ? "Roman" : "Antologi")}");

        }
    }
}

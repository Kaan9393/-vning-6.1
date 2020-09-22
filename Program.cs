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
            Faktabok faktabok = new Faktabok(Bilbok, KaanGolcuk, 30, BMW, 2);
            bibliotek.Add(faktabok);

        }
    }

    class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int Sidor { get; set; }
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
    }

    class Barnbok : Bok
    {
        public bool BarnUngdom { get; set; }
        public bool Bilderbok { get; set; }

        //Skapar Construktor
        public Barnbok(string titel, string författare, int sidor, bool barnungdom, bool bilderbok)
        {
            Titel = titel;
            Författare = författare;
            Sidor = sidor;
            BarnUngdom = barnungdom;
            Bilderbok = bilderbok;

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
    }
}

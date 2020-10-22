using System.Collections.Generic;

namespace InlämningUppgift
{
    class Hamnen
    {
        public int AntalPlatserIhamnen { get; set; }
        public bool SantEllerFalskt { get; set; }

        public List<Båt> HamnBåtar { get; set; }
        public Hamnen()
        {
            HamnBåtar = new List<Båt>();
        }

        //USE BETWEEN?
    }
    class Båt
    {
        public string IdNum { get; set; }
        public int Weight { get; set; }
        public int Speed { get; set; }

    }
    class Roddbåt : Båt
    {
        public int Passenger { get; set; }
        public Roddbåt(string idnum, int weight, int speed, int passenger)
        {
            IdNum = idnum;
            Weight = weight;
            Speed = speed;
            Passenger = passenger;
        }
    }

    class Motorbåt : Båt
    {
        public int HorsePower { get; set; }

        public Motorbåt(string idnum, int weight, int speed, int horsepower)
        {
            IdNum = idnum;
            Weight = weight;
            Speed = speed;
            HorsePower = horsepower;
        }
    }

    class Segelbåt : Båt
    {
        public int Lenght { get; set; }

        public Segelbåt(string idnum, int weight, int speed, int lenght)
        {
            IdNum = idnum;
            Weight = weight;
            Speed = speed;
            Lenght = lenght;
        }
    }

    class Lastfartyg : Båt
    {
        public int Containers { get; set; }

        public Lastfartyg(string idnum, int weight, int speed, int containers)
        {
            IdNum = idnum;
            Weight = weight;
            Speed = speed;
            Containers = containers;
        }
    }

}

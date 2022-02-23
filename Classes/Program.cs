using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat1 = new Allat();
            Allat allat2 = new Allat("Cirmos");
            Allat allat3 = new Allat("Tappancs", "Puli");
            Allat allat4 = new Allat("Huszár", "Agár",3);

            Console.WriteLine("Az allat1 kora: {0}", allat1.getKor());
            Console.WriteLine("Az allat1 neve: {0}", allat1.getNev());
            Console.WriteLine("Az allat1 fajtája: {0}", allat1.getFajta());
            Console.WriteLine("Az allat1 fajtáját komondorra változtatjuk");
            allat1.setFajta("Komondor");
            Console.WriteLine("Az allat1 fajtája: {0}", allat1.getFajta());
            Console.ReadKey();

            // Példányosítás paraméterekkel
            Kutya kutya1 = new Kutya("Bolhás", "puli", 2, "vau vau");
            Console.WriteLine("\nA kutya1 neve {0}", kutya1.getNev());
            Console.WriteLine("A kutya1 fajtája {0}", kutya1.getFajta());
            Console.WriteLine("A kutya1 kora {0}", kutya1.getKor());
            Console.WriteLine("A kutya1 hangja: ");
            kutya1.HangotAd();
            Console.ReadKey();

            // Példányosítás csak hang paraméterrel
            Kutya kutya2 = new Kutya("vau vau");
            Console.WriteLine("\nA kutya2 neve {0}", kutya2.getNev());
            Console.WriteLine("A kutya2 fajtája {0}", kutya2.getFajta());
            Console.WriteLine("A kutya2 kora {0}", kutya2.getKor());
            Console.WriteLine("A kutya2 hangja: ");
            kutya2.HangotAd();
            Console.ReadKey();
        }
    }

    class Allat
    {
        // Osztályváltozók (properties)
        private string nev;
        private string fajta;
        private int kor;
        protected string hang;

        /// <summary>
        /// Szülő osztály létrehozása
        /// </summary>
        /// <param name="nev"> Az állat neve szövegesen</param>
        /// <param name="fajta">Az állat fajtája szövegesen</param>
        /// <param name="kora">Állat kora egész szám</param>
        public Allat(string nev, string fajta, int kora)
        {
            if (nev != "")
            {
                this.nev = nev;
            }
            else
            {
                this.nev = "Bodri";
            }

            this.fajta = fajta;
            this.kor = kora;
        }
        
        public Allat(string nev, string fajta)
        {
            if (nev != "")
            {
                this.nev = nev;
            }
            else
            {
                this.nev = "Bodri";
            }

            this.fajta = fajta;
            this.kor = 1;
        }

        public Allat()
        {
            this.nev = "Nevetlen";
            this.fajta = "tacskó";
            this.kor = 1;
        }

        public Allat(string nev)
        {
            if (nev != "")
            {
                this.nev = nev;
            }
            else
            {
                this.nev = "Bodri";
            }
            this.fajta = "tacskó";
            this.kor = 1;
        }

        public void HangotAd()
        {
            Console.WriteLine(hang);
        }

        public int getKor()
        {
            return this.kor;
        }

        public void setKor(int p)
        {
            if (p > 0 & p < 100 & this.kor != p) this.kor = p;
        }

        public void setFajta(string p)
        {
            this.fajta = p;
        }

        public string getNev() { return this.nev; }

        public string getFajta() { return this.fajta; }
    }

    class Kutya : Allat
    {
        public Kutya(string nev, string fajta, int kora, string hang) : base(nev, fajta, kora)
        {
            this.hang = hang;
        }

        public Kutya(string hang) : base()
        {
            this.hang = hang;
        }

    }
}

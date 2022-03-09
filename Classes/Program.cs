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

            // Származtatott osztály példányosítása
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

            // Példányosítás paraméter nélkül
            Kutya kutya3 = new Kutya();
            Console.WriteLine("\nA kutya3 neve {0}", kutya2.getNev());
            Console.WriteLine("A kutya3 fajtája {0}", kutya2.getFajta());
            Console.WriteLine("A kutya3 kora {0}", kutya2.getKor());
            Console.WriteLine("A kutya3 hangja: ");
            kutya3.HangotAd();
            Console.ReadKey();

            // Macska Példányosítása paraméter nélkül
            Macska macska1 = new Macska();
            Console.WriteLine("\nA macska1 neve {0}", macska1.getNev());
            Console.WriteLine("A macska1 fajtája {0}", macska1.getFajta());
            Console.WriteLine("A macska1 kora {0}", macska1.getKor());
            Console.WriteLine("A macska1 hangja: ");
            macska1.HangotAd();
            Console.ReadKey();

            // Polimorfizmus bemutatása
            Console.WriteLine("\nPolimorfizmus bemutatása");
            Home sweetHome = new Home();

            // A sweethome feltöltése macskával és kutyával
            Console.WriteLine("Add meg a helyek számát: ");
            int hsz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hsz; i++)
            {
                sweetHome.addAllat(new Kutya());
                sweetHome.addAllat(new Macska());
            }

            // Állat véletlen szerű meghívása
            Console.WriteLine("Hányszor hívjam ki az állatokat?: ");
            int hivas = Convert.ToInt32(Console.ReadLine());

            Allat a = new Allat();
            for (int i = 0; i < hivas; i++)
            {
                a = sweetHome.hivas();
                Console.WriteLine("\nAz állat neve {0}", a.getNev());
                Console.WriteLine("Az állat fajtája {0}", a.getFajta());
                Console.WriteLine("Az állat kora {0}", a.getKor());
                Console.WriteLine("Az állat hangja: ");
                a.HangotAd();
                Console.ReadKey();
            }
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
            if (this.fajta != p) this.fajta = p;
        }

        public void setNev(string p) { if (p.Length < 15) this.nev = p; }

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

        public Kutya() : base()
        {
            this.hang = "Én vagyok a beszélő kutya! A nevem: " + this.getNev();
        }

    }

    class Macska : Allat
    {
        public Macska() : base()
        {
            this.setNev("Cicamica");
            this.setFajta("sziámi");
            this.hang = "Én vagyok a beszélő macska! A nevem: " + this.getNev();
        }
    }

    class Home
    {
        // Osztályváltozók
        private List<Allat> helyek = new List<Allat>();

        // Változók
        private Random rnd = new Random();

        public Home() {}

        // Új állat elemet ad a helyek listához
        public void addAllat(Allat p)
        {
            this.helyek.Add(p);
        }

        // Hívásra véletlen szerűen jön elő egy állat, ami vagy kutya, vagy macska
        public Allat hivas()
        {
            return this.helyek[rnd.Next(0, this.helyek.Count)];
        }
    }
}

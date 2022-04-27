using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamolo
{
    class Szamolo
    {
        // Osztályváltozók
        private int szam1,
            szam2,
            eredm;
        private string muvJel;

        public Szamolo() { }

        public void setSzam1()
        {
            Console.WriteLine("Adja meg az első számot:");
            this.szam1 = Convert.ToInt32(Console.ReadLine());
        }

        public void setSzam2()
        {
            Console.WriteLine("Adja meg a második számot:");
            this.szam2 = Convert.ToInt32(Console.ReadLine());
        }

        public void setMuvJel()
        {
            Console.WriteLine("Adja meg a műveleti jelet (+ - / * h - hatványozás g - gyökvonás):");
            this.muvJel = Console.ReadLine();
        }

        public int getSzam1() { return this.szam1; }
        public int getSzam2() { return this.szam2; }
        public string getMuvJel() { return this.muvJel; }

        public void setEredm()
        {
            this.eredm = kiszamol(this.szam1, this.szam2, this.muvJel);
        }

        private int kiszamol(int p1, int p2, string p3)
        {
            switch (p3)
            {
                case "+": return p1 + p2;
                case "-": return p1 - p2;
                case "/": return p1 / p2;
                case "*": return p1 * p2;
                case "h": return (int)Math.Pow(p1, p2);
                case "g": return (int)Math.Pow(p1, 1/p2);
                default: return 0;
            }
        }

        public double getEredm()
        {
            return this.eredm;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Szamolo s1 = new Szamolo();
            s1.setSzam1();
            s1.setSzam2();
            s1.setMuvJel();
            s1.setEredm();
            Console.WriteLine("Az 1. szám = {1}, 2.szám = {2}, művelet = {3} eredménye: {0}", s1.getEredm(), s1.getSzam1(), s1.getSzam2(), s1.getMuvJel());

            Console.ReadKey();
        }
    }
}

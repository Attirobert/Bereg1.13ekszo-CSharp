using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Kor
    {
        // Osztályváltozók
        private double sugar,   // A kör sugara
            terulet,
            kerulet;

        public Kor() {
            Console.WriteLine("Adja meg a kör sugarát!");
            this.sugar = Convert.ToDouble(Console.ReadLine());

            this.setKerulet();

            this.setTerulet();
        }

        public void setKerulet()
        {
            this.kerulet = Math.Round( 2 * this.sugar * Math.PI, 2);
        }

        public void setTerulet()
        {
            this.terulet = Math.Round( Math.Pow(this.sugar, 2) * Math.PI, 2);
        }

        public double getKerulet() { return this.kerulet; }
        public double getTerulet() { return this.terulet; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kor kor = new Kor();

            // Kiíratom a kerületet és a területet
            Console.WriteLine("A kör kerülete: {0}", kor.getKerulet());
            Console.WriteLine("A kör területe: {0}", kor.getTerulet());
            Console.ReadKey();
        }
    }
}

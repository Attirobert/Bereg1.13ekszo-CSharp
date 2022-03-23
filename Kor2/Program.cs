using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor2
{
    class Kor2
    {
        // Osztályváltozók
        private double sugar,   // A kör sugara
            terulet,
            kerulet;

        // Konstruktorok
        public Kor2(){}

        // Metódus (konstruktor) overloading
        public Kor2(double sugar){ if (joSugar(sugar)) this.sugar = sugar; }

        // Sugár beállítása
        public void setSugar(double p){
            if (joSugar(p)) this.sugar = p;
        }

        private bool joSugar(double p)
        {
            if (p > 0 && p < 100) return true;
            return false;
        }
        public void setKerulet()
        {
            this.kerulet = Math.Round(2 * this.sugar * Math.PI, 2);
        }

        public void setTerulet()
        {
            this.terulet = Math.Round(Math.Pow(this.sugar, 2) * Math.PI, 2);
        }

        public double getKerulet() { return this.kerulet; }
        public double getTerulet() { return this.terulet; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kor2 kor = new Kor2();
            double s = 0;
            do
            {
                Console.WriteLine("Adja meg a kör sugarát!");
                s = Convert.ToDouble(Console.ReadLine());
                if (s == 0) break;
                kor.setSugar(s);
                kor.setKerulet();
                kor.setTerulet();

                // Kiíratom a kerületet és a területet
                Console.WriteLine("A kör kerülete: {0}", kor.getKerulet());
                Console.WriteLine("A kör területe: {0}", kor.getTerulet());
                Console.ReadKey();

                Hasab h = new Hasab();
                Console.WriteLine("Adja meg a hasáb sugarát!");
                h.setSugar(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Adja meg a hasáb magasságát!");
                h.setMagas(Convert.ToDouble(Console.ReadLine()));
                h.setKerulet();
                h.setTerulet();
                h.setFelszin();
                h.setTerfogat();

                // Kiíratom a hasáb felszínét és térfogatát
                Console.WriteLine("A hasáb felszíne: {0}", h.getFelszin());
                Console.WriteLine("A hasáb térfogata: {0}", h.getTerfogat());
                Console.ReadKey();
            } while (true);

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class Program
    {
        struct adat
        {
            public string nev;
            public string elsoDatum;
            public string utolsoDatum;
            public int suly;
            public int magassag;
        }
        static void Main(string[] args)
        {
            // 2. feladat
            // Állomány sorainak beolvasása és tárolása
            string[] forras = File.ReadAllLines("../../balkezesek.csv");
            adat[] ad = new adat[forras.Length - 1];

            // 3. feladat
            // Sorok széttagolása ; mentén és a struktúrált tömbbe pakolás
            string[] f;
            for (int i = 1; i < ad.Length; i++)
            {
                f = forras[i].Split(';');
                ad[i].nev = f[0];
                ad[i].elsoDatum = f[1];
                ad[i].utolsoDatum = f[2];
                ad[i].suly = int.Parse(f[3]);
                ad[i].magassag = int.Parse(f[4]);
            }
            Console.WriteLine("3. feladat \n A feladatban {0} adatsor található.", ad.Length);

            // 4. feladat
            // 
            Console.WriteLine("4. feladat");
            for (int i = 1; i < ad.Length; i++)
            {
                if (ad[i].utolsoDatum.Contains("1999-10"))
                {
                    Console.WriteLine("{0} magassága: {1} cm", ad[i].nev, ad[i].magassag * 2.54);
                }
            }

            // 5. feladat
            // Évszám bekérése
            string evszam = "";
            do
            {
                Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
                evszam = Console.ReadLine();
                if (Convert.ToInt32(evszam) <= 1999 && Convert.ToInt32(evszam) >= 1990)
                {
                    break;
                }
                Console.Write("\nHibás adat!");
            } while (true);

            // 6. feladat
            // Átlagsúly
            int fo = 0;
            double osszsuly = 0;
            string ss = "";
            for (int i = 1; i < ad.Length; i++)
            {
                if (ad[i].elsoDatum.Substring(0, 4) == evszam)
                {
                    fo++;
                    osszsuly += ad[i].suly;
                }
            }

            Console.WriteLine("6. feladat: {0} font", osszsuly / fo);




            // Kilépés
            Console.ReadKey();
        }
    }
}

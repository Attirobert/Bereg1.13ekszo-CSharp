using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor2
{
    class Hasab : Kor2
    {
        // Osztályváltozó
        private double magas,
            terfogat,
            felszin;

        public Hasab() : base() {}

        public void setMagas(double p) { this.magas = p; }
        public double getMagas() { return this.magas; }

        public void setTerfogat(){this.terfogat = Math.Round(this.getTerulet() * this.magas, 2); }
        public double getTerfogat() { return this.terfogat; }

        public void setFelszin(){this.felszin = Math.Round(this.getTerulet() * 2 + this.magas * this.getKerulet(), 2); }
        public double getFelszin() { return this.felszin; }



    }
}

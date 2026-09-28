using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {

            this.AkkumulatorSzint = akkumulatorSzint;
        }

        public int AkkumulatorSzint
        {
            get => akkumulatorSzint; set
            {
                Math.Clamp(value, 0, 100);
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{this.Rendszam} - {this.Kor} éves jármű. {this.KilometerOra} km-rel, {AkkumulatorSzint} % töltötséggel");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                this.KilometerOra -= 10000;

            }
            this.akkumulatorSzint += 20;
            Console.WriteLine("A jármü szervizelése megtörtént.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PLD_autoszerviz
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.UzemanyagSzint = 0;
            this.akkumulatorSzint = akkumulatorSzint;
        }

        public int AkkumulatorSzint { get => akkumulatorSzint; set {
                if (value < 0)
                {
                    akkumulatorSzint = 0;
                }
                else if (value > 100)
                {
                    akkumulatorSzint = 100;
                }
                else
                {
                    akkumulatorSzint = value;
                }
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

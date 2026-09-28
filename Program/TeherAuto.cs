using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.Rakomany = rakomany;
        }

        public int Rakomany
        {
            get => rakomany; set
            {
                if (value < 0)
                {
                    rakomany = 0;
                }
                else if (value > 20)
                {
                    rakomany = 20;
                }
                else
                {
                    rakomany = value;
                }

            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{this.Rendszam} - {this.Kor} éves jármű. {this.KilometerOra} km-rel, {this.Rakomany} tonna");
        }

        public override void Szervizel(int dij)
        {
            //int lepakolt_suly = this.Rakomany;
            this.Rakomany = 0;
            Console.WriteLine("A rakomány le lett pakolva.");
            base.Szervizel(dij);
            //this.Rakomany = lepakolt_suly;
            Console.WriteLine("A rakomány vissza lett pakolva.");

        }
    }
}

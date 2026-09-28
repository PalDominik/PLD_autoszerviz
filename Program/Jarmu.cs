using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseg;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
            this.SzervizSzukseges = szervizSzukseg;
        }

        public string Rendszam
        {
            get => rendszam; set
            {
                if (value == "")
                {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            }
        }
        public int Kor { get => kor; set
            {
                if (value < 0)
                {
                    kor = 0;

                }
                else if (value > 50)
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                }
            }
        }
        public int KilometerOra
        {
            get => kilometerOra; set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                }

                else
                {
                    kilometerOra = value;
                }
            }
        }
        public int UzemanyagSzint
        {
            get => uzemanyagSzint; set
            {
                if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }


            }
        }
        public bool SzervizSzukseges
        {
            get => szervizSzukseg; set
            {
                if (this.kilometerOra >= 200000)
                {
                    szervizSzukseg = true;
                }
                else
                {
                    szervizSzukseg = false;
                }
            }
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{this.rendszam} - {this.kor} éves jármű. {this.kilometerOra}");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                this.kilometerOra -= 10000;

            }
            this.uzemanyagSzint -= 10;
            Console.WriteLine("A jármü szervizelése megtörtént.");
        }
    }
}

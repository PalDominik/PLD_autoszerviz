using System;
using System.Collections.Generic;
using System.Text;

namespace PLD_autoszerviz
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek;

        public List<Jarmu> Jarmuvek { get => jarmuvek; set => jarmuvek = value; }

        public void JarmuFelvetel(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervizbe");
        }

        public void InformaciokListazasa()
        {
            for (int i = 0; i < jarmuvek.Count; i++)
            {
                jarmuvek[i].InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            for (int i = 0; i < jarmuvek.Count; i++)
            {
                if (jarmuvek[i].SzervizSzukseg)
                {
                    jarmuvek[i].Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"{jarmuvek[i].Rendszam} szervizelése nem szükséges.");
                }
            }
        }
    }
}

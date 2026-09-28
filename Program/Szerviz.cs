using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        protected List<Jarmu>? jarmuvek = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
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
                if (jarmuvek[i].SzervizSzukseges)
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

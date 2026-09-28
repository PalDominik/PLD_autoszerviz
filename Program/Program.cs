namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Szerviz szerviz = new Szerviz();
            Jarmu autocska = new Jarmu("Fee111", 5, 2000, 20);

            szerviz.JarmuFelvetele(autocska);
            szerviz.InformaciokListazasa();
        }
    }
}

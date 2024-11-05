using System.Runtime.Versioning;

namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int cont = 0, cont1 = 0, cont6 = 0, dau;
            Random rand = new Random();

            //Iniciación de variables
            dau = rand.Next(1, 7);

            //mientras no final
            while(cont1 != cont6 || cont1==0 || cont6==0)
            {
                if (dau == 1)
                    cont1++;
                else if (dau == 6)
                    cont6++;
                cont++;
                dau = rand.Next(1, 7);
            }
            Console.WriteLine($"El dado se ha tirado: {cont} veces\nHa salido 6: {cont6} veces");
        }
    }
}

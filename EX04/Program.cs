namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string linia;
            int num, contPositius = 0, contNegatius = 0;

            StreamReader fitxer = new StreamReader(@"..\..\..\..\numeros.txt");
            linia = fitxer.ReadLine();

            while (linia != null)
            {
                num = Convert.ToInt32(linia);
                if (num < 0)
                    contNegatius ++;
                else
                    contPositius ++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"Valores positivos introducidos: {contPositius}\nValores negativos introducidos: {contNegatius}");
        }
    }
}

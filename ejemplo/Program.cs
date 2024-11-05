namespace ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linia;
            int num;

            StreamReader fitxer = new StreamReader("numeros.txt");
            linia = fitxer.ReadLine();
            //while (!fitxer.EndOfStream)
            //{
            //    num = Convert.ToInt32(fitxer.ReadLine());
            //    Console.WriteLine(num);
            //}
            while (linia != null)
            {
                num = Convert.ToInt32(linia);
                Console.WriteLine(num);
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
        }
    }
}

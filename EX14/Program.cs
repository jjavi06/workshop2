namespace EX14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIÓ VARIABLES
            string linia;
            int cont=0, acum=0;
            StreamReader arxiu = new StreamReader("../../../../BONUS2.TXT");
            linia = arxiu.ReadLine();

            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    cont++;
                    linia = arxiu.ReadLine();
                    acum += Convert.ToInt32(linia);
                }
                linia = arxiu.ReadLine();
            }
            arxiu.Close();
            Console.WriteLine($"Bonus total: {acum}\nBillets amb bonus: {cont}");
        }
    }
}

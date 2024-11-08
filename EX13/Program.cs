using System.Runtime.Versioning;

namespace EX13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linia;
            int acum = 0, contBonus = 0, contTotal = 0;
            Random rnd = new Random();
            StreamReader arxiu = new StreamReader("../../../../bonus.txt");
            linia = arxiu.ReadLine();

            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    acum += rnd.Next(1, 11);
                    contBonus++;
                }
                contTotal++;
                linia = arxiu.ReadLine();
            }
            arxiu.Close();
            Console.WriteLine($"Total billets guanyadors: {contBonus}\nPercentatge de billets amb bonus: " +
                $"{Math.Round((double)contBonus/contTotal*100, 2)}\nTotal diners guanyats: {acum}");
        }
    }
}

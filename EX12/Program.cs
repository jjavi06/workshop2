namespace EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string linia, alex, iker;
            int contAlex=0, contIker=0;
            StreamReader arxiu = new StreamReader("alumnesDAMDAW.txt");
            linia = arxiu.ReadLine();

            while (linia != null)
            {
                if (linia == "Alex")
                    contAlex++;
                else if (linia == "Iker")
                    contIker++;
                linia = arxiu.ReadLine();
            }
            arxiu.Close();
            if (contAlex == contIker)
                Console.WriteLine("Hi ha la mateixa quantitat d'Ikers que d'Alex");
            else if (contIker>contAlex)
                Console.WriteLine("Hi ha més alumnes que es diuen Iker");
            else
                Console.WriteLine("Hi ha més alumnes que es diuen Alex");

        }
    }
}

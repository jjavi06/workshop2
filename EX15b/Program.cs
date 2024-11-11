namespace EX15b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int rival, girona, punts = 0, guanyats = 0, perduts = 0, empatats = 0, cont = 0;
            string linia;
            StreamReader arxiu = new StreamReader("Girona lliga23_24(visitant-local).txt");

            //Primer valor
            linia = arxiu.ReadLine();

            while (linia != null)
            {
                if (cont % 2 != 0)
                {
                    girona = Convert.ToInt32(linia);
                    rival = Convert.ToInt32(linia = arxiu.ReadLine());
                    if (girona > rival)
                    {
                        guanyats++;
                        punts += 3;
                    }
                    else if (girona == rival)
                    {
                        empatats++;
                        punts++;
                    }
                    else
                        perduts++;
                }
                else
                {
                    rival = Convert.ToInt32(linia);
                    girona = Convert.ToInt32(linia = arxiu.ReadLine());
                    if (girona > rival)
                    {
                        guanyats++;
                        punts += 3;
                    }
                    else if (girona == rival)
                    {
                        empatats++;
                        punts++;
                    }
                    else
                        perduts++;
                }
                linia = arxiu.ReadLine();
                cont++;
            }
            arxiu.Close();
            Console.WriteLine($"Partits guanyats: {guanyats}\nPartits perduts: {perduts}\nPartits empatats: {empatats}\nPunts: {punts}");
        }
    }
}

namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string linia; 
            int suma=0, cont=0, num, mitjana;
            StreamReader arxiu = new StreamReader("NUMEROS2.TXT");
            linia = arxiu.ReadLine();
            num = Convert.ToInt32(linia);

            while (linia != null && num != 0)
            {
                suma += num;
                cont++;
                linia = arxiu.ReadLine();
                num = Convert.ToInt32(linia);
            }
            arxiu.Close();
            mitjana = suma / cont;
            Console.WriteLine($"La mitjana dels numeros es: {mitjana}");
        }
    }
}

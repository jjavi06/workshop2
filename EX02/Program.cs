using System.ComponentModel.DataAnnotations.Schema;

namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string linia;
            int num, cont;
            StreamReader file = new StreamReader("numeros.txt");

            linia = file.ReadLine();
            cont = 0;
            num = Convert.ToInt32(linia);

            while (linia != null && num != 0)
            {
                num = Convert.ToInt32(linia);
                cont ++;
                linia = file.ReadLine();
            }
            file.Close();
            Console.WriteLine($"Has introducido {cont} numeros");
        }
    }
}

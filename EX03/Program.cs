namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int num, contPositius, contNegatius;

            Console.Write("Dime un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            contPositius = 0;
            contNegatius = 0;

            while (num != 0)
            {
                if (num < 0)
                    contNegatius += 1;
                else
                    contNegatius += 1;
                Console.Write("Dime otro número: ");
            }
            Console.WriteLine($"Valores positivos introducidos: {contPositius}\nValores negativos introducidos: {contNegatius}");
        }
    }
}

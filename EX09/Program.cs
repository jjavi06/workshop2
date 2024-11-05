namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int num, cont;

            Console.Write("Dime un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            cont = 0;

            if (num < 0)
            {
                Console.Write("Dime otro número: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num > 0)
            {
                num /= 10;
                cont++;
            }
            Console.WriteLine($"El número tiene {cont} valores");

        }
    }
}

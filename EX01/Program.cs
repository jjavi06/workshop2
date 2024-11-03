namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int num, cont;

            Console.Write("Dime un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            cont = 1;

            while (num != 0)
            {
                cont += 1;
                Console.Write("Dime otro numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Has introducido {cont} numeros");
        }
    }
}

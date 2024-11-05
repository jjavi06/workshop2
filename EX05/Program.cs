namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int suma, cont, num, mitjana; 

            Console.Write("Dime un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            suma = 0;
            cont = 0;

            while (num != 0)
            {
                suma += num;
                cont++;
                Console.Write("Dime otro numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            mitjana = suma / cont;
            Console.WriteLine($"La mitjana dels numeros es: {mitjana}");
        }
    }
}

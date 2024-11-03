namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int num, menor, major;
                        
            Console.Write("Dime un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            //major = int.MinValue;
            //menor = int.MaxValue;
            major = num;
            menor = num;

            while (num != 0)
            {
                if (num > major)
                    major = num;
                else if (num < menor)
                    menor = num;
                Console.Write("Dime otro número: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Major: {major}\nMenor: {menor}");

        }
    }
}

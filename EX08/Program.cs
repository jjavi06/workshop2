namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string linia;
            int valorGran= int.MinValue, valorPetit = int.MinValue, num;

            StreamReader arxiu = new StreamReader(@"../../../../NUMEROS.TXT");
            linia = arxiu.ReadLine();
            num = Convert.ToInt32(linia);
            
            while (linia != null && num != 0)
            {
                if (num > valorGran)
                    valorGran = num;
                else if (num < valorPetit)
                    valorPetit = num;
                linia = arxiu.ReadLine();
                num = Convert.ToInt32(linia);
            }
            Console.WriteLine($"Valor mes gran: {valorGran}\nValor mes petit: {valorPetit}");

        }
    }
}

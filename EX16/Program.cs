using Microsoft.VisualBasic;

namespace EX16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            double radi, coordenadaX, coordenadaY;
            string linia, dintreFora;
            StreamReader arxiu = new StreamReader("coordenades.txt");

            //Demanem el radi i calculem perimetre
            Console.Write("Dime el radio del la circunferencia: ");
            radi = Convert.ToDouble(Console.ReadLine());
            linia = arxiu.ReadLine();
            while (linia != null)
            {
                coordenadaY = Math.Sqrt(Math.Pow(Convert.ToDouble(linia), 2));
                if (coordenadaY > radi)
                {
                    dintreFora = "Fora";
                    linia = arxiu.ReadLine();
                }
                else if (coordenadaY == radi)
                {
                    coordenadaX = Math.Sqrt(Math.Pow(Convert.ToDouble(linia = arxiu.ReadLine()), 2));
                    if (coordenadaX == coordenadaY)
                        dintreFora = "Sobre";
                    else if (coordenadaX > radi)
                        dintreFora = "Fora";
                    else
                        dintreFora = "Dintre";
                }
                else
                {
                    coordenadaX = Math.Sqrt(Math.Pow(Convert.ToDouble(linia = arxiu.ReadLine()), 2));
                    if (coordenadaX > radi)
                        dintreFora = "Fora";
                    else
                        dintreFora = "Dintre";
                }
                linia = arxiu.ReadLine();
                Console.WriteLine($"{dintreFora}");
            }
            arxiu.Close();
        }
    }
}

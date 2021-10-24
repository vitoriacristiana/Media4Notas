using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, med;

            Console.Clear();
            Console.Beep(365, 32);
            Console.WriteLine("--- Média ---");
            Console.WriteLine("Digite suas notas abaixo.");

            Console.Write("Nota 1 :");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2 :");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3:");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Nota 4:");
            n4 = double.Parse(Console.ReadLine());

            med = (n1 + n2 + n3 + n4) / 4;

            if ((n1 < 0 || n1 > 10) || (n2 < 0 || n2 > 10) || (n3 < 0 || n3 > 10) || (n4 < 0 || n4 > 10))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Console.ResetColor();

                }
            else if(med < 5)
            {
                Console.WriteLine($"Você ficou com média {med:N1}");
                Console.Write("Resultado:");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Reprovado");
                Console.ResetColor();

                }
            else if (med >= 5 && med <= 6)
            {
                Console.WriteLine($"Você ficou com média {med:N1}");
                Console.Write("Resultado:");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Em recuperação");
                Console.ResetColor();
            }
            else if (med > 6)

            {
                Console.WriteLine($"Você ficou com média {med:N1}");
                Console.Write("Resultado:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Aprovado");
           }    Console.ResetColor();
        }
    }
}

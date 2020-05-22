using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule a parcela do FGTS sobre o salário de um funcionário (8%).");
            Console.WriteLine("Sálario: R$2000,00");
            double resultado=2000 * 8;
            double resultado2=resultado / 100;
            Console.ReadKey();
            Console.WriteLine($"FGTS: R${resultado2},00");
        }
    }
}

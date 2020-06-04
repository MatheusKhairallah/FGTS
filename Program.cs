using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número que representara um salário de um funcionário,e logo após será feito o calculo da parcela do FGTS de 8% em cima deste salário.");
            Console.Write("Sálario:");
            double salario=Convert.ToDouble(Console.ReadLine());
            double resultado=salario * 8;
            double resultado2=resultado / 100;
            Console.Clear();
            Console.WriteLine($"A parcela do FGTS é:{resultado2:C}");
        }
    }
}

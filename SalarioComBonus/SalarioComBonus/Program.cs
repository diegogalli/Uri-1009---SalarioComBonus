using System;
using System.Globalization;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {

            string Nome;
            double SalarioFixo, TotalVenda, SalarioTotal;

            Nome = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SalarioTotal = TotalVenda * 15.0 / 100 + SalarioFixo;

            Console.WriteLine("TOTAL = R$ " + SalarioTotal.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}

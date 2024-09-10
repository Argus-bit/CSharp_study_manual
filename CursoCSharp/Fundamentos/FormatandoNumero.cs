using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));
            Console.WriteLine(valor.ToString("G"));
            Console.WriteLine(valor.ToString("F0"));
            Console.WriteLine(valor.ToString("E"));


            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("X"));
            Console.WriteLine(inteiro.ToString("N"));
            Console.WriteLine(inteiro.ToString("D"));
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}

using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
   
            Console.WriteLine(valor.ToString("F1")); //Quantas casas decimais
            Console.WriteLine(valor.ToString("C")); //Valor monetário
            Console.WriteLine(valor.ToString("P")); //Valor percentual
            Console.WriteLine(valor.ToString("#.##")); // Formatação de casa específica

            CultureInfo cultura = new CultureInfo("en-US"); //formatação de cultura
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //Preencher o número até 10 casas
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamente = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom compotamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamente = true;

            //bomComportamente = entrada == "S" || entrada == "s";
            bomComportamente = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamente)
            {
                Console.WriteLine("Quadro de honra!");
            }


        }
    }
}

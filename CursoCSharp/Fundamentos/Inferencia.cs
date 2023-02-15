using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            //"Inferência" é quando o C# idêntifica o tipo da variável a partir do dado atribuído a ela. Exemplo:
           
            var nome = "Leonardo";
            Console.WriteLine(nome);
            // nome = 123;
            //A linha acima daria erro porque o tipo da variável "nome" já foi definido na primeira atribuição.

            //var idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;
            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}

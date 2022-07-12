using System;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // área da circuferência 
            double raio = 4.5;
            const double PI = 3.14;

            //mudando o conteudo de uma variavel 
            raio = 5.5;

            double area = PI * raio * raio;

            //somando o valor com outro numero
            //Console.WriteLine("A área é: " + (area + 1000))

            Console.WriteLine("A área é: " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo ? " + estaChovendo);
        }
    }
}

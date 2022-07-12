using System;
namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é Seu Nome?");
            string nome = Console.ReadLine();

            //Console.ReadLine() aceita apenas string, com o uso do .Parse()
            //é possivel inserir valor do respectivo tipo da variavel.
            Console.WriteLine("Qual é Sua Idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é Seu Salário?");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} R$ {salario}");
        }
    }
}

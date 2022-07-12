using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " Da Marca " + marca + " Custa " + preco + ".");

            //usando Interpolação
            Console.WriteLine("O {0} da Marca {1} Custa {2}.", nome, marca, preco);

            //usando Interpolação inserindo a variavel diretamente
            Console.WriteLine($"O {nome} da Marca {marca} Custa {preco}.");
        }
    }
}

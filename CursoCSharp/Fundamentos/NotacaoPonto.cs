using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            //tudo maiusculo, inserindo depois do case 3 uma palavra, mudar a palavra usada depois do case 3
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine("Teste".Length);
            // .ToUpper() .Insert() Replace() = metodo
            //.Length = valor

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            //"?" depois do nome da varivael vazia para notação ponto ser ativada apenas se a variavel conter algum valor

        }
    }
}

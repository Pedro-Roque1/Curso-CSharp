using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade;
            idade = 32;
            int soma = (idade + 5) * 2;
            Console.WriteLine("Sua idade somada e multiplicada é:" + soma + " anos ");

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
    }
}

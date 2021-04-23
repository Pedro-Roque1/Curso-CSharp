using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7, Condicionais:");

            int idadeJoao = 16;
            int quantidadePessoas = 1;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João está acompanhado");
                }
                else
                {
                    Console.WriteLine("Menor de idade");
                }
         

            }

            Console.ReadLine();
        }
    }
}

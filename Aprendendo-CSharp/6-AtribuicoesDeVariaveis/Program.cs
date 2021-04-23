using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6:");

            int idade = 32;
            int idadePedro = idade;
            idade = 30;
            Console.WriteLine(idadePedro);
            Console.WriteLine(idade);
            

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            Console.WriteLine(conta);
            string contaToString = conta.ToString();
            Console.WriteLine(contaToString);
            
            object desenvolvedor = new Desenvolvedor("4564654");
            Console.WriteLine(desenvolvedor);

            Console.ReadLine();



        }


       

     
    }


}



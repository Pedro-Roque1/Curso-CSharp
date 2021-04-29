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
            Cliente cliente_1 = new Cliente();
            cliente_1.Nome = "Carlos";
            cliente_1.CPF = "458.623.120-03";
            cliente_1.Profissao = "Designer";

            Cliente cliente_2 = new Cliente();
            cliente_2.Nome = "Carlos";
            cliente_2.CPF = "458.624.120-03";
            cliente_2.Profissao = "Designer";


            if (cliente_2.Equals(cliente_1))
            {
                Console.WriteLine("Iguais");
            }
            else
            {
                Console.WriteLine("Não Iguais");
            }

            Console.ReadLine();



        }


       

     
    }


}



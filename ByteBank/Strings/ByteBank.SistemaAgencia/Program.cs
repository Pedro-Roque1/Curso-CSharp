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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            lista.Adicionar(new ContaCorrente(456, 7889));
            lista.Adicionar(new ContaCorrente(451, 78859));
            lista.Adicionar(new ContaCorrente(455, 78589));
            lista.Adicionar(new ContaCorrente(455, 78589));
            lista.Adicionar(new ContaCorrente(455, 78589));
            lista.Adicionar(new ContaCorrente(455, 78589));

            Console.ReadLine();
        }
       


    }


       

     
}






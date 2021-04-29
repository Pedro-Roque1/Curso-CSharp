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
            ContaCorrente[] contas = new ContaCorrente[]
            {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438),
                    new ContaCorrente(874, 7781438),
                    new ContaCorrente(874, 7781438),
        };
            
            
            
            
            

            foreach ( ContaCorrente conta in contas)
            {
                Console.WriteLine($"Conta atual :  Agencia: { conta.Agencia}  Numero:{conta.Numero}");
            } 
            Console.ReadLine();
        }
       


    }


       

     
    }






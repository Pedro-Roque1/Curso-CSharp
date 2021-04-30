using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Comparadores;
using ByteBank.Modelos.Extensoes;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        
        static void Main(string[] args)
        {


            var contas = new List<ContaCorrente>()
            {
                        new ContaCorrente(341, 1),
                        null,
                        new ContaCorrente(342, 2),
                        null,

                        new ContaCorrente(340, 3),
                        new ContaCorrente(290, 4)            };

            //contas.Sort();-> Chamar a implementação dada em IComparable
            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            
            var ContasOrdenadas =
                contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Agencia);

            foreach (var conta in ContasOrdenadas)
            {
               
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();





            
            
        }
        
       


    }


       

     
}






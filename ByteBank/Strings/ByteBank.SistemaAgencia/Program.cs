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
                        new ContaCorrente(341, 57480),
                        new ContaCorrente(342, 45678),
                        new ContaCorrente(340, 1),
                        new ContaCorrente(290, 18950)
            };

            //contas.Sort();-> Chamar a implementação dada em IComparable
            contas.Sort(new ComparadorContaCorrentePorAgencia());


            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();





            ///////////////testando Sort()//////////////////////
            var nomes = new List<string>()
            {
                "Pedro",
                "Guilherme",
                "Raissa",
                "SLA"
            };
            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            var  idades = new List<int>();
            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(99, -1);
            idades.Sort();
            //ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);

            idades.AdicionarVarios(5, 46, 47);

            for (int i = 0;  i< idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
        
       


    }


       

     
}






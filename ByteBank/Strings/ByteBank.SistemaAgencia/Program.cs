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
            
            ContaCorrente conta = new ContaCorrente(77777777, 7777777);
            lista.Adicionar(conta);
            lista.listaContas();
            lista.Remover(conta);
            Console.WriteLine("removido");
            lista.listaContas();

            Console.ReadLine();

            var a = true ? 1 : 0;

            String numeroAlt = null;
            var numeroAlt1 = numeroAlt != null ? numeroAlt.Substring(0, 2) : "";
            var numeroAlt2 = numeroAlt?.Substring(0, 2).ToUpper();

            int? numero = null;
            var numero1 = numero != null ? numero * 2 : 0 * 2;
            var numero2 = (numero ?? 0) * 2;
        }
       


    }


       

     
}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente Raissa = new Cliente();
            
            //Raissa.nome = "Raissa";
            //Raissa.profissao = "Desenvolvedora C#";
            //Raissa.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = new Cliente();
            //conta.titular = Raissa;
            if (conta.titular == null) Console.WriteLine("Referencia para o campo titular nula");
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;
            //conta.titular.nome = "Raissa Damasceno";
            //Console.WriteLine(Raissa.nome);
            //Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}

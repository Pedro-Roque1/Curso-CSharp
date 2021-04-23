using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaRaissa = new ContaCorrente();
            contaDaRaissa.titular = "Raissa";
            contaDaRaissa.agencia = 863;
            contaDaRaissa.numero = 86542;
            contaDaRaissa.saldo = 895;

            Console.WriteLine("titular: " + contaDaRaissa.titular);
            Console.WriteLine("Agencia: " + contaDaRaissa.agencia);
            Console.WriteLine("Numero:  " + contaDaRaissa.numero);
            Console.WriteLine("Saldo:   " + contaDaRaissa.saldo);

            contaDaRaissa.saldo += 200;


            Console.ReadLine();



        }
    }
}

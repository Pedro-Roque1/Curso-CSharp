using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Pedro";
            Console.WriteLine(conta.titular + " Você possuí um saldo de : R$ " + conta.saldo);
            conta.Sacar(200);
            Console.WriteLine(conta.titular+" Agora você possuí um saldo de :  R$ "+ conta.saldo);


            conta.Depositar(500);
            Console.WriteLine(conta.saldo);

            ContaCorrente contaRaissa = new ContaCorrente();
            contaRaissa.titular = "Raissa";

            conta.Transferir(200, contaRaissa);
            Console.WriteLine("Saldo do Pedro : " + conta.saldo);
            Console.WriteLine("Saldo da Raissa : " + contaRaissa.saldo);



            Console.ReadLine();
        }
    }
}

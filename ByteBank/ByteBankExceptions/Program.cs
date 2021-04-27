using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Metodo();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
           
            Console.ReadLine();

        }
        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
        }
        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}

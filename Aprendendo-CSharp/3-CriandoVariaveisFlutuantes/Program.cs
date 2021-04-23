using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 Criando variáveis ponto flutuante:");

            double salario;
            salario = 1222.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5.0 / 3;
            Console.WriteLine("5 / 3 = " + idade);


            Console.WriteLine("A execução terminou.Tecle enter para sair");
            Console.ReadLine();


        }
    }
}

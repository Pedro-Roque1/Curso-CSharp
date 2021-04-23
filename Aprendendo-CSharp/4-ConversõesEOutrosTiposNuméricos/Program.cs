using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversõesEOutrosTiposNuméricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4 Conversões e Outros tipos numéricos:");
            double salario;
            salario = 1200.50;
            
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            Console.WriteLine("A execução terminou.Tecle enter para sair");

            // O long é uma variavel de 64 bits
            long idade;
            idade = 13000000000000000;
            Console.WriteLine(idade);
            //o Short é uma variavel de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);
            //menor prescisão com relação ao double
            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();
        }
    }
}

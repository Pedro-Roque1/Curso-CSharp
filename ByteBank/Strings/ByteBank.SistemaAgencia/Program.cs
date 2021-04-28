﻿using System;
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
            //string padrao ="[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784-4444";
            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); Me retorna um bool
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);// Me retorna um valor
            Console.ReadLine();

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");
            
            urlTeste.StartsWith("https://www.bytebank.com");//começa com
            Console.WriteLine(urlTeste.EndsWith("cambio"));//termina com 
            Console.WriteLine(urlTeste.Contains("bytebank")); // contém parametro

            Console.WriteLine(indiceByteBank == 0);
            
            Console.ReadLine();
            string urlPametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=2500";
            ExtratorValorDeArgumentosURL extratorValores = new ExtratorValorDeArgumentosURL(urlPametros);

            string valor = extratorValores.GetValor("moedadestino");
            Console.WriteLine("Valor de moeda Destino:" + valor);
            string valorMoedaOrigem = extratorValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de Moeda Origem:" + valorMoedaOrigem);
            Console.ReadLine();
            


        }
    }


}



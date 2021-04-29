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
            double[] idades = new double[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            double acumulador = 0;
            for (int indice = 0; indice <= 4; indice++)
            {
                double idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            double divisao = acumulador / idades.Length;
            Console.WriteLine(divisao);
            
            Console.ReadLine();
        }
       


    }


       

     
    }






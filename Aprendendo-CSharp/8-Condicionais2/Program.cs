﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8, Condicionais:");

            int idadeJoao = 18;
            bool acompanhado = true;
            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não Pode entrar");
            }

            Console.ReadLine();
        }

        
    }
}




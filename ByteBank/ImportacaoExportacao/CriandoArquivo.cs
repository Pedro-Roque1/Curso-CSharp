using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78545,4752.50,Pedro Roque";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("456,6554646,8455.50,Pedro");
            }
            

        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";
            using (var fluxoDeArquivo = new FileStream(caminhoArquivo,FileMode.Create))
                using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000000; i++)
                {
                    escritor.WriteLine($"linha {i}");
                    escritor.Flush();//Despeja info do buffer para o fileStream
                    Console.WriteLine($"linha {i} essa linha foi escrita no arquivo");
                    Console.ReadLine();
                }
            }
        }
    }
}
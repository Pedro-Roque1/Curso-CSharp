using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao { 
partial class Program
{
    static void LidandoComFileStramDiretamente()
    {
        var caminhoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
        {
            var buffer = new byte[1024]; //1KB
            var numeroDeBytesLidos = -1;
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);

            }

        }
         void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;// Decodificação padrão do sistema operacional
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}
}
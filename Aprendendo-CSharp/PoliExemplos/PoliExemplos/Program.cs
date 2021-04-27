using System;

namespace PoliExemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            var quadrado1 = new Quadrado(10, 20);
            var quadrado2 = new Quadrado(30, 30);

            var circulo1 = new Circulo(10);

            Console.WriteLine(Operacoes.Somar(quadrado1, quadrado2));
            Console.WriteLine(Operacoes.Somar(quadrado1, circulo1));

            Operacoes.Desenhar(quadrado1, quadrado2, circulo1);
            Operacoes.Desenhar(new ObjetoGrafico[] { quadrado1, quadrado2, circulo1 });

            Operacoes.Salvar(quadrado1, quadrado2, circulo1);
        }
    }
}

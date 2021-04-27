using System;
using System.Collections.Generic;
using System.Text;

namespace PoliExemplos
{
    static class Operacoes
    {
        public static int Somar(ObjetoGrafico a, ObjetoGrafico b)
        {
            return a.Area + b.Area;
        }

        public static void Desenhar(params ObjetoGrafico[] objs)
        {
            foreach (ObjetoGrafico obj in objs)
                obj.Desenhar();
        }

        public static void Salvar(params ISalvarObjeto[] objs)
        {
            foreach (ISalvarObjeto obj in objs)
                obj.Save();
        }
    }
}

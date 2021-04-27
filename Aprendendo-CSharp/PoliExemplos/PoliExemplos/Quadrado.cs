using System;
using System.Collections.Generic;
using System.Text;

namespace PoliExemplos
{
    class Quadrado: ObjetoGrafico, ISalvarObjeto
    {
        public Quadrado(int altura, int largura)
        {
            Area = altura * largura;
        }

        public override void Desenhar()
        {            
        }

        public void Save()
        {
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PoliExemplos
{
    class Circulo : ObjetoGrafico, ISalvarObjeto
    {

        public Circulo(int diametro)
        {
            Area = diametro * 3;
        }

        public override void Desenhar()
        {
        }
        public override void DesenharAlt()
        {
        }

        public void Save()
        {
           // throw new NotImplementedException();
        }
    }
}

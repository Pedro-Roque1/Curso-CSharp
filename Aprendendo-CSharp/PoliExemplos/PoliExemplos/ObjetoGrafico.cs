using System;
using System.Collections.Generic;
using System.Text;

namespace PoliExemplos
{
    abstract class ObjetoGrafico
    {
        public int Area { get; set; }

        public abstract void Desenhar();

        public virtual void DesenharAlt()
        {
            //654 5d4as564ads
        }
    }
}

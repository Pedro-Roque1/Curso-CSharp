using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y) return 0;
            if (x == null) return 1;
            if (x == null) return -1; // X fica na frente de Y

            return x.Agencia.CompareTo(y.Agencia);
            
            
        }
    }
}

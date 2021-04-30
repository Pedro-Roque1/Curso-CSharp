using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>( this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

       

        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(14);
            idades.Add(14);
            idades.Add(14);

           idades.AdicionarVarios( 12, 3, 4, 5);
        }
    }
    
}

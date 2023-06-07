using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class AlmacenObjetos <T>
    {
        private T[] elementos;
        private int i;

        public AlmacenObjetos(int cantidad)
        {
            elementos = new T[cantidad];
            i = 0;
        }

        public void AgregarElemento(T objeto)
        {
            elementos[i] = objeto;
            i++;
        }

        public T ObtenerElemento(int posicion)
        {
            return elementos[posicion];
        }
    }
}

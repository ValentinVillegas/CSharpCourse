using GenericosIII.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosIII
{
    public class AlmacenObjetos<T> where T : IEmpleado
    {
        private int i;
        private T[] elementos;

        public AlmacenObjetos(int cantObjetos)
        {
            elementos = new T[cantObjetos];
        }

        public void AgregarObjeto(T objeto)
        {
            elementos[i] = objeto;
            i++;
        }

        public T ObtenerObjeto(int posicion)
        {
            return elementos[posicion];
        }
    }
}

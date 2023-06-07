using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capa de respirar");
        }

        public abstract void GetNombre();
    }
}

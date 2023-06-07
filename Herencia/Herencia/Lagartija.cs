using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Lagartija : Animales
    {
        private string nombreReptil;

        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreReptil}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Mamiferos:Animales
    {
        private string nombreSerVivo;

        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por sí solas");
        }

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del mamífero es: {nombreSerVivo}");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }
    }
}

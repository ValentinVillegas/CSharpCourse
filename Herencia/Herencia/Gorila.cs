using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia.Repository;

namespace Herencia
{
    public class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}

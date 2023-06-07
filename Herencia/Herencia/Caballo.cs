using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Herencia.Repository;

namespace Herencia
{
    public class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        public string TipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico()
        {
            return true;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }
}
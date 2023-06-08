using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaListBoxWPF
{
    public class Municipio
    {
        private string nombre;

        private double temperatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Temperatura { get => temperatura; set => temperatura = value; }
    }
}

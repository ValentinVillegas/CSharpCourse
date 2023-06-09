using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public  class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void GetDatosEmpresa()
        {
            Console.WriteLine($"Empresa: {this.Nombre} con Id: {this.Id}");
        }
    }
}

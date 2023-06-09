using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int IdEmpresa { get; set; }

        public void GetDatosEmpleado()
        {
            Console.WriteLine($"Empleado {this.Id} - {this.Nombre}.\nCargo: {this.Cargo}.\nSalario: {this.Salario}.\nPertenece a la empresa: {this.IdEmpresa}.\n");
        }
    }
}

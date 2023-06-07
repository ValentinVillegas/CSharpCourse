using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Enums
{
    public struct Empleado
    {
        private double salarioBase;
        private double comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public void IncrementaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }

        public override string ToString()
        {
            return $"Salario del empleado: {this.salarioBase}" +
                $"\nComisión del empleado: {this.comision}";
        }
    }
}
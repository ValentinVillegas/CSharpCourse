using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesAcceso
{
    public class Empleado
    {
        private string _nombre;
        private double _salario;

        public Empleado(string nombre, double salario)
        {
            this._nombre = nombre;
            this._salario = salario;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(string nombreEmpleado)
        {
            _nombre = nombreEmpleado;
        }

        /*
        public double GetSalario()
        {
            return salario;
        }
        */

        /*
        public void SetSalario(double nuevoSalario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo, el salario se actualizará a $0.00");
                salario = 0;
            }
            else
            {
                salario = nuevoSalario;
            }
        }
        */
        
        private double EvaluaSalario(double nuevoSalario)
        {
            //Si el nuevo salario es mayor a 0, retorna el nuevo salario, sino, retorna 0
            return nuevoSalario > 0 ? nuevoSalario : _salario;
        }

        public double SALARIO
        {
            get => _salario;
            set => _salario = EvaluaSalario(value);
        }
    }
}

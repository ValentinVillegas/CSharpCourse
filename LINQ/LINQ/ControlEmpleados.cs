using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ControlEmpleados
    {
        private List<Empresa> listaEmpresas;
        private List<Empleado> listaEmpleados;

        public ControlEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa() { Id = 1, Nombre = "Google Inc"});
            listaEmpresas.Add(new Empresa() { Id = 2, Nombre = "X Corp" });

            listaEmpleados.Add(new Empleado() { Id = 1, Nombre = "Sergey Brin", Cargo = "CEO", Salario = 150000, IdEmpresa = 1 });
            listaEmpleados.Add(new Empleado() { Id = 2, Nombre = "Juan Díaz", Cargo = "CEO", Salario = 150000, IdEmpresa = 2 });
            listaEmpleados.Add(new Empleado() { Id = 3, Nombre = "Larry Page", Cargo = "CO-CEO", Salario = 150001, IdEmpresa = 1 });
            listaEmpleados.Add(new Empleado() { Id = 4, Nombre = "Irina Shayk", Cargo = "CO-CEO", Salario = 150001, IdEmpresa = 2 });
        }

        public void GetCEO()
        {
            IEnumerable<Empleado> ceos = from emp in listaEmpleados where emp.Cargo == "CEO" select emp;
            foreach (Empleado emp in ceos)
            {
                emp.GetDatosEmpleado();
            }
        }

        public void GetEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from emp in listaEmpleados orderby emp.Nombre select emp;
            foreach (Empleado emp in empleados)
            {
                emp.GetDatosEmpleado();
            }
        }

        public void GetEmpleadosByEmpresa(int idEmpresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados join empresa in listaEmpresas on empleado.IdEmpresa equals empresa.Id where empresa.Id == idEmpresa orderby empleado.Nombre descending select empleado;
            foreach (Empleado emp in empleados)
            {
                emp.GetDatosEmpleado();
            }
        }
    }
}

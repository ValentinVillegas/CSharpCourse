﻿using GenericosIII.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosIII
{
    public class Electricista:IEmpleado
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return this.salario;
        }
    }
}

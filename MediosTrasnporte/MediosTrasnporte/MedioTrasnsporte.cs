using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediosTrasnporte
{
    public class MedioTrasnsporte
    {
        public void ArrancarMotor()
        {
            Console.WriteLine("Motor arrancado");
        }

        public void DetenerMotor()
        {
            Console.WriteLine("Motor detenido");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Medio de transporte en movimiento");
        }
    }
}

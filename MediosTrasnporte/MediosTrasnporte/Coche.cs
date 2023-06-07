using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediosTrasnporte
{
    public class Coche:MedioTrasnsporte
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Toamdo las curvas con decisión y destreza");
        }
    }
}

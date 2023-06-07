using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediosTrasnporte
{
    public class Avion:MedioTrasnsporte
    {
        public void Despegar()
        {
            Console.WriteLine("Despegando");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Surcando los cielos del globo");
        }
    }
}

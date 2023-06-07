using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}

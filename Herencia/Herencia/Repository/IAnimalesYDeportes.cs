using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Repository
{
    public interface IAnimalesYDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }
}
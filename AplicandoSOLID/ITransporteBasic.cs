using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicandoSOLID
{
    public interface ITransporteBasic
    {
        void Acelerar(int velocidad);
        void Desacelerar(int velocidad);
    }
}

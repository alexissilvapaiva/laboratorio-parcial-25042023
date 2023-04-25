using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public class Tren : ITransporte
    {
        public string _nombre;
        public int _velocidadActual;
        public int _velocidadMaxima;

        public void Acelerar(int velocidad)
        {
            if ((this._velocidadActual + velocidad) <= this._velocidadMaxima)
            {
                this._velocidadActual += velocidad;
            }
        }

        public void Desacelerar(int velocidad)
        {
            if ((this._velocidadActual - velocidad) >= 0)
            {
                this._velocidadActual -= velocidad;
            }
            else
            {
                this._velocidadActual = 0;
            }
        }

        public void Volar(int altitud)
        {
            return;
        }

        public void guardarEnBD()
        {
            TransporteRepository repository = new TransporteRepository();
            repository.guardar(this);
        }
    }
}

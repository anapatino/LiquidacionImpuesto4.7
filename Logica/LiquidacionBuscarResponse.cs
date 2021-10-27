using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LiquidacionBuscarResponse
    {
        public LiquidacionImpuesto Persona { get; set; }
        public string Mensaje { get; set; }
        public bool IsError { get; set; }

        public LiquidacionBuscarResponse(LiquidacionImpuesto persona)
        {
            Persona = persona;
            IsError = false;
        }
        public LiquidacionBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraDeImpuestos
    {
        const decimal porcentajeIVA = 0.16m;
        public decimal ObtenerIva(decimal MontoReserva)
        {   
            return (porcentajeIVA * MontoReserva);
        }
        public decimal ObtenerISH(decimal MontoReserva, decimal porcentaje)
        {
            return (MontoReserva * porcentaje);
        }
        public decimal ObtenerMontoTotalReserva(decimal iva, decimal ish, decimal montoReserva)
        {
            return (iva + ish + montoReserva);
        }
    }
}

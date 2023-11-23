using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    public class Euro:Moneda
    {
        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;
        private static decimal cotizacionRespectoDolar;
        static Euro()
        {
            cotizacionRespectoDolar = 1.07m;
            cotizacionCompra = 317.17m;
            cotizacionVenta = 391.45m;
        }
        public decimal CotizacionConRespectoDolar() => cotizacionRespectoDolar;
        public decimal CotizacionCompra() => cotizacionCompra;
        public decimal CotizacionVenta() => cotizacionVenta;

        public override decimal CalcularValorEnDolares()
        {
            return cantidad * cotizacionRespectoDolar;
        }

        public override decimal CalcularValorEnPesos()
        {
            return cotizacionCompra * base.Cantidad;
        }
        public override string MostrarInfo()
        {
            return $"Nombre:{GetType().Name} - Cantidad{cantidad} - Valor en Pesos:{CalcularValorEnPesos()}";
        }
        public Euro(decimal cantidad, decimal cotizacionCompra, decimal cotizacionVenta, decimal cotizacionRespectoDolar)
         : base(cantidad)
        {
            this.cotizacionCompra = cotizacionCompra;
            this.cotizacionVenta = cotizacionVenta;
            this.cotizacionRespectoDolar = cotizacionRespectoDolar;
        }
        
    }
}

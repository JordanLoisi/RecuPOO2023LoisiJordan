using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    public class Dolar : Moneda
    {
        private static decimal cotizacionCompra;
        private static decimal cotizacionVenta;
        static Dolar()
        {
            cotizacionCompra = 348.50m;
            cotizacionVenta = 368.50m;
        }
        public Dolar(decimal cantidad, decimal cotizacionCompra, decimal cotizacionVenta) : base(cantidad)
        {
            this.cotizacionCompra = cotizacionCompra;
            this.cotizacionVenta = cotizacionVenta;
        }
        public decimal CotizacionCompra() => cotizacionCompra;

        public decimal CotizacionVenta() => cotizacionVenta;
        public override decimal CalcularValorEnDolares()
        {
            return base.Cantidad;
        }

        public override decimal CalcularValorEnPesos()
        {
            return cotizacionCompra * CalcularValorEnDolares();
        }
        public override string MostrarInfo()
        {
            return $"Nombre:{GetType().Name} - Cantidad{CalcularValorEnDolares()} - Valor en Pesos:{CalcularValorEnPesos()}";
        }

    }
}


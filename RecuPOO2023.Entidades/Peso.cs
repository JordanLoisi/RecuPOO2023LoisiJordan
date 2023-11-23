using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    public class Peso: Moneda
    {
        private static decimal cotizacionRespectoDolar;
        public override decimal Cantidad { get; set; }
        static Peso()
        {

        }
        public Peso(decimal cantidad, decimal cotizacionRespectoDolar) : base(cantidad)
        {
            this.cotizacionRespectoDolar = cotizacionRespectoDolar;
        }

        public override decimal CalcularValorEnDolares()
        {
            return Cantidad * cotizacionRespectoDolar;
        }

        public override decimal CalcularValorEnPesos()
        {
            return Cantidad;
        }
        public override string MostrarInfo()
        {
            return $"Nombre:{GetType().Name} - Cantidad{CalcularValorEnPesos()} - Valor en Pesos:{CalcularValorEnDolares()}";
        }

        public override decimal Cantidad
        {
            get { return base.Cantidad; }
            set
            {
                base.Cantidad = (value > 0) ? value : 0;
            }
        }

     

        

      
    }
}

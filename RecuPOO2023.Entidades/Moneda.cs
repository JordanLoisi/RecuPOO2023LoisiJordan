using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    public abstract class Moneda
    {
        protected decimal cantidad;
        public virtual decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value > 0 && value > 200)
                {
                    cantidad = 200;
                }
                else if (value > 0)
                {
                    cantidad = value;
                }
                else
                {
                    cantidad = 0;
                }
            }
        }

        public Moneda(decimal cantidad)
        {
            Cantidad = cantidad;
        }

        public abstract decimal CalcularValorEnDolares();
        public abstract decimal CalcularValorEnPesos();
        public virtual string MostrarInfo()
        {
            return $"Cantidad: {Cantidad.ToString()}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Moneda moneda)
            {
                return this.GetType() == moneda.GetType();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.GetType().GetHashCode();
        }
        public static bool operator ==(Moneda m, Moneda m2)
        {
            return m.Equals(m2);
        }
        public static bool operator !=(Moneda m, Moneda m2)
        {
            return !(m == m2);
        }
    }
}

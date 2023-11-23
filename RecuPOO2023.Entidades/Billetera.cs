using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Entidades
{
    class Billetera
    {
        private List<Moneda> monedas;

        public Billetera()
        {
            monedas = new List<Moneda>();
        }
        public static bool operator ==(Billetera b, Moneda m)
        {
            foreach (var item in b.monedas)
            {
                if (item.GetType() == m.GetType())
                {
                    return true;
                }

            }
            return false;
        }
        public static bool operator !=(Billetera b, Moneda m)
        {
            return !(b == m);
        }
        public static bool operator +(Billetera b, Moneda m)
        {
            if (b == m)
            {
                foreach (var item in b.monedas)
                {
                    if (item.GetType() == m.GetType())
                    {
                        item.Cantidad = m.Cantidad;
                    }
                }
                return true;
            }
            else
            {
                b.monedas.Add(m);
                return false;
            }
        }
        public static string operator -(Billetera b, Moneda m)
        {
            if (b != m)
            {
                return $"No tiene {m.GetType().Name} para retirar";
            }
            if (b == m)
            {
                foreach (var item in b.monedas)
                {
                    if (item.GetType() == m.GetType())
                    {
                        if (item.Cantidad < m.Cantidad)
                        {
                            return "Fondos insuficientes!!!";
                        }
                        else
                        {
                            decimal totalBilletera = item.Cantidad - m.Cantidad;
                            if (item.Cantidad <= 0)
                            {
                                b.monedas.Remove(item);
                            }
                            return $"Se retiraron {totalBilletera} de la Moneda {item.GetType().Name}";
                        }
                    }

                }
            }
            return "Fin del proceso";
        }
        public string IngresarDinero(Moneda m)
        {
            Billetera b = new Billetera();
            if (b + m)
            {
                foreach (var item in b.monedas)
                {
                    if (item.GetType() == m.GetType())
                    {
                        item.Cantidad = m.Cantidad;
                    }
                }
                return $"Se actualizo la cantidad de {m} a {m.Cantidad}";
            }
            else
            {
                return "No tiene esta moneda en la lista, por lo tanto se agrego";
            }
        }
        public string ExtraerDinero(Moneda moneda)
        {
            Moneda monedaExistente = monedas.Find(m => m.GetType() == moneda.GetType());

            if (monedaExistente == null)
            {
                return $"No tiene {moneda.GetType().Name} para retirar.";
            }
            else
            {
                if (monedaExistente.Cantidad < moneda.Cantidad)
                {
                    return "Fondos insuficientes!!!";
                }
                else
                {
                    monedaExistente.Cantidad -= moneda.Cantidad;

                    if (monedaExistente.Cantidad <= 0)
                    {
                        monedas.Remove(monedaExistente);
                        return $"Se retiraron {moneda.Cantidad} {monedaExistente.GetType().Name}. La moneda ha sido eliminada de la billetera.";
                    }
                    else
                    {
                        return $"Se retiraron {moneda.Cantidad} {monedaExistente.GetType().Name}.";
                    }
                }
            }
        }
        public static implicit operator string(Billetera b)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (b.monedas.Count > 0)
            {
                foreach (var item in b.monedas)
                {
                    stringBuilder.AppendLine($"Cantidad: {item.Cantidad}, Tipo:{item.GetType().Name}");
                }
            }
            else
            {
                stringBuilder.AppendLine("No hay dinaero en su Billetera");
            }
            return stringBuilder.ToString();

        }
        public override int GetHashCode()
        {
            int nuevoGet = 0;
            if (monedas.Count > 0)
            {
                foreach (var item in monedas)
                {
                    nuevoGet += item.GetHashCode();
                }
                return nuevoGet;
            }
            else
            {
                return nuevoGet = 17;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public class Calculos
    {

        public static void CalculoValoresVenta(List<Mascota> Mascotas)
        {
            double PorcentajeIva = 0.19;
            int ValorNeto = CalculoValorNeto(Mascotas);
            int ValorDescuento = CalculoDescuento(ValorNeto);
            int ValorVenta = CalculoValorVenta(ValorNeto, ValorDescuento);
            int ValorIva = Convert.ToInt32(ValorVenta * PorcentajeIva);
            int TotalVenta = Convert.ToInt32(ValorIva+ValorVenta);
            Console.WriteLine("<-------*------->");
            Console.WriteLine("Precio Neto: " + ValorNeto);
            Console.WriteLine("Descuento: " + ValorDescuento);
            Console.WriteLine("Precio Venta: " + ValorVenta);
            Console.WriteLine("Iva: " + ValorIva);
            Console.WriteLine("Total Venta: " + TotalVenta);
        }
        public static int CalculoValorVenta(int ValorNeto, int ValorDescuento)
        {
            return (ValorNeto - ValorDescuento);
        }

        public static int CalculoValorNeto(List<Mascota> Mascotas)
        {
            int valorNeto = 0;
            foreach (var item in Mascotas)
            {
                valorNeto = valorNeto + item.PrecioVenta;
            }
            return valorNeto;
        }

        public static int CalculoDescuento(int ValorNeto)
        {
            int TipoDescuento = 0;
            int ValorDescuento;

            if(ValorNeto > 25000 && ValorNeto <= 100000)
            {
                TipoDescuento = 1;
            }
            else if(ValorNeto > 100000 && ValorNeto <= 250000)
            {
                TipoDescuento = 2;
            }
            else if(ValorNeto > 250000)
            {
                TipoDescuento = 3;
            }

            switch (TipoDescuento)
            {
                case 1:
                    ValorDescuento = Convert.ToInt32(ValorNeto * 0.05);
                    break;
                case 2:
                    ValorDescuento = Convert.ToInt32(ValorNeto * 0.1);
                    break;
                case 3:
                    ValorDescuento = Convert.ToInt32(ValorNeto * 0.15);
                    break;
                default:
                    ValorDescuento = 0;
                    break;
            }

            return ValorDescuento;
        }
    }
}

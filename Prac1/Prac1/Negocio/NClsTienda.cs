using Prac1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1.Negocio
{
    class NClsTienda
    {
        public string CalcularDesc(ClsTienda tienda21)
        {
            if (tienda21.Dia == "martes" || tienda21.Dia == "jueves")
            {
                Console.WriteLine("");
                Console.WriteLine("el dia de hoy hay un descuento del  15%");
                double total = tienda21.Monto - (tienda21.Monto * 0.15);
                return "Su total a pagar es de: " + total;
            }

            else
            {
                Console.WriteLine("");
                return "hoy no hay decuento, su total a pagar es " + tienda21.Monto;
            }

            
        }
    }
}

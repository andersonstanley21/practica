using Prac1.Entidades;
using Prac1.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsTienda clstienda = new ClsTienda();
            NClsTienda nclstienda = new NClsTienda();

            Console.WriteLine("Escriba el monto a gastar");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el la dia de hoy ");
            
            
            string dia = (Console.ReadLine());

            ClsTienda tienda21 = new ClsTienda(monto, dia);

            Console.WriteLine(nclstienda.CalcularDesc(tienda21));
            Console.ReadLine();
        }
    }
}

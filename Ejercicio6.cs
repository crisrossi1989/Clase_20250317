using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 6) Realizar un procedimiento que permita ingresar el alto y la base de un triángulo y muestre su área.
    class Ejercicio6
    {
        public void AreaTriangulo()
        {
            double valorBase;
            double valorAltura;
            double areaTriangulo;

            Console.WriteLine("ingrese el valor de la Base: "); // Pido ingreso de la Base.
            valorBase = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("ingrese el valor de la Altura: "); // Pido ingreso de la Altura.
            valorAltura = Convert.ToDouble(Console.ReadLine());

            // Calculo el Área del Triangulo y muestro el valor.
            areaTriangulo = ((valorBase * valorAltura) / 2);
            Console.WriteLine("el área del triángulo es: " + areaTriangulo);
        }
    }
}

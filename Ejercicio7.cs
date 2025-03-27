using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 7) Realizar un procedimiento que pida al usuario el valor de los dos lados y luego calcule y
    // muestre el perímetro y el área de un rectángulo.
    class Ejercicio7
    {
        public void PerimetroArea()
        {
            // Declaro las variables:
            double ladoA, ladoB, ladoC;
            double perimetro; // p = (ladoA + ladoB + ladoC)
            double semiperímetro; // S = (ladoA + ladoB + ladoC)/2
            double area;

            // Pido la medida de los lados por consola:
            Console.WriteLine("ingrese el lado A del triangulo: ");
            ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el lado B del triangulo: ");
            ladoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el lado C del triangulo: ");
            ladoC = Convert.ToDouble(Console.ReadLine());
            
            // Calculo el Perímetro:
            perimetro = (ladoA + ladoB + ladoC);

            // Fórmula de Herón: S = perimetro/2
            semiperímetro = (perimetro/2);
            // Calculo el Área: { RaízCuadrada [ S* (S-ladoA) * (S-ladoB) * (S-ladoC) ] }
            double x = (semiperímetro * (semiperímetro - ladoA) * (semiperímetro - ladoB) * (semiperímetro - ladoC));
            area = Math.Sqrt(x); // Raíz Cuadrada de "x".

            // Muestro los resultados de perímetro y área en pantalla:
            Console.WriteLine("el perímetro del triangulo es: " + perimetro); // OK
            Console.WriteLine("el área del triangulo es: " + area); // OK
        }
    }
}

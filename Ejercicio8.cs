using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 8) Realizar un procedimiento que solicite al alumno las notas de los dos parciales teóricos y de los dos parciales
    // prácticos de la materia actual y luego muestre el promedio de la teoría, el promedio de la práctica y el promedio
    // de la materia (promedio de las cuatro notas).
    class Ejercicio8
    {
        public void Promedios() 
        {
            byte notaTeorico1;
            byte notaTeorico2;
            byte notaPractico1;
            byte notaPractico2;
            byte promedioPractica;
            byte promedioTeoria;
            byte promedioMateria;

            Console.WriteLine("ingrese nota parcial teórico 1: ");
            notaTeorico1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("ingrese nota parcial teórico 2: ");
            notaTeorico2 = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("ingrese nota parcial práctico 1: ");
            notaPractico1 = Convert.ToByte(Console.ReadLine());
            
            Console.WriteLine("ingrese nota parcial práctico 2: ");
            notaPractico2 = Convert.ToByte(Console.ReadLine());

            promedioTeoria = Convert.ToByte((notaTeorico1 + notaTeorico2)/2);
            promedioPractica = Convert.ToByte((notaPractico1 + notaPractico2)/2);
            promedioMateria = Convert.ToByte((notaTeorico1 + notaTeorico2 + notaPractico1 + notaPractico2)/4);
            Console.WriteLine(  "El promedio de la Teoría es: "     + promedioTeoria    + ", "  +
                                "el promedio de la Práctica es: "   + promedioPractica  + ", "  +
                                "y el promedio de la Materia es: "  + promedioMateria   + "."   );
        }
    }
}

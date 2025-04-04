using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 5) Realizar un procedimiento que permita ingresar 4 números y los muestre en el orden inverso al ingresado.
    class Ejercicio5
    {
        public void IngresarNumeros()
        {
            byte numero1, numero2, numero3, numero4;

            Console.Write("ingrese el 1er número: ");
            numero1 = Convert.ToByte(Console.ReadLine());
            Console.Write("ingrese el 2do número: ");
            numero2 = Convert.ToByte(Console.ReadLine());
            Console.Write("ingrese el 3er número: ");
            numero3 = Convert.ToByte(Console.ReadLine());
            Console.Write("ingrese el 4to número: ");
            numero4 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Los números ingresados son: " 
                + numero4 + ", " 
                + numero3 + ", "
                + numero2 + ", " 
                + numero1 + ". ");

            /*
            byte[] numeros; // Declaración de un array de enteros
            numeros = new byte[4]; // Creación de un array de 4 elementos

            Console.Write("ingrese el 1er número: ");
            numeros[0] = Convert.ToByte(Console.ReadLine());
            Console.Write("ingrese el 2do número: ");
            numeros[1] = Convert.ToByte(Console.ReadLine());
            Console.Write("ingrese el 3er número: ");
            numeros[2] = Convert.ToByte(Console.ReadLine());
            Console.Write("ingrese el 4to número: ");
            numeros[3] = Convert.ToByte(Console.ReadLine());

            Console.Write(numeros[3] + ", ");
            Console.Write(numeros[2] + ", ");
            Console.Write(numeros[1] + ", ");
            Console.Write(numeros[0] + ".");
            */
        }
    }
}
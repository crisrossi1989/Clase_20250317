using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 3) Realizar un procedimiento que pida al usuario los siguientes datos personales: nombre, apellido, edad y carrera;
    // y luego muestre por pantalla los datos ingresados en una sola línea y luego en una línea por dato.
    class Ejercicio3
    {      
        public void PedirDatos() 
        {
            string nombrePersona;
            string apellidoPersona;
            byte edadPersona;
            string carreraPersona;

            Console.Write("ingrese su nombre: ");
            nombrePersona = Console.ReadLine();

            Console.Write("ingrese su apellido: ");
            apellidoPersona = Console.ReadLine();

            Console.Write("ingrese su edad: ");
            edadPersona = Convert.ToByte(Console.ReadLine());

            Console.Write("ingrese su carrera: ");
            carreraPersona = Console.ReadLine();

            Console.WriteLine("nombre: "    + nombrePersona     + " - " +
                              "apellido: "  + apellidoPersona   + " - " +
                              "edad: "      + edadPersona       + " - " +
                              "carrera: "   + carreraPersona    + "."   );

            Console.WriteLine("nombre: "    + nombrePersona);
            Console.WriteLine("apellido: "  + apellidoPersona);
            Console.WriteLine("edad: "      + edadPersona);
            Console.WriteLine("carrera: "   + carreraPersona);
        }
    }
}
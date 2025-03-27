using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 2) Realizar un procedimiento que muestre en la consola su nombre - edad - país,
    // y otro que se los pida como ingreso al usuario y luego los muestre.
    class Ejercicio2
    {
        public void MostrarDatos()
        {
            string nombrePersona = "Cristian";
            byte edadPersona = 35;
            string paisPersona = "Argentina";

            Console.WriteLine("su nombre es: " + nombrePersona + ", su edad es: " + edadPersona + ", y su pais es: " + paisPersona + ".");
        }
        public void IngresarDatos()
        {
            string nombrePersona;
            byte edadPersona;
            string paisPersona;

            Console.Write("ingrese su nombre: ");
            nombrePersona = Console.ReadLine();

            Console.Write("ingrese su edad: ");
            edadPersona = Convert.ToByte(Console.ReadLine());

            Console.Write("ingrese su país: ");
            paisPersona = Console.ReadLine();

            Console.Write("nombre: " + nombrePersona + ", edad: " + edadPersona + ", pais: " + paisPersona + ".");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    // 4) a. Realizar un procedimiento que pida al usuario la cantidad de materias de la carrera de Lic. en
    // Sistemas de Información de las Organizaciones, la cantidad de materias aprobadas y muestre en un cuadro
    // de mensajes la cantidad de materias faltantes para recibirse. (Omitir todo tipo de validaciones).
    // b. Modificar el procedimiento anterior para que el usuario no deba ingresar la cantidad de materias total
    // de la carrera, sino que esta se incluya en el mismo como una constante. (32 Materias)
    class Ejercicio4
    {
        public void MateriasFaltantesA()
        {
            byte CantMateriasTotal;
            byte CantMateriasAprob;
            byte CantMateriasFaltantes;

            Console.Write("ingrese Cantidad Total de Materias de la Lic.en Sistemas de Información de las Organizaciones: ");
            CantMateriasTotal = Convert.ToByte(Console.ReadLine());

            Console.Write("ingrese Cantidad de Materias Aprobadas: ");
            CantMateriasAprob = Convert.ToByte(Console.ReadLine());

            CantMateriasFaltantes = Convert.ToByte(CantMateriasTotal - CantMateriasAprob);
            Console.WriteLine("La Cantidad de Materias Faltantes es: " + CantMateriasFaltantes + ".");
        }
        public void MateriasFaltantesB()
        {
            const byte CantMateriasTotal = 32;
            byte CantMateriasAprob;
            byte CantMateriasFaltantes;

            Console.Write("ingrese Cantidad de Materias Aprobadas: ");
            CantMateriasAprob = Convert.ToByte(Console.ReadLine());

            CantMateriasFaltantes = Convert.ToByte(CantMateriasTotal - CantMateriasAprob);
            Console.Write("La Cantidad de Materias Faltantes es: " + CantMateriasFaltantes + ".");
        }
    }
}

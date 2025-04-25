using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20250317
{
    class Ejercicios 
    {
        // 1) Realizar un procedimiento que muestre el mensaje “Hola Mundo”.
        public void HolaMundo()
        {
            Console.WriteLine("Hola Mundo");
        }
        // 2) Realizar un procedimiento que muestre en la consola su nombre - edad - país,
        // y otro que se los pida como ingreso al usuario y luego los muestre.
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
        // 3) Realizar un procedimiento que pida al usuario los siguientes datos personales: nombre, apellido, edad y carrera;
        // y luego muestre por pantalla los datos ingresados en una sola línea y luego en una línea por dato.
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

            Console.WriteLine("nombre: " + nombrePersona + " - " +
                              "apellido: " + apellidoPersona + " - " +
                              "edad: " + edadPersona + " - " +
                              "carrera: " + carreraPersona + ".");

            Console.WriteLine("nombre: " + nombrePersona);
            Console.WriteLine("apellido: " + apellidoPersona);
            Console.WriteLine("edad: " + edadPersona);
            Console.WriteLine("carrera: " + carreraPersona);
        }
        // 4) a. Realizar un procedimiento que pida al usuario la cantidad de materias de la carrera de Lic. en
        // Sistemas de Información de las Organizaciones, la cantidad de materias aprobadas y muestre en un cuadro
        // de mensajes la cantidad de materias faltantes para recibirse. (Omitir todo tipo de validaciones).
        // b. Modificar el procedimiento anterior para que el usuario no deba ingresar la cantidad de materias total
        // de la carrera, sino que esta se incluya en el mismo como una constante. (32 Materias)
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
        // 5) Realizar un procedimiento que permita ingresar 4 números y los muestre en el orden inverso al ingresado.
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
        // 6) Realizar un procedimiento que permita ingresar el alto y la base de un triángulo y muestre su área.
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
        // 7) Realizar un procedimiento que pida al usuario el valor de los dos lados y luego calcule y
        // muestre el perímetro y el área de un rectángulo.
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
            semiperímetro = (perimetro / 2);
            // Calculo el Área: { RaízCuadrada [ S* (S-ladoA) * (S-ladoB) * (S-ladoC) ] }
            double x = (semiperímetro * (semiperímetro - ladoA) * (semiperímetro - ladoB) * (semiperímetro - ladoC));
            area = Math.Sqrt(x); // Raíz Cuadrada de "x".

            // Muestro los resultados de perímetro y área en pantalla:
            Console.WriteLine("el perímetro del triangulo es: " + perimetro); // OK
            Console.WriteLine("el área del triangulo es: " + area); // OK
        }
        // 8) Realizar un procedimiento que solicite al alumno las notas de los dos parciales teóricos y de los dos parciales
        // prácticos de la materia actual y luego muestre el promedio de la teoría, el promedio de la práctica y el promedio
        // de la materia (promedio de las cuatro notas).
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

            promedioTeoria = Convert.ToByte((notaTeorico1 + notaTeorico2) / 2);
            promedioPractica = Convert.ToByte((notaPractico1 + notaPractico2) / 2);
            promedioMateria = Convert.ToByte((notaTeorico1 + notaTeorico2 + notaPractico1 + notaPractico2) / 4);
            Console.WriteLine("El promedio de la Teoría es: " + promedioTeoria + ", " +
                          "el promedio de la Práctica es: " + promedioPractica + ", " +
                          "y el promedio de la Materia es: " + promedioMateria + ".");
        }
    }
}
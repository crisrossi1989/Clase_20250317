﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase_20250317
{
    internal class Ejercicios
    {/*
        public void DeclararVariables() // Procedimiento (PascalCase se usa para Estructuras)
        {
            // Sentencias. Acá voy a declarar 3 variables
            string nombrePersona; // (camelCase se utiliza para las Variables)
            string apellidoPersona;
            byte edadPersona;

            // Acá le asignamos los valores a mis variables
            nombrePersona = "Juan";
            apellidoPersona = "Perez";
            edadPersona = 30;

            // Muestro los datos asignados
            Console.WriteLine("Su nombre es " + nombrePersona + ", su apellido es " + apellidoPersona + " y su edad es " + edadPersona + ".");
            // Su nombre es Juan, si apellido es Perez y su edad es 30.
        }
        public void DeclararConstantes() // Procedimiento
        {
            const int numero5000 = 5000; // No se puede declarar una constante y asignarle un valor en la siguiente línea
            const string nombreMariano = "Mariano";

            Console.WriteLine("El valor de la constante numero5000 es " + numero5000 + ", y el valor de la constante nombreMariano es " + nombreMariano + ".");
        }
        public void PedirDatosDinamicos()
        {
            // Acá voy a declarae variables
            string nombrePersona;
            string apellidoPersona;
            byte edadPersona;

            // Acá voy a pedirle al usuario sus datos
            Console.Write("Por favor ingrese su nombre: ");
            nombrePersona = Console.ReadLine(); // Readline lee la línea de caracteres que uno escribe por consola y la asigna a nombrePersona

            Console.Write("Por favor ingrese su apellido: ");
            apellidoPersona = Console.ReadLine();

            Console.Write("Por favor ingrese su edad: ");
            edadPersona = Convert.ToByte(Console.ReadLine()); //Convierto el string a un byte

            Console.WriteLine("Su nombre es " + nombrePersona + ", su apellido es " + apellidoPersona + " y su edad es " + edadPersona + ".");
        }
        */
        //EJERCICIOS GUIA DE PRÁCTICA (GUÍA 1: EJERCICIOS 1 AL 8)

        // 1)	Realizar un procedimiento que muestre el mensaje “Hola Mundo”.
        public void HolaMundo()
        {
            Console.WriteLine("Hola Mundo");
        }
        // 2)	Realizar un procedimiento que muestre en la consola su nombre - edad - país, y otro que se los pida como ingreso al usuario y luego los muestre.
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
            edadPersona = Convert.ToByte( Console.ReadLine() );

            Console.Write("ingrese su país: ");
            paisPersona= Console.ReadLine();
            
            Console.Write("nombre: " + nombrePersona + ", edad: " + edadPersona + ", pais: " + paisPersona + ".");           
        }
        // 3)	Realizar un procedimiento que pida al usuario los siguientes datos personales: nombre, apellido, edad y carrera; y luego muestre por pantalla los datos ingresados en una sola línea y luego en una línea por dato.

    }
}

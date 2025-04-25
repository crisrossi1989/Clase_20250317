//forma 1 (Program):
//using Clase_20250317;
//Ejercicios;

//2da forma (Program):
using static System.Runtime.InteropServices.JavaScript.JSType;
// Nombre Solución + . + Nombre archivo + Nombre Objeto o Variable + = + Nueva instancia de esa misma clase
Clase_20250317.Ejercicio0 ej0 = new Clase_20250317.Ejercicio0();
ej0.DeclararVariables();
ej0.DeclararConstantes();
ej0.PedirDatosDinamicos();

// GUIA DE PRÁCTICA C# (GUÍA 1: EJERCICIOS del 1 al 8)
Clase_20250317.Ejercicios ej = new Clase_20250317.Ejercicios();
// EJERCICIO 1) Realizar un procedimiento que muestre el mensaje “Hola Mundo”.
ej.HolaMundo();
// EJERCICIO 2) Realizar un procedimiento que muestre en la consola su nombre - edad - país,
// y otro que se los pida como ingreso al usuario y luego los muestre.
ej.MostrarDatos();
ej.IngresarDatos();
// EJERCICIO 3) Realizar un procedimiento que pida al usuario los siguientes datos personales: nombre, apellido, edad
// y carrera; y luego muestre por pantalla los datos ingresados en una sola línea y luego en una línea por dato.
ej.PedirDatos();
// EJERCICIO 4) a. Realizar un procedimiento que pida al usuario la cantidad de materias de la carrera de Lic. en Sistemas de
// Información de las Organizaciones, la cantidad de materias aprobadas y muestre en un cuadro de mensajes la
// cantidad de materias faltantes para recibirse. (Omitir todo tipo de validaciones).
// b. Modificar el procedimiento anterior para que el usuario no deba ingresar la cantidad de materias total de la
// carrera, sino que esta se incluya en el mismo como una constante. (32 Materias)
ej.MateriasFaltantesA();
ej.MateriasFaltantesB();
// EJERCICIO 5) Realizar un procedimiento que permita ingresar 4 números y los muestre en el orden inverso al ingresado.
ej.IngresarNumeros();
// EJERCICIO 6) Realizar un procedimiento que permita ingresar el alto y la base de un triángulo y muestre su área.
ej.AreaTriangulo();
// EJERCICIO 7) Realizar un procedimiento que pida al usuario el valor de los dos lados y luego calcule y muestre el perímetro y
// el área de un rectángulo.
ej.PerimetroArea();
// EJERCICIO 8) Realizar un procedimiento que solicite al alumno las notas de los dos parciales teóricos y de los dos parciales
// prácticos de la materia actual y luego muestre el promedio de la teoría, el promedio de la práctica y el promedio
// de la materia (promedio de las cuatro notas).
ej.Promedios();
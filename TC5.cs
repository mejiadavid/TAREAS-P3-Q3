﻿/*Weird!
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.

	Tarea Corta 5
	Estudiante: David Mejia
	
	Enunciado:
	Haga una funcion que compare versiones, retornando -1 si el primer numero es mayor, 1 si el segundo numero es mayor y 0 y son iguales.
	Pueden asumir que los strings solo contienen numeros y el caracter '.'
	No hay un limite para la cantidad de subversiones que se pueden enviar: 1.1.1.1.1.1.1.1.1.1 es valido.
	0.1 < 1.0 < 1.0.1
	
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC5
{
    class TC5
    {
        static void Main(string[] args)
        {
            Compare c = new Compare();
            c.Print();
        }
    }
    public class Compare
    {
        public int Version(string a, string b)
        {
            return b.CompareTo(a); //Despues de varios intentos CompareTo era la solucion
        }
        public void Print()
        {
            string t1 = "1.1.1.1.1";
            string t2 = "1.1.1.1.2";
            string t3 = "1.1.1.1.1";

            Console.WriteLine("Resultado de mayor-menor: " + Version(t2, t1));
            Console.WriteLine("Resultado de menor-mayor: " + Version(t1, t2));
            Console.WriteLine("Resultado de igual-igual: " + Version(t3, t1));

            Console.ReadKey();
        }
    }
}

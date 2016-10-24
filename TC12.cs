﻿/*WHAT???
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

	Tarea Corta 12
	Estudiante: David Mejia
	
	Enunciado:
	Encontrar el K-esimo elemento las grande en un arreglo desordenado, notese que es el k-esimo elemento en el arreglo ordenado, no el k-esimo elemento distinto.
	ejemplo:
	[3,2,1,5,6,4], k=2 -> retorna 5
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC12
{
    class TC12
    {
        static void Main(string[] args)
        {
            int[] t = { 3, 2, 1, 5, 6, 4 };
            Console.WriteLine("Elemento: " + buscar(t, 2));
            Console.ReadKey();
        }
        static int buscar(int[] e, int p)
        {
            List<int> l = e.ToList<int>();   //pasamos el arreglo a una lista
            l.Sort();                        //ordenamos la lista
            return l[l.Count - p];           //retornamos el valor en la posicion deseada
        }
    }
}

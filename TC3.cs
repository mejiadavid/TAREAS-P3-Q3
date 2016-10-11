/*
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

	Tarea Corta 3
	Estudiante: David Mejia
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC3
{
    class TC3
    {
        static void Main(string[] args)
        {
            Find f = new Find();
            f.Print();
        }
    }
    public class Find
    {
        public int Times(List<int> l, int i)
        {
            int contador = 0;       //contador para los elementos repetidos
            foreach (int x in l)    //
            {                       //
                if (x == i)         //si encontramos el elemento
                {                   //aumentamos contador
                    contador++;     //
                }                   //
            }                       //
            return contador;        //l.FindAll(); realiza la misma funcion
        }
        public void Print()
        {
            List<int> l = new List<int>(new int[] { 2, 3, 7, 2, 3, 7, 1, 2, 4, 5, 6, 8, 9, 2 });
            Console.WriteLine("Elemento a buscar: 2, repetido: " + Times(l, 2));
            Console.ReadKey();
        }
    }
}

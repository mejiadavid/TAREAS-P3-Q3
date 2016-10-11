/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.

	Tarea Corta 2
	Estudiante: David Mejia
	
	Enunciado:
	Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
	Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC2
{
    class TC2
    {
        static void Main(string[] args)
        {
            Listas l = new Listas();
            l.Test();
        }
    }
    public class Listas
    {
        public void Print(List<int> l)
        {
            Console.WriteLine("---Original---");        //
            for (int a = 0; a < l.Count; a++)            //recorremos la lista de principio a fin
            {                                           //
                //Console.WriteLine($"{a} = {l[a]}");   //
                Console.Write(l[a] + ", ");             //
            }                                           //
            Console.WriteLine("\n\n---Invertida--");    //
            for (int z = l.Count - 1; z >= 0; z--)      //recorremos la lista desde el ultimo elemento al principio
            {                                           //
                //Console.WriteLine($"{z} = {l[z]}");   //
                Console.Write(l[z] + ", ");             //l.Reverse();
            }                                           //tambien se puede usar la funcion reverse para reorganizar la lista al reves
        }
        public void Test()
        {
            List<int> l = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Print(l);
            Console.ReadKey();
        }
    }
}

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

	Tarea Corta 19
	Estudiante: David Mejia
	
	Enunciado:
	Retorne la combinacion de los elementos unicos de dos arreglos de enteros
	Ejemplo
	[1,2,3,4,5,6],[5,6,7,8,9] -> [1,2,3,4,5,6,7,8,9]
	
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC19
{
    class TC19
    {
        static void Main(string[] args)
        {
            Combine c = new Combine();
            c.Print();
            Console.ReadKey();
        }
    }
    public class Combine
    {
        public int[] Receive(int[] a, int[] b)
        {
            List<int> la = a.ToList();              //usamos listas para mas facil manejo, agregamos el primer arreglo a la lista
            la.AddRange(b.ToList());                //agregamos el segundo arreglo a la lista
            List<int> lb = la.Distinct().ToList();  //creamos una nueva lista sin repetidos
            lb.Sort();                              //ordenamos la lista
            return lb.ToArray();                    //retornamos la lista como un array
        }
        public void Print()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int[] b = { 6, 7, 8, 9, 0 };
            int[] c = Receive(a, b);
            foreach (int x in c)
                Console.Write("{0}, ", x);
        }
    }
}

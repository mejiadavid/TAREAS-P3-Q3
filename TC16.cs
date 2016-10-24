/* Preferiblemente de manera iterativa (no recursiva para no agotar la memoria)
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

	Tarea Corta 16
	Estudiante: David Mejia
	
	Enunciado:
	Haga una funcion que imprima los primeros 100 elementos de la secuencia de fibonacci
	Fibonacci -> https://en.wikipedia.org/wiki/Fibonacci_number
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC16
{
    class TC16
    {
        static void Main(string[] args)
        {
            Fibonacci sample = new Fibonacci();
            sample.FirstHundred();
            //Console.WriteLine("->{0}", sample.Series(99));
            Console.ReadKey();
        }
    }
    public class Fibonacci
    {
        public ulong Series(int n)
        {
            ulong result = 0;
            ulong a = 0;
            ulong b = 1;

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            for(int x = 2; x <= n; x++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
        public void FirstHundred()
        {
            for(int x = 0; x <= 100; x++)
            {
                Console.WriteLine(Series(x));
            }
        }
    }
}

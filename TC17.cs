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

	Tarea Corta 17
	Estudiante: David Mejia
	
	Enunciado:
	Dado un string S, encuentre todos los caracteres repetidos en el string, imprima una linea con cada caracter repetido y cuantas veces aparece
	Ejemplo:
	"abcdabeacd"
	>a,3
	>b,2
	>c,2
	>d,2
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC17
{
    class TC17
    {
        static void Main(string[] args)
        {
            Repeat r = new Repeat();
            r.Count("abcdabeacd");
            Console.ReadKey();
        }
    }
    public class Repeat
    {
        public void Count(string s)
        {
            char[] c = s.ToCharArray();
            int limit = s.Length - 1;
            int count = 0;
            char a;

            for(int x = 0; x <= limit; x++)
            {
                if (c[x] == '-')
                    continue;
                a = c[x];
                for(int y = x; y <= limit; y++)
                {
                    if (a == c[y])
                    {
                        count++;
                        c[y] = '-';
                    }
                    if (y == limit)
                    {
                        if (count == 1)
                            continue;
                        Console.WriteLine("->{0},{1}", a, count);
                    }

                }
                count = 0;
            }
        }
    }
}

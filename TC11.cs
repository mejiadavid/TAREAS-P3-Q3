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

	Tarea Corta 11
	Estudiante: David Mejia
	
	Enunciado:
	Sub arreglo de suma minima:
	Si se recibe un arreglo con N enteros positivos, y se recibe un numero K, retornar el subarreglo mas corto de numeros cuya sumatoria es mayor o igual al numero K.
	Ejemplo
	[2,3,1,2,4,3], 7 -> [4,3] tiene el largo minimo de numeros que sumados son iguales o mayores a 7.
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC11
{
    class TC11
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 3, 1, 2, 4, 3} ;
            Console.WriteLine("[2,3,1,2,4,3], 7. Resultado: ");
            int[] y = subarreglo(x, 7);
            foreach (int z in y)
                Console.Write(z + ",");
            Console.ReadKey();
        }
        static int[] subarreglo(int [] a, int b)           //
        {                                                  //
            int tam = a.Length;                            //
            int[] t1 = new int[tam];                       //arreglo para acumular los posibles resultados
            int pos = 0;                                   //posicion para arreglo de resultados
            for(int x = 0; x < tam; x++)                   //
            {                                              //
                int toArray = a[x];                        //resultados que se acumular en el arreglo
                int suma = a[x];                           //suma provisional
                for (int y = x + 1; y < tam; y++)          //
                {                                          //
                    toArray = ((toArray * 10) + a[y]);     //
                    suma += a[y];                          //
                    if (suma >= b)                         //si la suma es igual o mayor a k
                    {                                      //
                        t1[pos] = toArray;                 //guardamos el posible resultado en el arreglo
                        pos++;                             //nos movemos una posicion
                        toArray = suma = 0;                //reset de las variables temporales
                    }                                      //if
                }                                          //for
            }                                              //for
            int t2 = t1.Min();                             //asignamos el resultado menor a una nueva variable
            var l = new Stack<int>();                      //pila
            do                                             //
            {                                              //
                l.Push(t2 % 10);                           //extraemos los numeros del resultado menor en la pila
                t2 /= 10;                                  //
            } while (t2 != 0);                             //
            return l.ToArray<int>();                       //devolvemos el arreglo del resultado menor
        }                                                  //subarreglo
    }
}

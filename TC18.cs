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

	Tarea Corta 18
	Estudiante: David Mejia
	
	Enunciado:
	Retorne los elementos comunes en dos arreglos de enteros
	Ejemplo:
	[1,2,3,4,5,6,7],[6,7,8,9,0] -> [6,7]
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC18
{
    class TC18
    {
        static void Main(string[] args)
        {
            Repetidos t = new Repetidos();
            t.Print();
            Console.ReadKey();
        }
    }
    public class Repetidos
    {
        public int[] Search(int[] a, int[] b)
        {
            int la = a.Length;
            int lb = b.Length;
            int[] c = new int[la + 1];                   //usamos el limite de a, porque comparamos a en b
            int pos = 1;                                 //
            for (int x = 0; x < la; x++)                 //recorremos el primer arreglo
            {                                            //
                for (int y = 0; y < lb; y++)             //recorremos el segundo arreglo
                {                                        //
                    if(a[x] == b[y])                     //si los elementos son iguales los agregamos al arreglo a retornar
                    {                                    //
                        bool temp = false;               //
                        if(pos > 1)                      //si es el primer elemento no recorremos el arrglo
                        {                                //
                            for (int z = 0; z < la; z++) //recorremos el arreglo a devolver buscando repetidos
                            {                            //
                                if (a[x] == c[z])        //
                                    temp = true;         //
                            }                            //
                        }                                //
                        if(!temp)                        //si no es repetido lo agregamos al arreglo
                        {                                //
                            c[pos] = a[x];               //
                            pos++;                       //
                        }                                //
                    }                                    //
                }                                        //
            }                                            //
            c[0] = pos;                                  //colocamos el tamano del vector en la pos 0
            return c;                                    //
        }
        public void Print()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int[] b = { 6, 7, 8, 9, 0 };
            int[] c = Search(a,b);
            Console.Write("-> [");
            for(int x = 1; x < c[0]; x++)                //usamos el valor de la posicion 0 como limite, si no usamos limite se imprime un vector del tamano del primer vector que se envio
                Console.Write("{0},", c[x]);
            Console.Write("]");
        }
    }
}

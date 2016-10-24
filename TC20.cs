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

	Tarea Corta 20
	Estudiante: David Mejia
	
	Enunciado:
	Identificador de numeros primos, escriba una funcion que indique si un numero recibido es primo o no, tome en cuenta que el numero recibido estará en un rago de 
	1 a 5000.
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC20
{
    class TC20
    {
        static void Main(string[] args)
        {
            Prime p = new Prime();
            p.Print();
            Console.ReadKey();
        }
    }
    public class Prime
    {
        public bool IsPrime(int n)
        {
            bool prime = true;
            if (n == 1)
                return false;
            if (n == 2)
                return true;
            for(int x = 2; x < n; x++)
            {
                if (n % x == 0)
                    prime = false;
            }
            return prime;
        }
        public void Print()
        {
            for(int x = 1; x <= 5000; x++)
            {
                if(IsPrime(x))
                    Console.Write("{0}, ",x);
            }
        }
    }
}

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

	Tarea Corta 9
	Estudiante: David Mejia
	
	Enunciado:
	Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
	Ejemplo:
	"the sky is blue" -> "blue is sky the"	
	
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC9
{
    class TC9
    {
        static void Main(string[] args)
        {
            Invert i = new Invert();
            i.Print();
        }
    }
    public class Invert
    {
        public string inversa(string s)
        {                                                    //
            string[] t = s.Split(' ');                       //dividimos el string en palabras
            return string.Join(" ", t.Reverse<string>());    //retornamos el string al revez
        }
        public void Print()
        {
            Console.WriteLine("I am Iron Man <---> " + inversa("I am Iron Man"));
            Console.ReadKey();
        }
    }
}

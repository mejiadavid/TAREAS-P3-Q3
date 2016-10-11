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

	Tarea Corta 4
	Estudiante: David Mejia
	
	Enunciado:
	Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
	La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
	Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC4
{
    class TC4
    {
        static void Main(string[] args)
        {
            Palindromo p = new Palindromo();
            p.Print();
        }
    }
    public class Palindromo
    {
        public bool Identify(string s)
        {
            int x = 0;                       //primera posicion del string
            int y = s.Length - 1;         //ultima posicion del string
            while (x < y)                    //Recorre el string del inicio y del final
            {                                //
                if (s[x] != s[y])      //si las letras no coinciden no es palindromo
                {                            //
                    return false;            //y retornamos false 
                }                            //
                x++;                         //aumentamos la posicion
                y--;                         //disminuimos la posicion
            }                                //
            return true;                     //de ser palindromo retornamos true
        }
        public void Print()
        {
            Console.WriteLine("Es la frase: Amor a Roma, un palindromo? " + Identify("amor a roma"));
            Console.WriteLine("Es la frase: David, un palindromo? " + Identify("David"));
            Console.WriteLine("Es la frase: , un palindromo? " + Identify(" "));
            Console.ReadKey();
        }
    }
}

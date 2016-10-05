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

	Tarea Corta 8
	Estudiante: David Mejia
	
	Enunciado:
	Validez de parentesis:
	Se va a recibir un string S que contienen unicamente los caracteres '(' y ')', ustedes deben escribir una funcion que valida si la secuencia de parentesis es valida,
	esto quiere decir que cada parentesis abierto tenga un parentesis que lo cierre.
	Por ejemplo:
	"()" -> True
	"((" -> False
	"(()(()))" -> True
	"(()(())))" -> False
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC8
{
    class TC8
    {
        static void Main(string[] args)
        {
            P p = new P();
            p.Print();
        }
        
    }
    public class P
    {
        public bool validate(string s)
        {
            List<char> l = s.ToList<char>();                            //convertimos el string en un lista para movernos por la lista
                                                                        //
            while (l.Contains('(') && l.Contains(')') && l[0] != ')')   //la list debe contener ambos caracteres para validarlo y que el primer caracter no sea ")"
            {                                                           //usamos while porque el tamano de la lista puede variar despues de remover elementos y nos generaria errores
                bool b = true;                                          //bandera para salir del while interno
                int pos = 1 + l.LastIndexOf('(');                       //localizamos el ultimo "(" y nos movemos 1 posicion para empezar la busqueda
                                                                        //
                while (b)                                                //sera que se puede caer o enciclar por aca
                {                                                       //hay ambos parentesis asi que no deberia
                    if (l[pos] == ')')                                //
                    {                                                   //
                        l.RemoveAt(pos);                                //quitamos el primer ")" despues del ultimo "("
                        l.RemoveAt(l.LastIndexOf('('));                 //quitamos el ultimo "("
                        b = false;                                      //cambiamos la bandera para salir
                    }                                                   //
                    pos++;                                              //
                }                                                       //cerramos el segundo while
            }                                                           //cerramos el primer while cuando se acaben los parentesis
            if (!l.Contains('(') && !l.Contains(')'))                   //si despues de recorrer la lista quedan elemtos, el string no era valido
                return true;                                            //si no quedan elementos todos los parentesis se cancelaron reciprocamente
            return false;
        }
        public void Print()
        {
            Console.WriteLine(validate("()"));
            Console.WriteLine(validate("))"));
            Console.WriteLine(validate("(()(()))"));
            Console.WriteLine(validate("(()(())))"));
            Console.ReadKey();
        }
    }
}

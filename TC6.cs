﻿/*
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

	Tarea Corta 6
	Estudiante: David Mejia
	
	Enunciado:
	El palindromo mas corto, 
	Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
	"aace" -> aacecaa
	"abcd" -> "abcdcba"
*/

//Your code starts here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC6
{
    class TC6
    {
        static void Main(string[] args)
        {
            Palindromo p = new Palindromo();
            p.Print();
        }                                       //
    }
    public class Palindromo
    {
        public string AddLetters(string s)
        {
            string t = s;                           //creamos un nuevo string para el nuevo palindromo
            for (int x = s.Length - 2; x > -1; x--) //recorro el string original al reves y se lo agrego al nuevo string
            {                                       //nos posicionamos desde la posicion antes de la ultima
                t += s[x];                          //
            }                                       //
            return t;                               //
        }
        public void Print()
        {
            Console.WriteLine("abc, el palindromo seria: " + AddLetters("abc"));
            Console.WriteLine("abce, el palindromo seria: " + AddLetters("abce"));
            Console.ReadKey();
        }
    }
}

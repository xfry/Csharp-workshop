/* Arrays
    Array es un type referenciado en C# lo que significa que al pasarlo como parametro,
    su valor nunca es copiado, pero si apuntado. (Lea punteros en C)
*/

using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //A continuacion se ilustra la definicion de arreglos unidimencionales y bidimencionales.
            int[] array1d = new int[] {1,2,3,22,50,15,33,77,10};
            int[,] array2d = new int[,] {
                {1,2,3},
                {4,5,6}
            };

            PrintArray(array1d);
            Console.WriteLine("\n");
            PrintArray(array2d);

            //Try catch examples
            try
            {
                foreach(int item in array1d)
                    System.Console.WriteLine("result: {0}\n", DivideItem(item));
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("There was an exception dividing by Cero");
                throw;
            }
            finally
            {
                System.Console.WriteLine("te exception was handled and finished");
            }
        }
        
        //Se crea una funcion que recibe un arreglo como parametros
        public static void PrintArray(int[] arr)
        {
            foreach(int item in arr)
                System.Console.WriteLine("Item: {0} ", item);
        }
        
        //Se sobrecarga la funcion con un tipo de dato bidimencional.
        public static void PrintArray(int[,] arr)
        {
            foreach(int item in arr)
                System.Console.WriteLine("Item: {0} ", item);
        }

        public static int DivideItem(int el)
        {   
            int b = 0;
            return el/b;
        }
    }
}

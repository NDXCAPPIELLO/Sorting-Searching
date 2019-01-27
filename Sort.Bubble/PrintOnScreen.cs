using System;
using System.Collections.Generic;
using System.Text;

namespace MainModule
{
    public class PrintOnScreen
    {
        public static void ImprimirVector(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine(" ");
        }

        public static void ImprimirPosicion(int? pos)
        {           
            if (pos != null)
            {
                Console.WriteLine("El numero 5 está en la posición: " + pos);
            }
            else {
                Console.Write("No se ha encontrado el elemento");
            }            
        }

        public static void ImprimirCantidad(int cant)
        {
            Console.WriteLine("El numero 5 aparece " + cant + " veces.");
        }
    }
}

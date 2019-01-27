using System;
using System.Collections.Generic;
using System.Text;

namespace MainModule
{
    public class PrintOnScreen
    {
        public static void Imprimir(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine(" ");
        }
    }
}

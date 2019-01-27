using System;
using Ordenamiento;

namespace MainModule
{
    class Program
    {
        static void Main(string[] args)
        {                        
            int[] lista = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            PrintOnScreen.Imprimir(Burbujeo.OrdernarPorBurbujeo(lista)); //Ordenamiento - Burbujeo
             
            PrintOnScreen.Imprimir(Seleccion.OrdenarPorSeleccionDelMinimo(lista)); //Ordenamiento - Selección (del Minimo)

            Console.ReadKey();
        }
    }
}
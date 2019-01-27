using System;
using Ordenamiento;

namespace MainModule
{
    class Program
    {
        static void Main(string[] args)
        {                        
            int[] lista = { 0, 8, 2, 1, 3, 5, 7, 6, 4, 9 };
            
            PrintOnScreen.Imprimir(Burbujeo.OrdernarPorBurbujeo(lista)); //Ordenamiento - Burbujeo
            
            PrintOnScreen.Imprimir(Seleccion.OrdenarPorSeleccionDelMinimo(lista)); //Ordenamiento - Selección (del Minimo)

            Console.ReadKey();
        }
    }
}
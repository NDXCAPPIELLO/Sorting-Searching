using System;
using Ordenamiento;
using Busqueda;

namespace MainModule
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 9, 2, 1, 7, 4, 8, 0, 3, 5, 6 };

            PrintOnScreen.ImprimirVector(Burbujeo.OrdenarPorBurbujeo(lista)); //Ordenamiento - Burbujeo             
            PrintOnScreen.ImprimirVector(Seleccion.OrdenarPorSeleccionDelMinimo(Auxiliar.pasarCopiaDeVector(lista))); //Ordenamiento - Selección (del Minimo)

            PrintOnScreen.ImprimirCantidad(Lineal.ContarLinealmente(lista, 50)); // Búsqueda - Conteo
            PrintOnScreen.ImprimirPosicion(Lineal.BuscarLinealmenteElPrimero(lista, 50)); //Búsqueda - Primero                       

            Console.ReadKey();
        }
    }
}   
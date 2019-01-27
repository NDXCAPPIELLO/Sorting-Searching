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

            PrintOnScreen.Imprimir(Burbujeo.OrdernarPorBurbujeo(Auxiliar.pasarCopiaDeVector(lista))); //Ordenamiento - Burbujeo             
            PrintOnScreen.Imprimir(Seleccion.OrdenarPorSeleccionDelMinimo(Auxiliar.pasarCopiaDeVector(lista))); //Ordenamiento - Selección (del Minimo)

            Console.WriteLine("El numero 5 aparece " + Lineal.ContarLinealmente(lista, 5) + " veces."); // Búsqueda - Conteo
            Console.WriteLine("El numero 5 está en la posición: " + Lineal.BuscarLinealmenteElPrimero(lista, 5)); //Búsqueda - Primero                       

            Console.ReadKey();
        }
    }
}   
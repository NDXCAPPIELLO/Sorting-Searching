using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento
{
    public class Seleccion
    {
        public static int[] OrdenarPorSeleccionDelMinimo(int [] lista)
        {
            int cont = 0;
            for (int i = 0; i < lista.Length - 1; i++)
            {
                int min = i;
                cont += 1;
                for (int j = i + 1; j < lista.Length; j++)
                {
                    cont += 1;
                    if (lista[j] < lista[min])
                    {
                        min = j;
                    }
                }
                int aux = lista[min];
                lista[min] = lista[i];
                lista[i] = aux;
            }
            Console.WriteLine("Selección - Iteraciones: " + cont);
            return lista;
        }
    }
}

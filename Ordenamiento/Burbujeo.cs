using System;

namespace Ordenamiento
{
    public class Burbujeo
    {
        public static int[] OrdernarPorBurbujeo(int[] lista)
        {     
            int cont = 0;
            for (int i = 0; i < lista.Length; i++) //Son n-1 pasadas. 0,1,2,3,4
            {
                for (int j = 0; j < lista.Length - 1; j++) //Hasta el anteultimo (lista-1)
                {
                    cont += 1;
                    if (lista[j] > lista[j + 1])
                    {
                        int aux;
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;                        
                    }
                }
                cont += 1;
            }
            Console.WriteLine("Burbujeo - Iteraciones: " + cont);
            return lista;
        }
    }
}

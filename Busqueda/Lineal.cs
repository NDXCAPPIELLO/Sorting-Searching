using System;

namespace Busqueda
{
    public class Lineal
    {
        public static int? BuscarLinealmenteElPrimero(int[] lista, int valor)
        {
            int? pos = null;
            for (int i = 0; i < lista.Length; i++)
            {
                if(lista[i] == valor)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public static int ContarLinealmente(int [] lista, int valor)
        {
            int cant = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                if(lista[i] == valor)
                {
                    cant += 1;
                }                    
            }
            return cant;
        }
    }
}

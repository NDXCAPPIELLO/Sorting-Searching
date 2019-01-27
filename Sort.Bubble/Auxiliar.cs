using System;
using System.Collections.Generic;
using System.Text;

namespace MainModule
{
    public class Auxiliar
    {
        public static int[] pasarCopiaDeVector(int[] vector)
        {
            int[] newList = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                newList.SetValue(vector[i], i);
            }
            return newList;
        }
    }
}

using System;
using System.Collections.Generic;

namespace app2
{
    class Program
    {
        static void Main (string[] args)
        {
            int[, ] matrix = new int[2, 2] { { 2, 8 }, { 7, 9 } };
            Procurar (((n) => n % 2 == 0), matrix);
        }
        static void Procurar<T> (Func<T, bool> Teste, T[] array)
        {
            foreach (var item in array)
            {
                if (Teste (item)) Console.WriteLine (item);
            }
        }
        static void Procurar<T> (Func<T, bool> Teste, T[, ] matrix)
        {
            foreach (var item in matrix)
            {
                if (Teste (item)) Console.WriteLine (item);
            }
        }

    }
}
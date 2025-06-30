//3.-Escribir un programa que almacene los vectores (1,2,3) y (-1,0,2) en dos listas y muestre por pantalla su producto escalar.
using System;

public class Ejercicio3
{
    public static void Ejecutar()
    {
        int[] vector1 = { 1, 2, 3 };
        int[] vector2 = { -1, 0, 2 };

        int productoEscalar = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            productoEscalar += vector1[i] * vector2[i];
        }

        Console.WriteLine("Ejercicio 3:");
        Console.WriteLine("Producto escalar de (1,2,3) y (-1,0,2): " + productoEscalar);
    }
}

//2.-Escribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.
using System;
using System.Collections.Generic;

public class Ejercicio2
{
    public static void Ejecutar()
    {
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
            numeros.Add(i);

        numeros.Reverse();

        Console.WriteLine("Números del 10 al 1:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}

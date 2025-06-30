//4.-Escribir un programa que pida al usuario una palabra y muestre por pantalla si es un palíndromo.
using System;

public class Ejercicio4
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio 4:");
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        string palabraInvertida = "";

        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida += palabra[i];
        }

        if (palabra.ToLower() == palabraInvertida.ToLower())
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra NO es un palíndromo.");
        }
    }
}

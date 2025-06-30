//5.-Escribir un programa que pida al usuario una palabra y muestre por pantalla el número de veces que contiene cada vocal.
using System;

public class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ejercicio 5:");
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int contadorA = 0;
        int contadorE = 0;
        int contadorI = 0;
        int contadorO = 0;
        int contadorU = 0;

        foreach (char letra in palabra)
        {
            switch (letra)
            {
                case 'a':
                    contadorA++;
                    break;
                case 'e':
                    contadorE++;
                    break;
                case 'i':
                    contadorI++;
                    break;
                case 'o':
                    contadorO++;
                    break;
                case 'u':
                    contadorU++;
                    break;
            }
        }

        Console.WriteLine($"Cantidad de vocales en '{palabra}':");
        Console.WriteLine($"a: {contadorA}");
        Console.WriteLine($"e: {contadorE}");
        Console.WriteLine($"i: {contadorI}");
        Console.WriteLine($"o: {contadorO}");
        Console.WriteLine($"u: {contadorU}");
    }
}

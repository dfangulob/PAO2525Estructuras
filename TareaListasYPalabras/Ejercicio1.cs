using System;
using System.Collections.Generic;

public class Ejercicio1
{
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Console.WriteLine("Asignaturas del curso:");
        foreach (var materia in asignaturas)
        {
            Console.WriteLine("- " + materia);
        }
    }
}

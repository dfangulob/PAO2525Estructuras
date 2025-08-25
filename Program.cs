using System;
using System.Collections.Generic;

class Vacunacion
{
    static void Main()
    {
        // Crear 500 ciudadanos ficticios
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // Crear 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 5; i < 80; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // Crear 75 vacunados con AstraZeneca
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++)
        {
            astrazeneca.Add("Ciudadano " + i);
        }

        // Ciudadanos que no se han vacunado
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(pfizer);
        noVacunados.ExceptWith(astrazeneca);

        // Ciudadanos que recibieron ambas dosis
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        // Ciudadanos solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        // Ciudadanos solo AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer);

        // Mostrar resultados
        Console.WriteLine("Total ciudadanos: " + ciudadanos.Count);
        Console.WriteLine("Vacunados solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Vacunados solo AstraZeneca: " + soloAstra.Count);
        Console.WriteLine("Vacunados ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);

        // Lista opcional de ejemplo
        Console.WriteLine("\n--- Ciudadanos solo Pfizer ---");
        foreach (var c in soloPfizer)
        {
            Console.WriteLine(c);
        }
    }
}

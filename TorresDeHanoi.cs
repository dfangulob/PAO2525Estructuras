using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(Console.ReadLine());

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Llenamos la torre de origen
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        // Iniciamos el movimiento
        MoverDiscos(n, origen, destino, auxiliar, "A", "C", "B");

        Console.WriteLine("Movimiento completado.");
    }

    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco {origen.Peek()} de {nombreOrigen} a {nombreDestino}");
            destino.Push(origen.Pop());
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
            Console.WriteLine($"Mover disco {origen.Peek()} de {nombreOrigen} a {nombreDestino}");
            destino.Push(origen.Pop());
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }
}

using System;

class Estudiante
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos;

    public void MostrarInformacion()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("- " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        estudiante.Id = 1;
        estudiante.Nombres = "Juan";
        estudiante.Apellidos = "Pérez";
        estudiante.Direccion = "Calle 123";
        estudiante.Telefonos = new string[3] { "0987654321", "0991234567", "0961122334" };

        estudiante.MostrarInformacion();
    }
}

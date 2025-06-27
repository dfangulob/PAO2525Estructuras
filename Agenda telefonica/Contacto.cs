public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public Contacto(string nombre, string telefono, string correo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre}, Teléfono: {Telefono}, Correo: {Correo}");
    }
}

using System;
using System.Collections.Generic;

public class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto(Contacto c)
    {
        contactos.Add(c);
    }

    public void MostrarContactos()
    {
        foreach (var c in contactos)
        {
            c.Mostrar();
        }
    }

    public void BuscarPorNombre(string nombre)
    {
        var resultado = contactos.Find(c => c.Nombre.ToLower() == nombre.ToLower());
        if (resultado != null)
            resultado.Mostrar();
        else
            Console.WriteLine("Contacto no encontrado.");
    }
}

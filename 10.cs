

using System;
using System.Collections;
using System.Collections.Generic;

public class Empleado
{
    public int Edad { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NumeroTelefonico { get; set; }
    public string CorreoElectronico { get; set; }
}

public class BaseDeEmpleados
{
    private List Empleado;
    private List<object> empleados;

    public BaseDeEmpleados()
    {
        empleados = new List Empleado();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        empleados.Add(empleado);
    }

    public void EliminarEmpleado(string nombre, string apellido)
    {
        Empleado empleado = empleados.Find(e => e.Nombre == nombre && e.Apellido == apellido);
        if (empleado != null)
        {
            empleados.Remove(empleado);
        }
    }

    public void MostrarInformacionEmpleado(string nombre, string apellido)
    {
        Empleado empleado = empleados.Find(e => e.Nombre == nombre && e.Apellido == apellido);
        if (empleado != null)
        {
            Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine($"Edad: {empleado.Edad}");
            Console.WriteLine($"Número telefónico: {empleado.NumeroTelefonico}");
            Console.WriteLine($"Correo electrónico: {empleado.CorreoElectronico}");
        }
    }
}
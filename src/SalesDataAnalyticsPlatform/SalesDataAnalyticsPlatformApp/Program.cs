using System;
using SalesDataAnalyticsPlatformApp.Models;

class Program
{
    static void Main()
    {
        // Crear instancias de las clases y probar sus métodos
        MiembroDeLaComunidad miembro = new MiembroDeLaComunidad("Juan Pérez", 30);
        Estudiante estudiante = new Estudiante("Ryan Ortiz", 18, "Desarrollo de Software");
        Exalumno exalumno = new Exalumno("Carlos Sánchez", 25, 2022);
        Docente docente = new Docente("Starling Germosén", 37, "Programación");
        Maestro maestro = new Maestro("Pedro Gómez", 45, "Ciencias", "Física");
        Administrador administrador = new Administrador("Laura Fernández", 50, "Administración");
        Administrativo administrativo = new Administrativo("Roberto Díaz", 35, "Recursos Humanos");

        miembro.MostrarInformacion();
        estudiante.MostrarInformacion();
        exalumno.MostrarInformacion();
        docente.MostrarInformacion();
        maestro.MostrarInformacion();
        administrador.MostrarInformacion();
        administrativo.MostrarInformacion();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera)
            : base(nombre, edad)
        {
            Carrera = carrera;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Estudiante - Nombre: {Nombre}, Edad: {Edad}, Carrera: {Carrera}");
        }
    }
}

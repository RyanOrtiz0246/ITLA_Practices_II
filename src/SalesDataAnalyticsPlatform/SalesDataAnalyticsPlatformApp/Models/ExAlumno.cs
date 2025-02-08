using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Exalumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public Exalumno(string nombre, int edad, int añoGraduacion)
            : base(nombre, edad)
        {
            AñoGraduacion = añoGraduacion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Exalumno - Nombre: {Nombre}, Edad: {Edad}, Año de Graduación: {AñoGraduacion}");
        }
    }
}

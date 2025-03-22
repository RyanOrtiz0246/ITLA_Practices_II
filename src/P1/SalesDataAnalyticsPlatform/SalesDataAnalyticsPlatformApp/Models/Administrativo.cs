using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Administrativo : Empleado
    {
        public string Seccion { get; set; }

        public Administrativo(string nombre, int edad, string seccion)
            : base(nombre, edad, "Administrativo")
        {
            Seccion = seccion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Administrativo - Nombre: {Nombre}, Edad: {Edad}, Sección: {Seccion}");
        }
    }
}

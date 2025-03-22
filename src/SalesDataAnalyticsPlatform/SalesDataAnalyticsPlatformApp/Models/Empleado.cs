using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Cargo { get; set; }

        public Empleado(string nombre, int edad, string cargo)
            : base(nombre, edad)
        {
            Cargo = cargo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Cargo: {Cargo}");
        }
    }
}

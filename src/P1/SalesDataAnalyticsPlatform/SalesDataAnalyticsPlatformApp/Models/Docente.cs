using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Docente : Empleado
    {
        public string Departamento { get; set; }

        public Docente(string nombre, int edad, string departamento)
            : base(nombre, edad, "Docente")
        {
            Departamento = departamento;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Cargo: {Cargo}, Departamento: {Departamento}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Maestro : Docente
    {
        public string Asignatura { get; set; }

        public Maestro(string nombre, int edad, string departamento, string asignatura)
            : base(nombre, edad, departamento)
        {
            Asignatura = asignatura;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Maestro - Nombre: {Nombre}, Edad: {Edad}, Departamento: {Departamento}, Asignatura: {Asignatura}");
        }
    }
}

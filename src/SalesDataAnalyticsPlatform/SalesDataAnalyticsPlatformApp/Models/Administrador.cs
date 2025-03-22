using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataAnalyticsPlatformApp.Models
{
    public class Administrador : Docente
    {
        public Administrador(string nombre, int edad, string departamento)
            : base(nombre, edad, departamento)
        {
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Administrador - Nombre: {Nombre}, Edad: {Edad}, Departamento: {Departamento}");
        }
    }
}

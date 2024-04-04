using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_I
{
    internal class Alumno
    {
        int dpi;
        string nombre;
        int direccion;

        public int Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Direccion { get => direccion; set => direccion = value; }
    }
}

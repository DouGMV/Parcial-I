using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_I
{
    internal class Inscripcion
    {
        int dpi;
        int codigo;
        DateTime fecha;

        public int Dpi { get => dpi; set => dpi = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}

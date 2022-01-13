using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Logica
{
    internal class Lasistencias
    {
        public int id_asistencia { get; set; }
        public int id_personal{ get; set; }
        public DateTime Fecha_entrada { get; set; }
        public DateTime Fecha_salida { get; set; }
        public string Estado { get; set; }
        public double Horas { get; set; }
        public string Observacion { get; set; }

    }
}

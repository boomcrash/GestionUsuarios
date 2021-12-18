using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Logica
{
    internal class Lcargos
    {
        //   [id_cargo] [int] IDENTITY(1,1) NOT NULL,
        //   [Cargo] [varchar] (50) NULL,
        //[SueldoPorHora] [numeric] (18, 2) NULL,
        public int id_cargo { get; set; }
        public string Cargo { get; set; }
        public double SueldoPorHora { get; set; }
    }
}

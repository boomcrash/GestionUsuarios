using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Logica
{
    public class Lpersonal
    {
		//[id_personal] [int] IDENTITY(1,1) NOT NULL,
		//[Nombres] [varchar] (50) NULL,
		//[Identificacion] [varchar] (50) NULL,
		//[Pais] [varchar] (50) NULL,
		//[id_cargo] [int] NULL,
		//[SueldoPorHora] [numeric] (18, 2) NULL,
		//[Estado] [varchar] (50) NULL,
		//[Codigo] [varchar] (50) NULL,

		public int id_personal { get; set; }
		public string Nombres { get; set; }
		public int Identificacion { get; set; }
		public string Pais { get; set; }
		public int id_cargo { get; set; }
		public double SueldoPorHora { get; set; }
		public string Estado { get; set; }
		public string Codigo { get; set; }

	}
}

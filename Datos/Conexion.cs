﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionUsuarios.Datos
{
    public class Conexion
    {
        public static string conexion = @"Data source=DESKTOP-JMRQRK8\SQLEXPRESS; Initial Catalog=Innovation; Integrated Security=true";
        public static SqlConnection conectar=new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }

    }
}

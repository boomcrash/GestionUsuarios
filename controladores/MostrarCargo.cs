using GestionUsuarios.Datos;
using GestionUsuarios.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios.controladores
{
    public partial class MostrarCargo : UserControl
    {
        public MostrarCargo()
        {
            InitializeComponent();
            Buscar();
        }

        private void cargo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Buscar()
        {
            DataTable tabla =new DataTable();
            Dcargos funcion=new Dcargos();
            funcion.BuscarCargos(ref tabla, cargo2.Text);
            tbcargo.DataSource = tabla;
            Base.DiseñoDtv(ref tbcargo);
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
           
        }

        private void cargo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar();
        }
    }
}

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
    public partial class EditarCargo : UserControl
    {
        public EditarCargo()
        {
            InitializeComponent();
            Buscar();
        }

        int Cid;

        private void Buscar()
        {
            DataTable tabla = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.BuscarCargos(ref tabla, cargo2.Text);
            tbcargo.DataSource = tabla;
            Base.DiseñoDtv(ref tbcargo);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar();
        }

        private void ObtenerCargo()
        {
            Cid = Convert.ToInt32(tbcargo.SelectedCells[1].Value);
            Cnombre.Text = tbcargo.SelectedCells[2].Value.ToString();
            Csueldo.Text = tbcargo.SelectedCells[3].Value.ToString();
            Cnombre.Focus();
            Cnombre.SelectAll();
        }


        private void Editar()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.id_cargo = Cid;
            parametros.Cargo = Cnombre.Text;
            parametros.SueldoPorHora = Convert.ToDouble(Csueldo.Text);
            if (funcion.EditarCargo(parametros) == true)
            {
                Cid = 0;
                Cnombre.Clear();
                Csueldo.Clear();
                MessageBox.Show("EDICION EXITOSA");
            }
            else
            {
                MessageBox.Show("ERROR DE EDICION");
            }
        }

        private void tbcargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerCargo();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            Editar();
            Buscar();
        }

        private void Csueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Base.Decimales(Csueldo, e);
        }
    }
}

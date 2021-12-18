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
    public partial class InsertarCargo : UserControl
    {
        public InsertarCargo()
        {
            InitializeComponent();
        }
        private void Insertar()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Cargo = cargo1.Text;
            parametros.SueldoPorHora = Convert.ToDouble(sueldo.Text);
            if (funcion.InsertarCargo(parametros) == true)
            {
                cargo1.Clear();
                sueldo.Clear();
                MessageBox.Show("REGISTRO EXITOSO");
            }
            else
            {
                MessageBox.Show("ERROR DE REGISTRO");
            }
        }

        private void cargo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Base.Decimales(sueldo, e);
        }
    }
    
}

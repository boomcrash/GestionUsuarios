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
    public partial class EliminarPersonal : UserControl
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );
        int contador, idP=0;
        public EliminarPersonal()
        {
            InitializeComponent();
            contar();
            BuscarPersonal(1, 10);
        }

        private void contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.contarPersonal(ref contador);
        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuscarPersonal(int desde, int hasta)
        {
            DataTable tabla = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonal(ref tabla, desde, hasta, personal.Text);
            tbPersonal.DataSource = tabla;
            Base.DiseñoDtv(ref tbPersonal);
        }

        private void personal_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscarPersonal(1, contador);
        }

        private void ObtenerCargo()
        {
            idP = Convert.ToInt32(tbPersonal.SelectedCells[1].Value);
        }

        private void tbPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerCargo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
        panel1.Height, 50, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();
            BuscarPersonal(1, contador);
        }

        private void personal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.id_personal = idP;
            if (idP!=0)
            {
                    if (funcion.EliminarPersonal(parametros) == true)
                    {
                        idP = 0;
                        MessageBox.Show("ELIMINACION EXITOSA");
                    }
                    else
                    {
                        MessageBox.Show("ERROR DE ELIMINACION");
                    }
            }
            else
            {
                MessageBox.Show("SELECCIONE EL PERSONAL A ELIMINAR");
            }
        }
    }
}

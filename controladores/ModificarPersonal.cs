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
    public partial class ModificarPersonal : UserControl
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
        int contador;
        public ModificarPersonal()
        {

            InitializeComponent();
            contar();
            BuscarCargo();
            Mostrar(1, 10);
            idPersonal.Enabled = false;
            Cnombre.Enabled = false;
            Csueldo.Enabled = false;
        }
        
        private void contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.contarPersonal(ref contador);
        }

        int Cid,Pid;


        private void BuscarCargo()
        {
            DataTable tabla = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.BuscarCargos(ref tabla, cargo2.Text);
            tbcargo.DataSource = tabla;
            Base.DiseñoDtv(ref tbcargo);
        }

        private void ObtenerCargo()
        {
            Cid = Convert.ToInt32(tbcargo.SelectedCells[1].Value);
            Cnombre.Text = tbcargo.SelectedCells[2].Value.ToString();
            Csueldo.Text = tbcargo.SelectedCells[3].Value.ToString();
        }



        private void Mostrar(int desde, int hasta)
        {
            DataTable tabla = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.MostrarPersonal(ref tabla, desde, hasta);
            tbPersonal.DataSource = tabla;
            Base.DiseñoDtv(ref tbPersonal);
        }

        private void BuscarPersonal(int desde,int hasta)
        {
            DataTable tabla = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonal(ref tabla, desde, hasta, personal.Text);
            tbPersonal.DataSource = tabla;
            Base.DiseñoDtv(ref tbPersonal);
        }

        private void ObtenerPersonal()
        {
            idPersonal.Text = tbPersonal.SelectedCells[1].Value.ToString();
            nombre.Text = tbPersonal.SelectedCells[2].Value.ToString();
            pais.Text = tbPersonal.SelectedCells[3].Value.ToString();
            cedula.Text = tbPersonal.SelectedCells[4].Value.ToString();
            Csueldo.Text = tbPersonal.SelectedCells[5].Value.ToString();
            Cnombre.Text = tbPersonal.SelectedCells[6].Value.ToString();
            Cid =Convert.ToInt32(tbPersonal.SelectedCells[7].Value.ToString());

            nombre.Focus();
            Cnombre.SelectAll();
        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
          panel1.Height, 50, 50));
        }

        private void tbPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerPersonal();
        }

        private void tbcargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbcargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerCargo();
        }

        private void personal_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscarPersonal(1, contador);
        }

        private void cargo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuscarCargo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editar();
            Mostrar(1, contador);
        }

        private void Editar()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombres = nombre.Text;
            parametros.Identificacion = cedula.Text;
            parametros.Pais = pais.Text;
            parametros.id_cargo = Cid;
            parametros.SueldoPorHora = Convert.ToDouble(Csueldo.Text);
            parametros.id_personal = Convert.ToInt32(idPersonal.Text);
            if (nombre.Text != null && cedula.Text != null && pais.Text != null && idPersonal.Text!=null)
            {
                if (Cnombre.Text != null && Csueldo.Text != null)
                {
                    if (funcion.EditarPersonal(parametros) == true)
                    {
                        Cid = 0;
                        Cnombre.Clear();
                        Csueldo.Clear();
                        nombre.Clear();
                        idPersonal.Clear();
                        cedula.Clear();
                        MessageBox.Show("EDICION EXITOSO");
                    }
                    else
                    {
                        MessageBox.Show("ERROR DE EDICION");
                    }
                    
                }
                else
                {
                    MessageBox.Show("ELIJA UN CARGO DE A TABLA PARA PODER EDITAR PERSONAL");
                }
            }


        }
    }
}

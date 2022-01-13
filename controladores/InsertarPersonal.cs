using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GestionUsuarios.Logica;
using GestionUsuarios.Datos;

namespace GestionUsuarios.controladores
{
    public partial class InsertarPersonal : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );


        public InsertarPersonal()
        {
            InitializeComponent();
            Buscar();
            Cnombre.Enabled = false;
            Csueldo.Enabled = false;
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


        private void ObtenerCargo()
        {
            Cid = Convert.ToInt32(tbcargo.SelectedCells[1].Value);
            Cnombre.Text = tbcargo.SelectedCells[2].Value.ToString();
            Csueldo.Text = tbcargo.SelectedCells[3].Value.ToString();
            Cnombre.Focus();
            Cnombre.SelectAll();
        }



        private void InsertarPersonal_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 50, 50));
        }

        private void panelRegistros_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Insertar()
        {
            Lpersonal parametros=new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombres = nombre.Text;
            parametros.Identificacion = cedula.Text;
            parametros.Pais = pais.Text;
            parametros.id_cargo = Cid;
            parametros.SueldoPorHora = Convert.ToDouble(Csueldo.Text);
            if(nombre.Text!=null&&cedula.Text != null&& pais.Text != null)
            {
                if (Cnombre.Text != null && Csueldo.Text != null)
                {
                    if (funcion.InsertarPersonal(parametros) == true)
                    {
                        Cid = 0;
                        Cnombre.Clear();
                        Csueldo.Clear();
                        MessageBox.Show("REGISTRO EXITOSO");
                    }
                    else
                    {
                        MessageBox.Show("ERROR DE REGISTRO");
                    }
                }
                else
                {
                    MessageBox.Show("ELIJA UN CARGO DE A TABLA PARA PODER REGISTRAR PERSONAL");
                }
            }
            
            
        }

        private void sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Base.Decimales(Csueldo, e);
        }

        private void tbcargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerCargo();
        }

        private void tbcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Insertar();
        }
    }
}

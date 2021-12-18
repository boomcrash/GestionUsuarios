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
        }

        private void sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Base.Decimales(sueldo, e);
        }
    }
}

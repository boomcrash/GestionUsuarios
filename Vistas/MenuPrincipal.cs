using GestionUsuarios.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios.Vistas
{
    public partial class MenuPrincipal : Form
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



        public MenuPrincipal()
        {
            InitializeComponent();
         
            Submenu(submenu);
            submenu2.Visible = false;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Submenu(Panel Submenu)
        {
            submenu.Visible = false;

        }

        private void ocultarSubmenu(Panel subemnu)
        {
            if (submenu.Visible == true)
            {
                submenu.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }


                private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelPrincipal.Dock = DockStyle.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Inicio control=new Inicio();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(submenu);

        }

        private void mostrar_Click(object sender, EventArgs e)
        {

            ocultarSubmenu(submenu);
            Personal control = new Personal();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();

        }

        private void insertar_Click(object sender, EventArgs e)
        {

            ocultarSubmenu(submenu);
            InsertarPersonal control = new InsertarPersonal();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenu);
            ModificarPersonal control = new ModificarPersonal();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
            ocultarSubmenu(submenu);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenu);
            EliminarPersonal control = new EliminarPersonal();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
            ocultarSubmenu(submenu);
        }

        public void panel_Principal_Paint(object sender, PaintEventArgs e)
        {
            panel_Principal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_Principal.Width,
            panel_Principal.Height, 50, 50));

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            submenu2.Visible = false;
            mostrarSubmenu(submenu);
           
        }

        private void encabezado_Paint(object sender, PaintEventArgs e)
        {
            encabezado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, encabezado.Width,
           encabezado.Height, 50, 50));
        }

        private void transparent_Paint(object sender, PaintEventArgs e)
        {
            transparent.BackColor=Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            transparent.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            abajo.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
   

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {
            arriba.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            ocultarSubmenu(submenu);
            mostrarSubmenu(submenu2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenu2);
            MostrarCargo control = new MostrarCargo();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenu2);
            InsertarCargo control = new InsertarCargo();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocultarSubmenu(submenu2);
            EditarCargo control = new EditarCargo();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Asistencias control = new Asistencias();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            panelPrincipal.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

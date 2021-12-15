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
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }


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
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void primer_Paint(object sender, PaintEventArgs e)
        {
            primer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, primer.Width,
            primer.Height, 50, 50));
        }

        private void segundo_Paint(object sender, PaintEventArgs e)
        {
            segundo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, segundo.Width,
            segundo.Height, 50, 50));
        }

        private void tercero_Paint(object sender, PaintEventArgs e)
        {
  
        }

        private void cuarto_Paint(object sender, PaintEventArgs e)
        {
            cuarto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cuarto.Width,
        cuarto.Height, 50, 50));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void quinto_Paint(object sender, PaintEventArgs e)
        {
            quinto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, quinto.Width,
       quinto.Height, 30, 30));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

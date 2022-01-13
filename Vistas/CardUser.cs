using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios.Vistas
{
    public partial class CardUser : Form
    {
        int valor = 0;


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

        public CardUser()
        {
            InitializeComponent();
        }
       

        private void transparent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void primero_Paint(object sender, PaintEventArgs e)
        {
            primero.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void segundo_Paint(object sender, PaintEventArgs e)
        {

            segundo.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void fondo_Paint(object sender, PaintEventArgs e)
        {
            fondo.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void empleado_Paint(object sender, PaintEventArgs e)
        {
            empleado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, empleado.Width,
            empleado.Height, 50, 50));
        }

        private void administrador_Paint(object sender, PaintEventArgs e)
        {
            administrador.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, administrador.Width,
           administrador.Height, 50, 50));
        }

        private void cliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empleado_MouseClick(object sender, MouseEventArgs e)
        {
  
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
        panel2.Height, 50, 50));
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            Point location = new Point(200, 20);
            menu.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            menu.Location = location;
            menu.ShowDialog();
            this.Close();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            Point location = new Point(200, 20);
            menu.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            menu.Location = location;
            menu.ShowDialog();
            this.Close();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            Point location = new Point(200, 20);
            menu.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            menu.Location = location;
            menu.ShowDialog();
            this.Close();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_MouseClick(object sender, MouseEventArgs e)
        {

            if (valor == 0)
            {
                panel2.BackColor = ColorTranslator.FromHtml("#DC5356");
                empleado.BackColor = ColorTranslator.FromHtml("#DC5356");
                administrador.BackColor = ColorTranslator.FromHtml("#DC5356");
                Pregistro.ForeColor = ColorTranslator.FromHtml("#DC5356");
                Pregistro.IdleLineColor = ColorTranslator.FromHtml("#DC5356");
                Cregistro.ForeColor = ColorTranslator.FromHtml("#DC5356");
                Cregistro.IdleLineColor = ColorTranslator.FromHtml("#DC5356");
                btnempleado.IdleLineColor = ColorTranslator.FromHtml("#DC5356");
                btnclient.IdleLineColor = ColorTranslator.FromHtml("#DC5356");
                Pregistro.IdleFillColor = ColorTranslator.FromHtml("#DC5356");
                Cregistro.IdleFillColor = ColorTranslator.FromHtml("#DC5356");
                valor++;
            }else if (valor!=0)
            {
                panel2.BackColor = ColorTranslator.FromHtml("#1A2125");
                empleado.BackColor = ColorTranslator.FromHtml("#1A2125");
                administrador.BackColor = ColorTranslator.FromHtml("#1A2125");
                btnempleado.IdleLineColor= ColorTranslator.FromHtml("#1A2125");
                btnclient.IdleLineColor = ColorTranslator.FromHtml("#1A2125");
                Pregistro.ForeColor = ColorTranslator.FromHtml("#1A2125");
                Pregistro.IdleLineColor = ColorTranslator.FromHtml("#1A2125");
                Cregistro.ForeColor = ColorTranslator.FromHtml("#1A2125");
                Cregistro.IdleLineColor = ColorTranslator.FromHtml("#1A2125");
                Pregistro.IdleFillColor = ColorTranslator.FromHtml("#1A2125");
                Cregistro.IdleFillColor = ColorTranslator.FromHtml("#1A2125");
                valor = 0;
            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

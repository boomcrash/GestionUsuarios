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
    public partial class Asistencias : UserControl
    {
        public Asistencias()
        {
            InitializeComponent();
            observaciones.Visible = false;
            lblobservacion.Visible = false;
            button1.Visible = false;
        }
        int  idpersonal, contador;
        string identificador;
        DateTime registro, salida;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha.Text = DateTime.Now.ToString();
        }

        private void cedula_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdentidad();
            if (identificador == cedula.Text)
            {
                BuscarAsistenciasId();
                if(contador == 0)
                {
                    DialogResult dialogo = MessageBox.Show("¿Agregar observacion?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogo == DialogResult.OK)
                    {
                        observaciones.Visible = true;
                        observaciones.Clear();
                        lblobservacion.Visible = true;
                        observaciones.Clear();
                        observaciones.Focus();
                        button1.Visible = true;

                    }
                    else
                    {
                        InsertarAsistencias();
                        button1.Visible = false;
                    }
                }else
                {
                    button1.Visible = false;
                    InsertarSalida();
                }
                
            }
        }
        private void InsertarAsistencias()
        {
            if (string.IsNullOrEmpty(observaciones.Text))
            {
                observaciones.Text = "-";
            }
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.id_personal = idpersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = observaciones.Text;
            if (funcion.InsertarAsistencias(parametros))
            {
                aviso.Text = "ENTRADA REGISTRADA";
                cedula.Clear();
                cedula.Focus();
                observaciones.Visible = false;
            }
        }

        private void InsertarSalida()
        {
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.id_personal = idpersonal;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Horas = Base.DateDiff(Base.DateInterval.Hour,registro,DateTime.Now);
            if (funcion.ConfirmarSalida(parametros)==true)
            {
                aviso.Text = "SALIDA REGISTRADA";
                cedula.Clear();
                cedula.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
            button1.Visible = false;
        }

        private void BuscarPersonalIdentidad()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonalIdentificacion(ref dt, cedula.Text);
            if (dt.Rows.Count > 0)
            {
                identificador = dt.Rows[0]["Identificacion"].ToString();
                idpersonal = Convert.ToInt32(dt.Rows[0]["id_personal"].ToString());
                nombre.Text = dt.Rows[0]["Nombres"].ToString();
            }
            Console.WriteLine(idpersonal);
        }

        private void BuscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.BuscarAsistenciaId(ref dt, idpersonal);
            //MessageBox.Show(idpersonal+"detecta id");
            contador = dt.Rows.Count;
            //MessageBox.Show(contador+"contador");
            if (contador > 0)
            {
                registro = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
                //MessageBox.Show(idpersonal+"final");
            }
        }
    }
}

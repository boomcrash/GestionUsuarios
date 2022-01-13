using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionUsuarios.Logica;
using GestionUsuarios.Datos;

namespace GestionUsuarios.controladores
{
    public partial class Personal : UserControl
    {
        int desde = 1, hasta = 10, contador, idCargo, idPersonal, totalPaginas;
        private int item_por_pagina = 10;
        string estado;
        public Personal()
        {
            InitializeComponent();
            Mostrar(desde, hasta);
        }
       
        private void Mostrar(int desde, int hasta)
        {
            DataTable tabla = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.MostrarPersonal(ref tabla,desde,hasta);
            tbpersonal.DataSource = tabla;
            Base.DiseñoDtv(ref tbpersonal);
        }
        private void Buscar()
        {
            DataTable tabla = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonal(ref tabla, desde, hasta, busca.Text);
            tbpersonal.DataSource = tabla;
            Base.DiseñoDtv(ref tbpersonal);
   
        }

        


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void busca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            desde += item_por_pagina;
            hasta += item_por_pagina;
            Mostrar(desde,hasta);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (desde >= 1)
            {
                
                desde -= item_por_pagina;
                hasta -= item_por_pagina;
                Mostrar(desde, hasta);
            }
            else
            {
                desde = 1;
                hasta = 10;
                Mostrar(desde, hasta);
                MessageBox.Show("Esta es la pagina limite!");
            }
          
        }
        private void contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.contarPersonal(ref contador);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            desde = 1;
            hasta = 10;
            Mostrar(desde, hasta);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            contar();
            desde = contador-item_por_pagina;
            hasta = contador;
            Mostrar(desde, hasta);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbpersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

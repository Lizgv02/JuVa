using JuVa.Models;
using JuVa.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuVa.Views.Compras.Proveedor
{
    public partial class Negociacion : Form
    {
        private UsuariosModel modelo;
        public Negociacion(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            groupBox2.Visible = false;
            Querys.llenarComboFiltros(comboBox1, 31, modelo.Usuario);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Querys.modGuia(comboBox1.SelectedValue.ToString(), textBox1.Text, modelo.Usuario);
            MessageBox.Show("Guia agregada correctamente");
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Querys.llenarDatagrid(dataGridView1, 25,"matenme", modelo.Usuario);
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}

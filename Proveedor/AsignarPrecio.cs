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
    public partial class AsignarPrecio : Form
    {
        private UsuariosModel modelo;
        public AsignarPrecio(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            Querys.llenarDatagrid(dataGridView1, 26, "Aceptada", modelo.Usuario);
            Querys.llenarComboFiltros(comboBox1, 28, modelo.Usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el precio de la solicitud....");
                textBox1.Focus();
            }
            else
            {
                try
                {
                    Querys.modPrecio(comboBox1.SelectedValue.ToString(), textBox1.Text, modelo.Usuario);
                    MessageBox.Show("El precio a la solicitud: " + comboBox1.SelectedValue.ToString() + " ha sido asignado de forma correcta");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

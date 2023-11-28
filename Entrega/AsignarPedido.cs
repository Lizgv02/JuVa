using JuVa.Models;
using JuVa.Utilerias;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuVa.Views.Entrega
{
    public partial class AsignarPedido : Form
    {
        private UsuariosModel modelito;
        public AsignarPedido(UsuariosModel modelito)
        {
            InitializeComponent();
            this.modelito = modelito;
            Querys.llenarCombo(comboBox1, button1, 49, new ArrayList());
            Querys.llenarComboFiltros(comboBox2, 50, modelito.Usuario);
            Querys.llenarDatagrid(dataGridView1, 52);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Querys.insertaRepa(comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), modelito.Usuario);
                MessageBox.Show("Repartidor asignado de forma exitosa");
                Querys.llenarDatagrid(dataGridView1, 52);
                Querys.llenarComboFiltros(comboBox2, 50, modelito.Usuario);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

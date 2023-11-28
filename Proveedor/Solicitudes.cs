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

namespace JuVa.Views.Compras.Proveedor
{
    public partial class Solicitudes : Form
    {
        private UsuariosModel modelo;
        ArrayList param = new ArrayList();
        public Solicitudes(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            // Querys.llenarComboUr(comboBox1, btnCambio, 22, param, modelo.Usuario);
            Querys.llenarComboFiltros(comboBox1, 22, modelo.Usuario);
            groupBox2.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Querys.llenarDatagrid(dataGridView1,21, "Pendiente",modelo.Usuario);
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            string resp = "Rechazada";
           // MessageBox.Show(comboBox1.SelectedValue.ToString() + "," + resp + "," + modelo.Usuario);
            Querys.modEstadoSol(comboBox1.SelectedValue.ToString(),resp,modelo.Usuario);
            Querys.llenarComboFiltros(comboBox1, 22, modelo.Usuario);
            MessageBox.Show("La solicitud ha sido rechazada");
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            string resp = "Aceptada";
            Querys.modEstadoSol(comboBox1.SelectedValue.ToString(),resp,modelo.Usuario);
            Querys.llenarComboFiltros(comboBox1, 22, modelo.Usuario);
            MessageBox.Show("La solicitud ha sido aceptada");
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}

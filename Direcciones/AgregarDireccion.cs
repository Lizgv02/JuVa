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

namespace JuVa.Views.Clientes.Direcciones
{
    public partial class AgregarDireccion : Form
    {
        private UsuariosModel modelo;
        public AgregarDireccion(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el número de la calle....");
                txtNum.Focus();
            }
            else if (txtCalle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el nombre de la calle, no seas wey....");
                txtCalle.Focus();
            }
            else if (txtCol.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el nombre de la colonia, no seas wey....");
                txtCol.Focus();
            }
            else if (txtCiudad.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el nombre de la ciudad, no seas wey....");
                txtCiudad.Focus();
            }
            else if (txtEst.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Escribe el nombre del estado, no seas wey....");
                txtEst.Focus();
            }
            else if (txtCP.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hace falta que te diga que esto es obligatorio?");
                txtCP.Focus();
            }
            else
            {
                try
                {
                    Querys.AgregaDireccion(modelo.Usuario, txtNum.Text, txtCalle.Text, txtCol.Text, txtCiudad.Text, txtEst.Text, txtCP.Text,EntrecalleTB.Text,ReferenciaB.Text,IndicacionesTB.Text,modelo.Usuario);
                    MessageBox.Show("La dirección fue agregada correctamente");
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

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

namespace JuVa.Views.Entrega
{
    public partial class ConfirmarEntrega : Form
    {
        private UsuariosModel modelo;
        private DireccionModel direc;
        public ConfirmarEntrega(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            Querys.llenarDatagrid(dataGridView1, 54, "Esta es la ultima", modelo.Usuario);
            Querys.llenarComboFiltros(comboBox1, 55, modelo.Usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Confirmar
            string resp = "Entregado";
            Querys.modEstadoEnvio(comboBox1.SelectedValue.ToString(), resp, modelo.Usuario);
            MessageBox.Show("Se ha indicado que se ha entregado el pedido");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //No se encontro al cliente
            string resp = "No se encontro al cliente";
            Querys.modEstadoEnvio(comboBox1.SelectedValue.ToString(), resp, modelo.Usuario);
            MessageBox.Show("Se ha indicado que el cliente no se encontraba en su domicilio");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debes ingresar el nombre del usuario");
            }else if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debes ingresar el numero de dirección del pedido");
            }
            else
            {
                try
                {
                    direc = Querys.extraeDirec(textBox1.Text, textBox2.Text);
                    textBox3.Text = direc.CALLE;
                    textBox4.Text = direc.NUMERO.ToString();
                    textBox5.Text = direc.COLONIA;
                    textBox6.Text = direc.CIUDAD;
                    textBox7.Text = direc.ESTADO;
                    textBox8.Text = direc.CP.ToString();
                    textBox9.Text = direc.ENTRECALLE;
                    textBox10.Text = direc.REFERENCIA;
                    textBox11.Text = direc.REFERENCIA;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

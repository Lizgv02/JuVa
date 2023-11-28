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

namespace JuVa.Views.Clientes
{
    public partial class NuevoPedido : Form
    {
        private UsuariosModel modelo;
        private UsuariosModel2 datos;
        private ProductoModel juguito;
        private CuponModel cuponazo;
        float subtotal, total;
        public NuevoPedido(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            datos = Querys.extraerUsuario(modelo.Usuario);
            Querys.llenarDatagrid(dataGridView1, 40);
            Querys.llenarComboFiltros(comboBox1, 41, modelo.Usuario);
            Querys.llenarComboFiltros(comboBox2, 39, modelo.Usuario);
            Querys.llenarComboFiltros(comboBox3, 42, datos.Nivel.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                juguito = Querys.extraeProducto(comboBox1.SelectedValue.ToString());
                cuponazo = Querys.extraeCupon(comboBox3.SelectedValue.ToString());
                subtotal = float.Parse(textBox1.Text) * juguito.COSTO;
                total = subtotal * cuponazo.Descuento;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (textBox1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Debes ingresar la cantidad del producto");
                textBox1.Focus();
            }
            else
            {
                try
                {
                    Querys.AgregaPedido(modelo.Usuario, comboBox1.SelectedValue.ToString(), textBox1.Text, subtotal+"", total+"", comboBox2.SelectedValue.ToString(), modelo.Usuario);
                    MessageBox.Show("Pedido agregado correctamente");
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            
            
        }
    }
}

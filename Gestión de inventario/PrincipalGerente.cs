using JuVa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuVa.Views.Compras.Gerente_de_compras
{
    public partial class PrincipalGerente : Form
    {
        private UsuariosModel modelo;
        public PrincipalGerente(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
        }

      

        private void btnInv_Click(object sender, EventArgs e)
        {
            
            Gestion_de_compras.Compras frm = new Gestion_de_compras.Compras(modelo);
            frm.Show();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            
            Gestion_de_inventario.Agregar frm = new Gestion_de_inventario.Agregar(modelo);
            frm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JuVa.Models;
using JuVa.Utilerias;

namespace JuVa.Views.Archivo.Alumnos
{
    public partial class clientesModificar : Form
    {
        private readonly int ID = 4;
        private UsuariosModel modelo;
        public clientesModificar(UsuariosModel modelo)
        {
            InitializeComponent();
            Querys q = new Querys();
            if (!Querys.tienePermiso(modelo.Tipo, ID))
            {
                MessageBox.Show(Properties.Resources.sinPermiso2);
                this.Close();
            }
        }

        private void clientesModificar_Load(object sender, EventArgs e)
        {

        }
    }
}

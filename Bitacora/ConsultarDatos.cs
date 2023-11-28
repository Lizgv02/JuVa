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

namespace JuVa.Views.Bitacora
{
    public partial class ConsultarDatos : Form
    {
        private UsuariosModel modelo;
        public ConsultarDatos(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            Querys.llenarDatagrid(dataGridView1, 58);
        }
    }
}

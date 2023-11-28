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

namespace JuVa.Views.Bitacora
{
    public partial class bitacoraConsultas : Form
    {
        
        private UsuariosModel modelo;
        public bitacoraConsultas(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            Querys.llenarDatagrid(dataGridView1, 53);
           
        }
    }
}

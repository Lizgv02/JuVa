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
    public partial class ConsultarDireccion : Form
    {
        private UsuariosModel modelo;
        private DireccionModel quieroUntaco;
        public ConsultarDireccion(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            Querys.llenarComboFiltros(DireccionCB, 39, modelo.Usuario);
        }

        private void ConsultarBTN_Click(object sender, EventArgs e)
        {
            quieroUntaco=Querys.extraeDirec(modelo.Usuario, DireccionCB.SelectedValue.ToString());
            IDDireccionTB.Text = quieroUntaco.NUMERO.ToString();
            CalleTB.Text = quieroUntaco.CALLE;
            ColoniaTB.Text = quieroUntaco.COLONIA;
            CiudadTB.Text = quieroUntaco.CIUDAD;
            EstadoTB.Text = quieroUntaco.ESTADO;
            CPTB.Text = quieroUntaco.CP.ToString();
            EntrecalleTB.Text = quieroUntaco.ENTRECALLE;
            ReferenciaB.Text = quieroUntaco.REFERENCIA;
            IndicacionesTB.Text = quieroUntaco.INDICACIONES;
        }
    }
}

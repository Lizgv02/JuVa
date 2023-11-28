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

namespace JuVa.Views
{
    public partial class PrincipalBueno : Form
    {
        private UsuariosModel modelo;
        public PrincipalBueno(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            this.Text = this.Text + " - " + modelo.Nombre;
            /*Aqui se desactivara todo menos el inicio de sesión, estos permisos los terminare una vez que ustedes hayan agregado las 
             pestañas que vayan a usar*/
            cerrarSesiónToolStripMenuItem.Visible = false;
            consultarCuponesDisponiblesToolStripMenuItem.Visible = false;
          
            agregarUnNuevoCuponToolStripMenuItem.Visible = false;
            darOpiniónToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = false;
            comprasToolStripMenuItem.Visible = false;
            gerenteToolStripMenuItem.Visible = false;
            proveedorToolStripMenuItem.Visible = false;
            agregarToolStripMenuItem.Visible = false;
            modificarToolStripMenuItem.Visible = false;
            desactivarToolStripMenuItem.Visible = false;
            aprobarSoliciudToolStripMenuItem.Visible = false;
            consultarOpinionesToolStripMenuItem.Visible = false;
            bitacoraToolStripMenuItem.Visible = false;
            consultarDatosToolStripMenuItem.Visible = false;
            enviosToolStripMenuItem.Visible = false;
            confirmarEntregaToolStripMenuItem.Visible = false;
            enviosToolStripMenuItem.Visible = false;
            clientesToolStripMenuItem.Visible = true;

            /*Panel de permisos, si le entienden editen... si no yo me encargo*/
            //Administrador
            if (modelo.Tipo == 0)
            {
                //Esto es innecesario pero para que medio le entiendan
                cerrarSesiónToolStripMenuItem.Visible = true;
                agregarUnNuevoCuponToolStripMenuItem.Visible = true;
                comprasToolStripMenuItem.Visible = true;
                gerenteToolStripMenuItem.Visible = true;
                agregarToolStripMenuItem.Visible = true;
                modificarToolStripMenuItem.Visible = true;
                desactivarToolStripMenuItem.Visible = true;
                aprobarSoliciudToolStripMenuItem.Visible = true;
                consultarOpinionesToolStripMenuItem.Visible = true;
                bitacoraToolStripMenuItem.Visible = true;
                consultarDatosToolStripMenuItem.Visible = true;
                enviosToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                pedidoToolStripMenuItem.Visible = false;
                direccionesToolStripMenuItem.Visible = false;
                solicitudToolStripMenuItem.Visible = false;
                enviosToolStripMenuItem.Visible = true;
            }
            //Administrador de bases
            else if (modelo.Tipo == 1)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
                agregarUnNuevoCuponToolStripMenuItem.Visible = true;
                comprasToolStripMenuItem.Visible = true;
                gerenteToolStripMenuItem.Visible = true;
                agregarToolStripMenuItem.Visible = true;
                modificarToolStripMenuItem.Visible = true;
                desactivarToolStripMenuItem.Visible = true;
                consultarOpinionesToolStripMenuItem.Visible = true;
                bitacoraToolStripMenuItem.Visible = true;
                consultarDatosToolStripMenuItem.Visible = true;
                enviosToolStripMenuItem.Visible = true;
            } 
            //Proveedor
            else if (modelo.Tipo == 2)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
                comprasToolStripMenuItem.Visible = true;
                proveedorToolStripMenuItem.Visible = true;
            }
            //Cliente
            else if (modelo.Tipo == 3)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
                consultarCuponesDisponiblesToolStripMenuItem.Visible = true;
               
                darOpiniónToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                
            }
            //Logistica
            else if (modelo.Tipo == 4)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
                agregarUnNuevoCuponToolStripMenuItem.Visible = true;
            }
            //Repartidor
            else if (modelo.Tipo == 5)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
                enviosToolStripMenuItem.Visible = true;
                confirmarEntregaToolStripMenuItem.Visible = true;
                enviosToolStripMenuItem.Visible = true;

            }
            //Marketing?
            else if (modelo.Tipo == 6)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
                agregarUnNuevoCuponToolStripMenuItem.Visible = true;
            }
            //Administrador general
            else if (modelo.Tipo == -1)
            {
                cerrarSesiónToolStripMenuItem.Visible = true;
            }

        }

        private void muestraFormulario(Form frm)
        {
            if (!FormularioDuplicado(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private bool FormularioDuplicado(Form frm)
        {
            bool Valor = false;
            foreach (Form fr in this.MdiChildren)
            {
                if (fr.GetType() == frm.GetType())
                {
                    fr.Activate();
                    fr.WindowState = FormWindowState.Normal;
                    Valor = true;
                }
            }
            return Valor;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("¿Estas seguro de cerrar la sesión?",
               "Estas por finalizar la sesión", MessageBoxButtons.OKCancel);
            switch (dr)
            {
                case DialogResult.OK:
                    MessageBox.Show("Sesión finalizada");
                    Querys.cerrarApp(modelo.Usuario);
                    break;
            }
        }

        private void noLeDesClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you happy now?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    MessageBox.Show("That is Fantastic");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Why Not?");
                    break;
            }
        }

        private void PrincipalBueno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Querys.cerrarApp(modelo.Usuario);
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.NuevoPedido(modelo));
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.Direcciones.AgregarDireccion(modelo));
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.Direcciones.ConsultarDireccion(modelo));
        }

        private void nuevaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.Solicitud.NuevaSolicitud(modelo));
        }

        private void consultarSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.Solicitud.ConsultarSolicitud(modelo));
        }

        private void aprobarSoliciudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.Solicitud.AprobarSolicitud(modelo));
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Gerente_de_compras.PrincipalGerente(modelo));
        }

        private void consultarYEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Gerente_de_compras.Gestion_de_inventario.Consultar(modelo));
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Gerente_de_compras.Gestion_de_inventario.Agregar(modelo));
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Gerente_de_compras.Gestion_de_compras.Compras(modelo));
        }

        private void generarNuevaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Gerente_de_compras.Gestion_de_compras.GenerarSolicitud(modelo));
        }

        private void pagarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Gerente_de_compras.Gestion_de_compras.Pagar_compra(modelo));
        }

        private void agregarUnNuevoCuponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Postventa.Cupones(modelo));
        }

        private void consultarCuponesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Postventa.CuponesDisponibles(modelo));
        }

        private void darOpiniónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Postventa.Opiniones(modelo));
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Archivo.Usuarios.UsrAgregar(modelo));
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Archivo.Usuarios.UsrModificar(modelo));
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Archivo.Usuarios.UsrDesactivar(modelo));
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Bitacora.bitacoraConsultas(modelo));
        }

        private void consultarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Bitacora.ConsultarDatos(modelo));
        }

        private void consultarOpinionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Postventa.Form1(modelo));
        }

        private void confirmarEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Entrega.ConfirmarEntrega(modelo));
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Proveedor.Solicitudes(modelo));
        }

        private void negociacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Proveedor.Negociacion(modelo));
        }

        private void asignarPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Compras.Proveedor.AsignarPrecio(modelo));
        }

        private void misPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Clientes.Solicitud.MisPedidos(modelo));
        }

        private void agregarEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Entrega.AsignarPedido(modelo));
        }

        private void confirmarEntregaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

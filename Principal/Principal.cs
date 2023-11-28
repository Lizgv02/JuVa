using System;
using System.Windows.Forms;
using JuVa.Models;
using JuVa.Utilerias;

namespace JuVa
{
    public partial class Principal : Form
    {
        private UsuariosModel modelo;

        public Principal(UsuariosModel modelo)
        {
            InitializeComponent();
            this.modelo = modelo;
            this.Text = this.Text + " - " + modelo.Nombre;
            titulacionesToolStripMenuItem.Visible = false;

            datosInstitucionalesToolStripMenuItem.Visible = false;
            modificarInstituciónToolStripMenuItem.Visible = false;
            directivosToolStripMenuItem.Visible = false;
            departamentosToolStripMenuItem.Visible = false;
            carrerasToolStripMenuItem.Visible = false;

            bitacoraToolStripMenuItem.Visible = false;
            solicitudesToolStripMenuItem.Visible = false;
            firmarToolStripMenuItem.Visible = false;
            alumnosToolStripMenuItem.Visible = false;
            lugaresDeTitulaciónToolStripMenuItem.Visible = false;
            profesoresToolStripMenuItem.Visible = false;
            usuariosToolStripMenuItem.Visible = false;

            //Admin vs admin general
            if (modelo.Tipo == 0)
            {
                //Solo admin
                lugaresDeTitulaciónToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
                datosInstitucionalesToolStripMenuItem.Visible = true;
                directivosToolStripMenuItem.Visible = true;
                modificarInstituciónToolStripMenuItem.Visible=true;
            }
            else if (modelo.Tipo == 1)
            {
                //Coordinadores
                solicitudesToolStripMenuItem.Visible = true;
                firmarToolStripMenuItem.Visible = true;
                lugaresDeTitulaciónToolStripMenuItem.Visible = true;
                titulacionesToolStripMenuItem.Visible = true;
            }
            else if (modelo.Tipo == 2)
            {
                //Secretarias
                solicitudesToolStripMenuItem.Visible = true;
                alumnosToolStripMenuItem.Visible = true;
                profesoresToolStripMenuItem.Visible = true;
            }
            else if (modelo.Tipo == 3)
            {
                //alumnos
                solicitudesToolStripMenuItem.Visible = true;
                firmarToolStripMenuItem.Visible = true;
                bitacoraToolStripMenuItem.Visible = false;
            }
            else if (modelo.Tipo == -1)
            {
                titulacionesToolStripMenuItem.Visible = true;

                datosInstitucionalesToolStripMenuItem.Visible = true;
                modificarInstituciónToolStripMenuItem.Visible = true;
                directivosToolStripMenuItem.Visible = true;
                departamentosToolStripMenuItem.Visible = true;
                carrerasToolStripMenuItem.Visible = true;

                bitacoraToolStripMenuItem.Visible = true;
                solicitudesToolStripMenuItem.Visible = true;
                firmarToolStripMenuItem.Visible = true;
                alumnosToolStripMenuItem.Visible = true;
                lugaresDeTitulaciónToolStripMenuItem.Visible = true;
                profesoresToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }


        }

        private void titulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarInstituciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Datos_Institucionales.datosModInst(modelo));
        }

        private void directivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private bool FormularioDuplicado(Form frm)
        {
            bool Valor = false;
            foreach(Form fr in this.MdiChildren)
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

        private void muestraFormulario(Form frm)
        {
            if (!FormularioDuplicado(frm))
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void firmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De actas
            muestraFormulario(new Views.Archivo.Actas.generarSol(modelo));
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De actas
            muestraFormulario(new Views.Archivo.Actas.actasVisualizar(modelo));
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // De alumno
            muestraFormulario(new Views.Archivo.Alumnos.clientesAgregar(modelo));
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De alumno
            muestraFormulario(new Views.Archivo.Alumnos.clientesModificar(modelo));
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //De lugares de Titulación
            muestraFormulario(new Views.Archivo.Lugares_de_Titulación.solcAgregar(modelo));
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //De lugares de Titulación
            muestraFormulario(new Views.Archivo.Lugares_de_Titulación.solcModificar(modelo));
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //De profesores
            muestraFormulario(new Views.Archivo.Profesores.provAgregar(modelo));
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //De profesores
            muestraFormulario(new Views.Archivo.Profesores.provModificar(modelo));
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // De Datos institucionales, Directivos
            muestraFormulario(new Views.Datos_Institucionales.Directivos.directivoAgregar(modelo));
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // De Datos institucionales, Directivos
            muestraFormulario(new Views.Datos_Institucionales.Directivos.directivoModificar(modelo));
        }

        private void agregarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // De Datos institucionales, Departamentos
            muestraFormulario(new Views.Datos_Institucionales.Departamentos.deptoAgregar(modelo));
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // De Datos institucionales, Departamentos
            muestraFormulario(new Views.Datos_Institucionales.Departamentos.deptoModificar(modelo));
        }

        private void agregarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // De Datos institucionales, Carreras
            muestraFormulario(new Views.Datos_Institucionales.Carreras.carsAgregar(modelo));
        }

        private void modificarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // De Datos institucionales, Carreras
            muestraFormulario(new Views.Datos_Institucionales.Carreras.carsModificar(modelo));
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //De archivo, usuarios
            muestraFormulario(new Views.Archivo.Usuarios.UsrAgregar(modelo));
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De archivo, usuarios
            muestraFormulario(new Views.Archivo.Usuarios.UsrDesactivar(modelo));
        }

        private void modificaarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De archivo, usuarios
            muestraFormulario(new Views.Archivo.Usuarios.UsrModificar(modelo));
        }

        private void agregarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De titulaciones
            muestraFormulario(new Views.Titulaciones.envioAgregar(modelo));
        }

        private void modificarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //De titulaciones
            muestraFormulario(new Views.Titulaciones.titulModificar(modelo));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querys.cerrarApp(modelo.Usuario);
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // De bitacoras, Consulta
            muestraFormulario(new Views.Bitacora.bitacoraConsultas(modelo));
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Querys.cerrarApp(modelo.Usuario);
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Postventa.Opiniones(modelo));
        }

        private void desarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestraFormulario(new Views.Postventa.Cupones(modelo));
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using JuVa.Models;
using JuVa.Utilerias;

namespace JuVa.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsr.ForeColor == Color.LightGray)
            {
                MessageBox.Show(Properties.Resources.LoginUsg2);
                txtUsr.Focus();
            }
            else if (txtUsr.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Properties.Resources.LoginUsg2);
                txtUsr.Focus();
            }
            else if(txtClv.ForeColor == Color.LightGray)
            {
                MessageBox.Show(Properties.Resources.LoginClv2);
                txtClv.Focus();
            }
            else if (txtClv.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Properties.Resources.LoginClv2);
                txtClv.Focus();
            }
            else
            {
                /*
                 * Esto es pendiente
                 * 
                 */

                //Para evitar el pendiente
                try
                {
                    UsuariosModel usr = Querys.buscarUsuarios(txtUsr.Text, txtClv.Text);
                    MessageBox.Show("Bienvenido: " + usr.Nombre);
                    this.Hide();
                    PrincipalBueno frm = new PrincipalBueno(usr);
                    frm.Show();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsr_TextChanged(object sender, EventArgs e)
        {
            if (txtUsr.Text.Trim() != String.Empty)
            {
                txtUsr.ForeColor = Color.Black;
            }
            else
            {
                txtUsr.ForeColor = Color.LightGray;
            }
        }

        private void txtUsr_Enter(object sender, EventArgs e)
        {
            if (txtUsr.Text == Properties.Resources.LoginUsg2)
            {
                txtUsr.Text = String.Empty;
            }
        }

        private void txtUsr_Leave(object sender, EventArgs e)
        {
            if (txtUsr.Text.Trim() == String.Empty)
            {
                txtUsr.Text = Properties.Resources.LoginUsg2;
                txtUsr.ForeColor = Color.LightGray;
            }
        }

        private void txtClv_TextChanged(object sender, EventArgs e)
        {
            if (txtClv.Text.Trim() != String.Empty)
            {
                txtClv.ForeColor = Color.Black;
                txtClv.PasswordChar = '*';
            }
            else
            {
                txtClv.ForeColor = Color.LightGray;
                txtClv.PasswordChar = '\0';
            }
        }

        private void txtClv_Enter(object sender, EventArgs e)
        {
            if (txtClv.Text == Properties.Resources.LoginClv2)
            {
                txtClv.Text = String.Empty;
                txtClv.PasswordChar = '*';
            }
        }

        private void txtClv_Leave(object sender, EventArgs e)
        {
            if (txtClv.Text.Trim() == String.Empty)
            {
                txtClv.Text = Properties.Resources.LoginClv2;
                txtClv.ForeColor = Color.LightGray;
                txtClv.PasswordChar = '\0';
            }
        }
    }
}

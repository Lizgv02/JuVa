using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using JuVa.Utilerias;

namespace JuVa.Views
{
    public partial class CombosListas : Form
    {
        public CombosListas()
        {
            InitializeComponent();
            ArrayList param = new ArrayList();
            Querys.llenarCombo(comboDepto, btnDepto, 3, param);
            Querys.LlenarLstBox(lstDepto, btnDeptoL, 3, param);
        }
        private void btnProf_Click(object sender, EventArgs e)
        {

        }
        

        private void btnDepto_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            param.Add(comboDepto.SelectedValue.ToString());
            Querys.llenarCombo(comboCarrera, btnCarrera, 4, param);
            Querys.LimpiarKlombo(comboProf, BtnProfL);  
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            param.Add(comboCarrera.SelectedValue.ToString());
            Querys.llenarCombo(comboProf, btnProf, 5, param);
        }

        private void btnDeptoL_Click(object sender, EventArgs e)
        {
            if (lstDepto.SelectedItems.Count > 0)
            {
                //tengo elementos seleccionados
                Querys.LimpiarListBox(lstProf, BtnProfL);
                ArrayList param = new ArrayList();
                for (int x = 0; x < lstDepto.SelectedItems.Count; x++)
                {
                    param.Add(((KeyValuePair<string, string>)lstDepto.SelectedItems[x]).Key);
                }
                Querys.LlenarLstBox(lstCarrera, btnCarreraL, 4, param);
            }
            else
            {
                //no tengo elementos seleccionados
                Querys.LimpiarListBox(lstCarrera, btnCarreraL);
                Querys.LimpiarListBox(lstProf, BtnProfL);
                MessageBox.Show("No seleccionaste nada");
            }
        }

        private void btnCarreraL_Click(object sender, EventArgs e)
        {
            if (lstCarrera.SelectedItems.Count > 0)
            {
                //tengo elementos seleccionados
                Querys.LimpiarListBox(lstProf, BtnProfL);
                ArrayList param = new ArrayList();
                for (int x = 0; x < lstCarrera.SelectedItems.Count; x++)
                {
                    param.Add(((KeyValuePair<string, string>)lstCarrera.SelectedItems[x]).Key);
                }
                Querys.LlenarLstBox(lstProf, BtnProfL, 5, param);
            }
            else
            {
                //no tengo elementos seleccionados
                Querys.LimpiarListBox(lstProf, BtnProfL);
                MessageBox.Show("No seleccionaste nada");
            }
        }
    }
}

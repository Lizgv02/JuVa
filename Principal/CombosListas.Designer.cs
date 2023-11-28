
using System;

namespace JuVa.Views
{
    partial class CombosListas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDepto = new System.Windows.Forms.ComboBox();
            this.comboCarrera = new System.Windows.Forms.ComboBox();
            this.comboProf = new System.Windows.Forms.ComboBox();
            this.btnDepto = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.lstDepto = new System.Windows.Forms.ListBox();
            this.lstCarrera = new System.Windows.Forms.ListBox();
            this.lstProf = new System.Windows.Forms.ListBox();
            this.btnDeptoL = new System.Windows.Forms.Button();
            this.btnCarreraL = new System.Windows.Forms.Button();
            this.BtnProfL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(207, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(385, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesores";
            // 
            // comboDepto
            // 
            this.comboDepto.FormattingEnabled = true;
            this.comboDepto.Location = new System.Drawing.Point(29, 57);
            this.comboDepto.Name = "comboDepto";
            this.comboDepto.Size = new System.Drawing.Size(125, 23);
            this.comboDepto.TabIndex = 3;
            // 
            // comboCarrera
            // 
            this.comboCarrera.FormattingEnabled = true;
            this.comboCarrera.Location = new System.Drawing.Point(207, 57);
            this.comboCarrera.Name = "comboCarrera";
            this.comboCarrera.Size = new System.Drawing.Size(130, 23);
            this.comboCarrera.TabIndex = 4;
            // 
            // comboProf
            // 
            this.comboProf.FormattingEnabled = true;
            this.comboProf.Location = new System.Drawing.Point(385, 56);
            this.comboProf.Name = "comboProf";
            this.comboProf.Size = new System.Drawing.Size(131, 23);
            this.comboProf.TabIndex = 5;
            // 
            // btnDepto
            // 
            this.btnDepto.BackColor = System.Drawing.Color.LightGreen;
            this.btnDepto.Location = new System.Drawing.Point(29, 96);
            this.btnDepto.Name = "btnDepto";
            this.btnDepto.Size = new System.Drawing.Size(75, 23);
            this.btnDepto.TabIndex = 6;
            this.btnDepto.Text = "Select";
            this.btnDepto.UseVisualStyleBackColor = false;
            this.btnDepto.Click += new System.EventHandler(this.btnDepto_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.BackColor = System.Drawing.Color.LightGreen;
            this.btnCarrera.Location = new System.Drawing.Point(207, 96);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnCarrera.TabIndex = 7;
            this.btnCarrera.Text = "Select";
            this.btnCarrera.UseVisualStyleBackColor = false;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // btnProf
            // 
            this.btnProf.BackColor = System.Drawing.Color.LightGreen;
            this.btnProf.Location = new System.Drawing.Point(385, 96);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(75, 23);
            this.btnProf.TabIndex = 8;
            this.btnProf.Text = "Select";
            this.btnProf.UseVisualStyleBackColor = false;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // lstDepto
            // 
            this.lstDepto.FormattingEnabled = true;
            this.lstDepto.ItemHeight = 15;
            this.lstDepto.Location = new System.Drawing.Point(29, 202);
            this.lstDepto.Name = "lstDepto";
            this.lstDepto.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDepto.Size = new System.Drawing.Size(125, 169);
            this.lstDepto.TabIndex = 9;
            // 
            // lstCarrera
            // 
            this.lstCarrera.FormattingEnabled = true;
            this.lstCarrera.ItemHeight = 15;
            this.lstCarrera.Location = new System.Drawing.Point(207, 202);
            this.lstCarrera.Name = "lstCarrera";
            this.lstCarrera.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCarrera.Size = new System.Drawing.Size(130, 169);
            this.lstCarrera.TabIndex = 10;
            // 
            // lstProf
            // 
            this.lstProf.FormattingEnabled = true;
            this.lstProf.ItemHeight = 15;
            this.lstProf.Location = new System.Drawing.Point(385, 202);
            this.lstProf.Name = "lstProf";
            this.lstProf.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstProf.Size = new System.Drawing.Size(131, 169);
            this.lstProf.TabIndex = 11;
            // 
            // btnDeptoL
            // 
            this.btnDeptoL.BackColor = System.Drawing.Color.LightGreen;
            this.btnDeptoL.Location = new System.Drawing.Point(29, 394);
            this.btnDeptoL.Name = "btnDeptoL";
            this.btnDeptoL.Size = new System.Drawing.Size(75, 23);
            this.btnDeptoL.TabIndex = 12;
            this.btnDeptoL.Text = "Select";
            this.btnDeptoL.UseVisualStyleBackColor = false;
            this.btnDeptoL.Click += new System.EventHandler(this.btnDeptoL_Click);
            // 
            // btnCarreraL
            // 
            this.btnCarreraL.BackColor = System.Drawing.Color.LightGreen;
            this.btnCarreraL.Location = new System.Drawing.Point(207, 394);
            this.btnCarreraL.Name = "btnCarreraL";
            this.btnCarreraL.Size = new System.Drawing.Size(75, 23);
            this.btnCarreraL.TabIndex = 13;
            this.btnCarreraL.Text = "Select";
            this.btnCarreraL.UseVisualStyleBackColor = false;
            this.btnCarreraL.Click += new System.EventHandler(this.btnCarreraL_Click);
            // 
            // BtnProfL
            // 
            this.BtnProfL.BackColor = System.Drawing.Color.LightGreen;
            this.BtnProfL.Location = new System.Drawing.Point(385, 394);
            this.BtnProfL.Name = "BtnProfL";
            this.BtnProfL.Size = new System.Drawing.Size(75, 23);
            this.BtnProfL.TabIndex = 14;
            this.BtnProfL.Text = "Select";
            this.BtnProfL.UseVisualStyleBackColor = false;
            // 
            // CombosListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.BtnProfL);
            this.Controls.Add(this.btnCarreraL);
            this.Controls.Add(this.btnDeptoL);
            this.Controls.Add(this.lstProf);
            this.Controls.Add(this.lstCarrera);
            this.Controls.Add(this.lstDepto);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnCarrera);
            this.Controls.Add(this.btnDepto);
            this.Controls.Add(this.comboProf);
            this.Controls.Add(this.comboCarrera);
            this.Controls.Add(this.comboDepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "CombosListas";
            this.Text = "CombosListas NC19091313";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnDepto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDepto;
        private System.Windows.Forms.ComboBox comboCarrera;
        private System.Windows.Forms.ComboBox comboProf;
        private System.Windows.Forms.Button btnDepto;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.ListBox lstDepto;
        private System.Windows.Forms.ListBox lstCarrera;
        private System.Windows.Forms.ListBox lstProf;
        private System.Windows.Forms.Button btnDeptoL;
        private System.Windows.Forms.Button btnCarreraL;
        private System.Windows.Forms.Button BtnProfL;
    }
}
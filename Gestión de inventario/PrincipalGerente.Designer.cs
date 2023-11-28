
namespace JuVa.Views.Compras.Gerente_de_compras
{
    partial class PrincipalGerente
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
            this.btnInv = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(167, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Gerente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(187, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Qué desea hacer hoy?";
            // 
            // btnInv
            // 
            this.btnInv.BackColor = System.Drawing.Color.LightGreen;
            this.btnInv.Location = new System.Drawing.Point(89, 142);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(132, 30);
            this.btnInv.TabIndex = 2;
            this.btnInv.Text = "Gestión de inventario";
            this.btnInv.UseVisualStyleBackColor = false;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnCom
            // 
            this.btnCom.BackColor = System.Drawing.Color.LightGreen;
            this.btnCom.Location = new System.Drawing.Point(292, 142);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(132, 30);
            this.btnCom.TabIndex = 3;
            this.btnCom.Text = "Gestión de compras";
            this.btnCom.UseVisualStyleBackColor = false;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // PrincipalGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 269);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrincipalGerente";
            this.Text = "PrincipalGerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnCom;
    }
}
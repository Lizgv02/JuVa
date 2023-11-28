namespace JuVa.Views.Entrega
{
    partial class Form1
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
            this.DatallesTF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PedidosLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RepartidoresLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubirPos = new System.Windows.Forms.Button();
            this.BajarPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatallesTF
            // 
            this.DatallesTF.Location = new System.Drawing.Point(276, 113);
            this.DatallesTF.Multiline = true;
            this.DatallesTF.Name = "DatallesTF";
            this.DatallesTF.ReadOnly = true;
            this.DatallesTF.Size = new System.Drawing.Size(322, 80);
            this.DatallesTF.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Detalles del Pedido";
            // 
            // PedidosLB
            // 
            this.PedidosLB.FormattingEnabled = true;
            this.PedidosLB.ItemHeight = 15;
            this.PedidosLB.Location = new System.Drawing.Point(150, 39);
            this.PedidosLB.Name = "PedidosLB";
            this.PedidosLB.Size = new System.Drawing.Size(120, 154);
            this.PedidosLB.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pedidos";
            // 
            // RepartidoresLB
            // 
            this.RepartidoresLB.FormattingEnabled = true;
            this.RepartidoresLB.ItemHeight = 15;
            this.RepartidoresLB.Location = new System.Drawing.Point(12, 39);
            this.RepartidoresLB.Name = "RepartidoresLB";
            this.RepartidoresLB.Size = new System.Drawing.Size(120, 154);
            this.RepartidoresLB.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Repartidores";
            // 
            // SubirPos
            // 
            this.SubirPos.Location = new System.Drawing.Point(276, 39);
            this.SubirPos.Name = "SubirPos";
            this.SubirPos.Size = new System.Drawing.Size(75, 23);
            this.SubirPos.TabIndex = 27;
            this.SubirPos.Text = "SubirPos";
            this.SubirPos.UseVisualStyleBackColor = true;
            // 
            // BajarPos
            // 
            this.BajarPos.Location = new System.Drawing.Point(276, 68);
            this.BajarPos.Name = "BajarPos";
            this.BajarPos.Size = new System.Drawing.Size(75, 23);
            this.BajarPos.TabIndex = 28;
            this.BajarPos.Text = "BajarPos";
            this.BajarPos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 231);
            this.Controls.Add(this.BajarPos);
            this.Controls.Add(this.SubirPos);
            this.Controls.Add(this.DatallesTF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PedidosLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RepartidoresLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EDITAR ITINERARIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatallesTF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox PedidosLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox RepartidoresLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubirPos;
        private System.Windows.Forms.Button BajarPos;
    }
}
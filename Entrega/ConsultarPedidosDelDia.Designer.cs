namespace JuVa.Views.Entrega
{
    partial class ConsultarPedidosDelDia
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
            this.RepartidoresLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PedidosLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DatallesTF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EstadoTF = new System.Windows.Forms.TextBox();
            this.RepartidorTF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RepartidoresLB
            // 
            this.RepartidoresLB.FormattingEnabled = true;
            this.RepartidoresLB.ItemHeight = 15;
            this.RepartidoresLB.Location = new System.Drawing.Point(12, 38);
            this.RepartidoresLB.Name = "RepartidoresLB";
            this.RepartidoresLB.Size = new System.Drawing.Size(120, 154);
            this.RepartidoresLB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Repartidores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PedidosLB
            // 
            this.PedidosLB.FormattingEnabled = true;
            this.PedidosLB.ItemHeight = 15;
            this.PedidosLB.Location = new System.Drawing.Point(150, 38);
            this.PedidosLB.Name = "PedidosLB";
            this.PedidosLB.Size = new System.Drawing.Size(120, 154);
            this.PedidosLB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pedidos";
            // 
            // DatallesTF
            // 
            this.DatallesTF.Location = new System.Drawing.Point(276, 52);
            this.DatallesTF.Multiline = true;
            this.DatallesTF.Name = "DatallesTF";
            this.DatallesTF.ReadOnly = true;
            this.DatallesTF.Size = new System.Drawing.Size(322, 80);
            this.DatallesTF.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Detalles del Pedido";
            // 
            // EstadoTF
            // 
            this.EstadoTF.Cursor = System.Windows.Forms.Cursors.No;
            this.EstadoTF.Location = new System.Drawing.Point(276, 153);
            this.EstadoTF.Name = "EstadoTF";
            this.EstadoTF.ReadOnly = true;
            this.EstadoTF.Size = new System.Drawing.Size(128, 23);
            this.EstadoTF.TabIndex = 18;
            // 
            // RepartidorTF
            // 
            this.RepartidorTF.Location = new System.Drawing.Point(410, 153);
            this.RepartidorTF.Name = "RepartidorTF";
            this.RepartidorTF.ReadOnly = true;
            this.RepartidorTF.Size = new System.Drawing.Size(188, 23);
            this.RepartidorTF.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado  Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Repartidor";
            // 
            // ConsultarPedidosDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 218);
            this.Controls.Add(this.DatallesTF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EstadoTF);
            this.Controls.Add(this.RepartidorTF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PedidosLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RepartidoresLB);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarPedidosDelDia";
            this.Text = "Consultar Pedidos del Dia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RepartidoresLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PedidosLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DatallesTF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EstadoTF;
        private System.Windows.Forms.TextBox RepartidorTF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
namespace Vista
{
    partial class FRMPedidosNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPedidosNuevo));
            this.label1 = new System.Windows.Forms.Label();
            this.bGuardarPedidoNuevo = new System.Windows.Forms.Button();
            this.bVolverDePedidoNuevo = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelPago = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtotalEmpanadas = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDemora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMACIÓN DEL PEDIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bGuardarPedidoNuevo
            // 
            this.bGuardarPedidoNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardarPedidoNuevo.Location = new System.Drawing.Point(881, 455);
            this.bGuardarPedidoNuevo.Name = "bGuardarPedidoNuevo";
            this.bGuardarPedidoNuevo.Size = new System.Drawing.Size(89, 33);
            this.bGuardarPedidoNuevo.TabIndex = 29;
            this.bGuardarPedidoNuevo.Text = "GUARDAR";
            this.bGuardarPedidoNuevo.UseVisualStyleBackColor = true;
            this.bGuardarPedidoNuevo.Click += new System.EventHandler(this.bGuardarPedidoNuevo_Click);
            // 
            // bVolverDePedidoNuevo
            // 
            this.bVolverDePedidoNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverDePedidoNuevo.Location = new System.Drawing.Point(786, 455);
            this.bVolverDePedidoNuevo.Name = "bVolverDePedidoNuevo";
            this.bVolverDePedidoNuevo.Size = new System.Drawing.Size(89, 33);
            this.bVolverDePedidoNuevo.TabIndex = 30;
            this.bVolverDePedidoNuevo.Text = "VOLVER";
            this.bVolverDePedidoNuevo.UseVisualStyleBackColor = true;
            this.bVolverDePedidoNuevo.Click += new System.EventHandler(this.bVolverDePedidoNuevo_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecio.Location = new System.Drawing.Point(512, 148);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(100, 25);
            this.labelPrecio.TabIndex = 33;
            this.labelPrecio.Text = "PRECIO:";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.BackColor = System.Drawing.Color.Transparent;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPago.Location = new System.Drawing.Point(531, 223);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(81, 25);
            this.labelPago.TabIndex = 34;
            this.labelPago.Text = "PAGO:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.Transparent;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstado.Location = new System.Drawing.Point(503, 291);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(109, 25);
            this.labelEstado.TabIndex = 35;
            this.labelEstado.Text = "ESTADO:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(642, 148);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(257, 30);
            this.textBoxPrecio.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "TOTAL EMPANADAS:";
            // 
            // textBoxtotalEmpanadas
            // 
            this.textBoxtotalEmpanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtotalEmpanadas.Location = new System.Drawing.Point(303, 246);
            this.textBoxtotalEmpanadas.Name = "textBoxtotalEmpanadas";
            this.textBoxtotalEmpanadas.Size = new System.Drawing.Size(151, 30);
            this.textBoxtotalEmpanadas.TabIndex = 53;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCliente.Location = new System.Drawing.Point(59, 146);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(110, 25);
            this.labelCliente.TabIndex = 31;
            this.labelCliente.Text = "CLIENTE:";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.Location = new System.Drawing.Point(197, 145);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(257, 30);
            this.textBoxCliente.TabIndex = 37;
            // 
            // textBoxPago
            // 
            this.textBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPago.Location = new System.Drawing.Point(642, 221);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(257, 30);
            this.textBoxPago.TabIndex = 54;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstado.Location = new System.Drawing.Point(642, 291);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(257, 30);
            this.textBoxEstado.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(59, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "DEMORA:";
            // 
            // textBoxDemora
            // 
            this.textBoxDemora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDemora.Location = new System.Drawing.Point(197, 332);
            this.textBoxDemora.Name = "textBoxDemora";
            this.textBoxDemora.Size = new System.Drawing.Size(257, 30);
            this.textBoxDemora.TabIndex = 57;
            // 
            // FRMPedidosNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.textBoxDemora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxPago);
            this.Controls.Add(this.textBoxtotalEmpanadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelPago);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.bVolverDePedidoNuevo);
            this.Controls.Add(this.bGuardarPedidoNuevo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMPedidosNuevo";
            this.Text = "Pantalla Pedidos Nuevos";
            this.Load += new System.EventHandler(this.FRMPedidosNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGuardarPedidoNuevo;
        private System.Windows.Forms.Button bVolverDePedidoNuevo;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxtotalEmpanadas;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxPago;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDemora;
    }
}
namespace Vista
{
    partial class FRMBorrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBorrarCliente));
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.txtBIdCliente = new System.Windows.Forms.TextBox();
            this.bGuardarCliBorrado = new System.Windows.Forms.Button();
            this.bVolverDeCliBorrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIdCliente.Location = new System.Drawing.Point(283, 227);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(137, 25);
            this.labelIdCliente.TabIndex = 40;
            this.labelIdCliente.Text = "ID CLIENTE:";
            // 
            // txtBIdCliente
            // 
            this.txtBIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIdCliente.Location = new System.Drawing.Point(455, 224);
            this.txtBIdCliente.Name = "txtBIdCliente";
            this.txtBIdCliente.Size = new System.Drawing.Size(257, 30);
            this.txtBIdCliente.TabIndex = 41;
            // 
            // bGuardarCliBorrado
            // 
            this.bGuardarCliBorrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardarCliBorrado.Location = new System.Drawing.Point(881, 455);
            this.bGuardarCliBorrado.Name = "bGuardarCliBorrado";
            this.bGuardarCliBorrado.Size = new System.Drawing.Size(89, 33);
            this.bGuardarCliBorrado.TabIndex = 60;
            this.bGuardarCliBorrado.Text = "GUARDAR";
            this.bGuardarCliBorrado.UseVisualStyleBackColor = true;
            this.bGuardarCliBorrado.Click += new System.EventHandler(this.bGuardarCliBorrado_Click);
            // 
            // bVolverDeCliBorrado
            // 
            this.bVolverDeCliBorrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverDeCliBorrado.Location = new System.Drawing.Point(786, 455);
            this.bVolverDeCliBorrado.Name = "bVolverDeCliBorrado";
            this.bVolverDeCliBorrado.Size = new System.Drawing.Size(89, 33);
            this.bVolverDeCliBorrado.TabIndex = 59;
            this.bVolverDeCliBorrado.Text = "VOLVER";
            this.bVolverDeCliBorrado.UseVisualStyleBackColor = true;
            // 
            // FRMBorrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.bGuardarCliBorrado);
            this.Controls.Add(this.bVolverDeCliBorrado);
            this.Controls.Add(this.txtBIdCliente);
            this.Controls.Add(this.labelIdCliente);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMBorrarCliente";
            this.Text = "FRMBorrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.TextBox txtBIdCliente;
        private System.Windows.Forms.Button bGuardarCliBorrado;
        private System.Windows.Forms.Button bVolverDeCliBorrado;
    }
}
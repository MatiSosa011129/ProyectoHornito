namespace Vista
{
    partial class FRMClientesNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMClientesNuevo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBApellido = new System.Windows.Forms.TextBox();
            this.txtBDni = new System.Windows.Forms.TextBox();
            this.txtBTelefono = new System.Windows.Forms.TextBox();
            this.bGuardarNuevoCli = new System.Windows.Forms.Button();
            this.bVolverDeNuevoCli = new System.Windows.Forms.Button();
            this.labelNombreCli = new System.Windows.Forms.Label();
            this.labelApellidoCli = new System.Windows.Forms.Label();
            this.labelDniCli = new System.Windows.Forms.Label();
            this.labelNacimientoCli = new System.Windows.Forms.Label();
            this.labelTelefonoCli = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMACIÓN DEL CLIENTE";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNombre.Location = new System.Drawing.Point(410, 120);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(257, 30);
            this.txtBNombre.TabIndex = 24;
            this.txtBNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBApellido
            // 
            this.txtBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBApellido.Location = new System.Drawing.Point(410, 170);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(257, 30);
            this.txtBApellido.TabIndex = 26;
            // 
            // txtBDni
            // 
            this.txtBDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDni.Location = new System.Drawing.Point(410, 222);
            this.txtBDni.Name = "txtBDni";
            this.txtBDni.Size = new System.Drawing.Size(257, 30);
            this.txtBDni.TabIndex = 28;
            // 
            // txtBTelefono
            // 
            this.txtBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTelefono.Location = new System.Drawing.Point(410, 323);
            this.txtBTelefono.Name = "txtBTelefono";
            this.txtBTelefono.Size = new System.Drawing.Size(257, 30);
            this.txtBTelefono.TabIndex = 32;
            // 
            // bGuardarNuevoCli
            // 
            this.bGuardarNuevoCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardarNuevoCli.Location = new System.Drawing.Point(881, 455);
            this.bGuardarNuevoCli.Name = "bGuardarNuevoCli";
            this.bGuardarNuevoCli.Size = new System.Drawing.Size(89, 33);
            this.bGuardarNuevoCli.TabIndex = 36;
            this.bGuardarNuevoCli.Text = "GUARDAR";
            this.bGuardarNuevoCli.UseVisualStyleBackColor = true;
            this.bGuardarNuevoCli.Click += new System.EventHandler(this.bGuardarNuevoCli_Click);
            // 
            // bVolverDeNuevoCli
            // 
            this.bVolverDeNuevoCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverDeNuevoCli.Location = new System.Drawing.Point(786, 455);
            this.bVolverDeNuevoCli.Name = "bVolverDeNuevoCli";
            this.bVolverDeNuevoCli.Size = new System.Drawing.Size(89, 33);
            this.bVolverDeNuevoCli.TabIndex = 37;
            this.bVolverDeNuevoCli.Text = "VOLVER";
            this.bVolverDeNuevoCli.UseVisualStyleBackColor = true;
            this.bVolverDeNuevoCli.Click += new System.EventHandler(this.bVolverDeNuevoCli_Click);
            // 
            // labelNombreCli
            // 
            this.labelNombreCli.AutoSize = true;
            this.labelNombreCli.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombreCli.Location = new System.Drawing.Point(277, 120);
            this.labelNombreCli.Name = "labelNombreCli";
            this.labelNombreCli.Size = new System.Drawing.Size(111, 25);
            this.labelNombreCli.TabIndex = 38;
            this.labelNombreCli.Text = "NOMBRE:";
            // 
            // labelApellidoCli
            // 
            this.labelApellidoCli.AutoSize = true;
            this.labelApellidoCli.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelApellidoCli.Location = new System.Drawing.Point(264, 170);
            this.labelApellidoCli.Name = "labelApellidoCli";
            this.labelApellidoCli.Size = new System.Drawing.Size(124, 25);
            this.labelApellidoCli.TabIndex = 39;
            this.labelApellidoCli.Text = "APELLIDO:";
            // 
            // labelDniCli
            // 
            this.labelDniCli.AutoSize = true;
            this.labelDniCli.BackColor = System.Drawing.Color.Transparent;
            this.labelDniCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDniCli.Location = new System.Drawing.Point(333, 225);
            this.labelDniCli.Name = "labelDniCli";
            this.labelDniCli.Size = new System.Drawing.Size(55, 25);
            this.labelDniCli.TabIndex = 40;
            this.labelDniCli.Text = "DNI:";
            // 
            // labelNacimientoCli
            // 
            this.labelNacimientoCli.AutoSize = true;
            this.labelNacimientoCli.BackColor = System.Drawing.Color.Transparent;
            this.labelNacimientoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacimientoCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNacimientoCli.Location = new System.Drawing.Point(233, 276);
            this.labelNacimientoCli.Name = "labelNacimientoCli";
            this.labelNacimientoCli.Size = new System.Drawing.Size(155, 25);
            this.labelNacimientoCli.TabIndex = 41;
            this.labelNacimientoCli.Text = "NACIMIENTO:";
            // 
            // labelTelefonoCli
            // 
            this.labelTelefonoCli.AutoSize = true;
            this.labelTelefonoCli.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefonoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoCli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTelefonoCli.Location = new System.Drawing.Point(253, 326);
            this.labelTelefonoCli.Name = "labelTelefonoCli";
            this.labelTelefonoCli.Size = new System.Drawing.Size(135, 25);
            this.labelTelefonoCli.TabIndex = 42;
            this.labelTelefonoCli.Text = "TELEFONO:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(410, 278);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(257, 22);
            this.dtpNacimiento.TabIndex = 44;
            // 
            // FRMClientesNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.labelTelefonoCli);
            this.Controls.Add(this.labelNacimientoCli);
            this.Controls.Add(this.labelDniCli);
            this.Controls.Add(this.labelApellidoCli);
            this.Controls.Add(this.labelNombreCli);
            this.Controls.Add(this.bVolverDeNuevoCli);
            this.Controls.Add(this.bGuardarNuevoCli);
            this.Controls.Add(this.txtBTelefono);
            this.Controls.Add(this.txtBDni);
            this.Controls.Add(this.txtBApellido);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMClientesNuevo";
            this.Text = "FRMClientesNuevo";
            this.Load += new System.EventHandler(this.FRMClientesNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBApellido;
        private System.Windows.Forms.TextBox txtBDni;
        private System.Windows.Forms.TextBox txtBTelefono;
        private System.Windows.Forms.Button bGuardarNuevoCli;
        private System.Windows.Forms.Button bVolverDeNuevoCli;
        private System.Windows.Forms.Label labelNombreCli;
        private System.Windows.Forms.Label labelApellidoCli;
        private System.Windows.Forms.Label labelDniCli;
        private System.Windows.Forms.Label labelNacimientoCli;
        private System.Windows.Forms.Label labelTelefonoCli;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
    }
}
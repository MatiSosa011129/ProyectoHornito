namespace Vista
{
    partial class FRMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bAltaPedidos = new System.Windows.Forms.Button();
            this.bMoBPedidos = new System.Windows.Forms.Button();
            this.bAltaClientes = new System.Windows.Forms.Button();
            this.bMoBClientes = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bAltaEmpanadas = new System.Windows.Forms.Button();
            this.bMoBEmpanadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(645, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMPANADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(348, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLIENTES";
            // 
            // bAltaPedidos
            // 
            this.bAltaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAltaPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAltaPedidos.ForeColor = System.Drawing.Color.White;
            this.bAltaPedidos.Location = new System.Drawing.Point(35, 138);
            this.bAltaPedidos.Name = "bAltaPedidos";
            this.bAltaPedidos.Size = new System.Drawing.Size(249, 51);
            this.bAltaPedidos.TabIndex = 13;
            this.bAltaPedidos.Text = "ALTA";
            this.bAltaPedidos.UseVisualStyleBackColor = false;
            this.bAltaPedidos.Click += new System.EventHandler(this.bAltaPedidos_Click);
            // 
            // bMoBPedidos
            // 
            this.bMoBPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMoBPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMoBPedidos.ForeColor = System.Drawing.Color.White;
            this.bMoBPedidos.Location = new System.Drawing.Point(35, 241);
            this.bMoBPedidos.Name = "bMoBPedidos";
            this.bMoBPedidos.Size = new System.Drawing.Size(249, 51);
            this.bMoBPedidos.TabIndex = 15;
            this.bMoBPedidos.Text = "VER - MODIFICAR - ELIMINAR";
            this.bMoBPedidos.UseVisualStyleBackColor = false;
            this.bMoBPedidos.Click += new System.EventHandler(this.bMoBPedidos_Click);
            // 
            // bAltaClientes
            // 
            this.bAltaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAltaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAltaClientes.ForeColor = System.Drawing.Color.White;
            this.bAltaClientes.Location = new System.Drawing.Point(357, 138);
            this.bAltaClientes.Name = "bAltaClientes";
            this.bAltaClientes.Size = new System.Drawing.Size(249, 51);
            this.bAltaClientes.TabIndex = 16;
            this.bAltaClientes.Text = "ALTA";
            this.bAltaClientes.UseVisualStyleBackColor = false;
            this.bAltaClientes.Click += new System.EventHandler(this.bAltaClientes_Click);
            // 
            // bMoBClientes
            // 
            this.bMoBClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMoBClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMoBClientes.ForeColor = System.Drawing.Color.White;
            this.bMoBClientes.Location = new System.Drawing.Point(357, 241);
            this.bMoBClientes.Name = "bMoBClientes";
            this.bMoBClientes.Size = new System.Drawing.Size(249, 51);
            this.bMoBClientes.TabIndex = 17;
            this.bMoBClientes.Text = "VER - MODIFICAR - ELIMINAR";
            this.bMoBClientes.UseVisualStyleBackColor = false;
            this.bMoBClientes.Click += new System.EventHandler(this.bMoBClientes_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCerrar.Location = new System.Drawing.Point(881, 455);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(89, 33);
            this.bCerrar.TabIndex = 19;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bAltaEmpanadas
            // 
            this.bAltaEmpanadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAltaEmpanadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAltaEmpanadas.ForeColor = System.Drawing.Color.White;
            this.bAltaEmpanadas.Location = new System.Drawing.Point(683, 138);
            this.bAltaEmpanadas.Name = "bAltaEmpanadas";
            this.bAltaEmpanadas.Size = new System.Drawing.Size(249, 51);
            this.bAltaEmpanadas.TabIndex = 20;
            this.bAltaEmpanadas.Text = "ALTA";
            this.bAltaEmpanadas.UseVisualStyleBackColor = false;
            this.bAltaEmpanadas.Click += new System.EventHandler(this.bAltaEmpanadas_Click);
            // 
            // bMoBEmpanadas
            // 
            this.bMoBEmpanadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMoBEmpanadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMoBEmpanadas.ForeColor = System.Drawing.Color.White;
            this.bMoBEmpanadas.Location = new System.Drawing.Point(683, 241);
            this.bMoBEmpanadas.Name = "bMoBEmpanadas";
            this.bMoBEmpanadas.Size = new System.Drawing.Size(249, 51);
            this.bMoBEmpanadas.TabIndex = 21;
            this.bMoBEmpanadas.Text = "VER - MODIFICAR - ELIMINAR";
            this.bMoBEmpanadas.UseVisualStyleBackColor = false;
            this.bMoBEmpanadas.Click += new System.EventHandler(this.bMoBEmpanadas_Click);
            // 
            // FRMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.bMoBEmpanadas);
            this.Controls.Add(this.bAltaEmpanadas);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bMoBClientes);
            this.Controls.Add(this.bAltaClientes);
            this.Controls.Add(this.bMoBPedidos);
            this.Controls.Add(this.bAltaPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMMenu";
            this.Text = "Pantalla Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAltaPedidos;
        private System.Windows.Forms.Button bMoBPedidos;
        private System.Windows.Forms.Button bAltaClientes;
        private System.Windows.Forms.Button bMoBClientes;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bAltaEmpanadas;
        private System.Windows.Forms.Button bMoBEmpanadas;
    }
}
namespace Vista
{
    partial class FRMAltaEmpanadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAltaEmpanadas));
            this.bVolverDeNuevaEmpanada = new System.Windows.Forms.Button();
            this.bGuardarNuevaEmpanada = new System.Windows.Forms.Button();
            this.textBPrecioEmpa = new System.Windows.Forms.TextBox();
            this.txtBGustoEmpa = new System.Windows.Forms.TextBox();
            this.labelPrecioEmpa = new System.Windows.Forms.Label();
            this.labelGustoEmpa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bVolverDeNuevaEmpanada
            // 
            this.bVolverDeNuevaEmpanada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverDeNuevaEmpanada.Location = new System.Drawing.Point(786, 455);
            this.bVolverDeNuevaEmpanada.Name = "bVolverDeNuevaEmpanada";
            this.bVolverDeNuevaEmpanada.Size = new System.Drawing.Size(89, 33);
            this.bVolverDeNuevaEmpanada.TabIndex = 39;
            this.bVolverDeNuevaEmpanada.Text = "VOLVER";
            this.bVolverDeNuevaEmpanada.UseVisualStyleBackColor = true;
            this.bVolverDeNuevaEmpanada.Click += new System.EventHandler(this.bVolverDeNuevaEmpanada_Click);
            // 
            // bGuardarNuevaEmpanada
            // 
            this.bGuardarNuevaEmpanada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardarNuevaEmpanada.Location = new System.Drawing.Point(881, 455);
            this.bGuardarNuevaEmpanada.Name = "bGuardarNuevaEmpanada";
            this.bGuardarNuevaEmpanada.Size = new System.Drawing.Size(89, 33);
            this.bGuardarNuevaEmpanada.TabIndex = 38;
            this.bGuardarNuevaEmpanada.Text = "GUARDAR";
            this.bGuardarNuevaEmpanada.UseVisualStyleBackColor = true;
            this.bGuardarNuevaEmpanada.Click += new System.EventHandler(this.bGuardarNuevaEmpanada_Click);
            // 
            // textBPrecioEmpa
            // 
            this.textBPrecioEmpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBPrecioEmpa.Location = new System.Drawing.Point(385, 198);
            this.textBPrecioEmpa.Name = "textBPrecioEmpa";
            this.textBPrecioEmpa.Size = new System.Drawing.Size(257, 30);
            this.textBPrecioEmpa.TabIndex = 53;
            // 
            // txtBGustoEmpa
            // 
            this.txtBGustoEmpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBGustoEmpa.Location = new System.Drawing.Point(385, 145);
            this.txtBGustoEmpa.Name = "txtBGustoEmpa";
            this.txtBGustoEmpa.Size = new System.Drawing.Size(257, 30);
            this.txtBGustoEmpa.TabIndex = 52;
            // 
            // labelPrecioEmpa
            // 
            this.labelPrecioEmpa.AutoSize = true;
            this.labelPrecioEmpa.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecioEmpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioEmpa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrecioEmpa.Location = new System.Drawing.Point(247, 201);
            this.labelPrecioEmpa.Name = "labelPrecioEmpa";
            this.labelPrecioEmpa.Size = new System.Drawing.Size(100, 25);
            this.labelPrecioEmpa.TabIndex = 51;
            this.labelPrecioEmpa.Text = "PRECIO:";
            // 
            // labelGustoEmpa
            // 
            this.labelGustoEmpa.AutoSize = true;
            this.labelGustoEmpa.BackColor = System.Drawing.Color.Transparent;
            this.labelGustoEmpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGustoEmpa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGustoEmpa.Location = new System.Drawing.Point(247, 150);
            this.labelGustoEmpa.Name = "labelGustoEmpa";
            this.labelGustoEmpa.Size = new System.Drawing.Size(96, 25);
            this.labelGustoEmpa.TabIndex = 49;
            this.labelGustoEmpa.Text = "GUSTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 51);
            this.label1.TabIndex = 48;
            this.label1.Text = "INFORMACIÓN EMPANADA";
            // 
            // FRMAltaEmpanadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.textBPrecioEmpa);
            this.Controls.Add(this.txtBGustoEmpa);
            this.Controls.Add(this.labelPrecioEmpa);
            this.Controls.Add(this.labelGustoEmpa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVolverDeNuevaEmpanada);
            this.Controls.Add(this.bGuardarNuevaEmpanada);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMAltaEmpanadas";
            this.Text = "FRMAltaEmpanadas";
            this.Load += new System.EventHandler(this.FRMAltaEmpanadas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVolverDeNuevaEmpanada;
        private System.Windows.Forms.Button bGuardarNuevaEmpanada;
        private System.Windows.Forms.TextBox textBPrecioEmpa;
        private System.Windows.Forms.TextBox txtBGustoEmpa;
        private System.Windows.Forms.Label labelPrecioEmpa;
        private System.Windows.Forms.Label labelGustoEmpa;
        private System.Windows.Forms.Label label1;
    }
}
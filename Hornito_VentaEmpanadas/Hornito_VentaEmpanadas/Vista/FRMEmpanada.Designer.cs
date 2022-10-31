namespace Vista
{
    partial class FRMEmpanada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMEmpanada));
            this.label1 = new System.Windows.Forms.Label();
            this.modifempanada = new System.Windows.Forms.Button();
            this.borrarempanada = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewEmpanada = new System.Windows.Forms.DataGridView();
            this.idEmpanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEmpanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gustoEmpanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empanadaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empanadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empanadaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empanadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "EMPANADAS";
            // 
            // modifempanada
            // 
            this.modifempanada.Location = new System.Drawing.Point(801, 127);
            this.modifempanada.Name = "modifempanada";
            this.modifempanada.Size = new System.Drawing.Size(89, 33);
            this.modifempanada.TabIndex = 9;
            this.modifempanada.Text = "MODIFICAR";
            this.modifempanada.UseVisualStyleBackColor = true;
            this.modifempanada.Click += new System.EventHandler(this.modifempanada_Click);
            // 
            // borrarempanada
            // 
            this.borrarempanada.Location = new System.Drawing.Point(801, 194);
            this.borrarempanada.Name = "borrarempanada";
            this.borrarempanada.Size = new System.Drawing.Size(89, 33);
            this.borrarempanada.TabIndex = 10;
            this.borrarempanada.Text = "BORRAR";
            this.borrarempanada.UseVisualStyleBackColor = true;
            this.borrarempanada.Click += new System.EventHandler(this.borrarempanada_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(881, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(786, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEmpanada
            // 
            this.dataGridViewEmpanada.AutoGenerateColumns = false;
            this.dataGridViewEmpanada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpanada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpanadaDataGridViewTextBoxColumn,
            this.precioEmpanadaDataGridViewTextBoxColumn,
            this.gustoEmpanadaDataGridViewTextBoxColumn});
            this.dataGridViewEmpanada.DataSource = this.empanadaBindingSource1;
            this.dataGridViewEmpanada.Location = new System.Drawing.Point(277, 99);
            this.dataGridViewEmpanada.Name = "dataGridViewEmpanada";
            this.dataGridViewEmpanada.RowHeadersWidth = 51;
            this.dataGridViewEmpanada.RowTemplate.Height = 24;
            this.dataGridViewEmpanada.Size = new System.Drawing.Size(426, 237);
            this.dataGridViewEmpanada.TabIndex = 13;
            // 
            // idEmpanadaDataGridViewTextBoxColumn
            // 
            this.idEmpanadaDataGridViewTextBoxColumn.DataPropertyName = "idEmpanada";
            this.idEmpanadaDataGridViewTextBoxColumn.HeaderText = "idEmpanada";
            this.idEmpanadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEmpanadaDataGridViewTextBoxColumn.Name = "idEmpanadaDataGridViewTextBoxColumn";
            this.idEmpanadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioEmpanadaDataGridViewTextBoxColumn
            // 
            this.precioEmpanadaDataGridViewTextBoxColumn.DataPropertyName = "precioEmpanada";
            this.precioEmpanadaDataGridViewTextBoxColumn.HeaderText = "precioEmpanada";
            this.precioEmpanadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioEmpanadaDataGridViewTextBoxColumn.Name = "precioEmpanadaDataGridViewTextBoxColumn";
            this.precioEmpanadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gustoEmpanadaDataGridViewTextBoxColumn
            // 
            this.gustoEmpanadaDataGridViewTextBoxColumn.DataPropertyName = "gustoEmpanada";
            this.gustoEmpanadaDataGridViewTextBoxColumn.HeaderText = "gustoEmpanada";
            this.gustoEmpanadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gustoEmpanadaDataGridViewTextBoxColumn.Name = "gustoEmpanadaDataGridViewTextBoxColumn";
            this.gustoEmpanadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // empanadaBindingSource1
            // 
            this.empanadaBindingSource1.DataSource = typeof(Logica.Empanada);
            // 
            // empanadaBindingSource
            // 
            this.empanadaBindingSource.DataSource = typeof(Logica.Empanada);
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(199, 444);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(121, 22);
            this.textBoxConsulta.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "CONSULTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRMEmpanada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.textBoxConsulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridViewEmpanada);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrarempanada);
            this.Controls.Add(this.modifempanada);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMEmpanada";
            this.Text = "FRMEmpanada";
            this.Load += new System.EventHandler(this.FRMEmpanada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empanadaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empanadaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource empanadaBindingSource;
        private System.Windows.Forms.Button modifempanada;
        private System.Windows.Forms.Button borrarempanada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewEmpanada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEmpanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gustoEmpanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource empanadaBindingSource1;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Button button3;
    }
}
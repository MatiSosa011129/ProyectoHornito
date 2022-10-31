namespace Vista
{
    partial class FRMPedidosProceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPedidosProceso));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPedidos = new System.Windows.Forms.DataGridView();
            this.bVolverDePedidosBoM = new System.Windows.Forms.Button();
            this.bGuardarPedidoBoM = new System.Windows.Forms.Button();
            this.modifpedido = new System.Windows.Forms.Button();
            this.borrarpedido = new System.Windows.Forms.Button();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantEmpanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "PEDIDOS EN CURSO";
            // 
            // dataGridPedidos
            // 
            this.dataGridPedidos.AutoGenerateColumns = false;
            this.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.formaPagoDataGridViewTextBoxColumn,
            this.cantEmpanadaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.precioTotalDataGridViewTextBoxColumn,
            this.demoraDataGridViewTextBoxColumn});
            this.dataGridPedidos.DataSource = this.pedidoBindingSource1;
            this.dataGridPedidos.Location = new System.Drawing.Point(27, 116);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.RowHeadersWidth = 51;
            this.dataGridPedidos.RowTemplate.Height = 24;
            this.dataGridPedidos.Size = new System.Drawing.Size(800, 246);
            this.dataGridPedidos.TabIndex = 6;
            this.dataGridPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPedidos_CellContentClick);
            // 
            // bVolverDePedidosBoM
            // 
            this.bVolverDePedidosBoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolverDePedidosBoM.Location = new System.Drawing.Point(786, 455);
            this.bVolverDePedidosBoM.Name = "bVolverDePedidosBoM";
            this.bVolverDePedidosBoM.Size = new System.Drawing.Size(89, 33);
            this.bVolverDePedidosBoM.TabIndex = 7;
            this.bVolverDePedidosBoM.Text = "VOLVER";
            this.bVolverDePedidosBoM.UseVisualStyleBackColor = true;
            this.bVolverDePedidosBoM.Click += new System.EventHandler(this.bVolverDePedidosBoM_Click);
            // 
            // bGuardarPedidoBoM
            // 
            this.bGuardarPedidoBoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardarPedidoBoM.Location = new System.Drawing.Point(881, 455);
            this.bGuardarPedidoBoM.Name = "bGuardarPedidoBoM";
            this.bGuardarPedidoBoM.Size = new System.Drawing.Size(89, 33);
            this.bGuardarPedidoBoM.TabIndex = 8;
            this.bGuardarPedidoBoM.Text = "GUARDAR";
            this.bGuardarPedidoBoM.UseVisualStyleBackColor = true;
            this.bGuardarPedidoBoM.Click += new System.EventHandler(this.bGuardarPedidoBoM_Click);
            // 
            // modifpedido
            // 
            this.modifpedido.Location = new System.Drawing.Point(855, 196);
            this.modifpedido.Name = "modifpedido";
            this.modifpedido.Size = new System.Drawing.Size(89, 33);
            this.modifpedido.TabIndex = 12;
            this.modifpedido.Text = "MODIFICAR";
            this.modifpedido.UseVisualStyleBackColor = true;
            this.modifpedido.Click += new System.EventHandler(this.modifpedido_Click);
            // 
            // borrarpedido
            // 
            this.borrarpedido.Location = new System.Drawing.Point(855, 252);
            this.borrarpedido.Name = "borrarpedido";
            this.borrarpedido.Size = new System.Drawing.Size(89, 33);
            this.borrarpedido.TabIndex = 13;
            this.borrarpedido.Text = "BORRAR";
            this.borrarpedido.UseVisualStyleBackColor = true;
            this.borrarpedido.Click += new System.EventHandler(this.borrarpedido_Click);
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // formaPagoDataGridViewTextBoxColumn
            // 
            this.formaPagoDataGridViewTextBoxColumn.DataPropertyName = "formaPago";
            this.formaPagoDataGridViewTextBoxColumn.HeaderText = "formaPago";
            this.formaPagoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formaPagoDataGridViewTextBoxColumn.Name = "formaPagoDataGridViewTextBoxColumn";
            this.formaPagoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantEmpanadaDataGridViewTextBoxColumn
            // 
            this.cantEmpanadaDataGridViewTextBoxColumn.DataPropertyName = "cantEmpanada";
            this.cantEmpanadaDataGridViewTextBoxColumn.HeaderText = "cantEmpanada";
            this.cantEmpanadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantEmpanadaDataGridViewTextBoxColumn.Name = "cantEmpanadaDataGridViewTextBoxColumn";
            this.cantEmpanadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioTotalDataGridViewTextBoxColumn
            // 
            this.precioTotalDataGridViewTextBoxColumn.DataPropertyName = "precioTotal";
            this.precioTotalDataGridViewTextBoxColumn.HeaderText = "precioTotal";
            this.precioTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioTotalDataGridViewTextBoxColumn.Name = "precioTotalDataGridViewTextBoxColumn";
            this.precioTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // demoraDataGridViewTextBoxColumn
            // 
            this.demoraDataGridViewTextBoxColumn.DataPropertyName = "demora";
            this.demoraDataGridViewTextBoxColumn.HeaderText = "demora";
            this.demoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.demoraDataGridViewTextBoxColumn.Name = "demoraDataGridViewTextBoxColumn";
            this.demoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // pedidoBindingSource1
            // 
            this.pedidoBindingSource1.DataSource = typeof(Logica.Pedido);
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataSource = typeof(Logica.Pedido);
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(174, 445);
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(121, 22);
            this.textBoxConsulta.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "CONSULTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRMPedidosProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.textBoxConsulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.borrarpedido);
            this.Controls.Add(this.modifpedido);
            this.Controls.Add(this.bGuardarPedidoBoM);
            this.Controls.Add(this.bVolverDePedidosBoM);
            this.Controls.Add(this.dataGridPedidos);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 547);
            this.MinimumSize = new System.Drawing.Size(1000, 547);
            this.Name = "FRMPedidosProceso";
            this.Text = "FRMPedidosProceso";
            this.Load += new System.EventHandler(this.FRMPedidosProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantEmpanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private System.Windows.Forms.Button bVolverDePedidosBoM;
        private System.Windows.Forms.Button bGuardarPedidoBoM;
        private System.Windows.Forms.Button modifpedido;
        private System.Windows.Forms.Button borrarpedido;
        private System.Windows.Forms.BindingSource pedidoBindingSource1;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Button button3;
    }
}
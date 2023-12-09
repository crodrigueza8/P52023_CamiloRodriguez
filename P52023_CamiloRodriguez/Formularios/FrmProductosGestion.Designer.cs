namespace P52023_CamiloRodriguez.Formularios
{
    partial class FrmProductosGestion
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.DgvListaProductos = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProductoId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUtillidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidadStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.wdawd = new System.Windows.Forms.Label();
            this.TxtTasaImpuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CboxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.ColProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductoCategoriaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(609, 29);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(205, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(1170, 28);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(131, 17);
            this.CbVerActivos.TabIndex = 2;
            this.CbVerActivos.Text = "Ver Productos Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            this.DgvListaProductos.AllowUserToOrderColumns = true;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductoID,
            this.ColCodigoBarras,
            this.ColNombreProducto,
            this.ColCosto,
            this.ColUtilidad,
            this.ColSubTotal,
            this.ColTasaImpuesto,
            this.ColPrecioUnitario,
            this.ColCantidadStock,
            this.ColProductoCategoriaDescripcion});
            this.DgvListaProductos.Location = new System.Drawing.Point(309, 62);
            this.DgvListaProductos.MultiSelect = false;
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProductos.Size = new System.Drawing.Size(992, 574);
            this.DgvListaProductos.TabIndex = 3;
            this.DgvListaProductos.VirtualMode = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(69, 642);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 37);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(1087, 642);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(104, 37);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1197, 642);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbActivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboxCategoria);
            this.groupBox1.Controls.Add(this.TxtTasaImpuesto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtSubTotal);
            this.groupBox1.Controls.Add(this.wdawd);
            this.groupBox1.Controls.Add(this.TxtPrecioUnitario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtCantidadStock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtUtillidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtNombreProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtCodigoBarras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.TxtProductoId);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 624);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtProductoId
            // 
            this.TxtProductoId.AutoSize = true;
            this.TxtProductoId.Location = new System.Drawing.Point(6, 30);
            this.TxtProductoId.Name = "TxtProductoId";
            this.TxtProductoId.Size = new System.Drawing.Size(86, 13);
            this.TxtProductoId.TabIndex = 0;
            this.TxtProductoId.Text = "Código Producto";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(105, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TxtCodigoBarras
            // 
            this.TxtCodigoBarras.Location = new System.Drawing.Point(105, 131);
            this.TxtCodigoBarras.Name = "TxtCodigoBarras";
            this.TxtCodigoBarras.Size = new System.Drawing.Size(140, 20);
            this.TxtCodigoBarras.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código de barras";
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(105, 179);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(140, 20);
            this.TxtNombreProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Producto";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(105, 409);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(140, 20);
            this.TxtCosto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Costo";
            // 
            // TxtUtillidad
            // 
            this.TxtUtillidad.Location = new System.Drawing.Point(105, 460);
            this.TxtUtillidad.Name = "TxtUtillidad";
            this.TxtUtillidad.Size = new System.Drawing.Size(140, 20);
            this.TxtUtillidad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Utilidad";
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Location = new System.Drawing.Point(105, 293);
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.Size = new System.Drawing.Size(140, 20);
            this.TxtCantidadStock.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad Stock ";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(105, 352);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(140, 20);
            this.TxtPrecioUnitario.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio Unitario";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(105, 566);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(140, 20);
            this.TxtSubTotal.TabIndex = 15;
            // 
            // wdawd
            // 
            this.wdawd.AutoSize = true;
            this.wdawd.Location = new System.Drawing.Point(7, 566);
            this.wdawd.Name = "wdawd";
            this.wdawd.Size = new System.Drawing.Size(50, 13);
            this.wdawd.TabIndex = 14;
            this.wdawd.Text = "SubTotal";
            // 
            // TxtTasaImpuesto
            // 
            this.TxtTasaImpuesto.Location = new System.Drawing.Point(105, 513);
            this.TxtTasaImpuesto.Name = "TxtTasaImpuesto";
            this.TxtTasaImpuesto.Size = new System.Drawing.Size(140, 20);
            this.TxtTasaImpuesto.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tasa Impuesto";
            // 
            // CboxCategoria
            // 
            this.CboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategoria.FormattingEnabled = true;
            this.CboxCategoria.Location = new System.Drawing.Point(105, 236);
            this.CboxCategoria.Name = "CboxCategoria";
            this.CboxCategoria.Size = new System.Drawing.Size(140, 21);
            this.CboxCategoria.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Categoria";
            // 
            // CbActivo
            // 
            this.CbActivo.AutoSize = true;
            this.CbActivo.Enabled = false;
            this.CbActivo.Location = new System.Drawing.Point(105, 76);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(56, 17);
            this.CbActivo.TabIndex = 20;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // ColProductoID
            // 
            this.ColProductoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColProductoID.DataPropertyName = "ProductoID";
            this.ColProductoID.HeaderText = "Código";
            this.ColProductoID.Name = "ColProductoID";
            this.ColProductoID.ReadOnly = true;
            this.ColProductoID.Width = 80;
            // 
            // ColCodigoBarras
            // 
            this.ColCodigoBarras.DataPropertyName = "CodigoBarras";
            this.ColCodigoBarras.HeaderText = "Código Barras";
            this.ColCodigoBarras.Name = "ColCodigoBarras";
            this.ColCodigoBarras.ReadOnly = true;
            // 
            // ColNombreProducto
            // 
            this.ColNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreProducto.DataPropertyName = "NombreProducto";
            this.ColNombreProducto.HeaderText = "Nombre";
            this.ColNombreProducto.Name = "ColNombreProducto";
            this.ColNombreProducto.ReadOnly = true;
            // 
            // ColCosto
            // 
            this.ColCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCosto.DataPropertyName = "Costo";
            this.ColCosto.HeaderText = "Costo";
            this.ColCosto.Name = "ColCosto";
            this.ColCosto.ReadOnly = true;
            this.ColCosto.Width = 70;
            // 
            // ColUtilidad
            // 
            this.ColUtilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUtilidad.DataPropertyName = "Utilidad";
            this.ColUtilidad.HeaderText = "Utilidad";
            this.ColUtilidad.Name = "ColUtilidad";
            this.ColUtilidad.ReadOnly = true;
            this.ColUtilidad.Width = 70;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSubTotal.DataPropertyName = "SubTotal";
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 70;
            // 
            // ColTasaImpuesto
            // 
            this.ColTasaImpuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.ColTasaImpuesto.HeaderText = "Tasa Impuesto";
            this.ColTasaImpuesto.Name = "ColTasaImpuesto";
            this.ColTasaImpuesto.ReadOnly = true;
            this.ColTasaImpuesto.Width = 70;
            // 
            // ColPrecioUnitario
            // 
            this.ColPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.ColPrecioUnitario.HeaderText = "Precio Unitario";
            this.ColPrecioUnitario.Name = "ColPrecioUnitario";
            this.ColPrecioUnitario.ReadOnly = true;
            this.ColPrecioUnitario.Width = 70;
            // 
            // ColCantidadStock
            // 
            this.ColCantidadStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCantidadStock.DataPropertyName = "CantidadStock";
            this.ColCantidadStock.HeaderText = "Stock";
            this.ColCantidadStock.Name = "ColCantidadStock";
            this.ColCantidadStock.ReadOnly = true;
            this.ColCantidadStock.Width = 70;
            // 
            // ColProductoCategoriaDescripcion
            // 
            this.ColProductoCategoriaDescripcion.DataPropertyName = "ProductoCategoriaDescripcion";
            this.ColProductoCategoriaDescripcion.HeaderText = "Categoría";
            this.ColProductoCategoriaDescripcion.Name = "ColProductoCategoriaDescripcion";
            this.ColProductoCategoriaDescripcion.ReadOnly = true;
            // 
            // FrmProductosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 691);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvListaProductos);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductosGestion";
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.FrmProductosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.DataGridView DgvListaProductos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TxtProductoId;
        private System.Windows.Forms.TextBox TxtTasaImpuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label wdawd;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCantidadStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUtillidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigoBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxCategoria;
        private System.Windows.Forms.CheckBox CbActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUtilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoCategoriaDescripcion;
    }
}
﻿namespace P52023_CamiloRodriguez.Formularios
{
    partial class FrmMovimientosInventarioDetalleProducto
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLable1 = new System.Windows.Forms.Label();
            this.NtxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NtxtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(209, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(330, 26);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProductoID,
            this.CCodigoBarras,
            this.CNombreProducto,
            this.CCosto,
            this.CSubTotal,
            this.CTasaImpuesto,
            this.CPrecioUnitario,
            this.CCantidadStock});
            this.DgvLista.Location = new System.Drawing.Point(12, 44);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(694, 289);
            this.DgvLista.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.NtxtCantidad);
            this.panel1.Controls.Add(this.LblLable1);
            this.panel1.Location = new System.Drawing.Point(9, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 119);
            this.panel1.TabIndex = 2;
            // 
            // LblLable1
            // 
            this.LblLable1.AutoSize = true;
            this.LblLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLable1.ForeColor = System.Drawing.Color.White;
            this.LblLable1.Location = new System.Drawing.Point(248, 0);
            this.LblLable1.Name = "LblLable1";
            this.LblLable1.Size = new System.Drawing.Size(251, 24);
            this.LblLable1.TabIndex = 0;
            this.LblLable1.Text = "CANTIDAD MOVIMIENTO";
            // 
            // NtxtCantidad
            // 
            this.NtxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NtxtCantidad.Location = new System.Drawing.Point(314, 53);
            this.NtxtCantidad.Name = "NtxtCantidad";
            this.NtxtCantidad.Size = new System.Drawing.Size(120, 31);
            this.NtxtCantidad.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(12, 475);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(371, 39);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(389, 475);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(317, 39);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CProductoID
            // 
            this.CProductoID.DataPropertyName = "ProductoID";
            this.CProductoID.HeaderText = "Cód. Producto";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            // 
            // CCodigoBarras
            // 
            this.CCodigoBarras.DataPropertyName = "CodigoBarras";
            this.CCodigoBarras.HeaderText = "Cód. Barras";
            this.CCodigoBarras.Name = "CCodigoBarras";
            this.CCodigoBarras.ReadOnly = true;
            // 
            // CNombreProducto
            // 
            this.CNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombreProducto.DataPropertyName = "NombreProducto";
            this.CNombreProducto.HeaderText = "Producto";
            this.CNombreProducto.Name = "CNombreProducto";
            this.CNombreProducto.ReadOnly = true;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Visible = false;
            // 
            // CSubTotal
            // 
            this.CSubTotal.DataPropertyName = "SubTotal";
            this.CSubTotal.HeaderText = "SubTotal";
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.ReadOnly = true;
            this.CSubTotal.Visible = false;
            // 
            // CTasaImpuesto
            // 
            this.CTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.CTasaImpuesto.HeaderText = "%IVA";
            this.CTasaImpuesto.Name = "CTasaImpuesto";
            this.CTasaImpuesto.ReadOnly = true;
            this.CTasaImpuesto.Visible = false;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio Unitario";
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.ReadOnly = true;
            // 
            // CCantidadStock
            // 
            this.CCantidadStock.DataPropertyName = "CantidadStock";
            this.CCantidadStock.HeaderText = "Stock";
            this.CCantidadStock.Name = "CCantidadStock";
            this.CCantidadStock.ReadOnly = true;
            // 
            // FrmMovimientosInventarioDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(722, 526);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMovimientosInventarioDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de producto";
            this.Load += new System.EventHandler(this.FrmMovimientosInventarioDetalleProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NtxtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NtxtCantidad;
        private System.Windows.Forms.Label LblLable1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadStock;
    }
}
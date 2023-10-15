﻿namespace P52023_CamiloRodriguez.Formularios
{
    partial class FrmUsuariosGestion
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
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.ColUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbUsuarioActivo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.TxtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.TxtUsuarioContrasennia = new System.Windows.Forms.TextBox();
            this.CboxUsuarioRol = new System.Windows.Forms.ComboBox();
            this.TxtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.TxtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtUsuarioCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(238, 13);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(340, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(651, 16);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(124, 17);
            this.CbVerActivos.TabIndex = 3;
            this.CbVerActivos.Text = "Ver Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.AllowUserToOrderColumns = true;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUsuarioID,
            this.ColCedula,
            this.ColNombre,
            this.ColCorreo,
            this.ColTelefono,
            this.ColRol});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(12, 52);
            this.DgvListaUsuarios.MultiSelect = false;
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(769, 199);
            this.DgvListaUsuarios.TabIndex = 4;
            this.DgvListaUsuarios.VirtualMode = true;
            // 
            // ColUsuarioID
            // 
            this.ColUsuarioID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUsuarioID.DataPropertyName = "UsuarioID";
            this.ColUsuarioID.HeaderText = "CÓDIGO";
            this.ColUsuarioID.Name = "ColUsuarioID";
            this.ColUsuarioID.ReadOnly = true;
            this.ColUsuarioID.Width = 80;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "CÉDULA";
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "NOMBRE";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCorreo.DataPropertyName = "Correo";
            this.ColCorreo.HeaderText = "CORREO";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            this.ColCorreo.Width = 120;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "TELÉFONO";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColRol
            // 
            this.ColRol.DataPropertyName = "Rol";
            this.ColRol.HeaderText = "ROL DE USUARIO";
            this.ColRol.Name = "ColRol";
            this.ColRol.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbUsuarioActivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.TxtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.TxtUsuarioContrasennia);
            this.groupBox1.Controls.Add(this.CboxUsuarioRol);
            this.groupBox1.Controls.Add(this.TxtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.TxtUsuarioNombre);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.TxtUsuarioCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            // 
            // CbUsuarioActivo
            // 
            this.CbUsuarioActivo.AutoSize = true;
            this.CbUsuarioActivo.Enabled = false;
            this.CbUsuarioActivo.Location = new System.Drawing.Point(271, 49);
            this.CbUsuarioActivo.Name = "CbUsuarioActivo";
            this.CbUsuarioActivo.Size = new System.Drawing.Size(56, 17);
            this.CbUsuarioActivo.TabIndex = 16;
            this.CbUsuarioActivo.Text = "Activo";
            this.CbUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dirección";
            // 
            // TxtUsuarioDireccion
            // 
            this.TxtUsuarioDireccion.Location = new System.Drawing.Point(404, 146);
            this.TxtUsuarioDireccion.Multiline = true;
            this.TxtUsuarioDireccion.Name = "TxtUsuarioDireccion";
            this.TxtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUsuarioDireccion.Size = new System.Drawing.Size(333, 126);
            this.TxtUsuarioDireccion.TabIndex = 14;
            // 
            // TxtUsuarioTelefono
            // 
            this.TxtUsuarioTelefono.Location = new System.Drawing.Point(34, 252);
            this.TxtUsuarioTelefono.Name = "TxtUsuarioTelefono";
            this.TxtUsuarioTelefono.Size = new System.Drawing.Size(293, 20);
            this.TxtUsuarioTelefono.TabIndex = 13;
            // 
            // TxtUsuarioContrasennia
            // 
            this.TxtUsuarioContrasennia.Location = new System.Drawing.Point(404, 96);
            this.TxtUsuarioContrasennia.Name = "TxtUsuarioContrasennia";
            this.TxtUsuarioContrasennia.Size = new System.Drawing.Size(333, 20);
            this.TxtUsuarioContrasennia.TabIndex = 12;
            // 
            // CboxUsuarioRol
            // 
            this.CboxUsuarioRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxUsuarioRol.FormattingEnabled = true;
            this.CboxUsuarioRol.Location = new System.Drawing.Point(404, 45);
            this.CboxUsuarioRol.Name = "CboxUsuarioRol";
            this.CboxUsuarioRol.Size = new System.Drawing.Size(333, 21);
            this.CboxUsuarioRol.TabIndex = 11;
            // 
            // TxtUsuarioCorreo
            // 
            this.TxtUsuarioCorreo.Location = new System.Drawing.Point(34, 202);
            this.TxtUsuarioCorreo.Name = "TxtUsuarioCorreo";
            this.TxtUsuarioCorreo.Size = new System.Drawing.Size(293, 20);
            this.TxtUsuarioCorreo.TabIndex = 10;
            // 
            // TxtUsuarioNombre
            // 
            this.TxtUsuarioNombre.Location = new System.Drawing.Point(34, 146);
            this.TxtUsuarioNombre.Name = "TxtUsuarioNombre";
            this.TxtUsuarioNombre.Size = new System.Drawing.Size(293, 20);
            this.TxtUsuarioNombre.TabIndex = 9;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(34, 96);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(293, 20);
            this.TxtCedula.TabIndex = 8;
            // 
            // TxtUsuarioCodigo
            // 
            this.TxtUsuarioCodigo.Enabled = false;
            this.TxtUsuarioCodigo.Location = new System.Drawing.Point(34, 46);
            this.TxtUsuarioCodigo.Name = "TxtUsuarioCodigo";
            this.TxtUsuarioCodigo.Size = new System.Drawing.Size(231, 20);
            this.TxtUsuarioCodigo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Usuario";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAgregar.Location = new System.Drawing.Point(47, 551);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(102, 38);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.BtnModificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnModificar.Location = new System.Drawing.Point(168, 551);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(98, 38);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.BtnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEliminar.Location = new System.Drawing.Point(284, 550);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 39);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLimpiar.Location = new System.Drawing.Point(557, 550);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(89, 39);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.BtnCerrar.BackColor = System.Drawing.Color.Sienna;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCerrar.Location = new System.Drawing.Point(652, 550);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(98, 39);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 601);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaUsuarios);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtUsuarioCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboxUsuarioRol;
        private System.Windows.Forms.TextBox TxtUsuarioCorreo;
        private System.Windows.Forms.TextBox TxtUsuarioNombre;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUsuarioDireccion;
        private System.Windows.Forms.TextBox TxtUsuarioTelefono;
        private System.Windows.Forms.TextBox TxtUsuarioContrasennia;
        private System.Windows.Forms.CheckBox CbUsuarioActivo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRol;
    }
}
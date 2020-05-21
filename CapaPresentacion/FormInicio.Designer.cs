namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.SubmenuPersonal = new System.Windows.Forms.Panel();
            this.BtnEstado = new System.Windows.Forms.Button();
            this.BtnAscenso = new System.Windows.Forms.Button();
            this.BtnPromocion = new System.Windows.Forms.Button();
            this.BtnSoldado = new System.Windows.Forms.Button();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.SubmenuServicios = new System.Windows.Forms.Panel();
            this.BtnServSemanal = new System.Windows.Forms.Button();
            this.BtnServDiario = new System.Windows.Forms.Button();
            this.BtnAgregarServicio = new System.Windows.Forms.Button();
            this.BtnServicio = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BtnSalirSistema = new System.Windows.Forms.PictureBox();
            this.PanelMenuLateral.SuspendLayout();
            this.SubmenuPersonal.SuspendLayout();
            this.SubmenuServicios.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.AutoScroll = true;
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(171)))), ((int)(((byte)(96)))));
            this.PanelMenuLateral.Controls.Add(this.BtnSalirSistema);
            this.PanelMenuLateral.Controls.Add(this.BtnCerrarSesion);
            this.PanelMenuLateral.Controls.Add(this.BtnUsuario);
            this.PanelMenuLateral.Controls.Add(this.SubmenuPersonal);
            this.PanelMenuLateral.Controls.Add(this.BtnPersonal);
            this.PanelMenuLateral.Controls.Add(this.SubmenuServicios);
            this.PanelMenuLateral.Controls.Add(this.BtnServicio);
            this.PanelMenuLateral.Controls.Add(this.PanelLogo);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(213, 576);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 516);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(213, 43);
            this.BtnCerrarSesion.TabIndex = 8;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsuario.Location = new System.Drawing.Point(0, 473);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(213, 43);
            this.BtnUsuario.TabIndex = 5;
            this.BtnUsuario.Text = "Usuarios";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // SubmenuPersonal
            // 
            this.SubmenuPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(106)))), ((int)(((byte)(11)))));
            this.SubmenuPersonal.Controls.Add(this.BtnEstado);
            this.SubmenuPersonal.Controls.Add(this.BtnAscenso);
            this.SubmenuPersonal.Controls.Add(this.BtnPromocion);
            this.SubmenuPersonal.Controls.Add(this.BtnSoldado);
            this.SubmenuPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuPersonal.Location = new System.Drawing.Point(0, 302);
            this.SubmenuPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmenuPersonal.Name = "SubmenuPersonal";
            this.SubmenuPersonal.Size = new System.Drawing.Size(213, 171);
            this.SubmenuPersonal.TabIndex = 4;
            // 
            // BtnEstado
            // 
            this.BtnEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstado.FlatAppearance.BorderSize = 0;
            this.BtnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEstado.Location = new System.Drawing.Point(0, 129);
            this.BtnEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEstado.Name = "BtnEstado";
            this.BtnEstado.Size = new System.Drawing.Size(213, 43);
            this.BtnEstado.TabIndex = 3;
            this.BtnEstado.Text = "Estado de Personal";
            this.BtnEstado.UseVisualStyleBackColor = true;
            this.BtnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // BtnAscenso
            // 
            this.BtnAscenso.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAscenso.FlatAppearance.BorderSize = 0;
            this.BtnAscenso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAscenso.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAscenso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAscenso.Location = new System.Drawing.Point(0, 86);
            this.BtnAscenso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAscenso.Name = "BtnAscenso";
            this.BtnAscenso.Size = new System.Drawing.Size(213, 43);
            this.BtnAscenso.TabIndex = 2;
            this.BtnAscenso.Text = "Ascensos";
            this.BtnAscenso.UseVisualStyleBackColor = true;
            this.BtnAscenso.Click += new System.EventHandler(this.BtnAscenso_Click);
            // 
            // BtnPromocion
            // 
            this.BtnPromocion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPromocion.FlatAppearance.BorderSize = 0;
            this.BtnPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPromocion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPromocion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPromocion.Location = new System.Drawing.Point(0, 43);
            this.BtnPromocion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPromocion.Name = "BtnPromocion";
            this.BtnPromocion.Size = new System.Drawing.Size(213, 43);
            this.BtnPromocion.TabIndex = 1;
            this.BtnPromocion.Text = "Promoción";
            this.BtnPromocion.UseVisualStyleBackColor = true;
            this.BtnPromocion.Click += new System.EventHandler(this.BtnPromocion_Click);
            // 
            // BtnSoldado
            // 
            this.BtnSoldado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSoldado.FlatAppearance.BorderSize = 0;
            this.BtnSoldado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoldado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoldado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSoldado.Location = new System.Drawing.Point(0, 0);
            this.BtnSoldado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSoldado.Name = "BtnSoldado";
            this.BtnSoldado.Size = new System.Drawing.Size(213, 43);
            this.BtnSoldado.TabIndex = 0;
            this.BtnSoldado.Text = "Soldados";
            this.BtnSoldado.UseVisualStyleBackColor = true;
            this.BtnSoldado.Click += new System.EventHandler(this.BtnSoldado_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 259);
            this.BtnPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(213, 43);
            this.BtnPersonal.TabIndex = 3;
            this.BtnPersonal.Text = "Personal de Tropa";
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // SubmenuServicios
            // 
            this.SubmenuServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(106)))), ((int)(((byte)(11)))));
            this.SubmenuServicios.Controls.Add(this.BtnServSemanal);
            this.SubmenuServicios.Controls.Add(this.BtnServDiario);
            this.SubmenuServicios.Controls.Add(this.BtnAgregarServicio);
            this.SubmenuServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuServicios.Location = new System.Drawing.Point(0, 127);
            this.SubmenuServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmenuServicios.Name = "SubmenuServicios";
            this.SubmenuServicios.Size = new System.Drawing.Size(213, 132);
            this.SubmenuServicios.TabIndex = 2;
            // 
            // BtnServSemanal
            // 
            this.BtnServSemanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnServSemanal.FlatAppearance.BorderSize = 0;
            this.BtnServSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServSemanal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServSemanal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnServSemanal.Location = new System.Drawing.Point(0, 86);
            this.BtnServSemanal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnServSemanal.Name = "BtnServSemanal";
            this.BtnServSemanal.Size = new System.Drawing.Size(213, 43);
            this.BtnServSemanal.TabIndex = 2;
            this.BtnServSemanal.Text = "Servicio Semanal";
            this.BtnServSemanal.UseVisualStyleBackColor = true;
            this.BtnServSemanal.Click += new System.EventHandler(this.BtnServSemanal_Click);
            // 
            // BtnServDiario
            // 
            this.BtnServDiario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnServDiario.FlatAppearance.BorderSize = 0;
            this.BtnServDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServDiario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServDiario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnServDiario.Location = new System.Drawing.Point(0, 43);
            this.BtnServDiario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnServDiario.Name = "BtnServDiario";
            this.BtnServDiario.Size = new System.Drawing.Size(213, 43);
            this.BtnServDiario.TabIndex = 1;
            this.BtnServDiario.Text = "Servicio Diario";
            this.BtnServDiario.UseVisualStyleBackColor = true;
            this.BtnServDiario.Click += new System.EventHandler(this.BtnServDiario_Click);
            // 
            // BtnAgregarServicio
            // 
            this.BtnAgregarServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.BtnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarServicio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregarServicio.Location = new System.Drawing.Point(0, 0);
            this.BtnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgregarServicio.Name = "BtnAgregarServicio";
            this.BtnAgregarServicio.Size = new System.Drawing.Size(213, 43);
            this.BtnAgregarServicio.TabIndex = 0;
            this.BtnAgregarServicio.Text = "Agregar Servicio";
            this.BtnAgregarServicio.UseVisualStyleBackColor = true;
            this.BtnAgregarServicio.Click += new System.EventHandler(this.BtnAgregarServicio_Click);
            // 
            // BtnServicio
            // 
            this.BtnServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnServicio.FlatAppearance.BorderSize = 0;
            this.BtnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnServicio.Location = new System.Drawing.Point(0, 84);
            this.BtnServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnServicio.Name = "BtnServicio";
            this.BtnServicio.Size = new System.Drawing.Size(213, 43);
            this.BtnServicio.TabIndex = 1;
            this.BtnServicio.Text = "Servicios";
            this.BtnServicio.UseVisualStyleBackColor = true;
            this.BtnServicio.Click += new System.EventHandler(this.BtnServicio_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.Teal;
            this.PanelLogo.Controls.Add(this.LabelTipo);
            this.PanelLogo.Controls.Add(this.LabelUsuario);
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(213, 84);
            this.PanelLogo.TabIndex = 0;
            // 
            // LabelTipo
            // 
            this.LabelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTipo.ForeColor = System.Drawing.Color.Yellow;
            this.LabelTipo.Location = new System.Drawing.Point(93, 50);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(36, 15);
            this.LabelTipo.TabIndex = 2;
            this.LabelTipo.Text = "Tipo";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.LabelUsuario.Location = new System.Drawing.Point(93, 15);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(57, 15);
            this.LabelUsuario.TabIndex = 1;
            this.LabelUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(87, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSize = true;
            this.PanelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(22)))), ((int)(((byte)(82)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(213, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(851, 576);
            this.PanelContenedor.TabIndex = 1;
            // 
            // BtnSalirSistema
            // 
            this.BtnSalirSistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSalirSistema.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalirSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirSistema.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalirSistema.Image")));
            this.BtnSalirSistema.Location = new System.Drawing.Point(89, 528);
            this.BtnSalirSistema.Name = "BtnSalirSistema";
            this.BtnSalirSistema.Size = new System.Drawing.Size(35, 35);
            this.BtnSalirSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalirSistema.TabIndex = 9;
            this.BtnSalirSistema.TabStop = false;
            this.BtnSalirSistema.Click += new System.EventHandler(this.BtnSalirSistema_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenuLateral);
            this.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(913, 487);
            this.Name = "FormInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.PanelMenuLateral.ResumeLayout(false);
            this.SubmenuPersonal.ResumeLayout(false);
            this.SubmenuServicios.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Panel SubmenuPersonal;
        private System.Windows.Forms.Button BtnEstado;
        private System.Windows.Forms.Button BtnAscenso;
        private System.Windows.Forms.Button BtnPromocion;
        private System.Windows.Forms.Button BtnSoldado;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Panel SubmenuServicios;
        private System.Windows.Forms.Button BtnServSemanal;
        private System.Windows.Forms.Button BtnServDiario;
        private System.Windows.Forms.Button BtnAgregarServicio;
        private System.Windows.Forms.Button BtnServicio;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.PictureBox BtnSalirSistema;
    }
}
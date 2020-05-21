namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicio));
            this.PanelTabla1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTabla2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVServicio = new System.Windows.Forms.DataGridView();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.Icono = new System.Windows.Forms.PictureBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbtipo = new System.Windows.Forms.ComboBox();
            this.Tbnombre = new System.Windows.Forms.TextBox();
            this.Tbid = new System.Windows.Forms.TextBox();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVServicio)).BeginInit();
            this.PanelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTabla1
            // 
            this.PanelTabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTabla1.BackColor = System.Drawing.Color.DarkCyan;
            this.PanelTabla1.ColumnCount = 2;
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.2029F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.7971F));
            this.PanelTabla1.Controls.Add(this.PanelTabla2, 1, 0);
            this.PanelTabla1.Controls.Add(this.LOGO, 0, 0);
            this.PanelTabla1.Location = new System.Drawing.Point(12, 37);
            this.PanelTabla1.Name = "PanelTabla1";
            this.PanelTabla1.RowCount = 1;
            this.PanelTabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla1.Size = new System.Drawing.Size(776, 373);
            this.PanelTabla1.TabIndex = 0;
            // 
            // PanelTabla2
            // 
            this.PanelTabla2.ColumnCount = 1;
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.Controls.Add(this.DGVServicio, 0, 1);
            this.PanelTabla2.Controls.Add(this.PanelFormulario, 0, 0);
            this.PanelTabla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla2.Location = new System.Drawing.Point(343, 0);
            this.PanelTabla2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla2.Name = "PanelTabla2";
            this.PanelTabla2.RowCount = 2;
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.74263F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.25737F));
            this.PanelTabla2.Size = new System.Drawing.Size(433, 373);
            this.PanelTabla2.TabIndex = 0;
            // 
            // DGVServicio
            // 
            this.DGVServicio.AllowUserToAddRows = false;
            this.DGVServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVServicio.Location = new System.Drawing.Point(3, 196);
            this.DGVServicio.Name = "DGVServicio";
            this.DGVServicio.ReadOnly = true;
            this.DGVServicio.RowHeadersVisible = false;
            this.DGVServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVServicio.Size = new System.Drawing.Size(427, 174);
            this.DGVServicio.TabIndex = 0;
            this.DGVServicio.MouseCaptureChanged += new System.EventHandler(this.DGVServicio_MouseCaptureChanged);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Controls.Add(this.Icono);
            this.PanelFormulario.Controls.Add(this.BtnModificar);
            this.PanelFormulario.Controls.Add(this.BtnEliminar);
            this.PanelFormulario.Controls.Add(this.BtnGuardar);
            this.PanelFormulario.Controls.Add(this.label3);
            this.PanelFormulario.Controls.Add(this.label2);
            this.PanelFormulario.Controls.Add(this.label1);
            this.PanelFormulario.Controls.Add(this.Cbtipo);
            this.PanelFormulario.Controls.Add(this.Tbnombre);
            this.PanelFormulario.Controls.Add(this.Tbid);
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(3, 3);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(427, 187);
            this.PanelFormulario.TabIndex = 1;
            // 
            // Icono
            // 
            this.Icono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Icono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icono.Image = ((System.Drawing.Image)(resources.GetObject("Icono.Image")));
            this.Icono.Location = new System.Drawing.Point(304, 41);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(25, 25);
            this.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono.TabIndex = 9;
            this.Icono.TabStop = false;
            this.Icono.Click += new System.EventHandler(this.Icono_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.DimGray;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnModificar.Location = new System.Drawing.Point(176, 139);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(80, 30);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Location = new System.Drawing.Point(262, 139);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 30);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Location = new System.Drawing.Point(90, 139);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(80, 30);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // Cbtipo
            // 
            this.Cbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbtipo.FormattingEnabled = true;
            this.Cbtipo.Location = new System.Drawing.Point(177, 83);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(121, 21);
            this.Cbtipo.TabIndex = 2;
            // 
            // Tbnombre
            // 
            this.Tbnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbnombre.Location = new System.Drawing.Point(177, 46);
            this.Tbnombre.Name = "Tbnombre";
            this.Tbnombre.Size = new System.Drawing.Size(121, 20);
            this.Tbnombre.TabIndex = 1;
            // 
            // Tbid
            // 
            this.Tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbid.Enabled = false;
            this.Tbid.Location = new System.Drawing.Point(177, 14);
            this.Tbid.Name = "Tbid";
            this.Tbid.ReadOnly = true;
            this.Tbid.Size = new System.Drawing.Size(121, 20);
            this.Tbid.TabIndex = 0;
            // 
            // LOGO
            // 
            this.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOGO.Image = ((System.Drawing.Image)(resources.GetObject("LOGO.Image")));
            this.LOGO.Location = new System.Drawing.Point(53, 49);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(237, 275);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGO.TabIndex = 1;
            this.LOGO.TabStop = false;
            // 
            // FormServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.PanelTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicio";
            this.Text = "FormServicio";
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVServicio)).EndInit();
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.DataGridView DGVServicio;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbtipo;
        private System.Windows.Forms.TextBox Tbnombre;
        private System.Windows.Forms.TextBox Tbid;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.PictureBox Icono;
    }
}
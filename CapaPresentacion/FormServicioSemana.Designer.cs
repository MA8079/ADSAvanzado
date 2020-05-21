namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormServicioSemana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicioSemana));
            this.PanelTabla1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTabla2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVSold_Disponible = new System.Windows.Forms.DataGridView();
            this.DGVServ_Semana = new System.Windows.Forms.DataGridView();
            this.PanelTabla3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTfin = new System.Windows.Forms.DateTimePicker();
            this.DTinicio = new System.Windows.Forms.DateTimePicker();
            this.Cbservicio = new System.Windows.Forms.ComboBox();
            this.Cbsoldado = new System.Windows.Forms.ComboBox();
            this.Tbid = new System.Windows.Forms.TextBox();
            this.Tbapellido = new System.Windows.Forms.TextBox();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSold_Disponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVServ_Semana)).BeginInit();
            this.PanelTabla3.SuspendLayout();
            this.PanelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTabla1
            // 
            this.PanelTabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTabla1.ColumnCount = 2;
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.85052F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.14948F));
            this.PanelTabla1.Controls.Add(this.PanelTabla2, 0, 0);
            this.PanelTabla1.Controls.Add(this.PanelTabla3, 1, 0);
            this.PanelTabla1.Location = new System.Drawing.Point(12, 12);
            this.PanelTabla1.Name = "PanelTabla1";
            this.PanelTabla1.RowCount = 1;
            this.PanelTabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla1.Size = new System.Drawing.Size(776, 432);
            this.PanelTabla1.TabIndex = 0;
            // 
            // PanelTabla2
            // 
            this.PanelTabla2.BackColor = System.Drawing.Color.Crimson;
            this.PanelTabla2.ColumnCount = 1;
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.Controls.Add(this.DGVSold_Disponible, 0, 0);
            this.PanelTabla2.Controls.Add(this.DGVServ_Semana, 0, 1);
            this.PanelTabla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla2.Location = new System.Drawing.Point(0, 0);
            this.PanelTabla2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla2.Name = "PanelTabla2";
            this.PanelTabla2.RowCount = 2;
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.Size = new System.Drawing.Size(511, 432);
            this.PanelTabla2.TabIndex = 0;
            // 
            // DGVSold_Disponible
            // 
            this.DGVSold_Disponible.AllowUserToAddRows = false;
            this.DGVSold_Disponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSold_Disponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSold_Disponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSold_Disponible.Location = new System.Drawing.Point(3, 3);
            this.DGVSold_Disponible.Name = "DGVSold_Disponible";
            this.DGVSold_Disponible.ReadOnly = true;
            this.DGVSold_Disponible.RowHeadersVisible = false;
            this.DGVSold_Disponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSold_Disponible.Size = new System.Drawing.Size(505, 210);
            this.DGVSold_Disponible.TabIndex = 0;
            // 
            // DGVServ_Semana
            // 
            this.DGVServ_Semana.AllowUserToAddRows = false;
            this.DGVServ_Semana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVServ_Semana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVServ_Semana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVServ_Semana.Location = new System.Drawing.Point(3, 219);
            this.DGVServ_Semana.Name = "DGVServ_Semana";
            this.DGVServ_Semana.ReadOnly = true;
            this.DGVServ_Semana.RowHeadersVisible = false;
            this.DGVServ_Semana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVServ_Semana.Size = new System.Drawing.Size(505, 210);
            this.DGVServ_Semana.TabIndex = 1;
            this.DGVServ_Semana.MouseCaptureChanged += new System.EventHandler(this.DGVServ_Semana_MouseCaptureChanged);
            // 
            // PanelTabla3
            // 
            this.PanelTabla3.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelTabla3.ColumnCount = 1;
            this.PanelTabla3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla3.Controls.Add(this.BtnGuardar, 0, 1);
            this.PanelTabla3.Controls.Add(this.BtnModificar, 0, 2);
            this.PanelTabla3.Controls.Add(this.BtnEliminar, 0, 3);
            this.PanelTabla3.Controls.Add(this.PanelFormulario, 0, 0);
            this.PanelTabla3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla3.Location = new System.Drawing.Point(511, 0);
            this.PanelTabla3.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla3.Name = "PanelTabla3";
            this.PanelTabla3.RowCount = 4;
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.Size = new System.Drawing.Size(265, 432);
            this.PanelTabla3.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(3, 305);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(259, 37);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Gray;
            this.BtnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(3, 348);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(259, 37);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(3, 391);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(259, 38);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Controls.Add(this.Tbapellido);
            this.PanelFormulario.Controls.Add(this.BtnLimpiar);
            this.PanelFormulario.Controls.Add(this.label5);
            this.PanelFormulario.Controls.Add(this.label4);
            this.PanelFormulario.Controls.Add(this.label3);
            this.PanelFormulario.Controls.Add(this.label2);
            this.PanelFormulario.Controls.Add(this.label1);
            this.PanelFormulario.Controls.Add(this.DTfin);
            this.PanelFormulario.Controls.Add(this.DTinicio);
            this.PanelFormulario.Controls.Add(this.Cbservicio);
            this.PanelFormulario.Controls.Add(this.Cbsoldado);
            this.PanelFormulario.Controls.Add(this.Tbid);
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(265, 302);
            this.PanelFormulario.TabIndex = 3;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(115, 266);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(35, 35);
            this.BtnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.TabStop = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Finaliza";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inicia";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soldado";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // DTfin
            // 
            this.DTfin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTfin.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfin.Location = new System.Drawing.Point(118, 222);
            this.DTfin.Name = "DTfin";
            this.DTfin.Size = new System.Drawing.Size(100, 23);
            this.DTfin.TabIndex = 4;
            // 
            // DTinicio
            // 
            this.DTinicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTinicio.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTinicio.Location = new System.Drawing.Point(118, 181);
            this.DTinicio.Name = "DTinicio";
            this.DTinicio.Size = new System.Drawing.Size(100, 23);
            this.DTinicio.TabIndex = 3;
            // 
            // Cbservicio
            // 
            this.Cbservicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbservicio.FormattingEnabled = true;
            this.Cbservicio.Location = new System.Drawing.Point(118, 141);
            this.Cbservicio.Name = "Cbservicio";
            this.Cbservicio.Size = new System.Drawing.Size(100, 21);
            this.Cbservicio.TabIndex = 2;
            // 
            // Cbsoldado
            // 
            this.Cbsoldado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbsoldado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbsoldado.FormattingEnabled = true;
            this.Cbsoldado.Location = new System.Drawing.Point(118, 97);
            this.Cbsoldado.Name = "Cbsoldado";
            this.Cbsoldado.Size = new System.Drawing.Size(100, 21);
            this.Cbsoldado.TabIndex = 1;
            // 
            // Tbid
            // 
            this.Tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbid.Location = new System.Drawing.Point(118, 50);
            this.Tbid.Name = "Tbid";
            this.Tbid.Size = new System.Drawing.Size(100, 20);
            this.Tbid.TabIndex = 0;
            // 
            // Tbapellido
            // 
            this.Tbapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbapellido.Location = new System.Drawing.Point(118, 97);
            this.Tbapellido.Name = "Tbapellido";
            this.Tbapellido.Size = new System.Drawing.Size(100, 20);
            this.Tbapellido.TabIndex = 11;
            this.Tbapellido.Visible = false;
            // 
            // FormServicioSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.PanelTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicioSemana";
            this.Text = "FormServicioSemana";
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSold_Disponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVServ_Semana)).EndInit();
            this.PanelTabla3.ResumeLayout(false);
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.DataGridView DGVSold_Disponible;
        private System.Windows.Forms.DataGridView DGVServ_Semana;
        private System.Windows.Forms.TableLayoutPanel PanelTabla3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTfin;
        private System.Windows.Forms.DateTimePicker DTinicio;
        private System.Windows.Forms.ComboBox Cbservicio;
        private System.Windows.Forms.ComboBox Cbsoldado;
        private System.Windows.Forms.TextBox Tbid;
        private System.Windows.Forms.PictureBox BtnLimpiar;
        private System.Windows.Forms.TextBox Tbapellido;
    }
}
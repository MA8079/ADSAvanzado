namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormSoldado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoldado));
            this.PanelTabla1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTabla2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVSoldado = new System.Windows.Forms.DataGridView();
            this.PanelBotonEliminar = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PanelTabla3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.PictureBox();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.TbPlaca = new System.Windows.Forms.TextBox();
            this.TbDni = new System.Windows.Forms.TextBox();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSoldado)).BeginInit();
            this.PanelBotonEliminar.SuspendLayout();
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
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.07732F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92268F));
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
            this.PanelTabla2.ColumnCount = 1;
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla2.Controls.Add(this.DGVSoldado, 0, 0);
            this.PanelTabla2.Controls.Add(this.PanelBotonEliminar, 0, 1);
            this.PanelTabla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla2.Location = new System.Drawing.Point(0, 0);
            this.PanelTabla2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla2.Name = "PanelTabla2";
            this.PanelTabla2.RowCount = 2;
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla2.Size = new System.Drawing.Size(504, 432);
            this.PanelTabla2.TabIndex = 0;
            // 
            // DGVSoldado
            // 
            this.DGVSoldado.AllowUserToAddRows = false;
            this.DGVSoldado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVSoldado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSoldado.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSoldado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSoldado.Location = new System.Drawing.Point(0, 0);
            this.DGVSoldado.Margin = new System.Windows.Forms.Padding(0);
            this.DGVSoldado.Name = "DGVSoldado";
            this.DGVSoldado.ReadOnly = true;
            this.DGVSoldado.RowHeadersVisible = false;
            this.DGVSoldado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSoldado.Size = new System.Drawing.Size(504, 388);
            this.DGVSoldado.TabIndex = 0;
            this.DGVSoldado.MouseCaptureChanged += new System.EventHandler(this.DGVSoldado_MouseCaptureChanged);
            // 
            // PanelBotonEliminar
            // 
            this.PanelBotonEliminar.BackColor = System.Drawing.Color.DimGray;
            this.PanelBotonEliminar.Controls.Add(this.BtnEliminar);
            this.PanelBotonEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotonEliminar.Location = new System.Drawing.Point(0, 388);
            this.PanelBotonEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBotonEliminar.Name = "PanelBotonEliminar";
            this.PanelBotonEliminar.Size = new System.Drawing.Size(504, 44);
            this.PanelBotonEliminar.TabIndex = 1;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(172, 2);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(10);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(160, 38);
            this.BtnEliminar.TabIndex = 0;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PanelTabla3
            // 
            this.PanelTabla3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelTabla3.ColumnCount = 1;
            this.PanelTabla3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla3.Controls.Add(this.BtnModificar, 0, 2);
            this.PanelTabla3.Controls.Add(this.BtnGuardar, 0, 1);
            this.PanelTabla3.Controls.Add(this.PanelFormulario, 0, 0);
            this.PanelTabla3.Location = new System.Drawing.Point(504, 0);
            this.PanelTabla3.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla3.Name = "PanelTabla3";
            this.PanelTabla3.RowCount = 3;
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.Size = new System.Drawing.Size(272, 432);
            this.PanelTabla3.TabIndex = 1;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(3, 391);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(266, 38);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(3, 348);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(266, 37);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Controls.Add(this.BtnLimpiar);
            this.PanelFormulario.Controls.Add(this.DTFecha);
            this.PanelFormulario.Controls.Add(this.TbPlaca);
            this.PanelFormulario.Controls.Add(this.TbDni);
            this.PanelFormulario.Controls.Add(this.TbApellido);
            this.PanelFormulario.Controls.Add(this.TbNombre);
            this.PanelFormulario.Controls.Add(this.TbId);
            this.PanelFormulario.Controls.Add(this.label6);
            this.PanelFormulario.Controls.Add(this.label5);
            this.PanelFormulario.Controls.Add(this.label4);
            this.PanelFormulario.Controls.Add(this.label3);
            this.PanelFormulario.Controls.Add(this.label2);
            this.PanelFormulario.Controls.Add(this.label1);
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(3, 3);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(266, 339);
            this.PanelFormulario.TabIndex = 2;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(120, 300);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(25, 25);
            this.BtnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.TabStop = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // DTFecha
            // 
            this.DTFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(115, 259);
            this.DTFecha.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(107, 20);
            this.DTFecha.TabIndex = 11;
            // 
            // TbPlaca
            // 
            this.TbPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPlaca.Enabled = false;
            this.TbPlaca.Location = new System.Drawing.Point(115, 221);
            this.TbPlaca.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.TbPlaca.Name = "TbPlaca";
            this.TbPlaca.ReadOnly = true;
            this.TbPlaca.Size = new System.Drawing.Size(107, 20);
            this.TbPlaca.TabIndex = 10;
            // 
            // TbDni
            // 
            this.TbDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbDni.Location = new System.Drawing.Point(115, 183);
            this.TbDni.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.TbDni.MaxLength = 8;
            this.TbDni.Name = "TbDni";
            this.TbDni.Size = new System.Drawing.Size(107, 20);
            this.TbDni.TabIndex = 9;
            this.TbDni.Leave += new System.EventHandler(this.TbDni_Leave);
            // 
            // TbApellido
            // 
            this.TbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbApellido.Location = new System.Drawing.Point(115, 145);
            this.TbApellido.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(107, 20);
            this.TbApellido.TabIndex = 8;
            // 
            // TbNombre
            // 
            this.TbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbNombre.Location = new System.Drawing.Point(115, 107);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(107, 20);
            this.TbNombre.TabIndex = 7;
            // 
            // TbId
            // 
            this.TbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbId.Enabled = false;
            this.TbId.Location = new System.Drawing.Point(115, 69);
            this.TbId.Name = "TbId";
            this.TbId.ReadOnly = true;
            this.TbId.Size = new System.Drawing.Size(107, 20);
            this.TbId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // FormSoldado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.PanelTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoldado";
            this.Text = "FormSoldado";
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSoldado)).EndInit();
            this.PanelBotonEliminar.ResumeLayout(false);
            this.PanelTabla3.ResumeLayout(false);
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.DataGridView DGVSoldado;
        private System.Windows.Forms.Panel PanelBotonEliminar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TableLayoutPanel PanelTabla3;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.TextBox TbPlaca;
        private System.Windows.Forms.TextBox TbDni;
        private System.Windows.Forms.PictureBox BtnLimpiar;
    }
}
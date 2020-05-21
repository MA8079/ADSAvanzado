namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormServicioDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicioDiario));
            this.PanelTabla1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTabla2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVSold_Disponible = new System.Windows.Forms.DataGridView();
            this.DGVServ_Diario = new System.Windows.Forms.DataGridView();
            this.PanelTablaFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.PictureBox();
            this.Cbturno = new System.Windows.Forms.ComboBox();
            this.Cbservicio = new System.Windows.Forms.ComboBox();
            this.Cbsoldado = new System.Windows.Forms.ComboBox();
            this.Tbid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSold_Disponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVServ_Diario)).BeginInit();
            this.PanelTablaFormulario.SuspendLayout();
            this.PanelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTabla1
            // 
            this.PanelTabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTabla1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelTabla1.ColumnCount = 2;
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.85052F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.14948F));
            this.PanelTabla1.Controls.Add(this.PanelTabla2, 0, 0);
            this.PanelTabla1.Controls.Add(this.PanelTablaFormulario, 1, 0);
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
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.Controls.Add(this.DGVSold_Disponible, 0, 0);
            this.PanelTabla2.Controls.Add(this.DGVServ_Diario, 0, 1);
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
            // DGVServ_Diario
            // 
            this.DGVServ_Diario.AllowUserToAddRows = false;
            this.DGVServ_Diario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVServ_Diario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVServ_Diario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVServ_Diario.Location = new System.Drawing.Point(3, 219);
            this.DGVServ_Diario.Name = "DGVServ_Diario";
            this.DGVServ_Diario.ReadOnly = true;
            this.DGVServ_Diario.RowHeadersVisible = false;
            this.DGVServ_Diario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVServ_Diario.Size = new System.Drawing.Size(505, 210);
            this.DGVServ_Diario.TabIndex = 1;
            this.DGVServ_Diario.MouseCaptureChanged += new System.EventHandler(this.DGVServ_Diario_MouseCaptureChanged);
            // 
            // PanelTablaFormulario
            // 
            this.PanelTablaFormulario.ColumnCount = 1;
            this.PanelTablaFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTablaFormulario.Controls.Add(this.BtnGuardar, 0, 1);
            this.PanelTablaFormulario.Controls.Add(this.BtnModificar, 0, 2);
            this.PanelTablaFormulario.Controls.Add(this.BtnEliminar, 0, 3);
            this.PanelTablaFormulario.Controls.Add(this.PanelFormulario, 0, 0);
            this.PanelTablaFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTablaFormulario.Location = new System.Drawing.Point(511, 0);
            this.PanelTablaFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTablaFormulario.Name = "PanelTablaFormulario";
            this.PanelTablaFormulario.RowCount = 4;
            this.PanelTablaFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PanelTablaFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTablaFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTablaFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTablaFormulario.Size = new System.Drawing.Size(265, 432);
            this.PanelTablaFormulario.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnModificar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.PanelFormulario.Controls.Add(this.DTFecha);
            this.PanelFormulario.Controls.Add(this.TbApellido);
            this.PanelFormulario.Controls.Add(this.BtnLimpiar);
            this.PanelFormulario.Controls.Add(this.Cbturno);
            this.PanelFormulario.Controls.Add(this.Cbservicio);
            this.PanelFormulario.Controls.Add(this.Cbsoldado);
            this.PanelFormulario.Controls.Add(this.Tbid);
            this.PanelFormulario.Controls.Add(this.label5);
            this.PanelFormulario.Controls.Add(this.label4);
            this.PanelFormulario.Controls.Add(this.label3);
            this.PanelFormulario.Controls.Add(this.label2);
            this.PanelFormulario.Controls.Add(this.label1);
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(265, 302);
            this.PanelFormulario.TabIndex = 3;
            // 
            // DTFecha
            // 
            this.DTFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(104, 199);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(116, 20);
            this.DTFecha.TabIndex = 13;
            // 
            // TbApellido
            // 
            this.TbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbApellido.Enabled = false;
            this.TbApellido.Location = new System.Drawing.Point(104, 82);
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(115, 20);
            this.TbApellido.TabIndex = 12;
            this.TbApellido.Visible = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimpiar.BackColor = System.Drawing.Color.White;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(120, 258);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(25, 25);
            this.BtnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.TabStop = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Cbturno
            // 
            this.Cbturno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbturno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cbturno.FormattingEnabled = true;
            this.Cbturno.Location = new System.Drawing.Point(105, 160);
            this.Cbturno.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Cbturno.Name = "Cbturno";
            this.Cbturno.Size = new System.Drawing.Size(115, 21);
            this.Cbturno.TabIndex = 8;
            // 
            // Cbservicio
            // 
            this.Cbservicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbservicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cbservicio.FormattingEnabled = true;
            this.Cbservicio.Location = new System.Drawing.Point(105, 121);
            this.Cbservicio.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Cbservicio.Name = "Cbservicio";
            this.Cbservicio.Size = new System.Drawing.Size(115, 21);
            this.Cbservicio.TabIndex = 7;
            // 
            // Cbsoldado
            // 
            this.Cbsoldado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbsoldado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbsoldado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cbsoldado.FormattingEnabled = true;
            this.Cbsoldado.Location = new System.Drawing.Point(105, 82);
            this.Cbsoldado.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Cbsoldado.Name = "Cbsoldado";
            this.Cbsoldado.Size = new System.Drawing.Size(115, 21);
            this.Cbsoldado.TabIndex = 6;
            // 
            // Tbid
            // 
            this.Tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbid.Enabled = false;
            this.Tbid.Location = new System.Drawing.Point(105, 44);
            this.Tbid.Name = "Tbid";
            this.Tbid.Size = new System.Drawing.Size(115, 20);
            this.Tbid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soldado";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // FormServicioDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.PanelTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicioDiario";
            this.Text = "FormServicioDiario";
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSold_Disponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVServ_Diario)).EndInit();
            this.PanelTablaFormulario.ResumeLayout(false);
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.DataGridView DGVSold_Disponible;
        private System.Windows.Forms.DataGridView DGVServ_Diario;
        private System.Windows.Forms.TableLayoutPanel PanelTablaFormulario;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.ComboBox Cbturno;
        private System.Windows.Forms.ComboBox Cbservicio;
        private System.Windows.Forms.ComboBox Cbsoldado;
        private System.Windows.Forms.TextBox Tbid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnLimpiar;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.DateTimePicker DTFecha;
    }
}
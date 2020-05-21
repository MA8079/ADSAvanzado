namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormAscenso
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
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelTabla1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTabla2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DGVAscensos = new System.Windows.Forms.DataGridView();
            this.PanelTabla3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.CbSoldado = new System.Windows.Forms.ComboBox();
            this.CbGrado = new System.Windows.Forms.ComboBox();
            this.DTfecha = new System.Windows.Forms.DateTimePicker();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelContenedor.SuspendLayout();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAscensos)).BeginInit();
            this.PanelTabla3.SuspendLayout();
            this.PanelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContenedor.Controls.Add(this.PanelTabla1);
            this.PanelContenedor.Location = new System.Drawing.Point(9, 9);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(782, 438);
            this.PanelContenedor.TabIndex = 1;
            // 
            // PanelTabla1
            // 
            this.PanelTabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTabla1.BackColor = System.Drawing.Color.Gray;
            this.PanelTabla1.ColumnCount = 2;
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.40668F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.59332F));
            this.PanelTabla1.Controls.Add(this.PanelTabla2, 0, 0);
            this.PanelTabla1.Controls.Add(this.PanelTabla3, 1, 0);
            this.PanelTabla1.Location = new System.Drawing.Point(19, 44);
            this.PanelTabla1.Name = "PanelTabla1";
            this.PanelTabla1.RowCount = 1;
            this.PanelTabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla1.Size = new System.Drawing.Size(746, 351);
            this.PanelTabla1.TabIndex = 1;
            // 
            // PanelTabla2
            // 
            this.PanelTabla2.ColumnCount = 1;
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.Controls.Add(this.BtnEliminar, 0, 1);
            this.PanelTabla2.Controls.Add(this.DGVAscensos, 0, 0);
            this.PanelTabla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla2.Location = new System.Drawing.Point(0, 0);
            this.PanelTabla2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla2.Name = "PanelTabla2";
            this.PanelTabla2.RowCount = 2;
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.PanelTabla2.Size = new System.Drawing.Size(420, 351);
            this.PanelTabla2.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(3, 318);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(414, 30);
            this.BtnEliminar.TabIndex = 0;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DGVAscensos
            // 
            this.DGVAscensos.AllowUserToAddRows = false;
            this.DGVAscensos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAscensos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAscensos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAscensos.Location = new System.Drawing.Point(3, 3);
            this.DGVAscensos.Name = "DGVAscensos";
            this.DGVAscensos.ReadOnly = true;
            this.DGVAscensos.RowHeadersVisible = false;
            this.DGVAscensos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAscensos.Size = new System.Drawing.Size(414, 309);
            this.DGVAscensos.TabIndex = 1;
            this.DGVAscensos.MouseCaptureChanged += new System.EventHandler(this.DGVAscensos_MouseCaptureChanged);
            // 
            // PanelTabla3
            // 
            this.PanelTabla3.ColumnCount = 1;
            this.PanelTabla3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla3.Controls.Add(this.BtnGuardar, 0, 1);
            this.PanelTabla3.Controls.Add(this.BtnActualizar, 0, 2);
            this.PanelTabla3.Controls.Add(this.BtnNuevo, 0, 3);
            this.PanelTabla3.Controls.Add(this.PanelFormulario, 0, 0);
            this.PanelTabla3.Location = new System.Drawing.Point(420, 0);
            this.PanelTabla3.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla3.Name = "PanelTabla3";
            this.PanelTabla3.RowCount = 4;
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla3.Size = new System.Drawing.Size(326, 351);
            this.PanelTabla3.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(3, 248);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(320, 29);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(3, 283);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(320, 29);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(3, 318);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(320, 30);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Activar Registro";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Controls.Add(this.CbSoldado);
            this.PanelFormulario.Controls.Add(this.CbGrado);
            this.PanelFormulario.Controls.Add(this.DTfecha);
            this.PanelFormulario.Controls.Add(this.TbId);
            this.PanelFormulario.Controls.Add(this.label4);
            this.PanelFormulario.Controls.Add(this.label3);
            this.PanelFormulario.Controls.Add(this.label2);
            this.PanelFormulario.Controls.Add(this.label1);
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(3, 3);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Padding = new System.Windows.Forms.Padding(5);
            this.PanelFormulario.Size = new System.Drawing.Size(320, 239);
            this.PanelFormulario.TabIndex = 3;
            // 
            // CbSoldado
            // 
            this.CbSoldado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbSoldado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSoldado.Enabled = false;
            this.CbSoldado.FormattingEnabled = true;
            this.CbSoldado.Location = new System.Drawing.Point(122, 154);
            this.CbSoldado.Name = "CbSoldado";
            this.CbSoldado.Size = new System.Drawing.Size(141, 21);
            this.CbSoldado.TabIndex = 7;
            // 
            // CbGrado
            // 
            this.CbGrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGrado.Enabled = false;
            this.CbGrado.FormattingEnabled = true;
            this.CbGrado.Location = new System.Drawing.Point(122, 115);
            this.CbGrado.Name = "CbGrado";
            this.CbGrado.Size = new System.Drawing.Size(141, 21);
            this.CbGrado.TabIndex = 6;
            this.CbGrado.SelectedIndexChanged += new System.EventHandler(this.CbGrado_SelectedIndexChanged);
            // 
            // DTfecha
            // 
            this.DTfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTfecha.Enabled = false;
            this.DTfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfecha.Location = new System.Drawing.Point(122, 82);
            this.DTfecha.Name = "DTfecha";
            this.DTfecha.Size = new System.Drawing.Size(141, 20);
            this.DTfecha.TabIndex = 5;
            // 
            // TbId
            // 
            this.TbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbId.Enabled = false;
            this.TbId.Location = new System.Drawing.Point(122, 47);
            this.TbId.Name = "TbId";
            this.TbId.ReadOnly = true;
            this.TbId.Size = new System.Drawing.Size(141, 20);
            this.TbId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soldado";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grado";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // FormAscenso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAscenso";
            this.Text = "FormAscenso";
            this.PanelContenedor.ResumeLayout(false);
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAscensos)).EndInit();
            this.PanelTabla3.ResumeLayout(false);
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DGVAscensos;
        private System.Windows.Forms.TableLayoutPanel PanelTabla3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSoldado;
        private System.Windows.Forms.ComboBox CbGrado;
        private System.Windows.Forms.DateTimePicker DTfecha;
        private System.Windows.Forms.TextBox TbId;
    }
}
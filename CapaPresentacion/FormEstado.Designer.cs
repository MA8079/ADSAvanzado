namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormEstado
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
            this.PanelTabla1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTabla2 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBotonOtro = new System.Windows.Forms.Panel();
            this.BtnCancelarOtro = new System.Windows.Forms.Button();
            this.BtnOtro = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.PanelBotonDisponible = new System.Windows.Forms.Panel();
            this.BtnCancelarDisponible = new System.Windows.Forms.Button();
            this.BtnDisponible = new System.Windows.Forms.Button();
            this.LBsoldados = new System.Windows.Forms.ListBox();
            this.PanelTabla3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVEstado = new System.Windows.Forms.DataGridView();
            this.PanelTabla4 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBotonEliminar = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.PanelDetalle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbMotivo = new System.Windows.Forms.TextBox();
            this.TbEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            this.PanelBotonOtro.SuspendLayout();
            this.PanelBotonDisponible.SuspendLayout();
            this.PanelTabla3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstado)).BeginInit();
            this.PanelTabla4.SuspendLayout();
            this.PanelBotonEliminar.SuspendLayout();
            this.PanelDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTabla1
            // 
            this.PanelTabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTabla1.BackColor = System.Drawing.Color.DarkGray;
            this.PanelTabla1.ColumnCount = 2;
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.98969F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.01031F));
            this.PanelTabla1.Controls.Add(this.PanelTabla2, 0, 0);
            this.PanelTabla1.Controls.Add(this.PanelTabla3, 1, 0);
            this.PanelTabla1.Location = new System.Drawing.Point(12, 31);
            this.PanelTabla1.Name = "PanelTabla1";
            this.PanelTabla1.RowCount = 1;
            this.PanelTabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.PanelTabla1.Size = new System.Drawing.Size(776, 413);
            this.PanelTabla1.TabIndex = 0;
            // 
            // PanelTabla2
            // 
            this.PanelTabla2.BackColor = System.Drawing.Color.Gray;
            this.PanelTabla2.ColumnCount = 1;
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla2.Controls.Add(this.PanelBotonOtro, 0, 3);
            this.PanelTabla2.Controls.Add(this.LblFecha, 0, 0);
            this.PanelTabla2.Controls.Add(this.PanelBotonDisponible, 0, 2);
            this.PanelTabla2.Controls.Add(this.LBsoldados, 0, 1);
            this.PanelTabla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla2.Location = new System.Drawing.Point(3, 3);
            this.PanelTabla2.Name = "PanelTabla2";
            this.PanelTabla2.RowCount = 4;
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PanelTabla2.Size = new System.Drawing.Size(249, 407);
            this.PanelTabla2.TabIndex = 0;
            // 
            // PanelBotonOtro
            // 
            this.PanelBotonOtro.Controls.Add(this.BtnCancelarOtro);
            this.PanelBotonOtro.Controls.Add(this.BtnOtro);
            this.PanelBotonOtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotonOtro.Location = new System.Drawing.Point(0, 365);
            this.PanelBotonOtro.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBotonOtro.Name = "PanelBotonOtro";
            this.PanelBotonOtro.Size = new System.Drawing.Size(249, 42);
            this.PanelBotonOtro.TabIndex = 4;
            // 
            // BtnCancelarOtro
            // 
            this.BtnCancelarOtro.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnCancelarOtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelarOtro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelarOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarOtro.Location = new System.Drawing.Point(0, 0);
            this.BtnCancelarOtro.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelarOtro.Name = "BtnCancelarOtro";
            this.BtnCancelarOtro.Size = new System.Drawing.Size(249, 42);
            this.BtnCancelarOtro.TabIndex = 3;
            this.BtnCancelarOtro.Text = "Cancelar";
            this.BtnCancelarOtro.UseVisualStyleBackColor = false;
            this.BtnCancelarOtro.Visible = false;
            this.BtnCancelarOtro.Click += new System.EventHandler(this.BtnCancelarOtro_Click);
            // 
            // BtnOtro
            // 
            this.BtnOtro.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnOtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOtro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOtro.Location = new System.Drawing.Point(0, 0);
            this.BtnOtro.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOtro.Name = "BtnOtro";
            this.BtnOtro.Size = new System.Drawing.Size(249, 42);
            this.BtnOtro.TabIndex = 2;
            this.BtnOtro.Text = "Otro";
            this.BtnOtro.UseVisualStyleBackColor = false;
            this.BtnOtro.Click += new System.EventHandler(this.BtnOtro_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(3, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(243, 20);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelBotonDisponible
            // 
            this.PanelBotonDisponible.Controls.Add(this.BtnCancelarDisponible);
            this.PanelBotonDisponible.Controls.Add(this.BtnDisponible);
            this.PanelBotonDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotonDisponible.Location = new System.Drawing.Point(0, 325);
            this.PanelBotonDisponible.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBotonDisponible.Name = "PanelBotonDisponible";
            this.PanelBotonDisponible.Size = new System.Drawing.Size(249, 40);
            this.PanelBotonDisponible.TabIndex = 3;
            // 
            // BtnCancelarDisponible
            // 
            this.BtnCancelarDisponible.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnCancelarDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelarDisponible.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelarDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarDisponible.Location = new System.Drawing.Point(0, 0);
            this.BtnCancelarDisponible.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelarDisponible.Name = "BtnCancelarDisponible";
            this.BtnCancelarDisponible.Size = new System.Drawing.Size(249, 40);
            this.BtnCancelarDisponible.TabIndex = 2;
            this.BtnCancelarDisponible.Text = "Cancelar";
            this.BtnCancelarDisponible.UseVisualStyleBackColor = false;
            this.BtnCancelarDisponible.Visible = false;
            this.BtnCancelarDisponible.Click += new System.EventHandler(this.BtnCancelarDisponible_Click);
            // 
            // BtnDisponible
            // 
            this.BtnDisponible.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDisponible.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisponible.Location = new System.Drawing.Point(0, 0);
            this.BtnDisponible.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDisponible.Name = "BtnDisponible";
            this.BtnDisponible.Size = new System.Drawing.Size(249, 40);
            this.BtnDisponible.TabIndex = 1;
            this.BtnDisponible.Text = "Disponible";
            this.BtnDisponible.UseVisualStyleBackColor = false;
            this.BtnDisponible.Click += new System.EventHandler(this.BtnDisponible_Click);
            // 
            // LBsoldados
            // 
            this.LBsoldados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBsoldados.FormattingEnabled = true;
            this.LBsoldados.Location = new System.Drawing.Point(3, 23);
            this.LBsoldados.Name = "LBsoldados";
            this.LBsoldados.Size = new System.Drawing.Size(243, 299);
            this.LBsoldados.TabIndex = 5;
            this.LBsoldados.MouseCaptureChanged += new System.EventHandler(this.LBsoldados_MouseCaptureChanged);
            // 
            // PanelTabla3
            // 
            this.PanelTabla3.ColumnCount = 1;
            this.PanelTabla3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelTabla3.Controls.Add(this.DGVEstado, 0, 0);
            this.PanelTabla3.Controls.Add(this.PanelTabla4, 0, 1);
            this.PanelTabla3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla3.Location = new System.Drawing.Point(255, 0);
            this.PanelTabla3.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla3.Name = "PanelTabla3";
            this.PanelTabla3.RowCount = 2;
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.36118F));
            this.PanelTabla3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.63882F));
            this.PanelTabla3.Size = new System.Drawing.Size(521, 413);
            this.PanelTabla3.TabIndex = 1;
            // 
            // DGVEstado
            // 
            this.DGVEstado.AllowUserToAddRows = false;
            this.DGVEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEstado.BackgroundColor = System.Drawing.Color.Salmon;
            this.DGVEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVEstado.Location = new System.Drawing.Point(3, 3);
            this.DGVEstado.Name = "DGVEstado";
            this.DGVEstado.ReadOnly = true;
            this.DGVEstado.RowHeadersVisible = false;
            this.DGVEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEstado.Size = new System.Drawing.Size(515, 321);
            this.DGVEstado.TabIndex = 0;
            this.DGVEstado.MouseCaptureChanged += new System.EventHandler(this.DGVEstado_MouseCaptureChanged);
            // 
            // PanelTabla4
            // 
            this.PanelTabla4.ColumnCount = 2;
            this.PanelTabla4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98058F));
            this.PanelTabla4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.01942F));
            this.PanelTabla4.Controls.Add(this.PanelBotonEliminar, 1, 0);
            this.PanelTabla4.Controls.Add(this.PanelDetalle, 0, 0);
            this.PanelTabla4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla4.Location = new System.Drawing.Point(0, 327);
            this.PanelTabla4.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla4.Name = "PanelTabla4";
            this.PanelTabla4.RowCount = 1;
            this.PanelTabla4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelTabla4.Size = new System.Drawing.Size(521, 86);
            this.PanelTabla4.TabIndex = 1;
            // 
            // PanelBotonEliminar
            // 
            this.PanelBotonEliminar.BackColor = System.Drawing.Color.Black;
            this.PanelBotonEliminar.Controls.Add(this.BtnModificar);
            this.PanelBotonEliminar.Controls.Add(this.label1);
            this.PanelBotonEliminar.Controls.Add(this.TbId);
            this.PanelBotonEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotonEliminar.Location = new System.Drawing.Point(180, 3);
            this.PanelBotonEliminar.Name = "PanelBotonEliminar";
            this.PanelBotonEliminar.Size = new System.Drawing.Size(338, 80);
            this.PanelBotonEliminar.TabIndex = 2;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(126, 44);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(110, 30);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // TbId
            // 
            this.TbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbId.Enabled = false;
            this.TbId.Location = new System.Drawing.Point(126, 11);
            this.TbId.Name = "TbId";
            this.TbId.ReadOnly = true;
            this.TbId.Size = new System.Drawing.Size(110, 20);
            this.TbId.TabIndex = 1;
            this.TbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelDetalle
            // 
            this.PanelDetalle.Controls.Add(this.label3);
            this.PanelDetalle.Controls.Add(this.label2);
            this.PanelDetalle.Controls.Add(this.TbMotivo);
            this.PanelDetalle.Controls.Add(this.TbEstado);
            this.PanelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetalle.Location = new System.Drawing.Point(0, 0);
            this.PanelDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelDetalle.Name = "PanelDetalle";
            this.PanelDetalle.Size = new System.Drawing.Size(177, 86);
            this.PanelDetalle.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motivo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado";
            // 
            // TbMotivo
            // 
            this.TbMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbMotivo.Enabled = false;
            this.TbMotivo.Location = new System.Drawing.Point(3, 63);
            this.TbMotivo.Name = "TbMotivo";
            this.TbMotivo.Size = new System.Drawing.Size(171, 20);
            this.TbMotivo.TabIndex = 5;
            this.TbMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbEstado
            // 
            this.TbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbEstado.Enabled = false;
            this.TbEstado.Location = new System.Drawing.Point(3, 21);
            this.TbEstado.Name = "TbEstado";
            this.TbEstado.Size = new System.Drawing.Size(171, 20);
            this.TbEstado.TabIndex = 3;
            this.TbEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(391, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Último Registrado:";
            // 
            // FormEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PanelTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstado";
            this.Text = "FormEstado";
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            this.PanelTabla2.PerformLayout();
            this.PanelBotonOtro.ResumeLayout(false);
            this.PanelBotonDisponible.ResumeLayout(false);
            this.PanelTabla3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstado)).EndInit();
            this.PanelTabla4.ResumeLayout(false);
            this.PanelBotonEliminar.ResumeLayout(false);
            this.PanelBotonEliminar.PerformLayout();
            this.PanelDetalle.ResumeLayout(false);
            this.PanelDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.Panel PanelBotonDisponible;
        private System.Windows.Forms.Button BtnDisponible;
        private System.Windows.Forms.Panel PanelBotonOtro;
        private System.Windows.Forms.Button BtnOtro;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Button BtnCancelarDisponible;
        private System.Windows.Forms.TableLayoutPanel PanelTabla3;
        private System.Windows.Forms.DataGridView DGVEstado;
        private System.Windows.Forms.Panel PanelBotonEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbMotivo;
        private System.Windows.Forms.TextBox TbEstado;
        private System.Windows.Forms.Button BtnCancelarOtro;
        private System.Windows.Forms.TableLayoutPanel PanelTabla4;
        private System.Windows.Forms.Panel PanelDetalle;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LBsoldados;
    }
}
namespace SAServicios_TSMV.CapaPresentacion
{
    partial class FormPromocion
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
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.DGVPromocion = new System.Windows.Forms.DataGridView();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.CbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbIdSoldado = new System.Windows.Forms.TextBox();
            this.TbAnio = new System.Windows.Forms.TextBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.PanelTabla1.SuspendLayout();
            this.PanelTabla2.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPromocion)).BeginInit();
            this.PanelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTabla1
            // 
            this.PanelTabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTabla1.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelTabla1.ColumnCount = 2;
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PanelTabla1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PanelTabla1.Controls.Add(this.PanelTabla2, 1, 0);
            this.PanelTabla1.Controls.Add(this.PanelFormulario, 0, 0);
            this.PanelTabla1.Location = new System.Drawing.Point(12, 12);
            this.PanelTabla1.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla1.Name = "PanelTabla1";
            this.PanelTabla1.RowCount = 1;
            this.PanelTabla1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla1.Size = new System.Drawing.Size(827, 552);
            this.PanelTabla1.TabIndex = 0;
            // 
            // PanelTabla2
            // 
            this.PanelTabla2.BackColor = System.Drawing.Color.DimGray;
            this.PanelTabla2.ColumnCount = 1;
            this.PanelTabla2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTabla2.Controls.Add(this.PanelBotones, 0, 1);
            this.PanelTabla2.Controls.Add(this.DGVPromocion, 0, 0);
            this.PanelTabla2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTabla2.Location = new System.Drawing.Point(248, 0);
            this.PanelTabla2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTabla2.Name = "PanelTabla2";
            this.PanelTabla2.RowCount = 2;
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PanelTabla2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelTabla2.Size = new System.Drawing.Size(579, 552);
            this.PanelTabla2.TabIndex = 0;
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelBotones.Controls.Add(this.BtnModificar);
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotones.Location = new System.Drawing.Point(0, 469);
            this.PanelBotones.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(579, 83);
            this.PanelBotones.TabIndex = 0;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(210, 25);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(140, 35);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // DGVPromocion
            // 
            this.DGVPromocion.AllowUserToAddRows = false;
            this.DGVPromocion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPromocion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPromocion.Location = new System.Drawing.Point(3, 3);
            this.DGVPromocion.Name = "DGVPromocion";
            this.DGVPromocion.ReadOnly = true;
            this.DGVPromocion.RowHeadersVisible = false;
            this.DGVPromocion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPromocion.Size = new System.Drawing.Size(573, 463);
            this.DGVPromocion.TabIndex = 1;
            this.DGVPromocion.MouseCaptureChanged += new System.EventHandler(this.DGVPromocion_MouseCaptureChanged);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelFormulario.Controls.Add(this.CbMes);
            this.PanelFormulario.Controls.Add(this.label4);
            this.PanelFormulario.Controls.Add(this.label3);
            this.PanelFormulario.Controls.Add(this.label2);
            this.PanelFormulario.Controls.Add(this.label1);
            this.PanelFormulario.Controls.Add(this.TbIdSoldado);
            this.PanelFormulario.Controls.Add(this.TbAnio);
            this.PanelFormulario.Controls.Add(this.TbId);
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(0, 0);
            this.PanelFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(248, 552);
            this.PanelFormulario.TabIndex = 1;
            // 
            // CbMes
            // 
            this.CbMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMes.FormattingEnabled = true;
            this.CbMes.Location = new System.Drawing.Point(59, 240);
            this.CbMes.Name = "CbMes";
            this.CbMes.Size = new System.Drawing.Size(124, 21);
            this.CbMes.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(56, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Soldado";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(56, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(56, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mes";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(56, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Promocion";
            // 
            // TbIdSoldado
            // 
            this.TbIdSoldado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbIdSoldado.Location = new System.Drawing.Point(59, 345);
            this.TbIdSoldado.Name = "TbIdSoldado";
            this.TbIdSoldado.Size = new System.Drawing.Size(124, 20);
            this.TbIdSoldado.TabIndex = 4;
            // 
            // TbAnio
            // 
            this.TbAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbAnio.Location = new System.Drawing.Point(59, 295);
            this.TbAnio.Name = "TbAnio";
            this.TbAnio.Size = new System.Drawing.Size(124, 20);
            this.TbAnio.TabIndex = 2;
            // 
            // TbId
            // 
            this.TbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbId.Location = new System.Drawing.Point(59, 186);
            this.TbId.Name = "TbId";
            this.TbId.ReadOnly = true;
            this.TbId.Size = new System.Drawing.Size(124, 20);
            this.TbId.TabIndex = 1;
            // 
            // FormPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(851, 576);
            this.Controls.Add(this.PanelTabla1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPromocion";
            this.Text = "FormPromocion";
            this.PanelTabla1.ResumeLayout(false);
            this.PanelTabla2.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPromocion)).EndInit();
            this.PanelFormulario.ResumeLayout(false);
            this.PanelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTabla1;
        private System.Windows.Forms.TableLayoutPanel PanelTabla2;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.DataGridView DGVPromocion;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbIdSoldado;
        private System.Windows.Forms.TextBox TbAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox CbMes;
    }
}
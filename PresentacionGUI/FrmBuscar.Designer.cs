
namespace PresentacionGUI
{
    partial class FrmBuscar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.cbFiltrar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.pcImagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvTabla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cnIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnEstablecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnValorUTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Animated = true;
            this.bnLimpiar.BorderRadius = 15;
            this.bnLimpiar.CheckedState.Parent = this.bnLimpiar;
            this.bnLimpiar.CustomImages.Parent = this.bnLimpiar;
            this.bnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(68)))), ((int)(((byte)(225)))));
            this.bnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bnLimpiar.HoverState.Parent = this.bnLimpiar;
            this.bnLimpiar.Location = new System.Drawing.Point(540, 448);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.ShadowDecoration.Parent = this.bnLimpiar;
            this.bnLimpiar.Size = new System.Drawing.Size(91, 31);
            this.bnLimpiar.TabIndex = 6;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderRadius = 15;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.Parent = this.txtBusqueda;
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.FocusedState.Parent = this.txtBusqueda;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.HoverState.Parent = this.txtBusqueda;
            this.txtBusqueda.Location = new System.Drawing.Point(296, 183);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Parent = this.txtBusqueda;
            this.txtBusqueda.Size = new System.Drawing.Size(257, 36);
            this.txtBusqueda.TabIndex = 11;
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbFiltrar.Location = new System.Drawing.Point(81, 189);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(50, 19);
            this.lbFiltrar.TabIndex = 10;
            this.lbFiltrar.Text = "Filtrar";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.cbFiltrar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrar.BorderRadius = 15;
            this.cbFiltrar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrar.FocusedColor = System.Drawing.Color.Empty;
            this.cbFiltrar.FocusedState.Parent = this.cbFiltrar;
            this.cbFiltrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.HoverState.Parent = this.cbFiltrar;
            this.cbFiltrar.ItemHeight = 30;
            this.cbFiltrar.Items.AddRange(new object[] {
            "IDENTIFICACION",
            "ESTABLECIMIENTO",
            "INGRESO",
            "GASTO",
            "TIEMPO",
            "RESPONSABILIDAD"});
            this.cbFiltrar.ItemsAppearance.Parent = this.cbFiltrar;
            this.cbFiltrar.Location = new System.Drawing.Point(137, 183);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.ShadowDecoration.Parent = this.cbFiltrar;
            this.cbFiltrar.Size = new System.Drawing.Size(140, 36);
            this.cbFiltrar.TabIndex = 12;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Animated = true;
            this.bnBuscar.BorderRadius = 15;
            this.bnBuscar.CheckedState.Parent = this.bnBuscar;
            this.bnBuscar.CustomImages.Parent = this.bnBuscar;
            this.bnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(68)))), ((int)(((byte)(225)))));
            this.bnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBuscar.ForeColor = System.Drawing.Color.White;
            this.bnBuscar.HoverState.Parent = this.bnBuscar;
            this.bnBuscar.Image = global::PresentacionGUI.Properties.Resources.edit_find_symbolic_362052;
            this.bnBuscar.Location = new System.Drawing.Point(573, 188);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.ShadowDecoration.Parent = this.bnBuscar;
            this.bnBuscar.Size = new System.Drawing.Size(37, 31);
            this.bnBuscar.TabIndex = 13;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(98)))), ((int)(((byte)(238)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbBuscar);
            this.bunifuPanel1.Controls.Add(this.pcImagen);
            this.bunifuPanel1.Location = new System.Drawing.Point(39, 23);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(429, 116);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lbBuscar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.lbBuscar.Location = new System.Drawing.Point(191, 30);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(139, 44);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar";
            // 
            // pcImagen
            // 
            this.pcImagen.BackColor = System.Drawing.Color.Transparent;
            this.pcImagen.Image = global::PresentacionGUI.Properties.Resources.Search_engines_Customizable_Flat_Illustrations___Rafiki_Style1;
            this.pcImagen.Location = new System.Drawing.Point(3, 0);
            this.pcImagen.Name = "pcImagen";
            this.pcImagen.ShadowDecoration.Parent = this.pcImagen;
            this.pcImagen.Size = new System.Drawing.Size(182, 126);
            this.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagen.TabIndex = 1;
            this.pcImagen.TabStop = false;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTabla.ColumnHeadersHeight = 22;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnIdentificacion,
            this.cnEstablecimiento,
            this.cnIngreso,
            this.cnGasto,
            this.cnTipo,
            this.cnTiempo,
            this.cnGanancia,
            this.cnTarifa,
            this.cnValorUTV,
            this.cnLiquidacion});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTabla.EnableHeadersVisualStyles = false;
            this.dgvTabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTabla.Location = new System.Drawing.Point(26, 243);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Thistle;
            this.dgvTabla.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(667, 184);
            this.dgvTabla.TabIndex = 14;
            this.dgvTabla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTabla.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTabla.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvTabla.ThemeStyle.ReadOnly = true;
            this.dgvTabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTabla.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTabla.Visible = false;
            // 
            // cnIdentificacion
            // 
            this.cnIdentificacion.HeaderText = "Identificacion";
            this.cnIdentificacion.Name = "cnIdentificacion";
            this.cnIdentificacion.ReadOnly = true;
            // 
            // cnEstablecimiento
            // 
            this.cnEstablecimiento.HeaderText = "Establecimiento";
            this.cnEstablecimiento.Name = "cnEstablecimiento";
            this.cnEstablecimiento.ReadOnly = true;
            // 
            // cnIngreso
            // 
            this.cnIngreso.HeaderText = "Ingreso";
            this.cnIngreso.Name = "cnIngreso";
            this.cnIngreso.ReadOnly = true;
            // 
            // cnGasto
            // 
            this.cnGasto.HeaderText = "Gasto";
            this.cnGasto.Name = "cnGasto";
            this.cnGasto.ReadOnly = true;
            // 
            // cnTipo
            // 
            this.cnTipo.HeaderText = "Tipo";
            this.cnTipo.Name = "cnTipo";
            this.cnTipo.ReadOnly = true;
            // 
            // cnTiempo
            // 
            this.cnTiempo.HeaderText = "Tiempo";
            this.cnTiempo.Name = "cnTiempo";
            this.cnTiempo.ReadOnly = true;
            // 
            // cnGanancia
            // 
            this.cnGanancia.HeaderText = "Ganancia";
            this.cnGanancia.Name = "cnGanancia";
            this.cnGanancia.ReadOnly = true;
            // 
            // cnTarifa
            // 
            this.cnTarifa.HeaderText = "Tarifa";
            this.cnTarifa.Name = "cnTarifa";
            this.cnTarifa.ReadOnly = true;
            // 
            // cnValorUTV
            // 
            this.cnValorUTV.HeaderText = "UTV";
            this.cnValorUTV.Name = "cnValorUTV";
            this.cnValorUTV.ReadOnly = true;
            // 
            // cnLiquidacion
            // 
            this.cnLiquidacion.HeaderText = "Liquidacion";
            this.cnLiquidacion.Name = "cnLiquidacion";
            this.cnLiquidacion.ReadOnly = true;
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(716, 542);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button bnLimpiar;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lbBuscar;
        private Guna.UI2.WinForms.Guna2PictureBox pcImagen;
        private Guna.UI2.WinForms.Guna2ComboBox cbFiltrar;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private System.Windows.Forms.Label lbFiltrar;
        private Guna.UI2.WinForms.Guna2Button bnBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnEstablecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnValorUTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnLiquidacion;
    }
}
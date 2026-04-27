namespace TPWinForm_equipo_1A
{
  partial class FrmVentanaPrincipal
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
            this.btnArticuloAgregar = new System.Windows.Forms.Button();
            this.btnArticuloEliminar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPosterior = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cboBoxCampo = new System.Windows.Forms.ComboBox();
            this.cboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.gBoxBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.txtBoxBusquedaAvanzada = new System.Windows.Forms.TextBox();
            this.lblBusquedaAvanzada = new System.Windows.Forms.Label();
            this.lblResultadoBusqueda = new System.Windows.Forms.Label();
            this.btnBorrarFiltroAv = new System.Windows.Forms.Button();
            this.btnBorrarFiltroRapido = new System.Windows.Forms.Button();
            this.pbxUrl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gBoxBusquedaAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArticuloAgregar
            // 
            this.btnArticuloAgregar.AccessibleName = "";
            this.btnArticuloAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticuloAgregar.Location = new System.Drawing.Point(18, 143);
            this.btnArticuloAgregar.Name = "btnArticuloAgregar";
            this.btnArticuloAgregar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloAgregar.TabIndex = 1;
            this.btnArticuloAgregar.Text = "Agregar Artículo";
            this.btnArticuloAgregar.UseVisualStyleBackColor = true;
            this.btnArticuloAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArticuloEliminar
            // 
            this.btnArticuloEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticuloEliminar.Location = new System.Drawing.Point(18, 243);
            this.btnArticuloEliminar.Name = "btnArticuloEliminar";
            this.btnArticuloEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloEliminar.TabIndex = 3;
            this.btnArticuloEliminar.Text = "Eliminar";
            this.btnArticuloEliminar.UseVisualStyleBackColor = true;
            this.btnArticuloEliminar.Click += new System.EventHandler(this.btnArticuloEliminar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(139, 48);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(669, 322);
            this.dgvArticulos.TabIndex = 4;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(889, 327);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(47, 38);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPosterior
            // 
            this.btnPosterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPosterior.Enabled = false;
            this.btnPosterior.Location = new System.Drawing.Point(946, 327);
            this.btnPosterior.Name = "btnPosterior";
            this.btnPosterior.Size = new System.Drawing.Size(47, 38);
            this.btnPosterior.TabIndex = 7;
            this.btnPosterior.Text = ">>";
            this.btnPosterior.UseVisualStyleBackColor = true;
            this.btnPosterior.Click += new System.EventHandler(this.btnPosterior_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(136, 22);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(90, 13);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Busqueda rápida:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxBuscar.Location = new System.Drawing.Point(232, 18);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(173, 20);
            this.txtBoxBuscar.TabIndex = 9;
            this.txtBoxBuscar.TextChanged += new System.EventHandler(this.txtBoxBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(577, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeleccionar.Location = new System.Drawing.Point(18, 193);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(103, 35);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Ver detalle";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cboBoxCampo
            // 
            this.cboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCampo.FormattingEnabled = true;
            this.cboBoxCampo.Location = new System.Drawing.Point(60, 23);
            this.cboBoxCampo.Name = "cboBoxCampo";
            this.cboBoxCampo.Size = new System.Drawing.Size(88, 21);
            this.cboBoxCampo.TabIndex = 13;
            // 
            // cboBoxCriterio
            // 
            this.cboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCriterio.FormattingEnabled = true;
            this.cboBoxCriterio.Location = new System.Drawing.Point(200, 23);
            this.cboBoxCriterio.Name = "cboBoxCriterio";
            this.cboBoxCriterio.Size = new System.Drawing.Size(87, 21);
            this.cboBoxCriterio.TabIndex = 15;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(16, 27);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 18;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(157, 27);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 19;
            this.lblCriterio.Text = "Criterio";
            // 
            // gBoxBusquedaAvanzada
            // 
            this.gBoxBusquedaAvanzada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxBusquedaAvanzada.Controls.Add(this.btnBorrarFiltroAv);
            this.gBoxBusquedaAvanzada.Controls.Add(this.txtBoxBusquedaAvanzada);
            this.gBoxBusquedaAvanzada.Controls.Add(this.lblBusquedaAvanzada);
            this.gBoxBusquedaAvanzada.Controls.Add(this.cboBoxCriterio);
            this.gBoxBusquedaAvanzada.Controls.Add(this.lblCriterio);
            this.gBoxBusquedaAvanzada.Controls.Add(this.btnBuscar);
            this.gBoxBusquedaAvanzada.Controls.Add(this.cboBoxCampo);
            this.gBoxBusquedaAvanzada.Controls.Add(this.lblCampo);
            this.gBoxBusquedaAvanzada.Location = new System.Drawing.Point(139, 377);
            this.gBoxBusquedaAvanzada.Name = "gBoxBusquedaAvanzada";
            this.gBoxBusquedaAvanzada.Size = new System.Drawing.Size(669, 59);
            this.gBoxBusquedaAvanzada.TabIndex = 20;
            this.gBoxBusquedaAvanzada.TabStop = false;
            this.gBoxBusquedaAvanzada.Text = "Busqueda avanzada";
            // 
            // txtBoxBusquedaAvanzada
            // 
            this.txtBoxBusquedaAvanzada.Location = new System.Drawing.Point(382, 22);
            this.txtBoxBusquedaAvanzada.Name = "txtBoxBusquedaAvanzada";
            this.txtBoxBusquedaAvanzada.Size = new System.Drawing.Size(153, 20);
            this.txtBoxBusquedaAvanzada.TabIndex = 21;
            // 
            // lblBusquedaAvanzada
            // 
            this.lblBusquedaAvanzada.AutoSize = true;
            this.lblBusquedaAvanzada.Location = new System.Drawing.Point(297, 26);
            this.lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            this.lblBusquedaAvanzada.Size = new System.Drawing.Size(81, 13);
            this.lblBusquedaAvanzada.TabIndex = 20;
            this.lblBusquedaAvanzada.Text = "Texto a buscar:";
            // 
            // lblResultadoBusqueda
            // 
            this.lblResultadoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoBusqueda.AutoSize = true;
            this.lblResultadoBusqueda.Location = new System.Drawing.Point(458, 22);
            this.lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            this.lblResultadoBusqueda.Size = new System.Drawing.Size(216, 13);
            this.lblResultadoBusqueda.TabIndex = 21;
            this.lblResultadoBusqueda.Text = "Sin resultados en Cod. de Artículo y Nombre";
            this.lblResultadoBusqueda.Visible = false;
            // 
            // btnBorrarFiltroAv
            // 
            this.btnBorrarFiltroAv.Image = global::TPWinForm_equipo_1A.Properties.Resources.limpia;
            this.btnBorrarFiltroAv.Location = new System.Drawing.Point(542, 21);
            this.btnBorrarFiltroAv.Name = "btnBorrarFiltroAv";
            this.btnBorrarFiltroAv.Size = new System.Drawing.Size(29, 23);
            this.btnBorrarFiltroAv.TabIndex = 23;
            this.btnBorrarFiltroAv.UseVisualStyleBackColor = true;
            this.btnBorrarFiltroAv.Click += new System.EventHandler(this.btnBorrarFiltroAv_Click);
            // 
            // btnBorrarFiltroRapido
            // 
            this.btnBorrarFiltroRapido.Image = global::TPWinForm_equipo_1A.Properties.Resources.limpia;
            this.btnBorrarFiltroRapido.Location = new System.Drawing.Point(411, 17);
            this.btnBorrarFiltroRapido.Name = "btnBorrarFiltroRapido";
            this.btnBorrarFiltroRapido.Size = new System.Drawing.Size(29, 23);
            this.btnBorrarFiltroRapido.TabIndex = 22;
            this.btnBorrarFiltroRapido.UseVisualStyleBackColor = true;
            this.btnBorrarFiltroRapido.Click += new System.EventHandler(this.btnBorrarFiltroRapido_Click);
            // 
            // pbxUrl
            // 
            this.pbxUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxUrl.Location = new System.Drawing.Point(822, 67);
            this.pbxUrl.Name = "pbxUrl";
            this.pbxUrl.Size = new System.Drawing.Size(234, 250);
            this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrl.TabIndex = 5;
            this.pbxUrl.TabStop = false;
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 455);
            this.Controls.Add(this.btnBorrarFiltroRapido);
            this.Controls.Add(this.lblResultadoBusqueda);
            this.Controls.Add(this.gBoxBusquedaAvanzada);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnPosterior);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbxUrl);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnArticuloEliminar);
            this.Controls.Add(this.btnArticuloAgregar);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 494);
            this.Name = "FrmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gBoxBusquedaAvanzada.ResumeLayout(false);
            this.gBoxBusquedaAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Button btnArticuloAgregar;
        private System.Windows.Forms.Button btnArticuloEliminar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxUrl;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPosterior;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ComboBox cboBoxCampo;
        private System.Windows.Forms.ComboBox cboBoxCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.GroupBox gBoxBusquedaAvanzada;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtBoxBusquedaAvanzada;
        private System.Windows.Forms.Label lblResultadoBusqueda;
        private System.Windows.Forms.Button btnBorrarFiltroRapido;
        private System.Windows.Forms.Button btnBorrarFiltroAv;
    }
}
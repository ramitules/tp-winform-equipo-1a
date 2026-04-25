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
            this.btnArticuloModificar = new System.Windows.Forms.Button();
            this.btnArticuloEliminar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxUrl = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPosterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArticuloAgregar
            // 
            this.btnArticuloAgregar.AccessibleName = "";
            this.btnArticuloAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticuloAgregar.Location = new System.Drawing.Point(31, 90);
            this.btnArticuloAgregar.Name = "btnArticuloAgregar";
            this.btnArticuloAgregar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloAgregar.TabIndex = 1;
            this.btnArticuloAgregar.Text = "Agregar Artículo";
            this.btnArticuloAgregar.UseVisualStyleBackColor = true;
            this.btnArticuloAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArticuloModificar
            // 
            this.btnArticuloModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticuloModificar.Location = new System.Drawing.Point(31, 140);
            this.btnArticuloModificar.Name = "btnArticuloModificar";
            this.btnArticuloModificar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloModificar.TabIndex = 2;
            this.btnArticuloModificar.Text = "Modificar";
            this.btnArticuloModificar.UseVisualStyleBackColor = true;
            this.btnArticuloModificar.Click += new System.EventHandler(this.btnArticuloModificar_Click);
            // 
            // btnArticuloEliminar
            // 
            this.btnArticuloEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArticuloEliminar.Location = new System.Drawing.Point(31, 191);
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
            this.dgvArticulos.Location = new System.Drawing.Point(170, 28);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(733, 391);
            this.dgvArticulos.TabIndex = 4;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxUrl
            // 
            this.pbxUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxUrl.Location = new System.Drawing.Point(938, 28);
            this.pbxUrl.Name = "pbxUrl";
            this.pbxUrl.Size = new System.Drawing.Size(238, 238);
            this.pbxUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUrl.TabIndex = 5;
            this.pbxUrl.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(938, 286);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 35);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPosterior
            // 
            this.btnPosterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPosterior.Enabled = false;
            this.btnPosterior.Location = new System.Drawing.Point(1125, 286);
            this.btnPosterior.Name = "btnPosterior";
            this.btnPosterior.Size = new System.Drawing.Size(51, 35);
            this.btnPosterior.TabIndex = 7;
            this.btnPosterior.Text = ">>";
            this.btnPosterior.UseVisualStyleBackColor = true;
            this.btnPosterior.Click += new System.EventHandler(this.btnPosterior_Click);
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 455);
            this.Controls.Add(this.btnPosterior);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbxUrl);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnArticuloEliminar);
            this.Controls.Add(this.btnArticuloModificar);
            this.Controls.Add(this.btnArticuloAgregar);
            this.MaximizeBox = false;
            this.Name = "FrmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUrl)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button btnArticuloAgregar;
        private System.Windows.Forms.Button btnArticuloModificar;
        private System.Windows.Forms.Button btnArticuloEliminar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxUrl;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPosterior;
    }
}
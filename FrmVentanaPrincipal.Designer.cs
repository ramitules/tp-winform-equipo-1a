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
            this.button3 = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArticuloAgregar
            // 
            this.btnArticuloAgregar.AccessibleName = "";
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
            this.btnArticuloModificar.Location = new System.Drawing.Point(31, 140);
            this.btnArticuloModificar.Name = "btnArticuloModificar";
            this.btnArticuloModificar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloModificar.TabIndex = 2;
            this.btnArticuloModificar.Text = "button2";
            this.btnArticuloModificar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(170, 28);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(606, 391);
            this.dgvArticulos.TabIndex = 4;
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnArticuloModificar);
            this.Controls.Add(this.btnArticuloAgregar);
            this.Name = "FrmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Button btnArticuloAgregar;
        private System.Windows.Forms.Button btnArticuloModificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}
namespace TPWinForm_equipo_1A
{
  partial class VentanaPrincipal
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
            this.tbxPrueba = new System.Windows.Forms.TextBox();
            this.btnArticuloAgregar = new System.Windows.Forms.Button();
            this.btnArticuloModificar = new System.Windows.Forms.Button();
            this.btnArticuloEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPrueba
            // 
            this.tbxPrueba.Location = new System.Drawing.Point(146, 74);
            this.tbxPrueba.Multiline = true;
            this.tbxPrueba.Name = "tbxPrueba";
            this.tbxPrueba.Size = new System.Drawing.Size(642, 364);
            this.tbxPrueba.TabIndex = 0;
            // 
            // btnArticuloAgregar
            // 
            this.btnArticuloAgregar.AccessibleName = "";
            this.btnArticuloAgregar.Location = new System.Drawing.Point(24, 74);
            this.btnArticuloAgregar.Name = "btnArticuloAgregar";
            this.btnArticuloAgregar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloAgregar.TabIndex = 1;
            this.btnArticuloAgregar.Text = "Agregar Artículo";
            this.btnArticuloAgregar.UseVisualStyleBackColor = true;
            this.btnArticuloAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArticuloModificar
            // 
            this.btnArticuloModificar.Location = new System.Drawing.Point(24, 124);
            this.btnArticuloModificar.Name = "btnArticuloModificar";
            this.btnArticuloModificar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloModificar.TabIndex = 2;
            this.btnArticuloModificar.Text = "Modificar Articulo";
            this.btnArticuloModificar.UseVisualStyleBackColor = true;
            // 
            // btnArticuloEliminar
            // 
            this.btnArticuloEliminar.Location = new System.Drawing.Point(24, 175);
            this.btnArticuloEliminar.Name = "btnArticuloEliminar";
            this.btnArticuloEliminar.Size = new System.Drawing.Size(103, 35);
            this.btnArticuloEliminar.TabIndex = 3;
            this.btnArticuloEliminar.Text = "Eliminar Artículo";
            this.btnArticuloEliminar.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArticuloEliminar);
            this.Controls.Add(this.btnArticuloModificar);
            this.Controls.Add(this.btnArticuloAgregar);
            this.Controls.Add(this.tbxPrueba);
            this.Name = "VentanaPrincipal";
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox tbxPrueba;
        private System.Windows.Forms.Button btnArticuloAgregar;
        private System.Windows.Forms.Button btnArticuloModificar;
        private System.Windows.Forms.Button btnArticuloEliminar;
    }
}
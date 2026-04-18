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
            this.SuspendLayout();
            // 
            // tbxPrueba
            // 
            this.tbxPrueba.Location = new System.Drawing.Point(113, 97);
            this.tbxPrueba.Multiline = true;
            this.tbxPrueba.Name = "tbxPrueba";
            this.tbxPrueba.Size = new System.Drawing.Size(506, 295);
            this.tbxPrueba.TabIndex = 0;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPrueba);
            this.Name = "VentanaPrincipal";
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox tbxPrueba;
    }
}
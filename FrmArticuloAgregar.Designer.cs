namespace TPWinForm_equipo_1A
{
    partial class FrmArticuloAgregar
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
            this.labelCodArticulo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.txtBoxCodArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxImagen = new System.Windows.Forms.TextBox();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.txtCargaArticulo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodArticulo
            // 
            this.labelCodArticulo.AutoSize = true;
            this.labelCodArticulo.Location = new System.Drawing.Point(31, 50);
            this.labelCodArticulo.Name = "labelCodArticulo";
            this.labelCodArticulo.Size = new System.Drawing.Size(87, 13);
            this.labelCodArticulo.TabIndex = 0;
            this.labelCodArticulo.Text = "Cod. de Artículo:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(31, 77);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(31, 103);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(31, 243);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(45, 13);
            this.labelImagen.TabIndex = 3;
            this.labelImagen.Text = "Imagen:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(31, 215);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(57, 13);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(31, 191);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(31, 269);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 6;
            this.labelPrecio.Text = "Precio:";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(119, 349);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(233, 26);
            this.btnAgregarArticulo.TabIndex = 7;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // txtBoxCodArticulo
            // 
            this.txtBoxCodArticulo.Location = new System.Drawing.Point(119, 47);
            this.txtBoxCodArticulo.Name = "txtBoxCodArticulo";
            this.txtBoxCodArticulo.Size = new System.Drawing.Size(233, 20);
            this.txtBoxCodArticulo.TabIndex = 8;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(119, 74);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(233, 20);
            this.txtBoxNombre.TabIndex = 9;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(119, 100);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(233, 84);
            this.txtBoxDescripcion.TabIndex = 10;
            // 
            // txtBoxImagen
            // 
            this.txtBoxImagen.Location = new System.Drawing.Point(119, 240);
            this.txtBoxImagen.Name = "txtBoxImagen";
            this.txtBoxImagen.Size = new System.Drawing.Size(233, 20);
            this.txtBoxImagen.TabIndex = 11;
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(119, 188);
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(233, 21);
            this.cBoxMarca.TabIndex = 14;
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(119, 212);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(233, 21);
            this.cBoxCategoria.TabIndex = 15;
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(119, 267);
            this.numPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(233, 20);
            this.numPrecio.TabIndex = 16;
            this.numPrecio.ThousandsSeparator = true;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(119, 317);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(233, 26);
            this.btnPrueba.TabIndex = 17;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // txtCargaArticulo
            // 
            this.txtCargaArticulo.Location = new System.Drawing.Point(399, 50);
            this.txtCargaArticulo.Multiline = true;
            this.txtCargaArticulo.Name = "txtCargaArticulo";
            this.txtCargaArticulo.Size = new System.Drawing.Size(261, 325);
            this.txtCargaArticulo.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(554, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 26);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmArticuloAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCargaArticulo);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.cBoxMarca);
            this.Controls.Add(this.txtBoxImagen);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodArticulo);
            this.Name = "FrmArticuloAgregar";
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.ArticuloAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodArticulo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.TextBox txtBoxCodArticulo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxImagen;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.TextBox txtCargaArticulo;
        private System.Windows.Forms.Button btnCancelar;
    }
}
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
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.btnGestionarImagen = new System.Windows.Forms.Button();
            this.txtBoxCodArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.cBoxMarca = new System.Windows.Forms.ComboBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelImagen = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.pbxImagenNueva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenNueva)).BeginInit();
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
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(31, 185);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(57, 13);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoría:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(31, 158);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(31, 210);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 6;
            this.labelPrecio.Text = "Precio:";
            // 
            // btnGestionarImagen
            // 
            this.btnGestionarImagen.Location = new System.Drawing.Point(119, 234);
            this.btnGestionarImagen.Name = "btnGestionarImagen";
            this.btnGestionarImagen.Size = new System.Drawing.Size(131, 25);
            this.btnGestionarImagen.TabIndex = 7;
            this.btnGestionarImagen.Text = "Gestionar Imagenes";
            this.btnGestionarImagen.UseVisualStyleBackColor = true;
            this.btnGestionarImagen.Click += new System.EventHandler(this.btnGestionarImagen_Click);
            // 
            // txtBoxCodArticulo
            // 
            this.txtBoxCodArticulo.Location = new System.Drawing.Point(119, 47);
            this.txtBoxCodArticulo.Name = "txtBoxCodArticulo";
            this.txtBoxCodArticulo.Size = new System.Drawing.Size(131, 20);
            this.txtBoxCodArticulo.TabIndex = 8;
            this.txtBoxCodArticulo.TextChanged += new System.EventHandler(this.txtBoxCodArticulo_TextChanged);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(119, 74);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(131, 20);
            this.txtBoxNombre.TabIndex = 9;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(119, 100);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(131, 48);
            this.txtBoxDescripcion.TabIndex = 10;
            this.txtBoxDescripcion.TextChanged += new System.EventHandler(this.txtBoxDescripcion_TextChanged);
            // 
            // cBoxMarca
            // 
            this.cBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMarca.FormattingEnabled = true;
            this.cBoxMarca.Location = new System.Drawing.Point(119, 154);
            this.cBoxMarca.Name = "cBoxMarca";
            this.cBoxMarca.Size = new System.Drawing.Size(131, 21);
            this.cBoxMarca.TabIndex = 14;
            this.cBoxMarca.SelectedIndexChanged += new System.EventHandler(this.cBoxMarca_SelectedIndexChanged);
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(119, 181);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(131, 21);
            this.cBoxCategoria.TabIndex = 15;
            this.cBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.cBoxCategoria_SelectedIndexChanged);
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(119, 208);
            this.numPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(131, 20);
            this.numPrecio.TabIndex = 16;
            this.numPrecio.ThousandsSeparator = true;
            this.numPrecio.ValueChanged += new System.EventHandler(this.numPrecio_ValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(439, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 39);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Crimson;
            this.lblCodigo.Location = new System.Drawing.Point(256, 50);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "* Campo Obligatorio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Crimson;
            this.lblNombre.Location = new System.Drawing.Point(256, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 13);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "* Campo Obligatorio";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Image = global::TPWinForm_equipo_1A.Properties.Resources.agregar;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(256, 179);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(31, 24);
            this.btnAgregarCategoria.TabIndex = 24;
            this.btnAgregarCategoria.Text = "+";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Image = global::TPWinForm_equipo_1A.Properties.Resources.quitar;
            this.btnEliminarMarca.Location = new System.Drawing.Point(293, 152);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(31, 24);
            this.btnEliminarMarca.TabIndex = 25;
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Image = global::TPWinForm_equipo_1A.Properties.Resources.quitar;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(293, 179);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(31, 24);
            this.btnEliminarCategoria.TabIndex = 26;
            this.btnEliminarCategoria.Text = "-";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(119, 276);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(131, 26);
            this.btnModificarArticulo.TabIndex = 28;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Visible = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(119, 308);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(131, 26);
            this.btnEliminarArticulo.TabIndex = 29;
            this.btnEliminarArticulo.Text = "Eliminar Artículo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Visible = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(188, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 39);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(32, 240);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(56, 13);
            this.labelImagen.TabIndex = 3;
            this.labelImagen.Text = "Imagenes:";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Image = global::TPWinForm_equipo_1A.Properties.Resources.agregar;
            this.btnAgregarMarca.Location = new System.Drawing.Point(256, 152);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(31, 24);
            this.btnAgregarMarca.TabIndex = 23;
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // pbxImagenNueva
            // 
            this.pbxImagenNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagenNueva.Location = new System.Drawing.Point(390, 50);
            this.pbxImagenNueva.Name = "pbxImagenNueva";
            this.pbxImagenNueva.Size = new System.Drawing.Size(250, 302);
            this.pbxImagenNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenNueva.TabIndex = 22;
            this.pbxImagenNueva.TabStop = false;
            // 
            // FrmArticuloAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.pbxImagenNueva);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.cBoxMarca);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodArticulo);
            this.Controls.Add(this.btnGestionarImagen);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodArticulo);
            this.MinimumSize = new System.Drawing.Size(756, 475);
            this.Name = "FrmArticuloAgregar";
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.ArticuloAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodArticulo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button btnGestionarImagen;
        private System.Windows.Forms.TextBox txtBoxCodArticulo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.ComboBox cBoxMarca;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxImagenNueva;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelImagen;
    }
}
namespace WindowsFormsApp1
{
    partial class frmArticulo
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
            this.botonImagen = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbImagen = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labelImagen = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // botonImagen
            // 
            this.botonImagen.Location = new System.Drawing.Point(261, 174);
            this.botonImagen.Name = "botonImagen";
            this.botonImagen.Size = new System.Drawing.Size(21, 20);
            this.botonImagen.TabIndex = 36;
            this.botonImagen.Text = "+";
            this.botonImagen.UseVisualStyleBackColor = true;
            this.botonImagen.Click += new System.EventHandler(this.botonImagen_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.botonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(288, 237);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(84, 25);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.botonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAceptar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(198, 237);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(84, 25);
            this.botonAceptar.TabIndex = 7;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = false;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(134, 200);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(121, 20);
            this.tbPrecio.TabIndex = 6;
            // 
            // tbImagen
            // 
            this.tbImagen.Location = new System.Drawing.Point(134, 174);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.Size = new System.Drawing.Size(121, 20);
            this.tbImagen.TabIndex = 5;
            this.tbImagen.Leave += new System.EventHandler(this.tbImagen_Leave);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(134, 147);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(134, 120);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(134, 92);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(121, 22);
            this.tbDescripcion.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 66);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.Location = new System.Drawing.Point(63, 177);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(66, 13);
            this.labelImagen.TabIndex = 27;
            this.labelImagen.Text = "Url Imagen:";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(288, 40);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(221, 180);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 26;
            this.pbImagen.TabStop = false;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(87, 203);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(42, 13);
            this.labelPrecio.TabIndex = 25;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(68, 150);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(60, 13);
            this.labelCategoria.TabIndex = 24;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(85, 123);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(43, 13);
            this.labelMarca.TabIndex = 23;
            this.labelMarca.Text = "Marca:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(58, 95);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(71, 13);
            this.labelDescripcion.TabIndex = 22;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(76, 69);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(52, 13);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.AutoSize = true;
            this.labelCodigoArticulo.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoArticulo.Location = new System.Drawing.Point(25, 43);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(104, 13);
            this.labelCodigoArticulo.TabIndex = 20;
            this.labelCodigoArticulo.Text = "Codigo de articulo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(134, 40);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(121, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(561, 292);
            this.Controls.Add(this.botonImagen);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbImagen);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.tbCodigo);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmArticulo";
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonImagen;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbImagen;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}
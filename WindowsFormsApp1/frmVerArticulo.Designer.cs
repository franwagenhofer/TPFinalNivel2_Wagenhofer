namespace WindowsFormsApp1
{
    partial class frmVerArticulo
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
            this.pImagen = new System.Windows.Forms.PictureBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.tImagen = new System.Windows.Forms.TextBox();
            this.cCategoria = new System.Windows.Forms.ComboBox();
            this.cMarca = new System.Windows.Forms.ComboBox();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigoArticulo = new System.Windows.Forms.Label();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pImagen
            // 
            this.pImagen.Enabled = false;
            this.pImagen.Location = new System.Drawing.Point(340, 12);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(319, 281);
            this.pImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImagen.TabIndex = 0;
            this.pImagen.TabStop = false;
            // 
            // tPrecio
            // 
            this.tPrecio.Enabled = false;
            this.tPrecio.Location = new System.Drawing.Point(138, 135);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.ReadOnly = true;
            this.tPrecio.Size = new System.Drawing.Size(121, 20);
            this.tPrecio.TabIndex = 34;
            // 
            // tImagen
            // 
            this.tImagen.Enabled = false;
            this.tImagen.Location = new System.Drawing.Point(138, 163);
            this.tImagen.Name = "tImagen";
            this.tImagen.ReadOnly = true;
            this.tImagen.Size = new System.Drawing.Size(184, 20);
            this.tImagen.TabIndex = 33;
            // 
            // cCategoria
            // 
            this.cCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCategoria.Enabled = false;
            this.cCategoria.FormattingEnabled = true;
            this.cCategoria.Location = new System.Drawing.Point(138, 108);
            this.cCategoria.Name = "cCategoria";
            this.cCategoria.Size = new System.Drawing.Size(121, 21);
            this.cCategoria.TabIndex = 32;
            // 
            // cMarca
            // 
            this.cMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMarca.Enabled = false;
            this.cMarca.FormattingEnabled = true;
            this.cMarca.Location = new System.Drawing.Point(138, 79);
            this.cMarca.Name = "cMarca";
            this.cMarca.Size = new System.Drawing.Size(121, 21);
            this.cMarca.TabIndex = 31;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Location = new System.Drawing.Point(138, 189);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(184, 59);
            this.tDescripcion.TabIndex = 30;
            // 
            // tNombre
            // 
            this.tNombre.Enabled = false;
            this.tNombre.Location = new System.Drawing.Point(138, 53);
            this.tNombre.Name = "tNombre";
            this.tNombre.ReadOnly = true;
            this.tNombre.Size = new System.Drawing.Size(121, 20);
            this.tNombre.TabIndex = 29;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.Location = new System.Drawing.Point(66, 166);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(66, 13);
            this.labelImagen.TabIndex = 41;
            this.labelImagen.Text = "Url Imagen:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(90, 138);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(42, 13);
            this.labelPrecio.TabIndex = 40;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(73, 111);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(60, 13);
            this.labelCategoria.TabIndex = 39;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(90, 82);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(43, 13);
            this.labelMarca.TabIndex = 38;
            this.labelMarca.Text = "Marca:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(61, 192);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(71, 13);
            this.labelDescripcion.TabIndex = 37;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(80, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(52, 13);
            this.labelNombre.TabIndex = 36;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCodigoArticulo
            // 
            this.labelCodigoArticulo.AutoSize = true;
            this.labelCodigoArticulo.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoArticulo.Location = new System.Drawing.Point(29, 30);
            this.labelCodigoArticulo.Name = "labelCodigoArticulo";
            this.labelCodigoArticulo.Size = new System.Drawing.Size(104, 13);
            this.labelCodigoArticulo.TabIndex = 35;
            this.labelCodigoArticulo.Text = "Codigo de articulo:";
            // 
            // tCodigo
            // 
            this.tCodigo.Enabled = false;
            this.tCodigo.HideSelection = false;
            this.tCodigo.Location = new System.Drawing.Point(138, 27);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.ReadOnly = true;
            this.tCodigo.Size = new System.Drawing.Size(121, 20);
            this.tCodigo.TabIndex = 28;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btVolver.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(184, 270);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 42;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // frmVerArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(701, 338);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.tPrecio);
            this.Controls.Add(this.tImagen);
            this.Controls.Add(this.cCategoria);
            this.Controls.Add(this.cMarca);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigoArticulo);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.pImagen);
            this.Name = "frmVerArticulo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmVerArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pImagen;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.TextBox tImagen;
        private System.Windows.Forms.ComboBox cCategoria;
        private System.Windows.Forms.ComboBox cMarca;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigoArticulo;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.Button btVolver;
    }
}
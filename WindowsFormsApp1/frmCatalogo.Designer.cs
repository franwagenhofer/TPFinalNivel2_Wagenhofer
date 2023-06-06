namespace WindowsFormsApp1
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminarFisico = new System.Windows.Forms.Button();
            this.tbFiltroRapido = new System.Windows.Forms.TextBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.tbFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.botonDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(156, 68);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(479, 178);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(641, 68);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(206, 178);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(156, 252);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(68, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(230, 252);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(68, 23);
            this.btModificar.TabIndex = 3;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click_1);
            // 
            // btEliminarFisico
            // 
            this.btEliminarFisico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEliminarFisico.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEliminarFisico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btEliminarFisico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarFisico.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarFisico.Location = new System.Drawing.Point(403, 252);
            this.btEliminarFisico.Name = "btEliminarFisico";
            this.btEliminarFisico.Size = new System.Drawing.Size(93, 23);
            this.btEliminarFisico.TabIndex = 4;
            this.btEliminarFisico.Text = "Eliminar Fisico";
            this.btEliminarFisico.UseVisualStyleBackColor = false;
            this.btEliminarFisico.Click += new System.EventHandler(this.btEliminarFisico_Click);
            // 
            // tbFiltroRapido
            // 
            this.tbFiltroRapido.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltroRapido.Location = new System.Drawing.Point(502, 252);
            this.tbFiltroRapido.Multiline = true;
            this.tbFiltroRapido.Name = "tbFiltroRapido";
            this.tbFiltroRapido.Size = new System.Drawing.Size(133, 23);
            this.tbFiltroRapido.TabIndex = 5;
            this.tbFiltroRapido.Text = "filtro rapido..";
            this.tbFiltroRapido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFiltroRapido.TextChanged += new System.EventHandler(this.tbFiltroRapido_TextChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.labelFiltro.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFiltro.Location = new System.Drawing.Point(23, 141);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(36, 13);
            this.labelFiltro.TabIndex = 35;
            this.labelFiltro.Text = "Filtro:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.labelCategoria.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCategoria.Location = new System.Drawing.Point(10, 114);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(49, 13);
            this.labelCategoria.TabIndex = 34;
            this.labelCategoria.Text = "Criterio:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.labelMarca.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMarca.Location = new System.Drawing.Point(12, 87);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(47, 13);
            this.labelMarca.TabIndex = 33;
            this.labelMarca.Text = "Campo:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.botonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.botonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(65, 164);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(85, 23);
            this.botonBuscar.TabIndex = 32;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // tbFiltroAvanzado
            // 
            this.tbFiltroAvanzado.BackColor = System.Drawing.SystemColors.Control;
            this.tbFiltroAvanzado.Location = new System.Drawing.Point(65, 138);
            this.tbFiltroAvanzado.Name = "tbFiltroAvanzado";
            this.tbFiltroAvanzado.Size = new System.Drawing.Size(85, 20);
            this.tbFiltroAvanzado.TabIndex = 31;
            // 
            // cbCriterio
            // 
            this.cbCriterio.BackColor = System.Drawing.SystemColors.Control;
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(65, 111);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(85, 21);
            this.cbCriterio.TabIndex = 30;
            // 
            // cbCampo
            // 
            this.cbCampo.BackColor = System.Drawing.SystemColors.Control;
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(65, 84);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(85, 21);
            this.cbCampo.TabIndex = 29;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.labelTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTitulo.Location = new System.Drawing.Point(296, 42);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(201, 23);
            this.labelTitulo.TabIndex = 36;
            this.labelTitulo.Text = "Listado de Articulos";
            // 
            // botonDetalle
            // 
            this.botonDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.botonDetalle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.botonDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.botonDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonDetalle.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDetalle.Location = new System.Drawing.Point(304, 252);
            this.botonDetalle.Name = "botonDetalle";
            this.botonDetalle.Size = new System.Drawing.Size(93, 23);
            this.botonDetalle.TabIndex = 37;
            this.botonDetalle.Text = "Ver Detalle";
            this.botonDetalle.UseVisualStyleBackColor = false;
            this.botonDetalle.Click += new System.EventHandler(this.botonDetalle_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(907, 330);
            this.Controls.Add(this.botonDetalle);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.tbFiltroAvanzado);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.tbFiltroRapido);
            this.Controls.Add(this.btEliminarFisico);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmCatalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminarFisico;
        private System.Windows.Forms.TextBox tbFiltroRapido;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox tbFiltroAvanzado;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button botonDetalle;
    }
}


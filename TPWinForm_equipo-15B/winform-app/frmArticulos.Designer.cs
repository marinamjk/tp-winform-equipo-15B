namespace winform_app
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.LbBusqueda = new System.Windows.Forms.Label();
            this.TbBusqueda = new System.Windows.Forms.TextBox();
            this.LbCampo = new System.Windows.Forms.Label();
            this.CbCampo = new System.Windows.Forms.ComboBox();
            this.LbCriterio = new System.Windows.Forms.Label();
            this.CbCriterio = new System.Windows.Forms.ComboBox();
            this.LbFiltro = new System.Windows.Forms.Label();
            this.TbFiltro = new System.Windows.Forms.TextBox();
            this.BtFiltrar = new System.Windows.Forms.Button();
            this.BtOrdenarPrecio = new System.Windows.Forms.Button();
            this.BTOrdenaralfabetico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(17, 101);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(605, 296);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgbArticulos_SelectionChanged);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArticulo.Location = new System.Drawing.Point(8, 13);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(391, 296);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCatalogo.Location = new System.Drawing.Point(19, 12);
            this.lblCatalogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(126, 25);
            this.lblCatalogo.TabIndex = 2;
            this.lblCatalogo.Text = "CATALOGO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 406);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(125, 406);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(234, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // LbBusqueda
            // 
            this.LbBusqueda.AutoSize = true;
            this.LbBusqueda.Location = new System.Drawing.Point(24, 57);
            this.LbBusqueda.Name = "LbBusqueda";
            this.LbBusqueda.Size = new System.Drawing.Size(111, 13);
            this.LbBusqueda.TabIndex = 7;
            this.LbBusqueda.Text = "Busqueda por nombre";
            // 
            // TbBusqueda
            // 
            this.TbBusqueda.Location = new System.Drawing.Point(141, 54);
            this.TbBusqueda.Name = "TbBusqueda";
            this.TbBusqueda.Size = new System.Drawing.Size(243, 20);
            this.TbBusqueda.TabIndex = 8;
            this.TbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBusqueda_KeyPress);
            // 
            // LbCampo
            // 
            this.LbCampo.AutoSize = true;
            this.LbCampo.Location = new System.Drawing.Point(9, 465);
            this.LbCampo.Name = "LbCampo";
            this.LbCampo.Size = new System.Drawing.Size(40, 13);
            this.LbCampo.TabIndex = 9;
            this.LbCampo.Text = "Campo";
            // 
            // CbCampo
            // 
            this.CbCampo.FormattingEnabled = true;
            this.CbCampo.Location = new System.Drawing.Point(55, 462);
            this.CbCampo.Name = "CbCampo";
            this.CbCampo.Size = new System.Drawing.Size(121, 21);
            this.CbCampo.TabIndex = 10;
            this.CbCampo.SelectedIndexChanged += new System.EventHandler(this.CbCampo_SelectedIndexChanged);
            // 
            // LbCriterio
            // 
            this.LbCriterio.AutoSize = true;
            this.LbCriterio.Location = new System.Drawing.Point(216, 465);
            this.LbCriterio.Name = "LbCriterio";
            this.LbCriterio.Size = new System.Drawing.Size(39, 13);
            this.LbCriterio.TabIndex = 11;
            this.LbCriterio.Text = "Criterio";
            // 
            // CbCriterio
            // 
            this.CbCriterio.FormattingEnabled = true;
            this.CbCriterio.Location = new System.Drawing.Point(259, 462);
            this.CbCriterio.Name = "CbCriterio";
            this.CbCriterio.Size = new System.Drawing.Size(121, 21);
            this.CbCriterio.TabIndex = 12;
            // 
            // LbFiltro
            // 
            this.LbFiltro.AutoSize = true;
            this.LbFiltro.Location = new System.Drawing.Point(433, 465);
            this.LbFiltro.Name = "LbFiltro";
            this.LbFiltro.Size = new System.Drawing.Size(29, 13);
            this.LbFiltro.TabIndex = 13;
            this.LbFiltro.Text = "Filtro";
            // 
            // TbFiltro
            // 
            this.TbFiltro.Location = new System.Drawing.Point(468, 462);
            this.TbFiltro.Name = "TbFiltro";
            this.TbFiltro.Size = new System.Drawing.Size(139, 20);
            this.TbFiltro.TabIndex = 14;
            // 
            // BtFiltrar
            // 
            this.BtFiltrar.Location = new System.Drawing.Point(631, 452);
            this.BtFiltrar.Name = "BtFiltrar";
            this.BtFiltrar.Size = new System.Drawing.Size(99, 38);
            this.BtFiltrar.TabIndex = 15;
            this.BtFiltrar.Text = "Filtrar";
            this.BtFiltrar.UseVisualStyleBackColor = true;
            this.BtFiltrar.Click += new System.EventHandler(this.BtFiltrar_Click);
            // 
            // BtOrdenarPrecio
            // 
            this.BtOrdenarPrecio.Location = new System.Drawing.Point(434, 37);
            this.BtOrdenarPrecio.Name = "BtOrdenarPrecio";
            this.BtOrdenarPrecio.Size = new System.Drawing.Size(129, 46);
            this.BtOrdenarPrecio.TabIndex = 16;
            this.BtOrdenarPrecio.Text = "Ordenar por precio";
            this.BtOrdenarPrecio.UseVisualStyleBackColor = true;
            this.BtOrdenarPrecio.Click += new System.EventHandler(this.BtOrdenar_Click);
            // 
            // BTOrdenaralfabetico
            // 
            this.BTOrdenaralfabetico.Location = new System.Drawing.Point(569, 37);
            this.BTOrdenaralfabetico.Name = "BTOrdenaralfabetico";
            this.BTOrdenaralfabetico.Size = new System.Drawing.Size(115, 46);
            this.BTOrdenaralfabetico.TabIndex = 17;
            this.BTOrdenaralfabetico.Text = "Ordenar alfabeticamente";
            this.BTOrdenaralfabetico.UseVisualStyleBackColor = true;
            this.BTOrdenaralfabetico.Click += new System.EventHandler(this.BTOrdenaralfabetico_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.pbArticulo);
            this.panel1.Location = new System.Drawing.Point(631, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 345);
            this.panel1.TabIndex = 18;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(113, 313);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(96, 27);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(213, 313);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(96, 27);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(344, 406);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 19;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 499);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTOrdenaralfabetico);
            this.Controls.Add(this.BtOrdenarPrecio);
            this.Controls.Add(this.BtFiltrar);
            this.Controls.Add(this.TbFiltro);
            this.Controls.Add(this.LbFiltro);
            this.Controls.Add(this.CbCriterio);
            this.Controls.Add(this.LbCriterio);
            this.Controls.Add(this.CbCampo);
            this.Controls.Add(this.LbCampo);
            this.Controls.Add(this.TbBusqueda);
            this.Controls.Add(this.LbBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(915, 492);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label LbBusqueda;
        private System.Windows.Forms.TextBox TbBusqueda;
        private System.Windows.Forms.Label LbCampo;
        private System.Windows.Forms.ComboBox CbCampo;
        private System.Windows.Forms.Label LbCriterio;
        private System.Windows.Forms.ComboBox CbCriterio;
        private System.Windows.Forms.Label LbFiltro;
        private System.Windows.Forms.TextBox TbFiltro;
        private System.Windows.Forms.Button BtFiltrar;
        private System.Windows.Forms.Button BtOrdenarPrecio;
        private System.Windows.Forms.Button BTOrdenaralfabetico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnDetalles;
    }
}
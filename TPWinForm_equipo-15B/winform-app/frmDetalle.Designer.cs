namespace winform_app
{
    partial class frmDetalle
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTextoCategoria = new System.Windows.Forms.Label();
            this.lblTextoMarca = new System.Windows.Forms.Label();
            this.lblTextoPrecio = new System.Windows.Forms.Label();
            this.lblTextoDescripcion = new System.Windows.Forms.Label();
            this.lblTextoNombre = new System.Windows.Forms.Label();
            this.lblTextoCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(256, 19);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(264, 295);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 29;
            this.pbxArticulo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(445, 333);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTextoCategoria
            // 
            this.lblTextoCategoria.AutoSize = true;
            this.lblTextoCategoria.Location = new System.Drawing.Point(133, 261);
            this.lblTextoCategoria.Name = "lblTextoCategoria";
            this.lblTextoCategoria.Size = new System.Drawing.Size(0, 13);
            this.lblTextoCategoria.TabIndex = 27;
            // 
            // lblTextoMarca
            // 
            this.lblTextoMarca.AutoSize = true;
            this.lblTextoMarca.Location = new System.Drawing.Point(133, 221);
            this.lblTextoMarca.Name = "lblTextoMarca";
            this.lblTextoMarca.Size = new System.Drawing.Size(0, 13);
            this.lblTextoMarca.TabIndex = 26;
            // 
            // lblTextoPrecio
            // 
            this.lblTextoPrecio.AutoSize = true;
            this.lblTextoPrecio.Location = new System.Drawing.Point(133, 181);
            this.lblTextoPrecio.Name = "lblTextoPrecio";
            this.lblTextoPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblTextoPrecio.TabIndex = 25;
            // 
            // lblTextoDescripcion
            // 
            this.lblTextoDescripcion.AutoSize = true;
            this.lblTextoDescripcion.Location = new System.Drawing.Point(133, 141);
            this.lblTextoDescripcion.Name = "lblTextoDescripcion";
            this.lblTextoDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lblTextoDescripcion.TabIndex = 24;
            // 
            // lblTextoNombre
            // 
            this.lblTextoNombre.AutoSize = true;
            this.lblTextoNombre.Location = new System.Drawing.Point(133, 101);
            this.lblTextoNombre.Name = "lblTextoNombre";
            this.lblTextoNombre.Size = new System.Drawing.Size(0, 13);
            this.lblTextoNombre.TabIndex = 23;
            // 
            // lblTextoCodigo
            // 
            this.lblTextoCodigo.AutoSize = true;
            this.lblTextoCodigo.Location = new System.Drawing.Point(133, 61);
            this.lblTextoCodigo.Name = "lblTextoCodigo";
            this.lblTextoCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblTextoCodigo.TabIndex = 22;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(38, 261);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(38, 221);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 20;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(38, 181);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(38, 141);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(38, 61);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Codigo";
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTextoCategoria);
            this.Controls.Add(this.lblTextoMarca);
            this.Controls.Add(this.lblTextoPrecio);
            this.Controls.Add(this.lblTextoDescripcion);
            this.Controls.Add(this.lblTextoNombre);
            this.Controls.Add(this.lblTextoCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmDetalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTextoCategoria;
        private System.Windows.Forms.Label lblTextoMarca;
        private System.Windows.Forms.Label lblTextoPrecio;
        private System.Windows.Forms.Label lblTextoDescripcion;
        private System.Windows.Forms.Label lblTextoNombre;
        private System.Windows.Forms.Label lblTextoCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}
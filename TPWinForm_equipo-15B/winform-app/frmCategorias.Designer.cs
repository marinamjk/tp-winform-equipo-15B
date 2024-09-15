namespace winform_app
{
    partial class FrmCastegorias
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
            this.DvgCategoria = new System.Windows.Forms.DataGridView();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgCategoria
            // 
            this.DvgCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DvgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgCategoria.Location = new System.Drawing.Point(183, 95);
            this.DvgCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DvgCategoria.MinimumSize = new System.Drawing.Size(429, 460);
            this.DvgCategoria.Name = "DvgCategoria";
            this.DvgCategoria.RowHeadersWidth = 62;
            this.DvgCategoria.Size = new System.Drawing.Size(429, 460);
            this.DvgCategoria.TabIndex = 0;
            // 
            // BAgregar
            // 
            this.BAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregar.Location = new System.Drawing.Point(651, 142);
            this.BAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(112, 35);
            this.BAgregar.TabIndex = 1;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BModificar
            // 
            this.BModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BModificar.Location = new System.Drawing.Point(651, 231);
            this.BModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(112, 35);
            this.BModificar.TabIndex = 2;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BEliminar.Location = new System.Drawing.Point(651, 328);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(112, 35);
            this.BEliminar.TabIndex = 3;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // FrmCastegorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 660);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.DvgCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(824, 716);
            this.Name = "FrmCastegorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCastegorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgCategoria;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.Button BEliminar;
    }
}
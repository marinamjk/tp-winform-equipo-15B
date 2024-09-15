namespace winform_app
{
    partial class frmAltaCateogia
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
            this.LbNombre = new System.Windows.Forms.Label();
            this.TbAgregar = new System.Windows.Forms.TextBox();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(153, 131);
            this.LbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(63, 20);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "nombre";
            // 
            // TbAgregar
            // 
            this.TbAgregar.Location = new System.Drawing.Point(240, 126);
            this.TbAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbAgregar.Name = "TbAgregar";
            this.TbAgregar.Size = new System.Drawing.Size(324, 26);
            this.TbAgregar.TabIndex = 1;
            this.TbAgregar.TextChanged += new System.EventHandler(this.TbAgregar_TextChanged);
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(240, 206);
            this.BtAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(132, 37);
            this.BtAceptar.TabIndex = 2;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(435, 206);
            this.BtCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(112, 35);
            this.BtCancelar.TabIndex = 3;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // frmAltaCateogia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 286);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.TbAgregar);
            this.Controls.Add(this.LbNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAltaCateogia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.TextBox TbAgregar;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.Button BtCancelar;
    }
}
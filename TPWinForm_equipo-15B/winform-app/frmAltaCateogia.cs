using dominio;
using DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace winform_app
{
    public partial class frmAltaCateogia : Form
    {
        private Categoria categoria = null;
        public frmAltaCateogia()
        {
            InitializeComponent();
        }

        public frmAltaCateogia(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private bool validarEntrada()
        {
            if (TbAgregar.Text == "")
            {
                TbAgregar.BackColor = Color.Red;
                return false;
            }
            else
            {
                TbAgregar.BackColor = System.Drawing.SystemColors.Control;
            }

            return true;
        }
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!validarEntrada())
            {
                return;
            }

            CategoriaManager CategoriaManager = new CategoriaManager();

            try
            {
                if (categoria == null)
                    categoria = new Categoria();
                categoria.Descripcion = TbAgregar.Text;

                if (categoria.id != 0)
                {
                    CategoriaManager.modificar(categoria);
                    MessageBox.Show("Modificada exitosamente");
                }
                else
                {
                    CategoriaManager.agregar(categoria);
                    MessageBox.Show("Agregada exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbAgregar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbAgregar.Text))
            {
                TbAgregar.BackColor = System.Drawing.SystemColors.Control;
            }
        }
    }
}

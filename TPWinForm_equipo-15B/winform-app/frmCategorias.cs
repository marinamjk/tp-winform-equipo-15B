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
using dominio;

namespace winform_app
{
    public partial class FrmCastegorias : Form
    {
        public FrmCastegorias()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            FrmCastegorias agregarCategoria = new FrmCastegorias();
            agregarCategoria.ShowDialog();
            cargar();
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)DvgCategoria.CurrentRow.DataBoundItem;
            frmAltaCateogia modificarCategoria = new frmAltaCateogia(categoriaSeleccionada);
            modificarCategoria.ShowDialog();
            cargar();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            CategoriaManager categoriaManager = new CategoriaManager();
            ArticuloManager artManager = new ArticuloManager();
            List<Articulo> articulos;

            Categoria categoria;

            try
            {
                articulos = artManager.listar();
                categoria = (Categoria)DvgCategoria.CurrentRow.DataBoundItem;
                foreach (var i in articulos)
                {
                    if (i.Marca.Id == categoria.id)
                    {
                        MessageBox.Show("No se puede eliminar esta categoria, revisar si hay articulos que la contegnan.");
                        return;
                    }
                }
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar esta Categoria?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    categoriaManager.eliminar(categoria.id);
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmCastegorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaManager AgregarCategoria = new CategoriaManager();
            try
            {
                List<Categoria> categorias = AgregarCategoria.listar();
                DvgCategoria.DataSource = categorias;
                DvgCategoria.Columns["id"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

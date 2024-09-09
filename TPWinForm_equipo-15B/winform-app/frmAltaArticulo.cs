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
using DBManager;

namespace winform_app
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloManager articuloManager = new ArticuloManager();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                // Agregar el artículo y obtener el ID recién creado
                int idArticuloNuevo = articuloManager.agregar(articulo);

                // Verificar si se ha proporcionado una URL de imagen y agregarla
                if (!string.IsNullOrEmpty(txtImagenUrl.Text))
                {
                    ImagenManager imagenManager = new ImagenManager();
                    Imagen nuevaImagen = new Imagen
                    {
                        idArticulo = idArticuloNuevo,
                        ImagenUrl = txtImagenUrl.Text
                    };
                    imagenManager.agregarImagen(nuevaImagen);
                }

                MessageBox.Show("Artículo y imagen agregados exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();
            CategoriaManager categoriaManager = new CategoriaManager();
            try
            {
                cboMarca.DataSource = marcaManager.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaManager.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

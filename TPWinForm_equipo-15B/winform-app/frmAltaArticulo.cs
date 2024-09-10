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
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();
            ImagenManager imagenManager = new ImagenManager();
            int idArticulo;

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id > 0) // Si ya tiene un Id, entonces es una modificación
                {
                    articuloManager.modificar(articulo);
                    idArticulo = articulo.Id; // Usar el ID del artículo modificado
                    MessageBox.Show("Artículo modificado exitosamente");
                }
                else // Si no tiene Id, es un artículo nuevo
                {
                    // Agregar el artículo y obtener el ID recién creado
                    idArticulo = articuloManager.agregar(articulo);
                    articulo.Id = idArticulo; // Asignar el nuevo Id al artículo
                    MessageBox.Show("Artículo agregado exitosamente");
                }

                // Verificar si se ha proporcionado una URL de imagen
                if (!string.IsNullOrEmpty(txtImagenUrl.Text))
                {
                    Imagen nuevaImagen = new Imagen
                    {
                        idArticulo = idArticulo,
                        ImagenUrl = txtImagenUrl.Text
                    };

                    // Verificar si el artículo ya tiene una imagen asociada
                    List<Imagen> imagenesExistentes = imagenManager.buscarImagenesXArticulo(idArticulo);
                    if (imagenesExistentes != null && imagenesExistentes.Count > 0)
                    {
                        // Si ya existe una imagen, modificarla (solo tomo la primera en este caso)
                        nuevaImagen.id = imagenesExistentes[0].id;
                        imagenManager.modificarImagen(nuevaImagen);
                        MessageBox.Show("Imagen modificada exitosamente");
                    }
                    else
                    {
                        // Si no existe, agregar una nueva
                        imagenManager.agregarImagen(nuevaImagen);
                        MessageBox.Show("Imagen agregada exitosamente");
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el artículo: " + ex.Message);
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
            ImagenManager imagenManager = new ImagenManager();
            try
            {
                cboMarca.DataSource = marcaManager.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaManager.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.Marca.id;
                    cboCategoria.SelectedValue = articulo.Categoria.id;

                    // Buscar la imagen del artículo y cargarla
                    List<Imagen> imagenes = imagenManager.buscarImagenesXArticulo(articulo.Id);
                    if (imagenes.Count > 0)
                    {
                        string imagenUrl = imagenes[0].ImagenUrl; // Asume que solo tiene una imagen
                        txtImagenUrl.Text = imagenUrl;
                        cargarImagen(imagenUrl);
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en evento Load AltaArticulo: " + ex.Message);
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)//Permite una visualizacion de la imagen a cargar
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://louisville.edu/history/images/noimage.jpg/");
            }

        }
    }
}

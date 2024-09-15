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
        private List<Imagen> listaImagenes = new List<Imagen>(); // Lista de imágenes temporal

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

        private void guadarImagen(int idArticulo)
        {
            ImagenManager imagenManager = new ImagenManager();

            // Recorre la lista y guarda cada imagen
            foreach (Imagen imagen in listaImagenes)
            {
                imagen.idArticulo = idArticulo; // Asigna el id del artículo

                List<Imagen> imagenesExistentes = imagenManager.buscarImagenesXArticulo(idArticulo);
                if (imagen.id > 0)
                {
                    // Si ya existe una imagen(solo tomo la primera en este caso) si hago esto reemplazo la imagen
                    //imagen.id = imagenesExistentes[0].id;
                    imagenManager.modificarImagen(imagen);
                }
                else
                {
                    // Si no existe, agregar una nueva
                    imagenManager.agregarImagen(imagen);
                }
            }
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

                // Valida campos obligatorios
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                    return;
                }

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

                    // Recupera las imágenes existentes para el artículo
                    var imagenesExistentes = imagenManager.buscarImagenesXArticulo(idArticulo);

                    // Agregar las nuevas imágenes a la lista de imágenes
                    listaImagenes.AddRange(imagenesExistentes);
                }
                else // Si no tiene Id, es un artículo nuevo
                {
                    // Agrega el articulo y obteniene el ID recién creado
                    idArticulo = articuloManager.agregar(articulo);
                    articulo.Id = idArticulo; // Asigna el nuevo Id
                }

                // Guardamos las imágenes asociadas al artículo
                guadarImagen(idArticulo);
                MessageBox.Show("Artículo guardado exitosamente.");
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
                // Cargar Marcas
                var marcas = marcaManager.listar();
                if (marcas != null && marcas.Count > 0)
                {
                    cboMarca.DataSource = marcas;
                    cboMarca.ValueMember = "Id";
                    cboMarca.DisplayMember = "Descripcion";
                }
                else
                {
                    MessageBox.Show("No se encontraron marcas disponibles.");
                }

                // Cargar Categorías
                var categorias = categoriaManager.listar();
                if (categorias != null && categorias.Count > 0)
                {
                    cboCategoria.DataSource = categorias;
                    cboCategoria.ValueMember = "Id";
                    cboCategoria.DisplayMember = "Descripcion";
                }
                else
                {
                    MessageBox.Show("No se encontraron categorías disponibles.");
                }

               

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    // Verifica que las marcas y categorías existan antes de asignarles el valor
                    if (marcas.Exists(m => m.Id == articulo.Marca.Id))
                        cboMarca.SelectedValue = articulo.Marca.Id;
                    else
                        MessageBox.Show("La marca del artículo no está disponible.");

                    if (categorias.Exists(c => c.id == articulo.Categoria.id))
                        cboCategoria.SelectedValue = articulo.Categoria.id;
                    else
                        MessageBox.Show("La categoría del artículo no está disponible.");

                    // Cargar imágenes existentes
                    listaImagenes = imagenManager.buscarImagenesXArticulo(articulo.Id);
                    dgvImagenes.DataSource = null; // Limpiar el DataGridView
                    dgvImagenes.DataSource = listaImagenes; // aasignar la lista de imágenes existentes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en evento Load AltaArticulo: " + ex.Message);
            }
        }

        private void btnAgregarImagenes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtImagenUrl.Text))
            {
                Imagen nuevaImagen = new Imagen
                {
                    ImagenUrl = txtImagenUrl.Text // agregar un diálogo para seleccionar la imagen
                };
                listaImagenes.Add(nuevaImagen);

                // Actualiza la vista temporal del dgv
                dgvImagenes.DataSource = null; // Limpia el dgv
                dgvImagenes.DataSource = listaImagenes; // Reasigna la lista temporal

                txtImagenUrl.Clear(); // Limpia el campo de texto después de agregar
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una URL de imagen.");
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
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

        private void dgvImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvImagenes.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta imagen?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Obtener el objeto de la fila seleccionada
                    Imagen imagenAEliminar = (Imagen)dgvImagenes.Rows[e.RowIndex].DataBoundItem;

                    // Eliminar el objeto de la base de datos
                    ImagenManager imagenManager = new ImagenManager();
                    imagenManager.eliminarImagen(imagenAEliminar.id);

                    // Actualizar la lista de imágenes y volver a asignar el DataSource
                    listaImagenes.Remove(imagenAEliminar);
                    dgvImagenes.DataSource = null; // Limpiar el DataGridView
                    dgvImagenes.DataSource = listaImagenes; // Asignar la lista actualizada
                }
            }
        }
    }
    
}

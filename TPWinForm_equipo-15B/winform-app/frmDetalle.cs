using DBManager;
using dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace winform_app
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;
        private List<Imagen> listaImagenes = new List<Imagen>(); // Lista de imágenes

        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo";
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                // Cargar imagen por defecto si no se puede cargar la imagen seleccionada
                pbxArticulo.Load("https://i.pinimg.com/564x/f3/3d/e6/f33de6ea2561faf442e6298b81f2c556.jpg");
            }
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            ImagenManager imagenManager = new ImagenManager(); // Manejador para las imágenes
            try
            {
                if (articulo != null)
                {
                    // Cargar los datos del artículo
                    lblTextoCodigo.Text = articulo.Codigo;
                    lblTextoNombre.Text = articulo.Nombre;
                    lblTextoDescripcion.Text = articulo.Descripcion;
                    lblTextoPrecio.Text = articulo.Precio.ToString();
                    lblTextoMarca.Text = articulo.Marca.Descripcion;
                    lblTextoCategoria.Text = articulo.Categoria.Descripcion;

                    // Buscar las imágenes del artículo
                    listaImagenes = imagenManager.buscarImagenesXArticulo(articulo.Id);

                    // Cargar la primera imagen en el PictureBox si existen imágenes
                    if (listaImagenes.Count > 0)
                    {
                        cargarImagen(listaImagenes[0].ImagenUrl); // Cargar la primera imagen
                    }
                    else
                    {
                        // Imagen por defecto si no hay imágenes
                        cargarImagen("https://i.pinimg.com/564x/f3/3d/e6/f33de6ea2561faf442e6298b81f2c556.jpg");
                    }

                    // Asignar la lista de imágenes al DataGridView
                    dgvImagenes.DataSource = null;
                    dgvImagenes.DataSource = listaImagenes; // Cargar la lista de imágenes en el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                // si se selecciona una fila válida 
                if (e.RowIndex >= 0 && e.RowIndex < dgvImagenes.Rows.Count)
                {
                    // ObtIene el objeto Imagen de la fila
                    Imagen imagenSeleccionada = (Imagen)dgvImagenes.Rows[e.RowIndex].DataBoundItem;

                    // Verificar que no sea nula
                    if (imagenSeleccionada != null && !string.IsNullOrEmpty(imagenSeleccionada.ImagenUrl))
                    {
                        // Cargar la imagen seleccionada en el PictureBox
                        cargarImagen(imagenSeleccionada.ImagenUrl);
                    }
                    else
                    {
                        // Si la imagen es nula o no tiene URL, cargar una imagen por defecto
                        cargarImagen("https://i.pinimg.com/564x/f3/3d/e6/f33de6ea2561faf442e6298b81f2c556.jpg");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cargar la imagen seleccionada: " + ex.Message);
            }
            
        }
    }
}
using DBManager;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;
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

                    // Buscar las imágenes del artículo y cargar la primera en el PictureBox
                    List<Imagen> imagenes = imagenManager.buscarImagenesXArticulo(articulo.Id);

                    if (imagenes.Count > 0)
                    {
                        // Si hay imágenes, cargamos la primera
                        string imagenUrl = imagenes[0].ImagenUrl;
                        cargarImagen(imagenUrl); // Método ya definido para cargar en PictureBox
                    }
                    else
                    {
                        // Si no hay imágenes, mostrar un mensaje o una imagen por defecto
                        cargarImagen("https://i.pinimg.com/564x/f3/3d/e6/f33de6ea2561faf442e6298b81f2c556.jpg");
                    }
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using DBManager;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        int nroImagen;
        public frmArticulos()
        {
            InitializeComponent();
            CbCampo.Items.Add("Precio");
            CbCampo.Items.Add("Marca");
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = false;
            cargar();            
        }

        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
            nroImagen = 0;

            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
             
                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    cargarImagen(seleccionado.Imagenes[nroImagen].ImagenUrl);
                }
                else
                {
                    // Si no hay imágenes, carga la imagen predeterminada
                    cargarImagen(string.Empty); // Pasa una cadena vacía para cargar la imagen predeterminada
                }

                habilitarControles();
            }
        }

        private void cargar()
        {
            ArticuloManager articuloManager = new ArticuloManager();
            try
            {
                listaArticulos = articuloManager.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                // Verifica si la URL de la imagen es válida o si la lista de imágenes está vacía
                if (string.IsNullOrEmpty(imagen) || !Uri.IsWellFormedUriString(imagen, UriKind.Absolute))
                {
                    pbArticulo.Load("https://louisville.edu/history/images/noimage.jpg/");
                }
                else
                {
                    pbArticulo.Load(imagen);
                }
            }
            catch (Exception ex)
            {
                // En caso de que la carga falle, también carga la imagen predeterminada
                pbArticulo.Load("https://louisville.edu/history/images/noimage.jpg/");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta =new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloManager articulo = new ArticuloManager();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro de la base de datos?","Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articulo.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> listaArticulosBuscados;
            string filtro = TbBusqueda.Text;
            if (filtro != "")
            {
                listaArticulosBuscados = listaArticulos.FindAll(i => i.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaArticulosBuscados = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArticulosBuscados;
            dgvArticulos.Columns["id"].Visible = false;
            //evento Text_Changed parece mejor..
        }

        private void CbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string OpcionCampo = CbCampo.SelectedItem.ToString();
            if(OpcionCampo == "Precio")
            {
                CbCriterio.Items.Clear();
                CbCriterio.Items.Add("Menor a");
                CbCriterio.Items.Add("Mayor a");
                CbCriterio.Items.Add("Igual a");
            }else
            {
                CbCriterio.Items.Clear();
                CbCriterio.Items.Add("Termina con");
                CbCriterio.Items.Add("Empieza con");
                CbCriterio.Items.Add("Exacto");
            }
        }

        private void BtFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloManager articuloFiltrado = new ArticuloManager();
            try
            {
                string campo = CbCampo.SelectedItem.ToString();
                string criterio = CbCriterio.SelectedItem.ToString();
                string filtro = TbFiltro.Text;
                dgvArticulos.DataSource = articuloFiltrado.filtrar(campo, criterio, filtro);
                dgvArticulos.Columns["id"].Visible = false;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtOrdenar_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager Articulo = new ArticuloManager();
            lista = Articulo.ordenarLista(listaArticulos);
            dgvArticulos.DataSource = lista;
        }

        private void BTOrdenaralfabetico_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloManager Articulo = new ArticuloManager();
            lista = Articulo.ordenarListaAlfabeto(listaArticulos);
            dgvArticulos.DataSource = lista;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            nroImagen++;
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagenes[nroImagen].ImagenUrl);
            habilitarControles();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            nroImagen--;

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagenes[nroImagen].ImagenUrl);
            habilitarControles();
        }

        private void habilitarControles()
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            if (seleccionado.Imagenes.Count > 0 && nroImagen < seleccionado.Imagenes.Count-1)
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }

            if (nroImagen > 0)
                
            {
                btnAnterior.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = false;
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalle detalle = new frmDetalle(seleccionado);
            detalle.ShowDialog();
            cargar();
        }
    }
}

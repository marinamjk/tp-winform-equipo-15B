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

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
            CbCampo.Items.Add("Precio");
            CbCampo.Items.Add("Marca");
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();            
            
        }

        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagenes[0].ImagenUrl);
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
                pbArticulo.Load(listaArticulos[0].Imagenes[0].ImagenUrl);
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
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
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
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro e la base de datos?","Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
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
                string campo = CbCampo.SelectedText.ToString();
                string criterio = CbCriterio.SelectedText.ToString();
                string filtro = TbFiltro.Text;
                dgvArticulos.DataSource = articuloFiltrado.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

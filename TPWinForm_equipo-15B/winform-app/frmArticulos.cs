using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

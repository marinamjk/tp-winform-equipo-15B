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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();

        }
          
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaManager marcaManager = new MarcaManager();

            try
            {
                List<Marca> marcas = marcaManager.listar();
                dgvMarcas.DataSource = marcas;
                dgvMarcas.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaMarca agregarMarca= new frmAltaMarca();
            agregarMarca.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAltaMarca modificarMarca = new frmAltaMarca(marcaSeleccionada);
            modificarMarca.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaManager marcaManagaer = new MarcaManager();
            ArticuloManager artManager = new ArticuloManager();
            List<Articulo> articulos;

            Marca seleccionada;

            try
            {
                articulos = artManager.listar();
                seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                foreach (var item in articulos)
                {
                    if (item.Marca.Id == seleccionada.Id)
                    {
                        MessageBox.Show("No se puede eliminar esta marca porque hay productos asociados.");
                        return;
                    }
                }
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar esta marca?", "Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    marcaManagaer.eliminar(seleccionada.Id);
                    cargar();
                }
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

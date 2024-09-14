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
    }
}

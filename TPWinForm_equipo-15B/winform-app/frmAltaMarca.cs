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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }
        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();

            try
            {
                if(marca==null)
                    marca=new Marca();
                marca.Descripcion = txtAgregar.Text;

                if (marca.Id != 0)
                {
                    marcaManager.modificar(marca);
                    MessageBox.Show("Modificada exitosamente");
                } 
                else
                {
                    marcaManager.agregar(marca);
                    MessageBox.Show("Agregada exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    txtAgregar.Text = marca.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }
    }
}

﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verCatálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmArticulos))
                {
                    MessageBox.Show("La ventana de Artículos ya se encuentra abierta.");
                    return;
                }
            }
            frmArticulos ventanaArticulos= new frmArticulos();
            ventanaArticulos.MdiParent = this;
            ventanaArticulos.Show();
        }

        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmMarcas))
                {
                    MessageBox.Show("La ventana de Marcas ya se encuentra abierta.");
                    return;
                }
            }
            frmMarcas ventanaMarcas = new frmMarcas();
            ventanaMarcas.MdiParent = this;
            ventanaMarcas.Show();
        }

        private void verListadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmCastegorias))
                {
                    MessageBox.Show("La ventana de Artículos ya se encuentra abierta.");
                    return;
                }
            }
            FrmCastegorias ventanaArticulos= new FrmCastegorias();
            ventanaArticulos.MdiParent = this;
            ventanaArticulos.Show();
        }
    }
}

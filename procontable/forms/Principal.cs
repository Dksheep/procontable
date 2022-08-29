using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procontable.forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        /* variables */
        private void Principal_Load(object sender, EventArgs e)
        {

        }

        /* Botones Strip */
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Ventas fConsuntaVentas = forms.Ventas.ventana_unica();
            fConsuntaVentas.MdiParent = this;
            fConsuntaVentas.Show();
            fConsuntaVentas.BringToFront();
        }      
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /* Metodos */
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

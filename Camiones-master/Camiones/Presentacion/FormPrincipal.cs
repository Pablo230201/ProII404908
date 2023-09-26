using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camiones.Presentacion;

namespace Camiones
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CargasCamiones().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir??"
                , "SALIENDO"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCarga consulta = new FrmConsultarCarga();
            consulta.ShowDialog();
        }
    }
}

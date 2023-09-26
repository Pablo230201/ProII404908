using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camiones.Presentacion
{
    public partial class FrmDetallesCargas : Form
    {
        public FrmDetallesCargas(int cargaNro)
        {
            InitializeComponent();
            this.Text += cargaNro.ToString();
        }
        public int cargaNro { get; set; }
    }
}

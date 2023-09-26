using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camiones.Datos;

namespace Camiones.Presentacion
{
    public partial class FrmConsultarCarga : Form
    {
        public FrmConsultarCarga()
        {
            InitializeComponent();
        }

        private void FrmConsultarCarga_Load(object sender, EventArgs e)
        {
            
        }

        
        private void dgvPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarga.CurrentCell.ColumnIndex == 3)
            {
                //int nro = int.Parse(dgvPresupuestos.CurrentRow.Cells["ColNro"].Value.ToString());
                int nro = Convert.ToInt32(dgvCarga.CurrentRow.Cells["ColPatente"].Value);
                FrmDetallesCargas detalle = new FrmDetallesCargas(nro); //llamada con constructor con parámetro.
                detalle.cargaNro = nro; //llamada con propiedad.   
                detalle.ShowDialog();
            }
        }

        private void grpFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            //validar campos de carga!!!
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@patente", txtPatente.Text));
            lst.Add(new Parametro("@id_estado", TxtEstado.Text));
            lst.Add(new Parametro("@peso_max", txtPeso.Text));


            DataTable tabla = new DBHelper().Consultar("SP_CONSULTAR_CAMIONES_MENOR", lst);
            dgvCarga.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                dgvCarga.Rows.Add(new object[] { fila["patente"].ToString(),
                                                        fila["id_estado"].ToString(),
                                                        fila["peso_max"].ToString(),
                                                        fila["acciones"]});
            }
        }
    }
}

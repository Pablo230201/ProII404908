using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camiones.Datos;
using Camiones.Entidades;


namespace Camiones.Presentacion
{
    public partial class CargasCamiones : Form
    {
        DBHelper gestor = null;
        Camione nuevoCamion = null;
        private bool primerCarga;
        private int iterar;

        public CargasCamiones()
        {
            InitializeComponent();
            gestor = new DBHelper();
            nuevoCamion = new Camione();
        }

        private void CargasCamiones_Load(object sender, EventArgs e)
        {
            txtPatente.Text = "ingresar una patente";
            txtPesoMaximo.Text = "0";
            txtPesoCarga.Text = "0";
            label1.Text = label1.Text + " " + gestor.ProximoCamion().ToString();
            CargarEstados();
            CargarProductos();
        }

        private void CargarEstados()
        {
            DataTable tabla = gestor.Consultar("SP_CONSULTAR_ESTADOS");
            cboEstado.DataSource = tabla;
            cboEstado.ValueMember = tabla.Columns[0].ColumnName;
            cboEstado.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void CargarProductos()
        {
            DataTable tabla = gestor.Consultar("SP_CONSULTAR_TIPOS_CARGA");
            cboTipoCarga.DataSource = tabla;
            cboTipoCarga.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCarga.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipoCarga.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una carga...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtPesoCarga.Text))
            {
                MessageBox.Show("Debe ingresar una carga valida...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Convert.ToInt32(txtPesoCarga.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Debe ingresar una carga valida...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                double pesoMaximo = Convert.ToInt32(txtPesoMaximo.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un maximo valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(primerCarga == true)
            {
                if (MessageBox.Show("Una vez agregada la primera carga no podra cambiar el peso maximo del camion!!", "Atencion"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation)== DialogResult.OK) 
                {
                    return;
                }
                else
                {
                    nuevoCamion.pesoMaximo = Convert.ToInt32(txtPesoMaximo.Text);
                    txtPesoMaximo.Enabled = false;
                    primerCarga = false;
                }
            }
            if((Convert.ToDouble(txtPesoCarga.Text)+nuevoCamion.CalcularTotal())> Convert.ToDouble(txtPesoMaximo.Text))
            {
                MessageBox.Show("No puede sumarse esa carga ya que supera el maximo del camion!", "Error", MessageBoxButtons.OK); 
                return;
            }
            AgregarCarga();


        }

        private void AgregarCarga()
        {
            foreach (DataGridViewRow row in dgvCargas.Rows)
            {
                if (row.Cells["Colid"].Value.ToString() == (cboTipoCarga.SelectedValue.ToString()))
                {
                    MessageBox.Show("Este producto ya fue presupuestado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DataRowView item = (DataRowView)cboTipoCarga.SelectedItem;
            int tipoCarga = (int)item.Row.ItemArray[0];
            string textoTipo = (string)item.Row.ItemArray[1];
            double peso = Convert.ToDouble(txtPesoCarga.Text);

            Carga nCarga = new Carga(iterar, peso, tipoCarga);
            iterar++;

            nuevoCamion.AgregarCarga(nCarga);
            dgvCargas.Rows.Add(new object[] { nCarga.id_Carga, peso, textoTipo, "Quitar" });
            CalcularPesoRestante();
        }

        private void CalcularPesoRestante()
        {
            txtPesoRestante.Enabled = false;
            txtPesoRestante.Text = "";
            txtPesoRestante.Text = nuevoCamion.PesoRestante().ToString();
        }
        private void GrabarCamion()
        {
            nuevoCamion.estadoCamion = (int)cboEstado.SelectedValue;
            nuevoCamion.Patente=txtPatente.Text;
            if (gestor.ConfirmarCarga(nuevoCamion))
            {
                MessageBox.Show("Se registró con éxito la carga...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la carga...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar el camion y su respectiva carga?", "CANCELAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                MessageBox.Show("Debe ingresar una patente...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvCargas.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una carga...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Confirmar o Grabar
            GrabarCamion();
        }

        


    }
}

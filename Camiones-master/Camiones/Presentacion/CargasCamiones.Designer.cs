namespace Camiones.Presentacion
{
    partial class CargasCamiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKilosRestantes = new System.Windows.Forms.Label();
            this.txtPesoRestante = new System.Windows.Forms.TextBox();
            this.lblPesoRestante = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblKilosCarga = new System.Windows.Forms.Label();
            this.lblKilosMaximos = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.lblPesoMaximo = new System.Windows.Forms.Label();
            this.txtPesoCarga = new System.Windows.Forms.TextBox();
            this.lblPesoCarga = new System.Windows.Forms.Label();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.lblTipoCarga = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblCamionesNro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCargas = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKilosRestantes
            // 
            this.lblKilosRestantes.AutoSize = true;
            this.lblKilosRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKilosRestantes.Location = new System.Drawing.Point(747, 494);
            this.lblKilosRestantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilosRestantes.Name = "lblKilosRestantes";
            this.lblKilosRestantes.Size = new System.Drawing.Size(33, 20);
            this.lblKilosRestantes.TabIndex = 39;
            this.lblKilosRestantes.Text = "KG";
            // 
            // txtPesoRestante
            // 
            this.txtPesoRestante.Location = new System.Drawing.Point(586, 493);
            this.txtPesoRestante.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoRestante.Name = "txtPesoRestante";
            this.txtPesoRestante.Size = new System.Drawing.Size(156, 22);
            this.txtPesoRestante.TabIndex = 38;
            // 
            // lblPesoRestante
            // 
            this.lblPesoRestante.AutoSize = true;
            this.lblPesoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPesoRestante.Location = new System.Drawing.Point(438, 493);
            this.lblPesoRestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoRestante.Name = "lblPesoRestante";
            this.lblPesoRestante.Size = new System.Drawing.Size(124, 20);
            this.lblPesoRestante.TabIndex = 37;
            this.lblPesoRestante.Text = "Peso Restante:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(455, 550);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 28);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(236, 550);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(164, 28);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(684, 251);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblKilosCarga
            // 
            this.lblKilosCarga.AutoSize = true;
            this.lblKilosCarga.Location = new System.Drawing.Point(647, 258);
            this.lblKilosCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilosCarga.Name = "lblKilosCarga";
            this.lblKilosCarga.Size = new System.Drawing.Size(25, 16);
            this.lblKilosCarga.TabIndex = 33;
            this.lblKilosCarga.Text = "KG";
            // 
            // lblKilosMaximos
            // 
            this.lblKilosMaximos.AutoSize = true;
            this.lblKilosMaximos.Location = new System.Drawing.Point(390, 194);
            this.lblKilosMaximos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilosMaximos.Name = "lblKilosMaximos";
            this.lblKilosMaximos.Size = new System.Drawing.Size(25, 16);
            this.lblKilosMaximos.TabIndex = 32;
            this.lblKilosMaximos.Text = "KG";
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(151, 190);
            this.txtPesoMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(229, 22);
            this.txtPesoMaximo.TabIndex = 31;
            // 
            // lblPesoMaximo
            // 
            this.lblPesoMaximo.AutoSize = true;
            this.lblPesoMaximo.Location = new System.Drawing.Point(46, 194);
            this.lblPesoMaximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoMaximo.Name = "lblPesoMaximo";
            this.lblPesoMaximo.Size = new System.Drawing.Size(92, 16);
            this.lblPesoMaximo.TabIndex = 30;
            this.lblPesoMaximo.Text = "Peso Maximo:";
            // 
            // txtPesoCarga
            // 
            this.txtPesoCarga.Location = new System.Drawing.Point(424, 254);
            this.txtPesoCarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoCarga.Name = "txtPesoCarga";
            this.txtPesoCarga.Size = new System.Drawing.Size(213, 22);
            this.txtPesoCarga.TabIndex = 29;
            // 
            // lblPesoCarga
            // 
            this.lblPesoCarga.AutoSize = true;
            this.lblPesoCarga.Location = new System.Drawing.Point(371, 258);
            this.lblPesoCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoCarga.Name = "lblPesoCarga";
            this.lblPesoCarga.Size = new System.Drawing.Size(42, 16);
            this.lblPesoCarga.TabIndex = 28;
            this.lblPesoCarga.Text = "Peso:";
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Location = new System.Drawing.Point(106, 256);
            this.cboTipoCarga.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(229, 24);
            this.cboTipoCarga.TabIndex = 27;
            // 
            // lblTipoCarga
            // 
            this.lblTipoCarga.AutoSize = true;
            this.lblTipoCarga.Location = new System.Drawing.Point(15, 258);
            this.lblTipoCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCarga.Name = "lblTipoCarga";
            this.lblTipoCarga.Size = new System.Drawing.Size(78, 16);
            this.lblTipoCarga.TabIndex = 26;
            this.lblTipoCarga.Text = "Tipo Carga:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(151, 144);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(229, 24);
            this.cboEstado.TabIndex = 24;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(86, 147);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado ";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(151, 92);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(373, 22);
            this.txtPatente.TabIndex = 22;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(76, 96);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(59, 16);
            this.lblPatente.TabIndex = 21;
            this.lblPatente.Text = "Patente :";
            // 
            // lblCamionesNro
            // 
            this.lblCamionesNro.AutoSize = true;
            this.lblCamionesNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblCamionesNro.Location = new System.Drawing.Point(146, -43);
            this.lblCamionesNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamionesNro.Name = "lblCamionesNro";
            this.lblCamionesNro.Size = new System.Drawing.Size(119, 26);
            this.lblCamionesNro.TabIndex = 20;
            this.lblCamionesNro.Text = "Camion N°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Camion N°";
            // 
            // dgvCargas
            // 
            this.dgvCargas.AllowUserToAddRows = false;
            this.dgvCargas.AllowUserToDeleteRows = false;
            this.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColPeso,
            this.ColTipoCarga,
            this.ColAcciones});
            this.dgvCargas.Location = new System.Drawing.Point(79, 314);
            this.dgvCargas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCargas.Name = "dgvCargas";
            this.dgvCargas.ReadOnly = true;
            this.dgvCargas.RowHeadersWidth = 51;
            this.dgvCargas.Size = new System.Drawing.Size(723, 126);
            this.dgvCargas.TabIndex = 41;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 150;
            // 
            // ColPeso
            // 
            this.ColPeso.HeaderText = "Peso";
            this.ColPeso.MinimumWidth = 6;
            this.ColPeso.Name = "ColPeso";
            this.ColPeso.ReadOnly = true;
            this.ColPeso.Width = 200;
            // 
            // ColTipoCarga
            // 
            this.ColTipoCarga.HeaderText = "Tipo de Carga";
            this.ColTipoCarga.MinimumWidth = 6;
            this.ColTipoCarga.Name = "ColTipoCarga";
            this.ColTipoCarga.ReadOnly = true;
            this.ColTipoCarga.Width = 150;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.MinimumWidth = 6;
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Quitar";
            this.ColAcciones.Width = 125;
            // 
            // CargasCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 586);
            this.Controls.Add(this.dgvCargas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKilosRestantes);
            this.Controls.Add(this.txtPesoRestante);
            this.Controls.Add(this.lblPesoRestante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblKilosCarga);
            this.Controls.Add(this.lblKilosMaximos);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.lblPesoMaximo);
            this.Controls.Add(this.txtPesoCarga);
            this.Controls.Add(this.lblPesoCarga);
            this.Controls.Add(this.cboTipoCarga);
            this.Controls.Add(this.lblTipoCarga);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblCamionesNro);
            this.Name = "CargasCamiones";
            this.Text = "CargasCamiones";
            this.Load += new System.EventHandler(this.CargasCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilosRestantes;
        private System.Windows.Forms.TextBox txtPesoRestante;
        private System.Windows.Forms.Label lblPesoRestante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblKilosCarga;
        private System.Windows.Forms.Label lblKilosMaximos;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label lblPesoMaximo;
        private System.Windows.Forms.TextBox txtPesoCarga;
        private System.Windows.Forms.Label lblPesoCarga;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.Label lblTipoCarga;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblCamionesNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoCarga;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}
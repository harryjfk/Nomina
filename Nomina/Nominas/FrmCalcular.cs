using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina.Nominas
{
    public partial class FrmCalcular : DevExpress.XtraEditors.XtraForm
    {
        public FrmCalcular()
        {
            InitializeComponent();
        }

        private void t_SolicitudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_SolicitudBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmCalcular_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNom' Puede moverla o quitarla según sea necesario.
            this.t_TipoNomTableAdapter.Fill(this.dSDatos.T_TipoNom);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNomPagar' Puede moverla o quitarla según sea necesario.
            this.t_TipoNomPagarTableAdapter.Fill(this.dSDatos.T_TipoNomPagar);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Solicitud' Puede moverla o quitarla según sea necesario.
            this.t_SolicitudTableAdapter.Fill(this.dSDatos.T_Solicitud);

        }
    }
}
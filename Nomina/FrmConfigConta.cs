using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina
{
    public partial class FrmConfigConta : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfigConta()
        {
            InitializeComponent();
        }

        private void FrmConfigConta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoCuenta' Puede moverla o quitarla según sea necesario.
            this.t_TipoCuentaTableAdapter.Fill(this.dSDatos.T_TipoCuenta);
            this.t_CuentaTableAdapter.Fill(this.dSDatos.T_Cuenta);

        }

        private void t_TipoCuentaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_TipoCuentaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoCuentaTableAdapter.Update(dSDatos.T_TipoCuenta);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_CuentaTableAdapter.Update(dSDatos.T_Cuenta);
        }
    }
}
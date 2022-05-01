using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina.Reportes
{
    public partial class FrmRepPlantilla : DevExpress.XtraEditors.XtraForm
    {
        public FrmRepPlantilla()
        {
            InitializeComponent();
        }

        private void t_DivisionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_DivisionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPlantilla);

        }

        private int t;
        private void FrmRepPlantilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Dpto' Puede moverla o quitarla según sea necesario.
            this.t_DptoTableAdapter.Fill(this.dSPlantilla.T_Dpto);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Taller' Puede moverla o quitarla según sea necesario.
            this.t_TallerTableAdapter.Fill(this.dSPlantilla.T_Taller);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Division' Puede moverla o quitarla según sea necesario.
            this.t_DivisionTableAdapter.Fill(this.dSPlantilla.T_Division);

        }

        private void t_DivisionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


            t = ((DevExpress.XtraGrid.Views.Grid.GridView) sender).GetDataSourceRowIndex(e.FocusedRowHandle);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            t = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetDataSourceRowIndex(e.FocusedRowHandle);
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            t = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetDataSourceRowIndex(e.FocusedRowHandle);
        }

        private void buttonEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            t_DivisionBindingSource.Position = t;
            
        }

        private void gridLookUpEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            fKTTallerTTallerBindingSource.Position = t;
        }

        private void gridLookUpEdit2_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            fKTDptoTTallerBindingSource.Position = t;
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
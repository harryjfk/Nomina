using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina.Plantilla
{
    public partial class FrmMovimientos : DevExpress.XtraEditors.XtraForm
    {
        public FrmMovimientos()
        {
            InitializeComponent();
        }

        private void t_MovimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_MovimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPlantilla);

        }

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
            this.t_PlantillaTableAdapter.Fill(this.dSPlantilla.T_Plantilla);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_TipoMov' Puede moverla o quitarla según sea necesario.
            this.t_TipoMovTableAdapter.Fill(this.dSPlantilla.T_TipoMov);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Movimiento' Puede moverla o quitarla según sea necesario.
            this.t_MovimientoTableAdapter.Fill(this.dSPlantilla.T_Movimiento);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNewMovimiento newMov = new FrmNewMovimiento();
            if (newMov.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) 
            {FrmMovimientos_Load(this,null);}

        
        }
    }
}
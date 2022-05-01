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
    public partial class FrmConfigPlantilla : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfigPlantilla()
        {
            InitializeComponent();
        }

        private void t_TurnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_TurnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPlantilla);

        }

        private void FrmConfigPlantilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plus' Puede moverla o quitarla según sea necesario.
            this.t_PlusTableAdapter.Fill(this.dSPlantilla.T_Plus);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_PDT' Puede moverla o quitarla según sea necesario.
            this.t_PDTTableAdapter.Fill(this.dSPlantilla.T_PDT);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_TipoEst' Puede moverla o quitarla según sea necesario.
            this.t_TipoEstTableAdapter.Fill(this.dSPlantilla.T_TipoEst);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Escala' Puede moverla o quitarla según sea necesario.
            this.t_EscalaTableAdapter.Fill(this.dSPlantilla.T_Escala);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Categoria' Puede moverla o quitarla según sea necesario.
            this.t_CategoriaTableAdapter.Fill(this.dSPlantilla.T_Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Turno' Puede moverla o quitarla según sea necesario.
            this.t_TurnoTableAdapter.Fill(this.dSPlantilla.T_Turno);

        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_CategoriaTableAdapter.Update(dSPlantilla.T_Categoria);
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_EscalaTableAdapter.Update(dSPlantilla.T_Escala);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TurnoTableAdapter.Update(dSPlantilla.T_Turno);
        }

        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_PDTTableAdapter.Update(dSPlantilla.T_PDT);
        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoEstTableAdapter.Update(dSPlantilla.T_TipoEst);
        }

        private void gridView6_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_PlusTableAdapter.Update(dSPlantilla.T_Plus);
        }
    }
}
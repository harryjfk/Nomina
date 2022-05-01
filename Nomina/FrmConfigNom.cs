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
    public partial class FrmConfigNom : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfigNom()
        {
            InitializeComponent();
        }

  

        private void FrmConfigNom_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNomPagar' Puede moverla o quitarla según sea necesario.
            this.t_TipoNomPagarTableAdapter.Fill(this.dSDatos.T_TipoNomPagar);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Dpto' Puede moverla o quitarla según sea necesario.
             // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
              this.t_TipoNomTableAdapter.Fill(this.dSDatos.T_TipoNom);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Centro' Puede moverla o quitarla según sea necesario.
              this.T_TipoNomDesTableAdapter.Fill(this.dSDatos.T_TipoNomDes);
       
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoNomTableAdapter.Update(dSDatos.T_TipoNom);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
      
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            T_TipoNomDesTableAdapter.Update(dSDatos.T_TipoNomDes);
        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           
        }

        private void t_TipoNomPagarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
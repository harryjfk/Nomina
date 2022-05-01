using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Nomina.Plantilla;

namespace Nomina
{
    public partial class FrmPlantilla : DevExpress.XtraEditors.XtraForm
    {
        public FrmPlantilla()
        {
            InitializeComponent();
        }

        private void FrmPlantilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Escala' Puede moverla o quitarla según sea necesario.
            this.t_EscalaTableAdapter.Fill(this.dSPlantilla.T_Escala);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_TipoEst' Puede moverla o quitarla según sea necesario.
            this.t_TipoEstTableAdapter.Fill(this.dSPlantilla.T_TipoEst);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Turno' Puede moverla o quitarla según sea necesario.
            this.t_TurnoTableAdapter.Fill(this.dSPlantilla.T_Turno);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Categoria' Puede moverla o quitarla según sea necesario.
            this.t_CategoriaTableAdapter.Fill(this.dSPlantilla.T_Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNom' Puede moverla o quitarla según sea necesario.
            this.t_TipoNomTableAdapter.Fill(this.dSDatos.T_TipoNom);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNomDes' Puede moverla o quitarla según sea necesario.
            this.T_TipoNomDesTableAdapter.Fill(this.dSDatos.T_TipoNomDes);
            gridControl2.Tag = 0;
               // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Division' Puede moverla o quitarla según sea necesario.
            this.t_DivisionTableAdapter.Fill(this.dSPlantilla.T_Division);

            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Taller' Puede moverla o quitarla según sea necesario.
            this.t_TallerTableAdapter.Fill(this.dSPlantilla.T_Taller);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Dpto' Puede moverla o quitarla según sea necesario.
            this.t_DptoTableAdapter.Fill(this.dSPlantilla.T_Dpto);
         
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
            this.t_PlantillaTableAdapter.Fill(this.dSPlantilla.T_Plantilla);
            repositoryItemPopupContainerEdit1.PopupControl = ucNewData1.popupContainerControl1;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEdit frmEdit = new FrmEdit();
          
            frmEdit.Type = int.Parse((e.Item).Tag.ToString());
            frmEdit.Editing = -1;
           
            frmEdit.Aceptar += new DelAceptar(frmEdit_Aceptar);
            frmEdit.ShowDialog(this);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            FrmEdit frmEdit = new FrmEdit();
            frmEdit.Type = int.Parse(gridControl2.Tag.ToString());
            if (frmEdit.Type==0)
            frmEdit.Editing = ((DSPlantilla.T_DivisionRow)((DataRowView)tDivisionBindingSource.Current).Row).iddivision;
            else
           if (frmEdit.Type==1)
            frmEdit.Editing = ((DSPlantilla.T_TallerRow)((DataRowView)fKTTallerTTallerBindingSource.Current).Row).idtaller;
            else
            if(frmEdit.Type==2)
                frmEdit.Editing = ((DSPlantilla.T_DptoRow)((DataRowView)fKTDptoTTallerBindingSource.Current).Row).iddpto;
            else
             frmEdit.Editing = ((DSPlantilla.T_PlantillaRow)((DataRowView)fKTPlantillaTDptoBindingSource.Current).Row).idplantilla;
            frmEdit.Aceptar += new DelAceptar(frmEdit_Aceptar);
            frmEdit.ShowDialog(this);
        }

        void frmEdit_Aceptar(object sender)
        {
            FrmPlantilla_Load(null, null);
            if (((FrmEdit)sender).Type == 2)
                ucNewData1.ReFill();
            //throw new NotImplementedException();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = int.Parse((e.Item).Tag.ToString());
            if (t==0)
            {
            tDivisionBindingSource.RemoveCurrent();
            tDivisionBindingSource.EndEdit();
            t_DivisionTableAdapter.Update(dSPlantilla.T_Division);
            ucNewData1.UpdateDeleted();
            }
            else
                if (t==1)
            {
                fKTTallerTTallerBindingSource.RemoveCurrent();
                fKTTallerTTallerBindingSource.EndEdit();
                t_TallerTableAdapter.Update(dSPlantilla.T_Taller);
                ucNewData1.UpdateDeleted();
            }
                else
                    if (t==2)
                    {
                        
                    }
                    else
                    {
                        //fKTDptoTTallerBindingSource1.RemoveCurrent();
                        //fKTDptoTTallerBindingSource1.EndEdit();
                        //t_PlantillaTableAdapter.Update(dSPlantilla.T_Plantilla);
                        //ucNewData1.UpdateDeleted();   
                    }
        }


        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridControl2.Tag = 0;
            
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridControl2.Tag = 1;
            fKTTallerTTallerBindingSource.Filter ="idtaller = "+ ((DSPlantilla.T_TallerRow) ((DevExpress.XtraGrid.Views.Grid.GridView) sender).GetDataRow(e.RowHandle)).
                idtaller;
            fKTDptoTTallerBindingSource.Filter = "";
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void repositoryItemPopupContainerEdit1_Popup(object sender, EventArgs e)
        {

        }

        private void repositoryItemPopupContainerEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void gridView4_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridControl2.Tag = 2;
            fKTTallerTTallerBindingSource.Filter = "idtaller = " +
                                                   ((DSPlantilla.T_DptoRow)
                                                    ((DevExpress.XtraGrid.Views.Grid.GridView) sender).GetDataRow(
                                                        e.RowHandle)).
                                                       idtaller;
            fKTDptoTTallerBindingSource.Filter = "iddpto = " + ((DSPlantilla.T_DptoRow)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetDataRow(e.RowHandle)).
              iddpto;
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            gridControl2.Tag = 3;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Visible = barButtonItem8.Down;
            gridControl3.Visible = !splitContainerControl1.Visible;
        }


    }
}
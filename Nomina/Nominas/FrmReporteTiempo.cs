using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Nomina.Plantilla;

namespace Nomina.Nominas
{
    public partial class FrmReporteTiempo : DevExpress.XtraEditors.XtraForm
    {
        public FrmReporteTiempo()
        {
            InitializeComponent();
        }

        private void t_DptoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_DptoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPlantilla);

        }

        private void FrmReporteTiempo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ReporteTiempoOtrosPagos' Puede moverla o quitarla según sea necesario.
            this.t_ReporteTiempoOtrosPagosTableAdapter.Fill(this.dSDatos.T_ReporteTiempoOtrosPagos);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ReporteTiempoAjuste' Puede moverla o quitarla según sea necesario.
            this.t_ReporteTiempoAjusteTableAdapter.Fill(this.dSDatos.T_ReporteTiempoAjuste);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_RepEstado' Puede moverla o quitarla según sea necesario.
            this.t_RepEstadoTableAdapter.Fill(this.dSDatos.T_RepEstado);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ReporteTiempoEstado' Puede moverla o quitarla según sea necesario.
      
             this.t_PlantillaTableAdapter.Fill(this.dSPlantilla.T_Plantilla);
              this.t_PlantillaTableAdapter1.Fill(this.dSDatos.T_Plantilla);
            t_Report_AllTableAdapter1.Fill(dSDatos.T_Report_All);
               this.t_ReporteTiempoTableAdapter.Fill(this.dSDatos.T_ReporteTiempo);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Turno' Puede moverla o quitarla según sea necesario.
            this.t_TurnoTableAdapter.Fill(this.dSPlantilla.T_Turno);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_PDT' Puede moverla o quitarla según sea necesario.
            this.t_PDTTableAdapter.Fill(this.dSPlantilla.T_PDT);
            this.t_DptoTableAdapter.Fill(this.dSPlantilla.T_Dpto);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
            //Reporte.IdSolicitud = ((FrmMain)ParentForm).CurrentSolicitud;
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
        
            //idplantillaGridLookUpEdit_EditValueChanged(this, null);
            //Reporte.Fecha = DateTime.Now;
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Dpto' Puede moverla o quitarla según sea necesario.
        }

        DSDatos.T_ReporteTiempoRow Reporte { get
        {
            if (t_ReporteTiempoBindingSource.Current == null)
                return null;
            return ((DSDatos.T_ReporteTiempoRow) ((DataRowView) t_ReporteTiempoBindingSource.Current).Row);
        } }
       
        private void iddptoGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (iddptoGridLookUpEdit.EditValue is int)
            t_DptoBindingSource.Position = t_DptoBindingSource.Find("iddpto", iddptoGridLookUpEdit.EditValue);
          
        }

        private void idplantillaGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
                   idPlantillaGridLookUpEdit1.EditValue = idplantillaGridLookUpEdit.EditValue;

                if (idplantillaGridLookUpEdit.EditValue is int)
                {

                    t_ReporteTiempoBindingSource.Filter = "idsolicitud = " + ((FrmMain)ParentForm).CurrentSolicitud + " and idplantilla = " + idPlantillaGridLookUpEdit1.EditValue;
              
                     t_PlantillaBindingSource.Filter = "idplantilla = " + idplantillaGridLookUpEdit.EditValue;
              

                }
          
        }

        private void idPlantillaLabel_Click(object sender, EventArgs e)
        {

        }

        private object _type;
        private void SetType(int i)
        {


            dSDatos.T_ReporteTiempoNormal.Clear();
            dSDatos.T_ReporteTiempoEstado.Clear();

            checkEdit1.Checked = i == 1;
            checkEdit2.Checked = i == 2;
            checkEdit3.Checked = i == 3;
            checkEdit4.Checked = i == 4;

            switch (i)
            {
                case 1:
                    {
                        t_ReporteTiempoGridControl.DataSource = t_ReporteTiempoNormalBindingSource;

                        t_ReporteTiempoGridControl.DefaultView.PopulateColumns();
                        t_ReporteTiempoNormalTableAdapter.FillBy(dSDatos.T_ReporteTiempoNormal, Reporte.idreporte);
                        break;
                    }
                case 2:
                    {
                        t_ReporteTiempoGridControl.DataSource = T_ReporteTiempoEstadoBindingSource;

                        t_ReporteTiempoGridControl.DefaultView.PopulateColumns();
                        //((DevExpress.XtraGrid.Views.Grid.GridView)t_ReporteTiempoGridControl.Views[0]).Columns.RemoveAt()
                        ((DevExpress.XtraGrid.Views.Grid.GridView)t_ReporteTiempoGridControl.Views[0]).Columns[
                            "idrpestadi"].ColumnEdit = repositoryItemGridLookUpEdit1;
                        ((DevExpress.XtraGrid.Views.Grid.GridView) t_ReporteTiempoGridControl.Views[0]).Columns[
                            "idrpestadi"].Caption = "Estado";
                        t_ReporteTiempoEstadoTableAdapter.FillBy(dSDatos.T_ReporteTiempoEstado, Reporte.idreporte);

                        break;
                    }
                case 3:
                    {
                        t_ReporteTiempoGridControl.DataSource = T_ReporteTiempoAjusteBindingSource;
                        t_ReporteTiempoGridControl.DefaultView.PopulateColumns();
                   t_ReporteTiempoAjusteTableAdapter1.FillBy(dSDatos.T_ReporteTiempoAjuste, Reporte.idreporte);

                        break;
                        
                    }
                case 4:
                    {
                        t_ReporteTiempoGridControl.DataSource = T_ReporteTiempoOtrosPagosBindingSource;
                        t_ReporteTiempoGridControl.DefaultView.PopulateColumns();
                        ((DevExpress.XtraGrid.Views.Grid.GridView)t_ReporteTiempoGridControl.Views[0]).Columns[
                           "IdOtrosPagos"].ColumnEdit = repositoryItemGridLookUpEdit2;
                        ((DevExpress.XtraGrid.Views.Grid.GridView)t_ReporteTiempoGridControl.Views[0]).Columns[
                         "IdOtrosPagos"].Caption = "Pagos";
                        t_ReporteTiempoOtrosPagosTableAdapter1.FillBy(dSDatos.T_ReporteTiempoOtrosPagos, Reporte.idreporte);
                        break;
                    }

            }
            ((DevExpress.XtraGrid.Views.Grid.GridView)t_ReporteTiempoGridControl.Views[0]).Columns.RemoveAt(0);

        }
        private void t_ReporteTiempoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
 
          
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //if(_type == null)
            //{
                
            //    _type = 1;


            //}
            var s = (int)_type;
            t_ReporteTiempoTableAdapter.Update(dSDatos.T_ReporteTiempo);
            var w = dSDatos.T_Report_All.NewT_Report_AllRow();
            w.idreport = Reporte.idreporte;
            w.type = (int)_type;
            
            
                    
            switch (s)
            {
                case 1:
                    {
                        t_ReporteTiempoNormalTableAdapter.Update(dSDatos.T_ReporteTiempoNormal);
                 
                        w.idall =
                            (int)t_ReporteTiempoTableAdapter.F_GetLastReal(1);
                         break;
                    }
                case 2:
                    {
                        t_ReporteTiempoEstadoTableAdapter.Update(dSDatos.T_ReporteTiempoEstado);
                        w.idall = (int)t_ReporteTiempoTableAdapter.F_GetLastReal(2);
                        break;
                    }
                case 3:
                    {
                        t_ReporteTiempoAjusteTableAdapter1.Update(dSDatos.T_ReporteTiempoAjuste);
                        w.idall = (int)t_ReporteTiempoTableAdapter.F_GetLastReal(3);
                        break;

                    }
                case 4:
                    {
                        t_ReporteTiempoOtrosPagosTableAdapter1.Update(dSDatos.T_ReporteTiempoOtrosPagos);
                        w.idall = (int)t_ReporteTiempoTableAdapter.F_GetLastReal(4);
                        break;
 
                    }

            }
            dSDatos.T_Report_All.AddT_Report_AllRow(w);
            t_Report_AllTableAdapter1.Update(dSDatos.T_Report_All);

        }

        private bool HasData()

        {
            switch ((int)_type)
            {
                case 1:
                    return dSDatos.T_ReporteTiempoNormal.Count > 0;
                case 2:
                    return dSDatos.T_ReporteTiempoEstado.Count > 0;
                case 3:
                    return dSDatos.T_ReporteTiempoAjuste.Count > 0;
                case 4:
                    return dSDatos.T_ReporteTiempoOtrosPagos.Count > 0;
            }
            return false;
        }
        
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            ((CheckEdit)sender).CheckedChanged -= checkEdit1_CheckedChanged;
            if (((CheckEdit)sender).Checked == true)
            {
                var s = Int32.Parse(((CheckEdit)sender).Tag.ToString());
                if (_type == null)
                {
                    _type = s;
                    //checkEdit1.Checked = true;

                }
                if (s != (int)_type)
                {

                    if (HasData())
                    {
                        if (
                            XtraMessageBox.Show(
                                "Si cambia el tipo de reporte de tiempo se eliminara el actual.  Esta Operacion no se podra restaurar. \n Desea Continuar?",
                                "Desea Continuar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            t_ReporteTiempoTableAdapter.DeleteBy(Reporte.idreporte);
                            _type = s;
                        }
                    }
                    else
                        _type = s;

                }





                SetType((int)_type);
            }
            ((CheckEdit)sender).CheckedChanged += checkEdit1_CheckedChanged;
        }

        private void gridView2_ColumnChanged(object sender, EventArgs e)
        {

        }
        public DSPlantilla.T_PlantillaRow Plantilla { get { return  ((DSPlantilla.T_PlantillaRow)((DataRowView)t_PlantillaBindingSource.Current).Row); } }
        private void t_PlantillaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
 //if(Plantilla==null)
 //    return;
            
            if (Reporte != null)
            {
                dSDatos.T_ReporteTiempoEstado.Clear();
                dSDatos.T_ReporteTiempoNormal.Clear();
                _type = queriesTableAdapter1.F_GetType(Reporte.idreporte);
                if (_type == null)
                    _type = 1;
                if (_type is int)
                    SetType((int)_type);


            }
            else
                if (idplantillaGridLookUpEdit.EditValue is int)
                {
                    if ((int)idplantillaGridLookUpEdit.EditValue != Plantilla.idplantilla)
                    {
                        //t_DptoBindingSource.Position = t_DptoBindingSource.Find("iddpto", iddptoGridLookUpEdit.EditValue);

                        t_PlantillaBindingSource.Filter = "idplantilla = " + Plantilla.idplantilla;
                     
                        return;
                    }
                  

                    if (XtraMessageBox.Show("Desea crear un nuevo reporte de tiempo para este trabajador", "Nuevo Reporte de Tiempo??", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        var rep = dSDatos.T_ReporteTiempo.NewT_ReporteTiempoRow();

                        t_ReporteTiempoBindingSource.CurrentChanged -= t_ReporteTiempoBindingSource_CurrentChanged;
                        t_ReporteTiempoBindingSource.Filter = "";
                        rep.IdPlantilla = Plantilla.idplantilla;

                        rep.IdSolicitud = ((FrmMain)ParentForm).CurrentSolicitud;
                        rep.Fecha = DateTime.Now;
                        rep.Revisado = false;
                        rep.Cerrado = false;
                        dSDatos.T_ReporteTiempo.AddT_ReporteTiempoRow(rep);
                        t_ReporteTiempoBindingSource.ResumeBinding();

                        t_ReporteTiempoBindingSource.Filter = "idsolicitud = " + ((FrmMain)ParentForm).CurrentSolicitud + " and idplantilla = " + Plantilla.idplantilla;

                        //t_ReporteTiempoBindingSource.Position = 0;
                        t_ReporteTiempoBindingSource.CurrentChanged += t_ReporteTiempoBindingSource_CurrentChanged;
                        t_ReporteTiempoBindingSource.MoveLast();

                    }
                }
        }
    }
}
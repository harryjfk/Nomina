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
    public partial class FrmInicializar : DevExpress.XtraEditors.XtraForm
    {
        public FrmInicializar()
        {
            InitializeComponent();
        }

        private void t_SolicitudBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_SolicitudBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }
        private DateTime FechaInicial(DateTime FIncial)
        {

            DateTime FFinal;
            DateTime FInicial;
            //DSPlantilla dsPlant = new DSPlantilla();
            //DataRowView DRNPagar = (DataRowView)tTipoNomPagarBindingSource.Current;
            //if (((bool)DRNPagar["Mensual"]) == false)
            //{
                FFinal = FIncial.Subtract(TimeSpan.FromDays(15));
                if (FFinal.Month != FIncial.Month)
            FFinal =
                new DateTime(FIncial.Year, FIncial.Month, 1);
            //    if (FInicial < FFinal && FIncial < FInicial)
            //        FFinal = FInicial;
            //}
            ///else
            //    FFinal =
            //        new DateTime(FIncial.AddMonths(1).Year, FIncial.AddMonths(1).Month, 1).Subtract(TimeSpan.FromDays(1));
            return FFinal;

            

        }
        private DateTime FechaFinal(DateTime FIncial)
        {

            DateTime FFinal;
            DateTime FInicial;
                //DSPlantilla dsPlant = new DSPlantilla();
                DataRowView DRNPagar = (DataRowView)tTipoNomPagarBindingSource.Current;
            if (((bool) DRNPagar["Mensual"]) == false)
            {
                FInicial = new DateTime(FIncial.Year, FIncial.Month, 15);
                FFinal =
                    new DateTime(FIncial.AddMonths(1).Year, FIncial.AddMonths(1).Month, 1).Subtract(TimeSpan.FromDays(1));
                if (FInicial < FFinal && FIncial < FInicial)
                    FFinal = FInicial;
            }
            else
                FFinal =
                    new DateTime(FIncial.AddMonths(1).Year, FIncial.AddMonths(1).Month, 1).Subtract(TimeSpan.FromDays(1));
            return FFinal;
            
        

        }
        private void FrmInicializar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNomPagar' Puede moverla o quitarla según sea necesario.
            this.t_TipoNomPagarTableAdapter.Fill(this.dSDatos.T_TipoNomPagar);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Meses' Puede moverla o quitarla según sea necesario.
            this.t_MesesTableAdapter.Fill(this.dSDatos.T_Meses);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Solicitud' Puede moverla o quitarla según sea necesario.
            this.t_SolicitudTableAdapter.Fill(this.dSDatos.T_Solicitud);

            t_SolicitudBindingSource.AddNew();
            t_SolicitudBindingSource.MoveLast();
            noSolGridLookUpEdit.Text = queriesTableAdapter1.F_GetNoSolicitud(true).ToString();
            var validation = (DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule)dxValidationProvider1.GetValidationRule(noSolGridLookUpEdit);
            validation.Value1 = queriesTableAdapter1.F_GetNoSolicitud(true);
            fInicioDateEdit.EditValue = DateTime.Now;
        }
        DSDatos.T_SolicitudRow Current {get{return (DSDatos.T_SolicitudRow)(((DataRowView)t_SolicitudBindingSource.Current).Row)
            ;
        }}

        private void idNominaPagarGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fInicioDateEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (fInicioDateEdit.EditValue is DateTime && fFinalDateEdit.Tag==null)
            {
                fInicioDateEdit.Tag = 0;
            fFinalDateEdit.EditValue = FechaFinal((DateTime) fInicioDateEdit.EditValue);
                fInicioDateEdit.Tag = null;
            }
        }

        private void fFinalDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if(fFinalDateEdit.EditValue is DateTime && fInicioDateEdit.Tag ==null)
            {
                fFinalDateEdit.Tag = 0;
                fInicioDateEdit.EditValue = FechaInicial((DateTime)fFinalDateEdit.EditValue);
                fFinalDateEdit.Tag = null;
            }
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            t_SolicitudBindingSource.EndEdit();
            t_SolicitudTableAdapter.Update(dSDatos.T_Solicitud);
            Close();
        }
    }
}
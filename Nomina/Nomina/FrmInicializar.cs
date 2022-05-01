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
        private DateTime FechaFinal(DateTime FIncial)
        {

            DateTime FFinal;
                //DSPlantilla dsPlant = new DSPlantilla();
                DataRowView DRNPagar = (DataRowView)tTipoNomPagarBindingSource.Current;
                if (((bool)DRNPagar["Mensual"]) == false)
                {
                    if (FIncial.Day == 1)
                    {
            FFinal = new DateTime(FIncial.Year, FIncial.Month, 15);
                    }
                    else
                    {
                        FFinal = new DateTime(FIncial.AddMonths(1).Year, FIncial.AddMonths(1).Month, 1).Subtract(TimeSpan.FromDays(1));
                    }

                }
                else
                {
                    FFinal = new DateTime(FIncial.AddMonths(1).Year, FIncial.AddMonths(1).Month, 1).Subtract(TimeSpan.FromDays(1));
                }
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
            noSolGridLookUpEdit.Text = queriesTableAdapter1.F_GetNoSolicitud().ToString();
            var validation = (DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule)dxValidationProvider1.GetValidationRule(noSolGridLookUpEdit);
            validation.Value1 = queriesTableAdapter1.F_GetNoSolicitud();
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
            if (fFinalDateEdit.EditValue!=null)
            fFinalDateEdit.EditValue = FechaFinal((DateTime) fFinalDateEdit.EditValue);
        }
    }
}
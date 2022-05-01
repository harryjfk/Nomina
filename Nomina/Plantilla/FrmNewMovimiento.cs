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
    public partial class FrmNewMovimiento : DevExpress.XtraEditors.XtraForm
    {
        public FrmNewMovimiento()
        {
            InitializeComponent();
        }
        
        private void t_MovimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_MovimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSPlantilla);

        }
        private DSPlantilla.T_MovimientoRow Current { get { return (DSPlantilla.T_MovimientoRow) ((DataRowView) t_MovimientoBindingSource.Current).Row; } }
        private void FrmNewMovimiento_Load(object sender, EventArgs e)
        {
            uTreeDept1.SetBinding();
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plus' Puede moverla o quitarla según sea necesario.
            this.t_PlusTableAdapter.Fill(this.dSPlantilla.T_Plus);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla_Plus' Puede moverla o quitarla según sea necesario.
            this.t_Plantilla_PlusTableAdapter.Fill(this.dSPlantilla.T_Plantilla_Plus);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Centro' Puede moverla o quitarla según sea necesario.
            this.t_CentroTableAdapter.Fill(this.dSDatos.T_Centro);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Escala' Puede moverla o quitarla según sea necesario.
            this.t_EscalaTableAdapter.Fill(this.dSPlantilla.T_Escala);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
            this.t_PlantillaTableAdapter.Fill(this.dSPlantilla.T_Plantilla);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_ConceptoBaja' Puede moverla o quitarla según sea necesario.
            this.t_ConceptoBajaTableAdapter.Fill(this.dSPlantilla.T_ConceptoBaja);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Movimiento' Puede moverla o quitarla según sea necesario.
            this.t_MovimientoTableAdapter.Fill(this.dSPlantilla.T_Movimiento);
            t_MovimientoBindingSource.AddNew();
            t_MovimientoBindingSource.MoveLast();
            uPlantilla1.Plantilla = -1;

            var validation = (DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule)dxValidationProvider1.GetValidationRule(nomovTextEdit);
            validation.Value1 = queriesTableAdapter1.F_GetNoMov();
            

        }
        private DSPlantilla.T_MovimientoRow CurrentMov { get { return (DSPlantilla.T_MovimientoRow)((DataRowView)t_MovimientoBindingSource.Current).Row; } }
        private void nomovLabel_Click(object sender, EventArgs e)
        {

        }

        private void iddptoSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uTreeDept1_OnChange(object sender)
        {
            popupContainerEdit1.Text = uTreeDept1.Text;
        }

        private void uTreeDept1_OnClose(object sender, EventArgs e)
        {
            popupContainerEdit1.ClosePopup();
        }

        private void t_PlantillaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            //uTreeDept1.Dpto = ((DSPlantilla.T_PlantillaRow) ((DataRowView) t_PlantillaBindingSource.Current).Row).iddpto;
        }

        private List<Control> CompareList = new List<Control>();

        String HasChanged(DSPlantilla.T_PlantillaRow row)
        {
            String t = "";
            foreach (Control c in CompareList)
                if(c.Text != ((DevExpress.XtraEditors.BaseEdit)c.Tag).Text)
            {
                var s = ((System.Windows.Forms.Binding)((DevExpress.XtraEditors.BaseEdit)c.Tag).DataBindings["EditValue"]);
                row[s.BindingMemberInfo.BindingMember] = ((DevExpress.XtraEditors.BaseEdit) c.Tag).EditValue;
                    if(t=="")
                t+= ((Control)c.Tag).Tag.ToString() + ":"+ ((Control)c.Tag).Text;
                    else
                        t += " - "+((Control)c.Tag).Tag.ToString() + " : " + ((Control)c.Tag).Text;

            }
            t_PlantillaTableAdapter.Update(row);
            return t;
        }
        private void CopyData(Control source,Control dest, object item)
        {
            dest.Tag = source;
            dest.Text = item.ToString();
            CompareList.Add(dest);
        }
        private void CopyAllData()
        {
            CompareList.Clear();
            var current = ((DSPlantilla.T_PlantillaRow)((DataRowView)t_PlantillaBindingSource.Current).Row);
             //textEdit1.Text = current.
            CopyData(tarifaHorariaTextEdit, textEdit1, current.TarifaHoraria);
            CopyData(tarifaMinimaTextEdit, textEdit2, current.TarifaMinima);
            CopyData(condiLabAnSpinEdit, spinEdit1, current.CondiLabAn);
            CopyData(idEscalaGridLookUpEdit, gridLookUpEdit2, idEscalaGridLookUpEdit.Text);
            CopyData(idcentrocostoGridLookUpEdit, gridLookUpEdit1, idcentrocostoGridLookUpEdit.Text);
        

        }
        private void lookUpEdit3_Properties_EditValueChanged(object sender, EventArgs e)
        {                if(lookUpEdit3.EditValue is int)
        {var p = t_PlantillaBindingSource.Find("idplantilla",lookUpEdit3.EditValue );

                    t_PlantillaBindingSource.Position = p;
                    CopyAllData();
        }
      
        }

      
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                
                uPlantilla1.UpdateChanges();
                CurrentMov.idplantila = uPlantilla1.Plantilla;
                CurrentMov.observacion = "Alta de trabajador";
            }
            else
                if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
                {
                    uPlantilla1.Plantilla = CurrentMov.idplantila;

                                CurrentMov.observacion = HasChanged(uPlantilla1.PlantillaRow);

                }
                else
                {
                    CurrentMov.observacion = "Baja";
                            uPlantilla1.Plantilla = CurrentMov.idplantila;
                    uPlantilla1.PlantillaRow.IsBaja = true;
                    t_PlantillaTableAdapter.Update(uPlantilla1.PlantillaRow);

                }
            CurrentMov.idtipomov = xtraTabControl1.SelectedTabPageIndex+1;
            CurrentMov.idmesconta = DateTime.Now.Month;
            if( xtraTabControl1.SelectedTabPage != xtraTabPage3)
            CurrentMov.fechamov = DateTime.Now;
            t_MovimientoBindingSource.EndEdit();
            t_MovimientoTableAdapter.Update(dSPlantilla.T_Movimiento);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

   
    

      

       
    }
}
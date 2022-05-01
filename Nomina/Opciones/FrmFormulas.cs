using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina.Opciones
{
    public partial class FrmFormulas : DevExpress.XtraEditors.XtraForm
    {
        public FrmFormulas()
        {
            InitializeComponent();
        }

        private void t_FormulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_FormulaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSFormulas);

        }

        private void FrmFormulas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSFormulas.T_Formula' Puede moverla o quitarla según sea necesario.
            this.t_FormulaTableAdapter.Fill(this.dSFormulas.T_Formula);

        }
        public DSFormulas.T_FormulaRow Current {get
        {
            if (t_FormulaBindingSource.Current == null)
                return null;
            else
                return ((DSFormulas.T_FormulaRow)((DataRowView)t_FormulaBindingSource.Current).Row);
        }}
        
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var edit = new FrmEditFormula();
            edit.DataSets = ((FrmMain) ParentForm).DataSets;
            //edit.FormClosed += new FormClosedEventHandler(edit_FormClosed);
           edit.Function = Current.valueformula;
            edit.Name = Current.nameformula;
            if( edit.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            {
                Current.valueformula = edit.Function;
                
                t_FormulaBindingSource.EndEdit();
                t_FormulaBindingSource.ResumeBinding();
                t_FormulaTableAdapter.Update(dSFormulas.T_Formula);
            }
        }

        public List<FuncData> Functions = new List<FuncData>();
        public void GetFunctions()
        {
          
            Functions.Clear();
            foreach (DSFormulas.T_FormulaRow formulaRow in dSFormulas.T_Formula)
            {
                var s = new FuncData(formulaRow.nameformula, formulaRow.valueformula);
                Functions.Add(s);

            }
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            /*  MathParser s  =new MathParser();
            s.BuildTree(dSFormulas.T_Formula);
            //s.Functions = Functions;
            //foreach (FuncData funcData in Functions)
            //    funcData.parser = s;
            //s.Functions = Functions;
            s.DataSets = ((FrmMain)ParentForm).DataSets;
            //s.String = Current.valueformula;
            //s.Name = Current.nameformula;
            if (Current != null)

                s.FromString(Current.nameformula, Current.valueformula);
            else
            {
                s.FromString("","");
            }
            var w = s.Evaluate();*/
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var edit = new FrmEditFormula();
            edit.Formulas = this;
            edit.DataSets = ((FrmMain)ParentForm).DataSets;
            if (edit.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

       
    }
}
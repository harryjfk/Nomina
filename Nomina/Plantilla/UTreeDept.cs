using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Nomina.Plantilla
{
    public partial class UTreeDept : DevExpress.XtraEditors.PopupContainerControl
    {
        public delegate void ChangeEvent(object sender);
        
        public UTreeDept()
        {
            InitializeComponent();
            t_DivisionTableAdapter.Fill(dSPlantilla.T_Division);
            t_TallerTableAdapter.Fill(dSPlantilla.T_Taller);
            t_DptoTableAdapter.Fill(dSPlantilla.T_Dpto);
          
          
        }
        
        public void SetBinding()
        { 
         var s = ((System.Windows.Forms.Binding)DataBindings["Tag"]);
         if (s != null) 
         ((BindingSource)s.DataSource).CurrentChanged += BindingSource_CurrentChanged;
        }
        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int dpto =(int)( (DataRowView)((BindingSource)sender).Current).Row["iddpto"];
            if (OwnerItem.OwnerEdit != null)
                OwnerItem.OwnerEdit.Text = dSPlantilla.T_Dpto.FindByiddpto(dpto).namedpto;
            

        }

  
        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            OwnerEdit.Text = Text;
            var s = ((System.Windows.Forms.Binding)DataBindings["Tag"]);
            if (s!=null)
                try
                {
            ((BindingSource)s.DataSource).EndEdit();
                    }
                catch
                {
                }

          this.OwnerEdit.ClosePopup();
            //if (OnClose != null)
            //    OnClose(this, null);
        }

        private DSPlantilla.T_DptoRow row=null;
       
        private void gridView4_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            row = (DSPlantilla.T_DptoRow) ((DevExpress.XtraGrid.Views.Grid.GridView) sender).GetDataRow(e.RowHandle);
            Text = row.namedpto;
            Tag = row.iddpto;
            
            //if (OnChange != null)
            //    OnChange(this);

        }
    }
}

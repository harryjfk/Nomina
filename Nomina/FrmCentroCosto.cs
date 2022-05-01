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
    public partial class FrmCentroCosto : DevExpress.XtraEditors.XtraForm
    {
        public FrmCentroCosto()
        {
            InitializeComponent();
        }

        private void FrmCentroCosto_Load(object sender, EventArgs e)
        {
         
            this.t_DptoTableAdapter.Fill(this.dSPlantilla.T_Dpto);
     
            this.t_CentroTableAdapter.Fill(this.dSDatos.T_Centro);
            this.t_Centro_DeptTableAdapter.Fill(this.dSDatos.T_Centro_Dept);
       
        }
    }
}
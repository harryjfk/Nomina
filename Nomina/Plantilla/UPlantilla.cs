using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina.Plantilla
{
    public partial class UPlantilla : DevExpress.XtraEditors.XtraUserControl
    {
        public UPlantilla()
        {
            InitializeComponent();
        }

        private void UPlantilla_Load(object sender, EventArgs e)
        {
           
  
        }
        private int edit;
        BindingSource bindingSource;
        
        public void UpdateChanges()
        {
            bindingSource.EndEdit();
            t_PlantillaTableAdapter.Update(dSPlantilla.T_Plantilla);
            t_Plantilla_PlusTableAdapter.Update(dSPlantilla.T_Plantilla_Plus);

            
            if (edit==-1)
            {
                t_PlantillaTableAdapter.Fill(dSPlantilla.T_Plantilla);
                bindingSource.Filter = "";
                bindingSource.MoveLast();
            }
            
            Plantilla = PlantillaRow.idplantilla;
        }
        public DSPlantilla.T_PlantillaRow PlantillaRow { get { return (DSPlantilla.T_PlantillaRow)((DataRowView)bindingSource.Current).Row; } }
        public int Plantilla { get { return edit; }

            set { edit = value;
            t_TallerTableAdapter.Fill(dSPlantilla.T_Taller);
            t_DptoTableAdapter.Fill(dSPlantilla.T_Dpto);
            t_PlantillaTableAdapter.Fill(dSPlantilla.T_Plantilla);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla_Plus' Puede moverla o quitarla según sea necesario.
            this.t_Plantilla_PlusTableAdapter.Fill(this.dSPlantilla.T_Plantilla_Plus);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_TipoEst' Puede moverla o quitarla según sea necesario.
            this.t_TipoEstTableAdapter.Fill(this.dSPlantilla.T_TipoEst);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_PDT' Puede moverla o quitarla según sea necesario.
            this.t_PDTTableAdapter.Fill(this.dSPlantilla.T_PDT);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Escala' Puede moverla o quitarla según sea necesario.
            this.t_EscalaTableAdapter.Fill(this.dSPlantilla.T_Escala);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Turno' Puede moverla o quitarla según sea necesario.
            this.t_TurnoTableAdapter.Fill(this.dSPlantilla.T_Turno);
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Categoria' Puede moverla o quitarla según sea necesario.
            this.t_CategoriaTableAdapter.Fill(this.dSPlantilla.T_Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoNom' Puede moverla o quitarla según sea necesario.
            this.t_TipoNomTableAdapter.Fill(this.dSDatos.T_TipoNom);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Centro' Puede moverla o quitarla según sea necesario.
            this.T_TipoNomDesTableAdapter.Fill(this.dSDatos.T_TipoNomDes);

            bindingSource = t_PlantillaBindingSource;

            if (edit == -1)
            {
                bindingSource.AddNew();
                bindingSource.MoveLast();
                
            }
            else
            {
                bindingSource.Filter = "idplantilla = " + edit;
               
              } 
                ucNewDataView1.WDataSource = bindingSource;
            }
        }

    }
}

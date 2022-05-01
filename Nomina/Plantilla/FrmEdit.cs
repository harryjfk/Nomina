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
    public delegate void DelAceptar(object sender);
    public partial class FrmEdit : DevExpress.XtraEditors.XtraForm
    {
        public event DelAceptar Aceptar;
        public FrmEdit()
        {
            InitializeComponent();
        }
        
//        public object bd {get{return }}
        
        public int Type { get; set; }
        private int edit;
        BindingSource bindingSource;
 
        public int Editing { get { return edit; } set { edit = value;
   
        t_DivisionTableAdapter1.Fill(dSPlantilla.T_Division);

     
            Control control=null;
        if (Type == 0)
        {

            Size = new Size(489, 158);
             bindingSource = t_DivisionBindingSource;
            control =panelControl2;
        }
        else
            if (Type==1)
            {
                Size = new Size(489, 172);
                t_TallerTableAdapter.Fill(dSPlantilla.T_Taller);  
                  bindingSource = t_TallerBindingSource;
                control = panelControl3;
            }
            else
                if (Type == 2)
                {
                    Size = new Size(489, 172);
                    t_TallerTableAdapter.Fill(dSPlantilla.T_Taller);
                    t_DptoTableAdapter.Fill(dSPlantilla.T_Dpto);
                    bindingSource = t_DptoBindingSource;
                    control = panelControl5;
                }
                if (Type == 3)
                {
                    // Size = new Size(489, 158);}
                  //t_TallerTableAdapter.Fill(dSPlantilla.T_Taller);
                  //  t_DptoTableAdapter.Fill(dSPlantilla.T_Dpto);
                  //  t_PlantillaTableAdapter.Fill(dSPlantilla.T_Plantilla);
                  //  bindingSource = t_PlantillaBindingSource;
                   control = uPlantilla1;
                }
        //else
        ///  bindingSource = 

                if (edit == -1 && Type<3)
                {
                    bindingSource.AddNew();
                    bindingSource.MoveLast();

                }
                else
                    if (Type == 0)
                        bindingSource.Filter = "iddivision = " + edit;

                    else if (Type == 1)

                        bindingSource.Filter = "idtaller = " + edit;
                    else if (Type == 2)
                        bindingSource.Filter = "iddpto = " + edit;
                    else
                        uPlantilla1.Plantilla = edit;
            ShowControlOnly(control);
            
        } 
        
        }
        private void ShowControlOnly(Control control)
        {
            foreach (Control c in control.Parent.Controls)
                if (c is PanelControl)
                c.Hide();
            control.Show();



        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            
           if (bindingSource!=null) 
        bindingSource.EndEdit();

        if (Type == 0)
            t_DivisionTableAdapter1.Update(dSPlantilla.T_Division);
        else
            if (Type == 1)
                t_TallerTableAdapter.Update(dSPlantilla.T_Taller);
            else
                if (Type == 2)
                {
                    t_DptoTableAdapter.Update(dSPlantilla.T_Dpto);
                }
            else
                if (Type == 3)
                {
                    uPlantilla1.UpdateChanges();
                }
            
            if (Aceptar != null)
                Aceptar(this);
            Close();
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
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
       //     t_PlantillaTableAdapter.Fill(dSPlantilla.T_Plantilla);   
            // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Dpto' Puede moverla o quitarla según sea necesario.
            //this.t_DptoTableAdapter.Fill(this.dSPlantilla.T_Dpto);
           // // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Plantilla' Puede moverla o quitarla según sea necesario.
          //  this.t_PlantillaTableAdapter.Fill(this.dSPlantilla.T_Plantilla);
           // // TODO: esta línea de código carga datos en la tabla 'dSPlantilla.T_Taller' Puede moverla o quitarla según sea necesario.
           //// this.t_TallerTableAdapter.Fill(this.dSPlantilla.T_Taller);
         
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sexoplantCheckEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
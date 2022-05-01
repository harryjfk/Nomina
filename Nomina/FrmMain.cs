using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACINOX.Components;
using ACINOX.Components.Forms;
using ACINOX.DBT;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Nomina.Nominas;
using Nomina.Opciones;
using Nomina.Plantilla;
using Nomina.Reportes;

//using Nomina.Plantilla;

namespace Nomina
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void CreateForm (Form form)
        {
            //foreach(Control f in Controls)
            //    if (f is MdiClient)
            //    {
                    
            //    }
            form.MdiParent = this;
            form.Show();
     
        }

        private int _currents;
        public int CurrentSolicitud { get { return _currents; } set { _currents = value; } }

        private DSDll.T_AccUsuarioRow user;
        private List<DataSet> _datasets;

        public DSDll.T_AccUsuarioRow Auth
        {
            get { return user; }
            set
            {
                user = value;
                //barStaticItem2.Caption = value.Nombre;
                barStaticItem1.Caption = value.Nombre;
                UCRepManager.FillGroup(ribbonPageGroup7,Properties.Settings.Default.NominaConnectionString,value.idusuario);
                //ucUser1.Connection = Carta_Limite.Properties.Settings.Default.Carta_LimiteConnectionString;
            }
        }
      
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmInicializar inicio = new FrmInicializar();
            inicio.ShowDialog(this);
            //XtraForm form = new XtraForm();
            //form.MdiParent = this;
            //form.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ACINOX.Functions.Skins.FillSkins(ribbonGalleryBarItem1);
            CurrentSolicitud = (int) queriesTableAdapter1.F_GetNoSolicitud(false);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmPlantilla());
        }

        private void ribbonPageGroup5_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            CreateForm(new FrmConfigPlantilla());
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void ribbonPageGroup2_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            CreateForm(new FrmConfigNom());
        }

        private void ribbonPageGroup4_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            CreateForm(new FrmConfigConta());
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

            CreateForm(new FrmCentroCosto());
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var repPlantilla = new FrmRepPlantilla();
            if (repPlantilla.ShowDialog(this)==DialogResult.OK)
            {
                var DS = new Plantilla.DSPlantilla();
                var P = new Plantilla.DSPlantillaTableAdapters.P_ImprimirPlantillaTableAdapter();
                
                P.Fill(DS.P_ImprimirPlantilla, (int?)repPlantilla.divisionedit.EditValue, (int?)repPlantilla.talleredit.EditValue,
                       (int?)repPlantilla.dptoedit.EditValue);

                FrmReportes frmReportes = new FrmReportes();
                CreateForm(frmReportes);
                if ((repPlantilla.divisionedit.EditValue == null) && (repPlantilla.talleredit.EditValue == null) && (repPlantilla.dptoedit.EditValue == null))
                    frmReportes.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Plantilladivision.repx", DS.P_ImprimirPlantilla, null);
                else
                     if ((repPlantilla.divisionedit.EditValue != null) && (repPlantilla.talleredit.EditValue == null) && (repPlantilla.dptoedit.EditValue == null))
                           frmReportes.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Plantillataller.repx",DS.P_ImprimirPlantilla,null);
                else
                     if ((repPlantilla.divisionedit.EditValue != null) && (repPlantilla.talleredit.EditValue != null) && (repPlantilla.dptoedit.EditValue != null))
                           frmReportes.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Plantilladpto.repx",DS.P_ImprimirPlantilla,null);
                
              
                


            }

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            FSave save = new FSave { Save = true, Connection = Properties.Settings.Default.NominaConnectionString };
            save.ShowDialog(this);
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            FSave save = new FSave { Save = false, Connection = Properties.Settings.Default.NominaConnectionString };
            save.ShowDialog(this);
        }

        private void barButtonItem14_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var repman = new FrmReportManager();
            CreateForm(repman);
            repman.ucRepManager1.ConnectionString = Properties.Settings.Default.NominaConnectionString;
            repman.ucRepManager1.User = Auth.idusuario;
            //        ucRepManager1.ImageIndex = 12; 
            //        ucRepManager1.OnclickButton+= new ItemClickEventHandler(ReportManagerClick);
            //        ucRepManager1.PageGroup = ribbonPageGroup9;
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmuser = new FrmUserManager();
            CreateForm(frmuser);
            frmuser.ucUser1.User = Auth;
            // ucUser1.Show();
            frmuser.ucUser1.Logging = LogType.UserGroup;
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmuser = new FrmUserManager();
            CreateForm(frmuser);
            frmuser.ucUser1.User = Auth;
            // ucUser1.Show();
            frmuser.ucUser1.Logging = LogType.UsersMg;
        }

        private void ribbonGalleryBarItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
       
        }

        private void ribbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Properties.Settings.Default.Skin = e.Item.Caption;
            Properties.Settings.Default.Save();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCUser.ChangePass(Auth,Nomina.Properties.Settings.Default.NominaConnectionString);
            
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmMovimientos());


        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmReporteTiempo());
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmFormulas());
        }

        public List<DataSet> DataSets
        {
            get
            {
                if (_datasets == null)
                {
                    _datasets = new List<DataSet>();
                    var s = new DSDatos();
                    t_CentroTableAdapter1.Fill(s.T_Centro);
                    _datasets.Add(s);
                    _datasets.Add(new DSPlantilla());

                }

                    return _datasets;
        }}

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCalcular());
        }
     
    }
}
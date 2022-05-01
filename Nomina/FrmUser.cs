using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Nomina
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void ucUser1_Resize(object sender, EventArgs e)
        {
            Height = ucUser1.Height + 40;
        }  
        private void UpdateConnect()
        {
          
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder(ucUser1.Connection);

                    ConfigurationSection section = config.GetSection("connectionStrings");
                    ConfigurationSection section1 = config.GetSection("NominaConnectionString");
                    config.ConnectionStrings.ConnectionStrings["Nomina.Properties.Settings.NominaConnectionString"
                        ].ConnectionString = ucUser1.Connection;
                 //   Properties.Settings.Default.VersatDB = ucUser1.Versat;

                    config.Save(ConfigurationSaveMode.Modified, true);
                    Properties.Settings.Default.Save();
                    ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
                    Properties.Settings.Default.Reload();

                    //this.Close();
                }
                catch (System.Data.DataException exec)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(exec.Message, "Error", MessageBoxButtons.OK,
                                                               MessageBoxIcon.Error);
                }
                catch (Exception exec)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(exec.Message, "Error", MessageBoxButtons.OK,

                        MessageBoxIcon.Error);

                }

          }

        private void ucUser1_AceptarClick(object sender)
        {
            UpdateConnect();
            FrmMain main = new FrmMain();
            //main.ucUser1.Connection = ucUser1.Connection;
            //   main.ucRepManager1.ConnectionString = ucUser1.Connection;

            Hide();
            main.Show();

            main.Auth = ucUser1.User;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            var s = Properties.Settings.Default.Skin;
            if (Properties.Settings.Default.Skin!="Ninguno")
            ACINOX.Functions.Skins.SetSkin(Properties.Settings.Default.Skin);
            ucUser1.Connection.RealConnection = Properties.Settings.Default.NominaConnectionString;
            //ucUser1.Versat = Properties.Settings.Default.VersatDB;

        }
    }
}
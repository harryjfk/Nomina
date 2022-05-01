namespace Nomina
{
    partial class FrmUserManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ACINOX.Components.ConnectionString connectionString1 = new ACINOX.Components.ConnectionString();
            this.ucUser1 = new ACINOX.Components.UCUser();
            this.SuspendLayout();
            // 
            // ucUser1
            // 
            connectionString1.Autologon = false;
            connectionString1.CDatabase = "Nomina";
            connectionString1.CDataSource = ".\\SQL2005";
            connectionString1.Connection = "Data Source=.\\SQL2005;Initial Catalog=Nomina;Persist Security Info=True;User ID=s" +
                "a;Password=123456";
            connectionString1.CPassword = "123456";
            connectionString1.CUser = "sa";
            connectionString1.RealConnection = "Nomina.Properties.Settings.NominaConnectionString";
            this.ucUser1.Connection = connectionString1;
            this.ucUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUser1.HeadText = "labelControl3";
            this.ucUser1.Location = new System.Drawing.Point(0, 0);
            this.ucUser1.Logging = ACINOX.Components.LogType.UsersMg;
            this.ucUser1.Name = "ucUser1";
            this.ucUser1.Picture = null;
            this.ucUser1.ShowConnection = true;
            this.ucUser1.Size = new System.Drawing.Size(522, 368);
            this.ucUser1.TabIndex = 1;
            this.ucUser1.Tag = 0;
            this.ucUser1.User = null;
            this.ucUser1.Versat = "";
            this.ucUser1.WindowsDefault = false;
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 368);
            this.Controls.Add(this.ucUser1);
            this.Name = "FrmUserManager";
            this.Text = "Administrar Usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        public ACINOX.Components.UCUser ucUser1;
    }
}
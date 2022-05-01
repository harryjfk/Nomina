namespace Nomina
{
    partial class FrmReportManager
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
            this.ucRepManager1 = new ACINOX.Components.UCRepManager();
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            this.SuspendLayout();
            // 
            // ucRepManager1
            // 
            this.ucRepManager1.ConnectionString = "";
            this.ucRepManager1.dataset = null;
            this.ucRepManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRepManager1.ImageIndex = 0;
            this.ucRepManager1.Location = new System.Drawing.Point(0, 0);
            this.ucRepManager1.Name = "ucRepManager1";
            this.ucRepManager1.PageGroup = null;
            this.ucRepManager1.Size = new System.Drawing.Size(597, 451);
            this.ucRepManager1.TabIndex = 2;
            this.ucRepManager1.User = -1;
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.ucRepManager1);
            this.Name = "FrmReportManager";
            this.Text = "Administrador Reportes";
            this.Load += new System.EventHandler(this.FrmReportManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ACINOX.Components.UCRepManager ucRepManager1;
        private Plantilla.DSPlantilla dSPlantilla;
    }
}
﻿namespace Nomina
{
    partial class FrmReportes
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
            this.ucReport1 = new MaxMin.UCReport();
            this.SuspendLayout();
            // 
            // ucReport1
            // 
            this.ucReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReport1.Location = new System.Drawing.Point(0, 0);
            this.ucReport1.Name = "ucReport1";
            this.ucReport1.Size = new System.Drawing.Size(628, 488);
            this.ucReport1.TabIndex = 0;
            this.ucReport1.ViewNormal = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 488);
            this.Controls.Add(this.ucReport1);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.ResumeLayout(false);

        }

        #endregion

        public MaxMin.UCReport ucReport1;

    }
}
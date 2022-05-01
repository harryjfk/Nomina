namespace Nomina.Reportes
{
    partial class FrmRepPlantilla
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
            this.components = new System.ComponentModel.Container();
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            this.t_DivisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_DivisionTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_DivisionTableAdapter();
            this.tableAdapterManager = new Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager();
            this.t_DptoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter();
            this.t_TallerTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_TallerTableAdapter();
            this.divisionedit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamedivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.talleredit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fKTTallerTTallerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dptoedit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fKTDptoTTallerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamedpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DivisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talleredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTTallerTTallerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptoedit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTDptoTTallerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_DivisionBindingSource
            // 
            this.t_DivisionBindingSource.DataMember = "T_Division";
            this.t_DivisionBindingSource.DataSource = this.dSPlantilla;
            this.t_DivisionBindingSource.CurrentChanged += new System.EventHandler(this.t_DivisionBindingSource_CurrentChanged);
            // 
            // t_DivisionTableAdapter
            // 
            this.t_DivisionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P_ImprimirPlantillaTableAdapter = null;
            this.tableAdapterManager.T_DivisionTableAdapter = this.t_DivisionTableAdapter;
            this.tableAdapterManager.T_DptoTableAdapter = this.t_DptoTableAdapter;
            this.tableAdapterManager.T_PlantillaTableAdapter = null;
            this.tableAdapterManager.T_TallerTableAdapter = this.t_TallerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_DptoTableAdapter
            // 
            this.t_DptoTableAdapter.ClearBeforeFill = true;
            // 
            // t_TallerTableAdapter
            // 
            this.t_TallerTableAdapter.ClearBeforeFill = true;
            // 
            // divisionedit
            // 
            this.divisionedit.Location = new System.Drawing.Point(92, 9);
            this.divisionedit.Name = "divisionedit";
            this.divisionedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.divisionedit.Properties.DataSource = this.t_DivisionBindingSource;
            this.divisionedit.Properties.DisplayMember = "namedivision";
            this.divisionedit.Properties.HideSelection = false;
            this.divisionedit.Properties.NullText = "";
            this.divisionedit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.divisionedit.Properties.ValueMember = "iddivision";
            this.divisionedit.Properties.View = this.gridLookUpEdit1View;
            this.divisionedit.Size = new System.Drawing.Size(237, 20);
            this.divisionedit.TabIndex = 0;
            this.divisionedit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.buttonEdit1_Closed);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamedivision});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridLookUpEdit1View_FocusedRowChanged);
            // 
            // colnamedivision
            // 
            this.colnamedivision.FieldName = "namedivision";
            this.colnamedivision.Name = "colnamedivision";
            this.colnamedivision.Visible = true;
            this.colnamedivision.VisibleIndex = 0;
            // 
            // talleredit
            // 
            this.talleredit.Location = new System.Drawing.Point(92, 35);
            this.talleredit.Name = "talleredit";
            this.talleredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.talleredit.Properties.DataSource = this.fKTTallerTTallerBindingSource;
            this.talleredit.Properties.DisplayMember = "nametaller";
            this.talleredit.Properties.NullText = "";
            this.talleredit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.talleredit.Properties.ValueMember = "idtaller";
            this.talleredit.Properties.View = this.gridView1;
            this.talleredit.Size = new System.Drawing.Size(237, 20);
            this.talleredit.TabIndex = 1;
            this.talleredit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.gridLookUpEdit1_Closed);
            // 
            // fKTTallerTTallerBindingSource
            // 
            this.fKTTallerTTallerBindingSource.DataMember = "FK_T_Taller_T_Taller";
            this.fKTTallerTTallerBindingSource.DataSource = this.t_DivisionBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametaller});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colnametaller
            // 
            this.colnametaller.FieldName = "nametaller";
            this.colnametaller.Name = "colnametaller";
            this.colnametaller.Visible = true;
            this.colnametaller.VisibleIndex = 0;
            // 
            // dptoedit
            // 
            this.dptoedit.Location = new System.Drawing.Point(92, 61);
            this.dptoedit.Name = "dptoedit";
            this.dptoedit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptoedit.Properties.DataSource = this.fKTDptoTTallerBindingSource;
            this.dptoedit.Properties.DisplayMember = "namedpto";
            this.dptoedit.Properties.NullText = "";
            this.dptoedit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.dptoedit.Properties.ValueMember = "iddpto";
            this.dptoedit.Properties.View = this.gridView2;
            this.dptoedit.Size = new System.Drawing.Size(237, 20);
            this.dptoedit.TabIndex = 2;
            this.dptoedit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.gridLookUpEdit2_Closed);
            // 
            // fKTDptoTTallerBindingSource
            // 
            this.fKTDptoTTallerBindingSource.DataMember = "FK_T_Dpto_T_Taller";
            this.fKTDptoTTallerBindingSource.DataSource = this.fKTTallerTTallerBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamedpto});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colnamedpto
            // 
            this.colnamedpto.FieldName = "namedpto";
            this.colnamedpto.Name = "colnamedpto";
            this.colnamedpto.Visible = true;
            this.colnamedpto.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Division:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Taller:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Departamento:";
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 95);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.Size = new System.Drawing.Size(351, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.TabIndex = 6;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // FrmRepPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 125);
            this.Controls.Add(this.ucPieFormulario1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dptoedit);
            this.Controls.Add(this.talleredit);
            this.Controls.Add(this.divisionedit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRepPlantilla";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Informe de Plantilla";
            this.Load += new System.EventHandler(this.FrmRepPlantilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DivisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talleredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTTallerTTallerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptoedit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTDptoTTallerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Plantilla.DSPlantilla dSPlantilla;
        private System.Windows.Forms.BindingSource t_DivisionBindingSource;
        private Plantilla.DSPlantillaTableAdapters.T_DivisionTableAdapter t_DivisionTableAdapter;
        private Plantilla.DSPlantillaTableAdapters.TableAdapterManager tableAdapterManager;
        private Plantilla.DSPlantillaTableAdapters.T_TallerTableAdapter t_TallerTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource fKTTallerTTallerBindingSource;
        private Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter t_DptoTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource fKTDptoTTallerBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedivision;
        private DevExpress.XtraGrid.Columns.GridColumn colnametaller;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedpto;
        public DevExpress.XtraEditors.GridLookUpEdit divisionedit;
        public DevExpress.XtraEditors.GridLookUpEdit talleredit;
        public DevExpress.XtraEditors.GridLookUpEdit dptoedit;
    }
}
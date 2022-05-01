namespace Nomina
{
    partial class FrmCentroCosto
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.t_CentroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new Nomina.DSDatos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodcentro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamecentro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliddept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tDptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamedpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamecentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_CentroTableAdapter = new Nomina.DSDatosTableAdapters.T_CentroTableAdapter();
            this.t_Centro_DeptTableAdapter = new Nomina.DSDatosTableAdapters.T_Centro_DeptTableAdapter();
            this.t_DptoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_CentroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidcentro,
            this.coliddept});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colidcentro
            // 
            this.colidcentro.Caption = "Centro Costo";
            this.colidcentro.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidcentro.FieldName = "idcentro";
            this.colidcentro.Name = "colidcentro";
            this.colidcentro.Visible = true;
            this.colidcentro.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.t_CentroBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "namecentro";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idcentro";
            this.repositoryItemGridLookUpEdit2.View = this.gridView1;
            // 
            // t_CentroBindingSource
            // 
            this.t_CentroBindingSource.DataMember = "T_Centro";
            this.t_CentroBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodcentro1,
            this.colnamecentro1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcodcentro1
            // 
            this.colcodcentro1.Caption = "Codigo";
            this.colcodcentro1.FieldName = "codcentro";
            this.colcodcentro1.Name = "colcodcentro1";
            this.colcodcentro1.Visible = true;
            this.colcodcentro1.VisibleIndex = 0;
            // 
            // colnamecentro1
            // 
            this.colnamecentro1.Caption = "Nombre";
            this.colnamecentro1.FieldName = "namecentro";
            this.colnamecentro1.Name = "colnamecentro1";
            this.colnamecentro1.Visible = true;
            this.colnamecentro1.VisibleIndex = 1;
            // 
            // coliddept
            // 
            this.coliddept.Caption = "Departamento";
            this.coliddept.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.coliddept.FieldName = "iddept";
            this.coliddept.Name = "coliddept";
            this.coliddept.Visible = true;
            this.coliddept.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tDptoBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "namedpto";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "iddpto";
            this.repositoryItemGridLookUpEdit3.View = this.gridView2;
            // 
            // tDptoBindingSource
            // 
            this.tDptoBindingSource.DataMember = "T_Dpto";
            this.tDptoBindingSource.DataSource = this.dSPlantilla;
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamedpto});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colnamedpto
            // 
            this.colnamedpto.Caption = "Nombre";
            this.colnamedpto.FieldName = "namedpto";
            this.colnamedpto.Name = "colnamedpto";
            this.colnamedpto.Visible = true;
            this.colnamedpto.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.t_CentroBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView4;
            gridLevelNode1.RelationName = "FK_T_Centro_Dept_T_Centro";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(429, 408);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView4});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamecentro,
            this.colcodcentro});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView3.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colnamecentro
            // 
            this.colnamecentro.Caption = "Nombre";
            this.colnamecentro.FieldName = "namecentro";
            this.colnamecentro.Name = "colnamecentro";
            this.colnamecentro.Visible = true;
            this.colnamecentro.VisibleIndex = 1;
            // 
            // colcodcentro
            // 
            this.colcodcentro.Caption = "Codigo";
            this.colcodcentro.FieldName = "codcentro";
            this.colcodcentro.Name = "colcodcentro";
            this.colcodcentro.Visible = true;
            this.colcodcentro.VisibleIndex = 0;
            // 
            // t_CentroTableAdapter
            // 
            this.t_CentroTableAdapter.ClearBeforeFill = true;
            // 
            // t_Centro_DeptTableAdapter
            // 
            this.t_Centro_DeptTableAdapter.ClearBeforeFill = true;
            // 
            // t_DptoTableAdapter
            // 
            this.t_DptoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCentroCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 408);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmCentroCosto";
            this.Text = "FrmCentroCosto";
            this.Load += new System.EventHandler(this.FrmCentroCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_CentroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource t_CentroBindingSource;
        private DSDatos dSDatos;
        private DSDatosTableAdapters.T_CentroTableAdapter t_CentroTableAdapter;
        private DSDatosTableAdapters.T_Centro_DeptTableAdapter t_Centro_DeptTableAdapter;
        private Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter t_DptoTableAdapter;
        private Plantilla.DSPlantilla dSPlantilla;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colidcentro;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcodcentro1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamecentro1;
        private DevExpress.XtraGrid.Columns.GridColumn coliddept;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedpto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnamecentro;
        private DevExpress.XtraGrid.Columns.GridColumn colcodcentro;
        private System.Windows.Forms.BindingSource tDptoBindingSource;
    }
}
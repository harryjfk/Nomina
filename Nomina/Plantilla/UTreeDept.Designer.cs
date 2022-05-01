namespace Nomina.Plantilla
{
    partial class UTreeDept
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.tDivisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamedivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coliddpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamedpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_DivisionTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_DivisionTableAdapter();
            this.t_TallerTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_TallerTableAdapter();
            this.t_PlantillaTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_PlantillaTableAdapter();
            this.t_DptoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDivisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametaller});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView3.OptionsView.ShowColumnHeaders = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowIndicator = false;
            // 
            // colnametaller
            // 
            this.colnametaller.FieldName = "nametaller";
            this.colnametaller.Name = "colnametaller";
            this.colnametaller.Visible = true;
            this.colnametaller.VisibleIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.tDivisionBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode2.LevelTemplate = this.gridView4;
            gridLevelNode3.RelationName = "FK_T_Plantilla_T_Dpto";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "FK_T_Dpto_T_Taller";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "FK_T_Taller_T_Taller";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(333, 416);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView4,
            this.gridView3});
            // 
            // tDivisionBindingSource
            // 
            this.tDivisionBindingSource.DataMember = "T_Division";
            this.tDivisionBindingSource.DataSource = this.dSPlantilla;
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamedivision});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.ShowColumnHeaders = false;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // colnamedivision
            // 
            this.colnamedivision.FieldName = "namedivision";
            this.colnamedivision.Name = "colnamedivision";
            this.colnamedivision.Visible = true;
            this.colnamedivision.VisibleIndex = 0;
            // 
            // gridView4
            // 
            this.gridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coliddpto,
            this.colnamedpto,
            this.colidtaller});
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.gridView4.OptionsDetail.EnableMasterViewMode = false;
            this.gridView4.OptionsView.ShowColumnHeaders = false;
            this.gridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.OptionsView.ShowIndicator = false;
            this.gridView4.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView4_RowClick);
            this.gridView4.DoubleClick += new System.EventHandler(this.gridView4_DoubleClick);
            // 
            // coliddpto
            // 
            this.coliddpto.FieldName = "iddpto";
            this.coliddpto.Name = "coliddpto";
            this.coliddpto.OptionsColumn.ReadOnly = true;
            this.coliddpto.Visible = true;
            this.coliddpto.VisibleIndex = 0;
            // 
            // colnamedpto
            // 
            this.colnamedpto.FieldName = "namedpto";
            this.colnamedpto.Name = "colnamedpto";
            this.colnamedpto.Visible = true;
            this.colnamedpto.VisibleIndex = 1;
            // 
            // colidtaller
            // 
            this.colidtaller.FieldName = "idtaller";
            this.colidtaller.Name = "colidtaller";
            this.colidtaller.Visible = true;
            this.colidtaller.VisibleIndex = 2;
            // 
            // t_DivisionTableAdapter
            // 
            this.t_DivisionTableAdapter.ClearBeforeFill = true;
            // 
            // t_TallerTableAdapter
            // 
            this.t_TallerTableAdapter.ClearBeforeFill = true;
            // 
            // t_PlantillaTableAdapter
            // 
            this.t_PlantillaTableAdapter.ClearBeforeFill = true;
            // 
            // t_DptoTableAdapter
            // 
            this.t_DptoTableAdapter.ClearBeforeFill = true;
            // 
            // UTreeDept
            // 
           // this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Name = "UTreeDept";
            this.Size = new System.Drawing.Size(333, 416);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDivisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSPlantilla dSPlantilla;
        private System.Windows.Forms.BindingSource tDivisionBindingSource;
        private DSPlantillaTableAdapters.T_DivisionTableAdapter t_DivisionTableAdapter;
        private DSPlantillaTableAdapters.T_TallerTableAdapter t_TallerTableAdapter;
        private DSPlantillaTableAdapters.T_PlantillaTableAdapter t_PlantillaTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnametaller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedivision;
        private DSPlantillaTableAdapters.T_DptoTableAdapter t_DptoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coliddpto;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedpto;
        private DevExpress.XtraGrid.Columns.GridColumn colidtaller;
    }
}

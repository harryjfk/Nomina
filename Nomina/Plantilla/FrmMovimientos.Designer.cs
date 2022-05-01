namespace Nomina.Plantilla
{
    partial class FrmMovimientos
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            this.t_MovimientoBindingSource = new System.Windows.Forms.BindingSource();
            this.t_MovimientoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_MovimientoTableAdapter();
            this.tableAdapterManager = new Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager();
            this.t_TipoMovTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_TipoMovTableAdapter();
            this.t_MovimientoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoMovBindingSource = new System.Windows.Forms.BindingSource();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidtipomov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechamov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmesconta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidplantila = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tPlantillaBindingSource = new System.Windows.Forms.BindingSource();
            this.t_PlantillaTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_PlantillaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MovimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MovimientoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPlantillaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Herramientas";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nuevo";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(581, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(581, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(581, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_MovimientoBindingSource
            // 
            this.t_MovimientoBindingSource.DataMember = "T_Movimiento";
            this.t_MovimientoBindingSource.DataSource = this.dSPlantilla;
            // 
            // t_MovimientoTableAdapter
            // 
            this.t_MovimientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P_ImprimirPlantillaTableAdapter = null;
            this.tableAdapterManager.T_CategoriaTableAdapter = null;
            this.tableAdapterManager.T_ConceptoBajaTableAdapter = null;
            this.tableAdapterManager.T_DivisionTableAdapter = null;
            this.tableAdapterManager.T_DptoTableAdapter = null;
            this.tableAdapterManager.T_EscalaTableAdapter = null;
            this.tableAdapterManager.T_EstadoTableAdapter = null;
            this.tableAdapterManager.T_MovimientoTableAdapter = this.t_MovimientoTableAdapter;
            this.tableAdapterManager.T_PDTTableAdapter = null;
            this.tableAdapterManager.T_Plantilla_PlusTableAdapter = null;
            this.tableAdapterManager.T_PlantillaTableAdapter = null;
            this.tableAdapterManager.T_PlusTableAdapter = null;
            this.tableAdapterManager.T_TallerTableAdapter = null;
            this.tableAdapterManager.T_TipoEstTableAdapter = null;
            this.tableAdapterManager.T_TipoMovTableAdapter = this.t_TipoMovTableAdapter;
            this.tableAdapterManager.T_TurnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_TipoMovTableAdapter
            // 
            this.t_TipoMovTableAdapter.ClearBeforeFill = true;
            // 
            // t_MovimientoGridControl
            // 
            this.t_MovimientoGridControl.DataSource = this.t_MovimientoBindingSource;
            this.t_MovimientoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_MovimientoGridControl.Location = new System.Drawing.Point(0, 29);
            this.t_MovimientoGridControl.MainView = this.gridView1;
            this.t_MovimientoGridControl.MenuManager = this.barManager1;
            this.t_MovimientoGridControl.Name = "t_MovimientoGridControl";
            this.t_MovimientoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3});
            this.t_MovimientoGridControl.Size = new System.Drawing.Size(581, 398);
            this.t_MovimientoGridControl.TabIndex = 5;
            this.t_MovimientoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidtipomov,
            this.colfechamov,
            this.colnomov,
            this.colidmesconta,
            this.colobservacion,
            this.colidplantila});
            this.gridView1.GridControl = this.t_MovimientoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tTipoMovBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "namemov";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idtipomov";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tTipoMovBindingSource
            // 
            this.tTipoMovBindingSource.DataMember = "T_TipoMov";
            this.tTipoMovBindingSource.DataSource = this.dSPlantilla;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colidtipomov
            // 
            this.colidtipomov.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidtipomov.FieldName = "idtipomov";
            this.colidtipomov.Name = "colidtipomov";
            this.colidtipomov.Visible = true;
            this.colidtipomov.VisibleIndex = 0;
            // 
            // colfechamov
            // 
            this.colfechamov.FieldName = "fechamov";
            this.colfechamov.Name = "colfechamov";
            this.colfechamov.Visible = true;
            this.colfechamov.VisibleIndex = 1;
            // 
            // colnomov
            // 
            this.colnomov.FieldName = "nomov";
            this.colnomov.Name = "colnomov";
            this.colnomov.Visible = true;
            this.colnomov.VisibleIndex = 2;
            // 
            // colidmesconta
            // 
            this.colidmesconta.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidmesconta.FieldName = "idmesconta";
            this.colidmesconta.Name = "colidmesconta";
            this.colidmesconta.Visible = true;
            this.colidmesconta.VisibleIndex = 3;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 4;
            // 
            // colidplantila
            // 
            this.colidplantila.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colidplantila.FieldName = "idplantila";
            this.colidplantila.Name = "colidplantila";
            this.colidplantila.Visible = true;
            this.colidplantila.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tPlantillaBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "noexpplant";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "idplantilla";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // tPlantillaBindingSource
            // 
            this.tPlantillaBindingSource.DataMember = "T_Plantilla";
            this.tPlantillaBindingSource.DataSource = this.dSPlantilla;
            // 
            // t_PlantillaTableAdapter
            // 
            this.t_PlantillaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.t_MovimientoGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmMovimientos";
            this.Text = "FrmMovimientos";
            this.Load += new System.EventHandler(this.FrmMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MovimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MovimientoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPlantillaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource t_MovimientoBindingSource;
        private DSPlantilla dSPlantilla;
        private DSPlantillaTableAdapters.T_MovimientoTableAdapter t_MovimientoTableAdapter;
        private DSPlantillaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_MovimientoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DSPlantillaTableAdapters.T_TipoMovTableAdapter t_TipoMovTableAdapter;
        private System.Windows.Forms.BindingSource tTipoMovBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipomov;
        private DevExpress.XtraGrid.Columns.GridColumn colfechamov;
        private DevExpress.XtraGrid.Columns.GridColumn colnomov;
        private DevExpress.XtraGrid.Columns.GridColumn colidmesconta;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colidplantila;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private System.Windows.Forms.BindingSource tPlantillaBindingSource;
        private DSPlantillaTableAdapters.T_PlantillaTableAdapter t_PlantillaTableAdapter;
    }
}
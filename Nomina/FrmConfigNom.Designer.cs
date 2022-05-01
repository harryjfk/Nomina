namespace Nomina
{
    partial class FrmConfigNom
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
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipoPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.t_TipoNomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new Nomina.DSDatos();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameTipoNom1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_TipoNomGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameTipoNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new Nomina.DSDatosTableAdapters.TableAdapterManager();
            this.t_TipoNomTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoNomTableAdapter();
            this.T_TipoNomDesTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoNomDesTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.t_TipoNomPagarGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_TipoNomPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNameTipoNomPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_TipoNomPagarTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoNomPagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomPagarGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipoPagar,
            this.colidTipoNom});
            this.gridView3.GridControl = this.t_TipoNomGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.ViewCaption = "Tipo de Nomina a Pagar";
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            // 
            // colnametipoPagar
            // 
            this.colnametipoPagar.Caption = "Nombre";
            this.colnametipoPagar.FieldName = "nametipoPagar";
            this.colnametipoPagar.Name = "colnametipoPagar";
            this.colnametipoPagar.Visible = true;
            this.colnametipoPagar.VisibleIndex = 0;
            // 
            // colidTipoNom
            // 
            this.colidTipoNom.Caption = "Nomina";
            this.colidTipoNom.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidTipoNom.FieldName = "idTipoNom";
            this.colidTipoNom.Name = "colidTipoNom";
            this.colidTipoNom.Visible = true;
            this.colidTipoNom.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.t_TipoNomBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nameTipoNom";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idTipoNom";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // t_TipoNomBindingSource
            // 
            this.t_TipoNomBindingSource.DataMember = "T_TipoNom";
            this.t_TipoNomBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameTipoNom1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameTipoNom1
            // 
            this.colnameTipoNom1.FieldName = "nameTipoNom";
            this.colnameTipoNom1.Name = "colnameTipoNom1";
            this.colnameTipoNom1.Visible = true;
            this.colnameTipoNom1.VisibleIndex = 0;
            // 
            // t_TipoNomGridControl
            // 
            this.t_TipoNomGridControl.DataSource = this.t_TipoNomBindingSource;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode1.RelationName = "FK_T_TipoNomPagar_T_TipoNom";
            this.t_TipoNomGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.t_TipoNomGridControl.Location = new System.Drawing.Point(458, 28);
            this.t_TipoNomGridControl.MainView = this.gridView2;
            this.t_TipoNomGridControl.Name = "t_TipoNomGridControl";
            this.t_TipoNomGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_TipoNomGridControl.Size = new System.Drawing.Size(443, 486);
            this.t_TipoNomGridControl.TabIndex = 0;
            this.t_TipoNomGridControl.UseEmbeddedNavigator = true;
            this.t_TipoNomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameTipoNom});
            this.gridView2.GridControl = this.t_TipoNomGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colnameTipoNom
            // 
            this.colnameTipoNom.Caption = "Nombre";
            this.colnameTipoNom.FieldName = "nameTipoNom";
            this.colnameTipoNom.Name = "colnameTipoNom";
            this.colnameTipoNom.Visible = true;
            this.colnameTipoNom.VisibleIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.T_Centro_DeptTableAdapter = null;
            this.tableAdapterManager.T_CentroTableAdapter = null;
            this.tableAdapterManager.T_CuentaTableAdapter = null;
            this.tableAdapterManager.T_TipoCuentaTableAdapter = null;
            this.tableAdapterManager.T_TipoNomDesTableAdapter = null;
            this.tableAdapterManager.T_TipoNomPagarTableAdapter = null;
            this.tableAdapterManager.T_TipoNomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_TipoNomTableAdapter
            // 
            this.t_TipoNomTableAdapter.ClearBeforeFill = true;
            // 
            // T_TipoNomDesTableAdapter
            // 
            this.T_TipoNomDesTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.t_TipoNomPagarGridControl);
            this.layoutControl1.Controls.Add(this.t_TipoNomGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(913, 526);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // t_TipoNomPagarGridControl
            // 
            this.t_TipoNomPagarGridControl.DataSource = this.t_TipoNomPagarBindingSource;
            this.t_TipoNomPagarGridControl.Location = new System.Drawing.Point(12, 28);
            this.t_TipoNomPagarGridControl.MainView = this.gridView5;
            this.t_TipoNomPagarGridControl.Name = "t_TipoNomPagarGridControl";
            this.t_TipoNomPagarGridControl.Size = new System.Drawing.Size(442, 486);
            this.t_TipoNomPagarGridControl.TabIndex = 2;
            this.t_TipoNomPagarGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // t_TipoNomPagarBindingSource
            // 
            this.t_TipoNomPagarBindingSource.DataMember = "T_TipoNomPagar";
            this.t_TipoNomPagarBindingSource.DataSource = this.dSDatos;
            this.t_TipoNomPagarBindingSource.CurrentChanged += new System.EventHandler(this.t_TipoNomPagarBindingSource_CurrentChanged);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNameTipoNomPagar});
            this.gridView5.GridControl = this.t_TipoNomPagarGridControl;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colNameTipoNomPagar
            // 
            this.colNameTipoNomPagar.Caption = "Nombre";
            this.colNameTipoNomPagar.FieldName = "NameTipoNomPagar";
            this.colNameTipoNomPagar.Name = "colNameTipoNomPagar";
            this.colNameTipoNomPagar.Visible = true;
            this.colNameTipoNomPagar.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(913, 526);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.t_TipoNomPagarGridControl;
            this.layoutControlItem3.CustomizationFormText = "Nominas a Pagar";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(446, 506);
            this.layoutControlItem3.Text = "Nominas a Pagar";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.t_TipoNomGridControl;
            this.layoutControlItem1.CustomizationFormText = "Tipo de Nominas";
            this.layoutControlItem1.Location = new System.Drawing.Point(446, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(447, 506);
            this.layoutControlItem1.Text = "Tipo de Nominas";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
            // 
            // t_TipoNomPagarTableAdapter
            // 
            this.t_TipoNomPagarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConfigNom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 526);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmConfigNom";
            this.Text = "Configurar Nominas";
            this.Load += new System.EventHandler(this.FrmConfigNom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomPagarGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoNomPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource t_TipoNomBindingSource;
        private DSDatosTableAdapters.T_TipoNomTableAdapter t_TipoNomTableAdapter;
        private DevExpress.XtraGrid.GridControl t_TipoNomGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnameTipoNom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipoPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoNom;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DSDatosTableAdapters.T_TipoNomDesTableAdapter T_TipoNomDesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameTipoNom1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource t_TipoNomPagarBindingSource;
        private DSDatosTableAdapters.T_TipoNomPagarTableAdapter t_TipoNomPagarTableAdapter;
        private DevExpress.XtraGrid.GridControl t_TipoNomPagarGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colNameTipoNomPagar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
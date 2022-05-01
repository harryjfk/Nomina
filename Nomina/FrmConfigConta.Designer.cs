namespace Nomina
{
    partial class FrmConfigConta
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldesccuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipocuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.t_TipoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new Nomina.DSDatos();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipocuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_TipoCuentaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipocuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_TipoCuentaTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoCuentaTableAdapter();
            this.tableAdapterManager = new Nomina.DSDatosTableAdapters.TableAdapterManager();
            this.t_CuentaTableAdapter = new Nomina.DSDatosTableAdapters.T_CuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoCuentaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodcuenta,
            this.coldesccuenta,
            this.colidtipocuenta1});
            this.gridView2.GridControl = this.t_TipoCuentaGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colcodcuenta
            // 
            this.colcodcuenta.Caption = "Codigo";
            this.colcodcuenta.FieldName = "codcuenta";
            this.colcodcuenta.Name = "colcodcuenta";
            this.colcodcuenta.Visible = true;
            this.colcodcuenta.VisibleIndex = 0;
            // 
            // coldesccuenta
            // 
            this.coldesccuenta.Caption = "Descripcion";
            this.coldesccuenta.FieldName = "desccuenta";
            this.coldesccuenta.Name = "coldesccuenta";
            this.coldesccuenta.Visible = true;
            this.coldesccuenta.VisibleIndex = 1;
            // 
            // colidtipocuenta1
            // 
            this.colidtipocuenta1.Caption = "Tipo de cuenta";
            this.colidtipocuenta1.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidtipocuenta1.FieldName = "idtipocuenta";
            this.colidtipocuenta1.Name = "colidtipocuenta1";
            this.colidtipocuenta1.Visible = true;
            this.colidtipocuenta1.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.t_TipoCuentaBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nametipocuenta";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idtipocuenta";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // t_TipoCuentaBindingSource
            // 
            this.t_TipoCuentaBindingSource.DataMember = "T_TipoCuenta";
            this.t_TipoCuentaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipocuenta1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipocuenta1
            // 
            this.colnametipocuenta1.FieldName = "nametipocuenta";
            this.colnametipocuenta1.Name = "colnametipocuenta1";
            this.colnametipocuenta1.Visible = true;
            this.colnametipocuenta1.VisibleIndex = 0;
            // 
            // t_TipoCuentaGridControl
            // 
            this.t_TipoCuentaGridControl.DataSource = this.t_TipoCuentaBindingSource;
            this.t_TipoCuentaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "FK_T_Cuenta_T_TipoCuenta";
            this.t_TipoCuentaGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.t_TipoCuentaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoCuentaGridControl.MainView = this.gridView1;
            this.t_TipoCuentaGridControl.Name = "t_TipoCuentaGridControl";
            this.t_TipoCuentaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_TipoCuentaGridControl.Size = new System.Drawing.Size(636, 430);
            this.t_TipoCuentaGridControl.TabIndex = 1;
            this.t_TipoCuentaGridControl.UseEmbeddedNavigator = true;
            this.t_TipoCuentaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipocuenta});
            this.gridView1.GridControl = this.t_TipoCuentaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnametipocuenta
            // 
            this.colnametipocuenta.Caption = "Tipo Cuenta";
            this.colnametipocuenta.FieldName = "nametipocuenta";
            this.colnametipocuenta.Name = "colnametipocuenta";
            this.colnametipocuenta.Visible = true;
            this.colnametipocuenta.VisibleIndex = 0;
            // 
            // t_TipoCuentaTableAdapter
            // 
            this.t_TipoCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_Centro_DeptTableAdapter = null;
            this.tableAdapterManager.T_CentroTableAdapter = null;
            this.tableAdapterManager.T_CuentaTableAdapter = null;
            this.tableAdapterManager.T_TipoCuentaTableAdapter = this.t_TipoCuentaTableAdapter;
            this.tableAdapterManager.T_TipoNomDesTableAdapter = null;
            this.tableAdapterManager.T_TipoNomPagarTableAdapter = null;
            this.tableAdapterManager.T_TipoNomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_CuentaTableAdapter
            // 
            this.t_CuentaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConfigConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 430);
            this.Controls.Add(this.t_TipoCuentaGridControl);
            this.Name = "FrmConfigConta";
            this.Text = "FrmConfigConta";
            this.Load += new System.EventHandler(this.FrmConfigConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoCuentaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_TipoCuentaBindingSource;
        private DSDatosTableAdapters.T_TipoCuentaTableAdapter t_TipoCuentaTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_TipoCuentaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colcodcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn coldesccuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipocuenta1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipocuenta1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipocuenta;
        private DSDatosTableAdapters.T_CuentaTableAdapter t_CuentaTableAdapter;
    }
}
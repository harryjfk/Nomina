namespace Nomina.Nominas
{
    partial class FrmReporteTiempo
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
            System.Windows.Forms.Label iddptoLabel;
            System.Windows.Forms.Label noexpplantLabel;
            System.Windows.Forms.Label tarifaHorariaLabel;
            System.Windows.Forms.Label fechaEntradaLabel;
            System.Windows.Forms.Label tarifaMinimaLabel;
            System.Windows.Forms.Label condiLabAnLabel;
            System.Windows.Forms.Label ciesLabel;
            System.Windows.Forms.Label idPDTLabel;
            System.Windows.Forms.Label idTurnosLabel;
            System.Windows.Forms.Label idSolicitudLabel;
            System.Windows.Forms.Label idPlantillaLabel;
            System.Windows.Forms.Label fechaLabel;
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            this.t_DptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_DptoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter();
            this.tableAdapterManager = new Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager();
            this.t_PlantillaTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_PlantillaTableAdapter();
            this.t_PlantillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iddptoGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.iddptoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamedpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idplantillaGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idplantillaGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameplant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIplant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnoexpplant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col1erApellplant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2doApellplant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dSDatos = new Nomina.DSDatos();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.idTurnosGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTurnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTurnosGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idPDTGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tPDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPDTGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ciesLabel1 = new System.Windows.Forms.Label();
            this.condiLabAnLabel1 = new System.Windows.Forms.Label();
            this.tarifaMinimaLabel1 = new System.Windows.Forms.Label();
            this.fechaEntradaLabel1 = new System.Windows.Forms.Label();
            this.tarifaHorariaLabel1 = new System.Windows.Forms.Label();
            this.t_PDTTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_PDTTableAdapter();
            this.t_TurnoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_TurnoTableAdapter();
            this.t_ReporteTiempoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ReporteTiempoTableAdapter = new Nomina.DSDatosTableAdapters.T_ReporteTiempoTableAdapter();
            this.tableAdapterManager1 = new Nomina.DSDatosTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fechaLabel1 = new System.Windows.Forms.Label();
            this.idPlantillaGridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.idPlantillaGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idSolicitudLabel1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.t_ReporteTiempoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tRepEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.queriesTableAdapter1 = new Nomina.DSDatosTableAdapters.QueriesTableAdapter();
            this.t_ReporteTiempoNormalTableAdapter = new Nomina.DSDatosTableAdapters.T_ReporteTiempoNormalTableAdapter();
            this.t_ReporteTiempoNormalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Report_AllTableAdapter1 = new Nomina.DSDatosTableAdapters.T_Report_AllTableAdapter();
            this.T_ReporteTiempoEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ReporteTiempoEstadoTableAdapter = new Nomina.DSDatosTableAdapters.T_ReporteTiempoEstadoTableAdapter();
            this.t_RepEstadoTableAdapter = new Nomina.DSDatosTableAdapters.T_RepEstadoTableAdapter();
            this.t_PlantillaTableAdapter1 = new Nomina.DSDatosTableAdapters.T_PlantillaTableAdapter();
            this.T_ReporteTiempoAjusteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ReporteTiempoAjusteTableAdapter = new Nomina.DSDatosTableAdapters.T_ReporteTiempoAjusteTableAdapter();
            this.T_ReporteTiempoOtrosPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ReporteTiempoOtrosPagosTableAdapter = new Nomina.DSDatosTableAdapters.T_ReporteTiempoOtrosPagosTableAdapter();
            this.t_OtrosPagosTableAdapter1 = new Nomina.DSDatosTableAdapters.T_OtrosPagosTableAdapter();
            this.t_ReporteTiempoOtrosPagosTableAdapter1 = new Nomina.DSDatosTableAdapters.T_ReporteTiempoOtrosPagosTableAdapter();
            this.t_ReporteTiempoAjusteTableAdapter1 = new Nomina.DSDatosTableAdapters.T_ReporteTiempoAjusteTableAdapter();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tOtrosPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colnameOtrosPagos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamerpestado = new DevExpress.XtraGrid.Columns.GridColumn();
            iddptoLabel = new System.Windows.Forms.Label();
            noexpplantLabel = new System.Windows.Forms.Label();
            tarifaHorariaLabel = new System.Windows.Forms.Label();
            fechaEntradaLabel = new System.Windows.Forms.Label();
            tarifaMinimaLabel = new System.Windows.Forms.Label();
            condiLabAnLabel = new System.Windows.Forms.Label();
            ciesLabel = new System.Windows.Forms.Label();
            idPDTLabel = new System.Windows.Forms.Label();
            idTurnosLabel = new System.Windows.Forms.Label();
            idSolicitudLabel = new System.Windows.Forms.Label();
            idPlantillaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PlantillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddptoGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddptoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idplantillaGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idplantillaGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTurnosGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTurnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTurnosGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPDTGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPDTGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ReporteTiempoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idPlantillaGridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPlantillaGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_ReporteTiempoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRepEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_ReporteTiempoNormalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ReporteTiempoEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ReporteTiempoAjusteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ReporteTiempoOtrosPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOtrosPagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iddptoLabel
            // 
            iddptoLabel.AutoSize = true;
            iddptoLabel.Location = new System.Drawing.Point(12, 9);
            iddptoLabel.Name = "iddptoLabel";
            iddptoLabel.Size = new System.Drawing.Size(80, 13);
            iddptoLabel.TabIndex = 0;
            iddptoLabel.Text = "Departamento:";
            // 
            // noexpplantLabel
            // 
            noexpplantLabel.AutoSize = true;
            noexpplantLabel.Location = new System.Drawing.Point(12, 35);
            noexpplantLabel.Name = "noexpplantLabel";
            noexpplantLabel.Size = new System.Drawing.Size(65, 13);
            noexpplantLabel.TabIndex = 2;
            noexpplantLabel.Text = "Expediente:";
            // 
            // tarifaHorariaLabel
            // 
            tarifaHorariaLabel.AutoSize = true;
            tarifaHorariaLabel.Location = new System.Drawing.Point(5, 11);
            tarifaHorariaLabel.Name = "tarifaHorariaLabel";
            tarifaHorariaLabel.Size = new System.Drawing.Size(77, 13);
            tarifaHorariaLabel.TabIndex = 0;
            tarifaHorariaLabel.Text = "Tarifa Horaria:";
            // 
            // fechaEntradaLabel
            // 
            fechaEntradaLabel.AutoSize = true;
            fechaEntradaLabel.Location = new System.Drawing.Point(5, 34);
            fechaEntradaLabel.Name = "fechaEntradaLabel";
            fechaEntradaLabel.Size = new System.Drawing.Size(81, 13);
            fechaEntradaLabel.TabIndex = 2;
            fechaEntradaLabel.Text = "Fecha Entrada:";
            // 
            // tarifaMinimaLabel
            // 
            tarifaMinimaLabel.AutoSize = true;
            tarifaMinimaLabel.Location = new System.Drawing.Point(5, 62);
            tarifaMinimaLabel.Name = "tarifaMinimaLabel";
            tarifaMinimaLabel.Size = new System.Drawing.Size(74, 13);
            tarifaMinimaLabel.TabIndex = 4;
            tarifaMinimaLabel.Text = "Tarifa Minima:";
            // 
            // condiLabAnLabel
            // 
            condiLabAnLabel.AutoSize = true;
            condiLabAnLabel.Location = new System.Drawing.Point(5, 89);
            condiLabAnLabel.Name = "condiLabAnLabel";
            condiLabAnLabel.Size = new System.Drawing.Size(74, 13);
            condiLabAnLabel.TabIndex = 6;
            condiLabAnLabel.Text = "Condi Lab An:";
            // 
            // ciesLabel
            // 
            ciesLabel.AutoSize = true;
            ciesLabel.Location = new System.Drawing.Point(5, 112);
            ciesLabel.Name = "ciesLabel";
            ciesLabel.Size = new System.Drawing.Size(31, 13);
            ciesLabel.TabIndex = 8;
            ciesLabel.Text = "Cies:";
            // 
            // idPDTLabel
            // 
            idPDTLabel.AutoSize = true;
            idPDTLabel.Location = new System.Drawing.Point(5, 141);
            idPDTLabel.Name = "idPDTLabel";
            idPDTLabel.Size = new System.Drawing.Size(30, 13);
            idPDTLabel.TabIndex = 10;
            idPDTLabel.Text = "PDT:";
            // 
            // idTurnosLabel
            // 
            idTurnosLabel.AutoSize = true;
            idTurnosLabel.Location = new System.Drawing.Point(5, 172);
            idTurnosLabel.Name = "idTurnosLabel";
            idTurnosLabel.Size = new System.Drawing.Size(44, 13);
            idTurnosLabel.TabIndex = 12;
            idTurnosLabel.Text = "Turnos:";
            // 
            // idSolicitudLabel
            // 
            idSolicitudLabel.AutoSize = true;
            idSolicitudLabel.Location = new System.Drawing.Point(5, 31);
            idSolicitudLabel.Name = "idSolicitudLabel";
            idSolicitudLabel.Size = new System.Drawing.Size(50, 13);
            idSolicitudLabel.TabIndex = 0;
            idSolicitudLabel.Text = "Solicitud:";
            // 
            // idPlantillaLabel
            // 
            idPlantillaLabel.AutoSize = true;
            idPlantillaLabel.Location = new System.Drawing.Point(5, 54);
            idPlantillaLabel.Name = "idPlantillaLabel";
            idPlantillaLabel.Size = new System.Drawing.Size(47, 13);
            idPlantillaLabel.TabIndex = 2;
            idPlantillaLabel.Text = "Plantilla:";
            idPlantillaLabel.Click += new System.EventHandler(this.idPlantillaLabel_Click);
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(5, 79);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_DptoBindingSource
            // 
            this.t_DptoBindingSource.DataMember = "T_Dpto";
            this.t_DptoBindingSource.DataSource = this.dSPlantilla;
            // 
            // t_DptoTableAdapter
            // 
            this.t_DptoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P_ImprimirPlantillaTableAdapter = null;
            this.tableAdapterManager.T_CategoriaTableAdapter = null;
            this.tableAdapterManager.T_ConceptoBajaTableAdapter = null;
            this.tableAdapterManager.T_DivisionTableAdapter = null;
            this.tableAdapterManager.T_DptoTableAdapter = this.t_DptoTableAdapter;
            this.tableAdapterManager.T_EscalaTableAdapter = null;
            this.tableAdapterManager.T_EstadoTableAdapter = null;
            this.tableAdapterManager.T_MovimientoTableAdapter = null;
            this.tableAdapterManager.T_PDTTableAdapter = null;
            this.tableAdapterManager.T_Plantilla_PlusTableAdapter = null;
            this.tableAdapterManager.T_PlantillaTableAdapter = this.t_PlantillaTableAdapter;
            this.tableAdapterManager.T_PlusTableAdapter = null;
            this.tableAdapterManager.T_TallerTableAdapter = null;
            this.tableAdapterManager.T_TipoEstTableAdapter = null;
            this.tableAdapterManager.T_TipoMovTableAdapter = null;
            this.tableAdapterManager.T_TurnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_PlantillaTableAdapter
            // 
            this.t_PlantillaTableAdapter.ClearBeforeFill = true;
            // 
            // t_PlantillaBindingSource
            // 
            this.t_PlantillaBindingSource.DataMember = "FK_T_Plantilla_T_Dpto";
            this.t_PlantillaBindingSource.DataSource = this.t_DptoBindingSource;
            this.t_PlantillaBindingSource.CurrentChanged += new System.EventHandler(this.t_PlantillaBindingSource_CurrentChanged);
            // 
            // iddptoGridLookUpEdit
            // 
            this.iddptoGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_DptoBindingSource, "iddpto", true));
            this.iddptoGridLookUpEdit.Location = new System.Drawing.Point(98, 6);
            this.iddptoGridLookUpEdit.Name = "iddptoGridLookUpEdit";
            this.iddptoGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iddptoGridLookUpEdit.Properties.DataSource = this.t_DptoBindingSource;
            this.iddptoGridLookUpEdit.Properties.DisplayMember = "namedpto";
            this.iddptoGridLookUpEdit.Properties.ValueMember = "iddpto";
            this.iddptoGridLookUpEdit.Properties.View = this.iddptoGridLookUpEditView;
            this.iddptoGridLookUpEdit.Size = new System.Drawing.Size(219, 20);
            this.iddptoGridLookUpEdit.TabIndex = 1;
            this.iddptoGridLookUpEdit.EditValueChanged += new System.EventHandler(this.iddptoGridLookUpEdit_EditValueChanged);
            // 
            // iddptoGridLookUpEditView
            // 
            this.iddptoGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamedpto});
            this.iddptoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.iddptoGridLookUpEditView.Name = "iddptoGridLookUpEditView";
            this.iddptoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.iddptoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colnamedpto
            // 
            this.colnamedpto.FieldName = "namedpto";
            this.colnamedpto.Name = "colnamedpto";
            this.colnamedpto.Visible = true;
            this.colnamedpto.VisibleIndex = 0;
            // 
            // idplantillaGridLookUpEdit
            // 
            this.idplantillaGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "idplantilla", true));
            this.idplantillaGridLookUpEdit.Location = new System.Drawing.Point(98, 32);
            this.idplantillaGridLookUpEdit.Name = "idplantillaGridLookUpEdit";
            this.idplantillaGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idplantillaGridLookUpEdit.Properties.DataSource = this.bindingSource1;
            this.idplantillaGridLookUpEdit.Properties.DisplayMember = "nameplant";
            this.idplantillaGridLookUpEdit.Properties.ValueMember = "idplantilla";
            this.idplantillaGridLookUpEdit.Properties.View = this.idplantillaGridLookUpEditView;
            this.idplantillaGridLookUpEdit.Size = new System.Drawing.Size(219, 20);
            this.idplantillaGridLookUpEdit.TabIndex = 4;
            this.idplantillaGridLookUpEdit.EditValueChanged += new System.EventHandler(this.idplantillaGridLookUpEdit_EditValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "FK_T_Plantilla_T_Dpto";
            this.bindingSource1.DataSource = this.t_DptoBindingSource;
            // 
            // idplantillaGridLookUpEditView
            // 
            this.idplantillaGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameplant,
            this.colCIplant,
            this.colnoexpplant,
            this.col1erApellplant,
            this.col2doApellplant});
            this.idplantillaGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idplantillaGridLookUpEditView.Name = "idplantillaGridLookUpEditView";
            this.idplantillaGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idplantillaGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colnameplant
            // 
            this.colnameplant.FieldName = "nameplant";
            this.colnameplant.Name = "colnameplant";
            this.colnameplant.Visible = true;
            this.colnameplant.VisibleIndex = 0;
            // 
            // colCIplant
            // 
            this.colCIplant.FieldName = "CIplant";
            this.colCIplant.Name = "colCIplant";
            this.colCIplant.Visible = true;
            this.colCIplant.VisibleIndex = 1;
            // 
            // colnoexpplant
            // 
            this.colnoexpplant.FieldName = "noexpplant";
            this.colnoexpplant.Name = "colnoexpplant";
            this.colnoexpplant.Visible = true;
            this.colnoexpplant.VisibleIndex = 2;
            // 
            // col1erApellplant
            // 
            this.col1erApellplant.FieldName = "1erApellplant";
            this.col1erApellplant.Name = "col1erApellplant";
            this.col1erApellplant.Visible = true;
            this.col1erApellplant.VisibleIndex = 3;
            // 
            // col2doApellplant
            // 
            this.col2doApellplant.FieldName = "2doApellplant";
            this.col2doApellplant.Name = "col2doApellplant";
            this.col2doApellplant.Visible = true;
            this.col2doApellplant.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.idplantillaGridLookUpEdit);
            this.panelControl1.Controls.Add(noexpplantLabel);
            this.panelControl1.Controls.Add(iddptoLabel);
            this.panelControl1.Controls.Add(this.iddptoGridLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(720, 59);
            this.panelControl1.TabIndex = 0;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(idTurnosLabel);
            this.panelControl2.Controls.Add(this.idTurnosGridLookUpEdit);
            this.panelControl2.Controls.Add(idPDTLabel);
            this.panelControl2.Controls.Add(this.idPDTGridLookUpEdit);
            this.panelControl2.Controls.Add(ciesLabel);
            this.panelControl2.Controls.Add(this.ciesLabel1);
            this.panelControl2.Controls.Add(condiLabAnLabel);
            this.panelControl2.Controls.Add(this.condiLabAnLabel1);
            this.panelControl2.Controls.Add(tarifaMinimaLabel);
            this.panelControl2.Controls.Add(this.tarifaMinimaLabel1);
            this.panelControl2.Controls.Add(fechaEntradaLabel);
            this.panelControl2.Controls.Add(this.fechaEntradaLabel1);
            this.panelControl2.Controls.Add(tarifaHorariaLabel);
            this.panelControl2.Controls.Add(this.tarifaHorariaLabel1);
            this.panelControl2.Location = new System.Drawing.Point(5, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(202, 200);
            this.panelControl2.TabIndex = 1;
            // 
            // idTurnosGridLookUpEdit
            // 
            this.idTurnosGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "idTurnos", true));
            this.idTurnosGridLookUpEdit.Enabled = false;
            this.idTurnosGridLookUpEdit.Location = new System.Drawing.Point(57, 169);
            this.idTurnosGridLookUpEdit.Name = "idTurnosGridLookUpEdit";
            this.idTurnosGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idTurnosGridLookUpEdit.Properties.DataSource = this.tTurnoBindingSource;
            this.idTurnosGridLookUpEdit.Properties.DisplayMember = "nameturno";
            this.idTurnosGridLookUpEdit.Properties.ValueMember = "idturno";
            this.idTurnosGridLookUpEdit.Properties.View = this.idTurnosGridLookUpEditView;
            this.idTurnosGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.idTurnosGridLookUpEdit.TabIndex = 13;
            // 
            // tTurnoBindingSource
            // 
            this.tTurnoBindingSource.DataMember = "T_Turno";
            this.tTurnoBindingSource.DataSource = this.dSPlantilla;
            // 
            // idTurnosGridLookUpEditView
            // 
            this.idTurnosGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idTurnosGridLookUpEditView.Name = "idTurnosGridLookUpEditView";
            this.idTurnosGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idTurnosGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // idPDTGridLookUpEdit
            // 
            this.idPDTGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "idPDT", true));
            this.idPDTGridLookUpEdit.Enabled = false;
            this.idPDTGridLookUpEdit.Location = new System.Drawing.Point(57, 138);
            this.idPDTGridLookUpEdit.Name = "idPDTGridLookUpEdit";
            this.idPDTGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idPDTGridLookUpEdit.Properties.DataSource = this.tPDTBindingSource;
            this.idPDTGridLookUpEdit.Properties.DisplayMember = "pagospdt";
            this.idPDTGridLookUpEdit.Properties.ValueMember = "idpdt";
            this.idPDTGridLookUpEdit.Properties.View = this.idPDTGridLookUpEditView;
            this.idPDTGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.idPDTGridLookUpEdit.TabIndex = 11;
            // 
            // tPDTBindingSource
            // 
            this.tPDTBindingSource.DataMember = "T_PDT";
            this.tPDTBindingSource.DataSource = this.dSPlantilla;
            // 
            // idPDTGridLookUpEditView
            // 
            this.idPDTGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idPDTGridLookUpEditView.Name = "idPDTGridLookUpEditView";
            this.idPDTGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idPDTGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ciesLabel1
            // 
            this.ciesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_PlantillaBindingSource, "Cies", true));
            this.ciesLabel1.Location = new System.Drawing.Point(92, 112);
            this.ciesLabel1.Name = "ciesLabel1";
            this.ciesLabel1.Size = new System.Drawing.Size(100, 23);
            this.ciesLabel1.TabIndex = 9;
            this.ciesLabel1.Text = "label1";
            // 
            // condiLabAnLabel1
            // 
            this.condiLabAnLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_PlantillaBindingSource, "CondiLabAn", true));
            this.condiLabAnLabel1.Location = new System.Drawing.Point(92, 89);
            this.condiLabAnLabel1.Name = "condiLabAnLabel1";
            this.condiLabAnLabel1.Size = new System.Drawing.Size(100, 23);
            this.condiLabAnLabel1.TabIndex = 7;
            this.condiLabAnLabel1.Text = "label1";
            // 
            // tarifaMinimaLabel1
            // 
            this.tarifaMinimaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_PlantillaBindingSource, "TarifaMinima", true));
            this.tarifaMinimaLabel1.Location = new System.Drawing.Point(92, 62);
            this.tarifaMinimaLabel1.Name = "tarifaMinimaLabel1";
            this.tarifaMinimaLabel1.Size = new System.Drawing.Size(100, 23);
            this.tarifaMinimaLabel1.TabIndex = 5;
            this.tarifaMinimaLabel1.Text = "label1";
            // 
            // fechaEntradaLabel1
            // 
            this.fechaEntradaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_PlantillaBindingSource, "FechaEntrada", true));
            this.fechaEntradaLabel1.Location = new System.Drawing.Point(92, 34);
            this.fechaEntradaLabel1.Name = "fechaEntradaLabel1";
            this.fechaEntradaLabel1.Size = new System.Drawing.Size(100, 23);
            this.fechaEntradaLabel1.TabIndex = 3;
            this.fechaEntradaLabel1.Text = "label1";
            // 
            // tarifaHorariaLabel1
            // 
            this.tarifaHorariaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_PlantillaBindingSource, "TarifaHoraria", true));
            this.tarifaHorariaLabel1.Location = new System.Drawing.Point(92, 11);
            this.tarifaHorariaLabel1.Name = "tarifaHorariaLabel1";
            this.tarifaHorariaLabel1.Size = new System.Drawing.Size(100, 23);
            this.tarifaHorariaLabel1.TabIndex = 1;
            this.tarifaHorariaLabel1.Text = "label1";
            // 
            // t_PDTTableAdapter
            // 
            this.t_PDTTableAdapter.ClearBeforeFill = true;
            // 
            // t_TurnoTableAdapter
            // 
            this.t_TurnoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ReporteTiempoBindingSource
            // 
            this.t_ReporteTiempoBindingSource.DataMember = "T_ReporteTiempo";
            this.t_ReporteTiempoBindingSource.DataSource = this.dSDatos;
            this.t_ReporteTiempoBindingSource.CurrentChanged += new System.EventHandler(this.t_ReporteTiempoBindingSource_CurrentChanged);
            // 
            // t_ReporteTiempoTableAdapter
            // 
            this.t_ReporteTiempoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.T_Centro_DeptTableAdapter = null;
            this.tableAdapterManager1.T_CentroTableAdapter = null;
            this.tableAdapterManager1.T_CuentaTableAdapter = null;
            this.tableAdapterManager1.T_MesesTableAdapter = null;
            this.tableAdapterManager1.T_OtrosPagosTableAdapter = null;
            this.tableAdapterManager1.T_PlantillaTableAdapter = null;
            this.tableAdapterManager1.T_RepEstadoTableAdapter = null;
            this.tableAdapterManager1.T_Report_AllTableAdapter = null;
            this.tableAdapterManager1.T_ReporteTiempoAjusteTableAdapter = null;
            this.tableAdapterManager1.T_ReporteTiempoEstadoTableAdapter = null;
            this.tableAdapterManager1.T_ReporteTiempoNormalTableAdapter = null;
            this.tableAdapterManager1.T_ReporteTiempoOtrosPagosTableAdapter = null;
            this.tableAdapterManager1.T_ReporteTiempoTableAdapter = this.t_ReporteTiempoTableAdapter;
            this.tableAdapterManager1.T_SolicitudTableAdapter = null;
            this.tableAdapterManager1.T_TipoCuentaTableAdapter = null;
            this.tableAdapterManager1.T_TipoNomDesTableAdapter = null;
            this.tableAdapterManager1.T_TipoNomPagarTableAdapter = null;
            this.tableAdapterManager1.T_TipoNomTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Nomina.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(fechaLabel);
            this.groupControl1.Controls.Add(this.fechaLabel1);
            this.groupControl1.Controls.Add(idPlantillaLabel);
            this.groupControl1.Controls.Add(this.idPlantillaGridLookUpEdit1);
            this.groupControl1.Controls.Add(idSolicitudLabel);
            this.groupControl1.Controls.Add(this.idSolicitudLabel1);
            this.groupControl1.Location = new System.Drawing.Point(5, 208);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(202, 105);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Reporte Tiempo:";
            // 
            // fechaLabel1
            // 
            this.fechaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_ReporteTiempoBindingSource, "Fecha", true));
            this.fechaLabel1.Location = new System.Drawing.Point(61, 79);
            this.fechaLabel1.Name = "fechaLabel1";
            this.fechaLabel1.Size = new System.Drawing.Size(100, 23);
            this.fechaLabel1.TabIndex = 5;
            this.fechaLabel1.Text = "label1";
            // 
            // idPlantillaGridLookUpEdit1
            // 
            this.idPlantillaGridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_ReporteTiempoBindingSource, "IdPlantilla", true));
            this.idPlantillaGridLookUpEdit1.Enabled = false;
            this.idPlantillaGridLookUpEdit1.Location = new System.Drawing.Point(64, 51);
            this.idPlantillaGridLookUpEdit1.Name = "idPlantillaGridLookUpEdit1";
            this.idPlantillaGridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idPlantillaGridLookUpEdit1.Properties.DataSource = this.t_PlantillaBindingSource;
            this.idPlantillaGridLookUpEdit1.Properties.DisplayMember = "nameplant";
            this.idPlantillaGridLookUpEdit1.Properties.ValueMember = "idplantilla";
            this.idPlantillaGridLookUpEdit1.Properties.View = this.idPlantillaGridLookUpEdit1View;
            this.idPlantillaGridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.idPlantillaGridLookUpEdit1.TabIndex = 3;
            // 
            // idPlantillaGridLookUpEdit1View
            // 
            this.idPlantillaGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idPlantillaGridLookUpEdit1View.Name = "idPlantillaGridLookUpEdit1View";
            this.idPlantillaGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idPlantillaGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // idSolicitudLabel1
            // 
            this.idSolicitudLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_ReporteTiempoBindingSource, "IdSolicitud", true));
            this.idSolicitudLabel1.Location = new System.Drawing.Point(61, 31);
            this.idSolicitudLabel1.Name = "idSolicitudLabel1";
            this.idSolicitudLabel1.Size = new System.Drawing.Size(100, 23);
            this.idSolicitudLabel1.TabIndex = 1;
            this.idSolicitudLabel1.Text = "label1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.t_ReporteTiempoGridControl);
            this.panelControl3.Controls.Add(this.layoutControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 59);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(509, 539);
            this.panelControl3.TabIndex = 6;
            // 
            // t_ReporteTiempoGridControl
            // 
            this.t_ReporteTiempoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_ReporteTiempoGridControl.Location = new System.Drawing.Point(182, 2);
            this.t_ReporteTiempoGridControl.MainView = this.gridView2;
            this.t_ReporteTiempoGridControl.Name = "t_ReporteTiempoGridControl";
            this.t_ReporteTiempoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.t_ReporteTiempoGridControl.Size = new System.Drawing.Size(325, 535);
            this.t_ReporteTiempoGridControl.TabIndex = 0;
            this.t_ReporteTiempoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.t_ReporteTiempoGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.ColumnChanged += new System.EventHandler(this.gridView2_ColumnChanged);
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tRepEstadoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "namerpestado";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idrpestado";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tRepEstadoBindingSource
            // 
            this.tRepEstadoBindingSource.DataMember = "T_RepEstado";
            this.tRepEstadoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamerpestado});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.checkEdit4);
            this.layoutControl1.Controls.Add(this.checkEdit2);
            this.layoutControl1.Controls.Add(this.checkEdit3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(180, 535);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 12);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Reporte de tiempo";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit1.Properties.RadioGroupIndex = 0;
            this.checkEdit1.Size = new System.Drawing.Size(156, 19);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 0;
            this.checkEdit1.TabStop = false;
            this.checkEdit1.Tag = "1";
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(12, 81);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "Otros Pagos";
            this.checkEdit4.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit4.Properties.RadioGroupIndex = 0;
            this.checkEdit4.Size = new System.Drawing.Size(156, 19);
            this.checkEdit4.StyleController = this.layoutControl1;
            this.checkEdit4.TabIndex = 3;
            this.checkEdit4.TabStop = false;
            this.checkEdit4.Tag = "4";
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(12, 35);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Reporte de estado";
            this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit2.Properties.RadioGroupIndex = 0;
            this.checkEdit2.Size = new System.Drawing.Size(156, 19);
            this.checkEdit2.StyleController = this.layoutControl1;
            this.checkEdit2.TabIndex = 1;
            this.checkEdit2.TabStop = false;
            this.checkEdit2.Tag = "2";
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(12, 58);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "Ajustes";
            this.checkEdit3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit3.Properties.RadioGroupIndex = 0;
            this.checkEdit3.Size = new System.Drawing.Size(156, 19);
            this.checkEdit3.StyleController = this.layoutControl1;
            this.checkEdit3.TabIndex = 2;
            this.checkEdit3.TabStop = false;
            this.checkEdit3.Tag = "3";
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(180, 535);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEdit2;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(160, 23);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(160, 23);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkEdit3;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 23);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkEdit4;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(160, 446);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panelControl2);
            this.panelControl4.Controls.Add(this.groupControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(509, 59);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(211, 539);
            this.panelControl4.TabIndex = 7;
            // 
            // t_ReporteTiempoNormalTableAdapter
            // 
            this.t_ReporteTiempoNormalTableAdapter.ClearBeforeFill = true;
            // 
            // t_ReporteTiempoNormalBindingSource
            // 
            this.t_ReporteTiempoNormalBindingSource.DataMember = "T_ReporteTiempoNormal";
            this.t_ReporteTiempoNormalBindingSource.DataSource = this.dSDatos;
            // 
            // t_Report_AllTableAdapter1
            // 
            this.t_Report_AllTableAdapter1.ClearBeforeFill = true;
            // 
            // T_ReporteTiempoEstadoBindingSource
            // 
            this.T_ReporteTiempoEstadoBindingSource.DataMember = "T_ReporteTiempoEstado";
            this.T_ReporteTiempoEstadoBindingSource.DataSource = this.dSDatos;
            // 
            // t_ReporteTiempoEstadoTableAdapter
            // 
            this.t_ReporteTiempoEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_RepEstadoTableAdapter
            // 
            this.t_RepEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_PlantillaTableAdapter1
            // 
            this.t_PlantillaTableAdapter1.ClearBeforeFill = true;
            // 
            // T_ReporteTiempoAjusteBindingSource
            // 
            this.T_ReporteTiempoAjusteBindingSource.DataMember = "T_ReporteTiempoAjuste";
            this.T_ReporteTiempoAjusteBindingSource.DataSource = this.dSDatos;
            // 
            // t_ReporteTiempoAjusteTableAdapter
            // 
            this.t_ReporteTiempoAjusteTableAdapter.ClearBeforeFill = true;
            // 
            // T_ReporteTiempoOtrosPagosBindingSource
            // 
            this.T_ReporteTiempoOtrosPagosBindingSource.DataMember = "T_ReporteTiempoOtrosPagos";
            this.T_ReporteTiempoOtrosPagosBindingSource.DataSource = this.dSDatos;
            // 
            // t_ReporteTiempoOtrosPagosTableAdapter
            // 
            this.t_ReporteTiempoOtrosPagosTableAdapter.ClearBeforeFill = true;
            // 
            // t_OtrosPagosTableAdapter1
            // 
            this.t_OtrosPagosTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ReporteTiempoOtrosPagosTableAdapter1
            // 
            this.t_ReporteTiempoOtrosPagosTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ReporteTiempoAjusteTableAdapter1
            // 
            this.t_ReporteTiempoAjusteTableAdapter1.ClearBeforeFill = true;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tOtrosPagosBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "nameOtrosPagos";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idOtrosPagos";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameOtrosPagos});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // tOtrosPagosBindingSource
            // 
            this.tOtrosPagosBindingSource.DataMember = "T_OtrosPagos";
            this.tOtrosPagosBindingSource.DataSource = this.dSDatos;
            // 
            // colnameOtrosPagos
            // 
            this.colnameOtrosPagos.FieldName = "nameOtrosPagos";
            this.colnameOtrosPagos.Name = "colnameOtrosPagos";
            this.colnameOtrosPagos.Visible = true;
            this.colnameOtrosPagos.VisibleIndex = 0;
            // 
            // colnamerpestado
            // 
            this.colnamerpestado.FieldName = "namerpestado";
            this.colnamerpestado.Name = "colnamerpestado";
            this.colnamerpestado.Visible = true;
            this.colnamerpestado.VisibleIndex = 0;
            // 
            // FrmReporteTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 598);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmReporteTiempo";
            this.Text = "FrmReporteTiempo";
            this.Load += new System.EventHandler(this.FrmReporteTiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PlantillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddptoGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddptoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idplantillaGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idplantillaGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTurnosGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTurnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTurnosGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPDTGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPDTGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ReporteTiempoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idPlantillaGridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPlantillaGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_ReporteTiempoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRepEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_ReporteTiempoNormalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ReporteTiempoEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ReporteTiempoAjusteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_ReporteTiempoOtrosPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOtrosPagosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Plantilla.DSPlantilla dSPlantilla;
        private System.Windows.Forms.BindingSource t_DptoBindingSource;
        private Plantilla.DSPlantillaTableAdapters.T_DptoTableAdapter t_DptoTableAdapter;
        private Plantilla.DSPlantillaTableAdapters.TableAdapterManager tableAdapterManager;
        private Plantilla.DSPlantillaTableAdapters.T_PlantillaTableAdapter t_PlantillaTableAdapter;
        private System.Windows.Forms.BindingSource t_PlantillaBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit iddptoGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView iddptoGridLookUpEditView;
        private DevExpress.XtraEditors.GridLookUpEdit idplantillaGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idplantillaGridLookUpEditView;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameplant;
        private DevExpress.XtraGrid.Columns.GridColumn colCIplant;
        private DevExpress.XtraGrid.Columns.GridColumn colnoexpplant;
        private DevExpress.XtraGrid.Columns.GridColumn col1erApellplant;
        private DevExpress.XtraGrid.Columns.GridColumn col2doApellplant;
        private DevExpress.XtraGrid.Columns.GridColumn colnamedpto;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label fechaEntradaLabel1;
        private System.Windows.Forms.Label tarifaHorariaLabel1;
        private System.Windows.Forms.Label condiLabAnLabel1;
        private System.Windows.Forms.Label tarifaMinimaLabel1;
        private System.Windows.Forms.Label ciesLabel1;
        private DevExpress.XtraEditors.GridLookUpEdit idPDTGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idPDTGridLookUpEditView;
        private System.Windows.Forms.BindingSource tPDTBindingSource;
        private Plantilla.DSPlantillaTableAdapters.T_PDTTableAdapter t_PDTTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idTurnosGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idTurnosGridLookUpEditView;
        private System.Windows.Forms.BindingSource tTurnoBindingSource;
        private Plantilla.DSPlantillaTableAdapters.T_TurnoTableAdapter t_TurnoTableAdapter;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_ReporteTiempoBindingSource;
        private DSDatosTableAdapters.T_ReporteTiempoTableAdapter t_ReporteTiempoTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label fechaLabel1;
        private DevExpress.XtraEditors.GridLookUpEdit idPlantillaGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView idPlantillaGridLookUpEdit1View;
        private System.Windows.Forms.Label idSolicitudLabel1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DSDatosTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraGrid.GridControl t_ReporteTiempoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DSDatosTableAdapters.T_ReporteTiempoNormalTableAdapter t_ReporteTiempoNormalTableAdapter;
        private System.Windows.Forms.BindingSource t_ReporteTiempoNormalBindingSource;
        private DSDatosTableAdapters.T_Report_AllTableAdapter t_Report_AllTableAdapter1;
        private System.Windows.Forms.BindingSource T_ReporteTiempoEstadoBindingSource;
        private DSDatosTableAdapters.T_ReporteTiempoEstadoTableAdapter t_ReporteTiempoEstadoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tRepEstadoBindingSource;
        private DSDatosTableAdapters.T_RepEstadoTableAdapter t_RepEstadoTableAdapter;
        private DSDatosTableAdapters.T_PlantillaTableAdapter t_PlantillaTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource T_ReporteTiempoAjusteBindingSource;
        private DSDatosTableAdapters.T_ReporteTiempoAjusteTableAdapter t_ReporteTiempoAjusteTableAdapter;
        private System.Windows.Forms.BindingSource T_ReporteTiempoOtrosPagosBindingSource;
        private DSDatosTableAdapters.T_ReporteTiempoOtrosPagosTableAdapter t_ReporteTiempoOtrosPagosTableAdapter;
        private DSDatosTableAdapters.T_OtrosPagosTableAdapter t_OtrosPagosTableAdapter1;
        private DSDatosTableAdapters.T_ReporteTiempoOtrosPagosTableAdapter t_ReporteTiempoOtrosPagosTableAdapter1;
        private DSDatosTableAdapters.T_ReporteTiempoAjusteTableAdapter t_ReporteTiempoAjusteTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamerpestado;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private System.Windows.Forms.BindingSource tOtrosPagosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colnameOtrosPagos;
    }
}
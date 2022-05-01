namespace Nomina.Plantilla
{
    partial class FrmNewMovimiento
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
            System.Windows.Forms.Label idcentrocostoLabel;
            System.Windows.Forms.Label iddptoLabel;
            System.Windows.Forms.Label idEscalaLabel;
            System.Windows.Forms.Label condiLabAnLabel;
            System.Windows.Forms.Label tarifaMinimaLabel;
            System.Windows.Forms.Label tarifaHorariaLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label fechamovLabel;
            System.Windows.Forms.Label idconceptoLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.t_MovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPlantilla = new Nomina.Plantilla.DSPlantilla();
            this.t_Plantilla_PlusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_PlantillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPlusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCentroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new Nomina.DSDatos();
            this.tEscalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tConceptoBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_MovimientoTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_MovimientoTableAdapter();
            this.tableAdapterManager = new Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager();
            this.t_ConceptoBajaTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_ConceptoBajaTableAdapter();
            this.t_PlantillaTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_PlantillaTableAdapter();
            this.queriesTableAdapter1 = new Nomina.Plantilla.DSPlantillaTableAdapters.QueriesTableAdapter();
            this.t_EscalaTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_EscalaTableAdapter();
            this.t_CentroTableAdapter = new Nomina.DSDatosTableAdapters.T_CentroTableAdapter();
            this.t_Plantilla_PlusTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_Plantilla_PlusTableAdapter();
            this.t_PlusTableAdapter = new Nomina.Plantilla.DSPlantillaTableAdapters.T_PlusTableAdapter();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidplusplantilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidplantilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.uPlantilla1 = new Nomina.Plantilla.UPlantilla();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.uTreeDept1 = new Nomina.Plantilla.UTreeDept();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.t_Plantilla_PlusGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidplus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltarifa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupContainerEdit1 = new DevExpress.XtraEditors.PopupContainerEdit();
            this.idcentrocostoGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.idcentrocostoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idEscalaGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.idEscalaGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tarifaMinimaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tarifaHorariaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.condiLabAnSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.popupContainerEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.fechamovMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nomovTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            idcentrocostoLabel = new System.Windows.Forms.Label();
            iddptoLabel = new System.Windows.Forms.Label();
            idEscalaLabel = new System.Windows.Forms.Label();
            condiLabAnLabel = new System.Windows.Forms.Label();
            tarifaMinimaLabel = new System.Windows.Forms.Label();
            tarifaHorariaLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            fechamovLabel = new System.Windows.Forms.Label();
            idconceptoLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_MovimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Plantilla_PlusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PlantillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPlusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCentroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEscalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConceptoBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTreeDept1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Plantilla_PlusGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcentrocostoGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcentrocostoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEscalaGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEscalaGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifaMinimaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifaHorariaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condiLabAnSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit2.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomovTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idcentrocostoLabel
            // 
            idcentrocostoLabel.AutoSize = true;
            idcentrocostoLabel.Location = new System.Drawing.Point(7, 185);
            idcentrocostoLabel.Name = "idcentrocostoLabel";
            idcentrocostoLabel.Size = new System.Drawing.Size(75, 13);
            idcentrocostoLabel.TabIndex = 12;
            idcentrocostoLabel.Text = "Centro Costo:";
            // 
            // iddptoLabel
            // 
            iddptoLabel.AutoSize = true;
            iddptoLabel.Location = new System.Drawing.Point(7, 107);
            iddptoLabel.Name = "iddptoLabel";
            iddptoLabel.Size = new System.Drawing.Size(80, 13);
            iddptoLabel.TabIndex = 10;
            iddptoLabel.Text = "Departamento:";
            // 
            // idEscalaLabel
            // 
            idEscalaLabel.AutoSize = true;
            idEscalaLabel.Location = new System.Drawing.Point(7, 159);
            idEscalaLabel.Name = "idEscalaLabel";
            idEscalaLabel.Size = new System.Drawing.Size(78, 13);
            idEscalaLabel.TabIndex = 8;
            idEscalaLabel.Text = "Escala Salarial:";
            // 
            // condiLabAnLabel
            // 
            condiLabAnLabel.AutoSize = true;
            condiLabAnLabel.Location = new System.Drawing.Point(7, 133);
            condiLabAnLabel.Name = "condiLabAnLabel";
            condiLabAnLabel.Size = new System.Drawing.Size(87, 13);
            condiLabAnLabel.TabIndex = 4;
            condiLabAnLabel.Text = "C. L. Anormales:";
            // 
            // tarifaMinimaLabel
            // 
            tarifaMinimaLabel.AutoSize = true;
            tarifaMinimaLabel.Location = new System.Drawing.Point(7, 81);
            tarifaMinimaLabel.Name = "tarifaMinimaLabel";
            tarifaMinimaLabel.Size = new System.Drawing.Size(74, 13);
            tarifaMinimaLabel.TabIndex = 2;
            tarifaMinimaLabel.Text = "Tarifa Minima:";
            // 
            // tarifaHorariaLabel
            // 
            tarifaHorariaLabel.AutoSize = true;
            tarifaHorariaLabel.Location = new System.Drawing.Point(7, 55);
            tarifaHorariaLabel.Name = "tarifaHorariaLabel";
            tarifaHorariaLabel.Size = new System.Drawing.Size(77, 13);
            tarifaHorariaLabel.TabIndex = 0;
            tarifaHorariaLabel.Text = "Tarifa Horaria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(19, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 13);
            label5.TabIndex = 11;
            label5.Text = "Plantilla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new System.Drawing.Point(5, 160);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 13);
            label4.TabIndex = 18;
            label4.Text = "Centro Costo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new System.Drawing.Point(5, 82);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 13);
            label6.TabIndex = 17;
            label6.Text = "Departamento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new System.Drawing.Point(5, 134);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(78, 13);
            label7.TabIndex = 16;
            label7.Text = "Escala Salarial:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new System.Drawing.Point(5, 108);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 13);
            label8.TabIndex = 15;
            label8.Text = "C. L. Anormales:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Location = new System.Drawing.Point(5, 56);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(74, 13);
            label9.TabIndex = 14;
            label9.Text = "Tarifa Minima:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Enabled = false;
            label10.Location = new System.Drawing.Point(5, 30);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(77, 13);
            label10.TabIndex = 13;
            label10.Text = "Tarifa Horaria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 7;
            label1.Text = "Plantilla:";
            // 
            // fechamovLabel
            // 
            fechamovLabel.AutoSize = true;
            fechamovLabel.Location = new System.Drawing.Point(11, 43);
            fechamovLabel.Name = "fechamovLabel";
            fechamovLabel.Size = new System.Drawing.Size(40, 13);
            fechamovLabel.TabIndex = 0;
            fechamovLabel.Text = "Fecha:";
            // 
            // idconceptoLabel
            // 
            idconceptoLabel.AutoSize = true;
            idconceptoLabel.Location = new System.Drawing.Point(11, 214);
            idconceptoLabel.Name = "idconceptoLabel";
            idconceptoLabel.Size = new System.Drawing.Size(57, 13);
            idconceptoLabel.TabIndex = 4;
            idconceptoLabel.Text = "Concepto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(24, 13);
            label3.TabIndex = 18;
            label3.Text = "No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 13);
            label2.TabIndex = 20;
            label2.Text = "No Expediente:";
            // 
            // t_MovimientoBindingSource
            // 
            this.t_MovimientoBindingSource.DataMember = "T_Movimiento";
            this.t_MovimientoBindingSource.DataSource = this.dSPlantilla;
            // 
            // dSPlantilla
            // 
            this.dSPlantilla.DataSetName = "DSPlantilla";
            this.dSPlantilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_Plantilla_PlusBindingSource
            // 
            this.t_Plantilla_PlusBindingSource.DataMember = "FK_T_Plantilla_Plus_T_Plantilla";
            this.t_Plantilla_PlusBindingSource.DataSource = this.t_PlantillaBindingSource;
            // 
            // t_PlantillaBindingSource
            // 
            this.t_PlantillaBindingSource.DataMember = "T_Plantilla";
            this.t_PlantillaBindingSource.DataSource = this.dSPlantilla;
            this.t_PlantillaBindingSource.CurrentChanged += new System.EventHandler(this.t_PlantillaBindingSource_CurrentChanged);
            // 
            // tPlusBindingSource
            // 
            this.tPlusBindingSource.DataMember = "T_Plus";
            this.tPlusBindingSource.DataSource = this.dSPlantilla;
            // 
            // tCentroBindingSource
            // 
            this.tCentroBindingSource.DataMember = "T_Centro";
            this.tCentroBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEscalaBindingSource
            // 
            this.tEscalaBindingSource.DataMember = "T_Escala";
            this.tEscalaBindingSource.DataSource = this.dSPlantilla;
            // 
            // tConceptoBajaBindingSource
            // 
            this.tConceptoBajaBindingSource.DataMember = "T_ConceptoBaja";
            this.tConceptoBajaBindingSource.DataSource = this.dSPlantilla;
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
            this.tableAdapterManager.T_ConceptoBajaTableAdapter = this.t_ConceptoBajaTableAdapter;
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
            this.tableAdapterManager.T_TipoMovTableAdapter = null;
            this.tableAdapterManager.T_TurnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.Plantilla.DSPlantillaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_ConceptoBajaTableAdapter
            // 
            this.t_ConceptoBajaTableAdapter.ClearBeforeFill = true;
            // 
            // t_PlantillaTableAdapter
            // 
            this.t_PlantillaTableAdapter.ClearBeforeFill = true;
            // 
            // t_EscalaTableAdapter
            // 
            this.t_EscalaTableAdapter.ClearBeforeFill = true;
            // 
            // t_CentroTableAdapter
            // 
            this.t_CentroTableAdapter.ClearBeforeFill = true;
            // 
            // t_Plantilla_PlusTableAdapter
            // 
            this.t_Plantilla_PlusTableAdapter.ClearBeforeFill = true;
            // 
            // t_PlusTableAdapter
            // 
            this.t_PlusTableAdapter.ClearBeforeFill = true;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidplusplantilla,
            this.colidplantilla,
            this.colactua});
            this.gridView3.Name = "gridView3";
            // 
            // colidplusplantilla
            // 
            this.colidplusplantilla.FieldName = "idplusplantilla";
            this.colidplusplantilla.Name = "colidplusplantilla";
            this.colidplusplantilla.OptionsColumn.ReadOnly = true;
            this.colidplusplantilla.Visible = true;
            this.colidplusplantilla.VisibleIndex = 2;
            // 
            // colidplantilla
            // 
            this.colidplantilla.FieldName = "idplantilla";
            this.colidplantilla.Name = "colidplantilla";
            this.colidplantilla.Visible = true;
            this.colidplantilla.VisibleIndex = 3;
            // 
            // colactua
            // 
            this.colactua.FieldName = "actua";
            this.colactua.Name = "colactua";
            this.colactua.Visible = true;
            this.colactua.VisibleIndex = 4;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 36);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(502, 488);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.uPlantilla1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(496, 460);
            this.xtraTabPage1.Text = "Alta";
            // 
            // uPlantilla1
            // 
            this.uPlantilla1.Location = new System.Drawing.Point(3, 3);
            this.uPlantilla1.Name = "uPlantilla1";
            this.uPlantilla1.Plantilla = 0;
            this.uPlantilla1.Size = new System.Drawing.Size(492, 454);
            this.uPlantilla1.TabIndex = 15;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.uTreeDept1);
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Controls.Add(label5);
            this.xtraTabPage2.Controls.Add(this.lookUpEdit3);
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(496, 460);
            this.xtraTabPage2.Text = "Interno";
            // 
            // uTreeDept1
            // 
            this.uTreeDept1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.t_PlantillaBindingSource, "iddpto", true));
            this.uTreeDept1.Location = new System.Drawing.Point(-97, 123);
            this.uTreeDept1.Name = "uTreeDept1";
            this.uTreeDept1.Size = new System.Drawing.Size(217, 131);
            this.uTreeDept1.TabIndex = 22;
            this.uTreeDept1.Tag = "0";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textEdit3);
            this.groupControl2.Controls.Add(label2);
            this.groupControl2.Controls.Add(this.t_Plantilla_PlusGridControl);
            this.groupControl2.Controls.Add(this.popupContainerEdit1);
            this.groupControl2.Controls.Add(idcentrocostoLabel);
            this.groupControl2.Controls.Add(this.idcentrocostoGridLookUpEdit);
            this.groupControl2.Controls.Add(iddptoLabel);
            this.groupControl2.Controls.Add(idEscalaLabel);
            this.groupControl2.Controls.Add(this.idEscalaGridLookUpEdit);
            this.groupControl2.Controls.Add(condiLabAnLabel);
            this.groupControl2.Controls.Add(tarifaMinimaLabel);
            this.groupControl2.Controls.Add(tarifaHorariaLabel);
            this.groupControl2.Controls.Add(this.tarifaMinimaTextEdit);
            this.groupControl2.Controls.Add(this.tarifaHorariaTextEdit);
            this.groupControl2.Controls.Add(this.condiLabAnSpinEdit);
            this.groupControl2.Location = new System.Drawing.Point(14, 226);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(479, 213);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Modificado";
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "noexpplant", true));
            this.textEdit3.Location = new System.Drawing.Point(93, 26);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 21;
            this.textEdit3.Tag = "No Expediente:";
            // 
            // t_Plantilla_PlusGridControl
            // 
            this.t_Plantilla_PlusGridControl.DataSource = this.t_Plantilla_PlusBindingSource;
            this.t_Plantilla_PlusGridControl.Location = new System.Drawing.Point(216, 31);
            this.t_Plantilla_PlusGridControl.MainView = this.gridView1;
            this.t_Plantilla_PlusGridControl.Name = "t_Plantilla_PlusGridControl";
            this.t_Plantilla_PlusGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_Plantilla_PlusGridControl.Size = new System.Drawing.Size(258, 171);
            this.t_Plantilla_PlusGridControl.TabIndex = 16;
            this.t_Plantilla_PlusGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidplus,
            this.coltarifa});
            this.gridView1.GridControl = this.t_Plantilla_PlusGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colidplus
            // 
            this.colidplus.Caption = "Plus";
            this.colidplus.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidplus.FieldName = "idplus";
            this.colidplus.Name = "colidplus";
            this.colidplus.Visible = true;
            this.colidplus.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tPlusBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nameplus";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idplus";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // coltarifa
            // 
            this.coltarifa.Caption = "Tarifa";
            this.coltarifa.FieldName = "tarifa";
            this.coltarifa.Name = "coltarifa";
            this.coltarifa.Visible = true;
            this.coltarifa.VisibleIndex = 1;
            // 
            // popupContainerEdit1
            // 
            this.popupContainerEdit1.Location = new System.Drawing.Point(96, 104);
            this.popupContainerEdit1.Name = "popupContainerEdit1";
            this.popupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEdit1.Properties.PopupControl = this.uTreeDept1;
            this.popupContainerEdit1.Size = new System.Drawing.Size(100, 20);
            this.popupContainerEdit1.TabIndex = 15;
            this.popupContainerEdit1.Tag = "Departamento";
            // 
            // idcentrocostoGridLookUpEdit
            // 
            this.idcentrocostoGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "idcentrocosto", true));
            this.idcentrocostoGridLookUpEdit.Location = new System.Drawing.Point(106, 182);
            this.idcentrocostoGridLookUpEdit.Name = "idcentrocostoGridLookUpEdit";
            this.idcentrocostoGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idcentrocostoGridLookUpEdit.Properties.DataSource = this.tCentroBindingSource;
            this.idcentrocostoGridLookUpEdit.Properties.DisplayMember = "namecentro";
            this.idcentrocostoGridLookUpEdit.Properties.ValueMember = "idcentro";
            this.idcentrocostoGridLookUpEdit.Properties.View = this.idcentrocostoGridLookUpEditView;
            this.idcentrocostoGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.idcentrocostoGridLookUpEdit.TabIndex = 13;
            this.idcentrocostoGridLookUpEdit.Tag = "Centro Costo";
            // 
            // idcentrocostoGridLookUpEditView
            // 
            this.idcentrocostoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idcentrocostoGridLookUpEditView.Name = "idcentrocostoGridLookUpEditView";
            this.idcentrocostoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idcentrocostoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // idEscalaGridLookUpEdit
            // 
            this.idEscalaGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "idEscala", true));
            this.idEscalaGridLookUpEdit.Location = new System.Drawing.Point(106, 156);
            this.idEscalaGridLookUpEdit.Name = "idEscalaGridLookUpEdit";
            this.idEscalaGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idEscalaGridLookUpEdit.Properties.DataSource = this.tEscalaBindingSource;
            this.idEscalaGridLookUpEdit.Properties.DisplayMember = "nameescala";
            this.idEscalaGridLookUpEdit.Properties.ValueMember = "idescala";
            this.idEscalaGridLookUpEdit.Properties.View = this.idEscalaGridLookUpEditView;
            this.idEscalaGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.idEscalaGridLookUpEdit.TabIndex = 9;
            this.idEscalaGridLookUpEdit.Tag = "Escala Salarial";
            // 
            // idEscalaGridLookUpEditView
            // 
            this.idEscalaGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idEscalaGridLookUpEditView.Name = "idEscalaGridLookUpEditView";
            this.idEscalaGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idEscalaGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // tarifaMinimaTextEdit
            // 
            this.tarifaMinimaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "TarifaMinima", true));
            this.tarifaMinimaTextEdit.Location = new System.Drawing.Point(93, 78);
            this.tarifaMinimaTextEdit.Name = "tarifaMinimaTextEdit";
            this.tarifaMinimaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tarifaMinimaTextEdit.TabIndex = 3;
            this.tarifaMinimaTextEdit.Tag = "Tarifa Minima";
            // 
            // tarifaHorariaTextEdit
            // 
            this.tarifaHorariaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "TarifaHoraria", true));
            this.tarifaHorariaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_PlantillaBindingSource, "TarifaHoraria", true));
            this.tarifaHorariaTextEdit.Location = new System.Drawing.Point(93, 52);
            this.tarifaHorariaTextEdit.Name = "tarifaHorariaTextEdit";
            this.tarifaHorariaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tarifaHorariaTextEdit.TabIndex = 1;
            this.tarifaHorariaTextEdit.Tag = "Tarifa Horaria";
            // 
            // condiLabAnSpinEdit
            // 
            this.condiLabAnSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_PlantillaBindingSource, "CondiLabAn", true));
            this.condiLabAnSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.condiLabAnSpinEdit.Location = new System.Drawing.Point(106, 130);
            this.condiLabAnSpinEdit.Name = "condiLabAnSpinEdit";
            this.condiLabAnSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.condiLabAnSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.condiLabAnSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.condiLabAnSpinEdit.TabIndex = 5;
            this.condiLabAnSpinEdit.Tag = "C. L. Anormales";
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_MovimientoBindingSource, "idplantila", true));
            this.lookUpEdit3.Location = new System.Drawing.Point(72, 7);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("noexpplant", "No Expediente", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nameplant", "Nombre", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit3.Properties.DataSource = this.t_PlantillaBindingSource;
            this.lookUpEdit3.Properties.DisplayMember = "noexpplant";
            this.lookUpEdit3.Properties.ValueMember = "idplantilla";
            this.lookUpEdit3.Properties.EditValueChanged += new System.EventHandler(this.lookUpEdit3_Properties_EditValueChanged);
            this.lookUpEdit3.Size = new System.Drawing.Size(190, 20);
            this.lookUpEdit3.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(label4);
            this.groupControl1.Controls.Add(label6);
            this.groupControl1.Controls.Add(label7);
            this.groupControl1.Controls.Add(label8);
            this.groupControl1.Controls.Add(label9);
            this.groupControl1.Controls.Add(label10);
            this.groupControl1.Controls.Add(this.spinEdit1);
            this.groupControl1.Controls.Add(this.gridLookUpEdit2);
            this.groupControl1.Controls.Add(this.gridLookUpEdit1);
            this.groupControl1.Controls.Add(this.popupContainerEdit2);
            this.groupControl1.Location = new System.Drawing.Point(14, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 184);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Original";
            // 
            // gridControl1
            // 
            this.gridControl1.Enabled = false;
            this.gridControl1.Location = new System.Drawing.Point(204, 24);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(268, 153);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(98, 53);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 20;
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(98, 27);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 19;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Enabled = false;
            this.spinEdit1.Location = new System.Drawing.Point(95, 105);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.spinEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 26;
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.Enabled = false;
            this.gridLookUpEdit2.Location = new System.Drawing.Point(89, 131);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.NullText = "[Vacío]";
            this.gridLookUpEdit2.Size = new System.Drawing.Size(100, 20);
            this.gridLookUpEdit2.TabIndex = 27;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Enabled = false;
            this.gridLookUpEdit1.Location = new System.Drawing.Point(86, 157);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.NullText = "[Vacío]";
            this.gridLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.gridLookUpEdit1.TabIndex = 28;
            // 
            // popupContainerEdit2
            // 
            this.popupContainerEdit2.Location = new System.Drawing.Point(98, 79);
            this.popupContainerEdit2.Name = "popupContainerEdit2";
            this.popupContainerEdit2.Size = new System.Drawing.Size(100, 20);
            this.popupContainerEdit2.TabIndex = 29;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.AutoScroll = true;
            this.xtraTabPage3.Controls.Add(label1);
            this.xtraTabPage3.Controls.Add(this.lookUpEdit2);
            this.xtraTabPage3.Controls.Add(this.lookUpEdit1);
            this.xtraTabPage3.Controls.Add(fechamovLabel);
            this.xtraTabPage3.Controls.Add(this.fechamovMonthCalendar);
            this.xtraTabPage3.Controls.Add(idconceptoLabel);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(496, 460);
            this.xtraTabPage3.Text = "Baja";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_MovimientoBindingSource, "idplantila", true));
            this.lookUpEdit2.Location = new System.Drawing.Point(74, 11);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("noexpplant", "No Expediente", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nameplant", "Nombre", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.t_PlantillaBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "noexpplant";
            this.lookUpEdit2.Properties.ValueMember = "idplantilla";
            this.lookUpEdit2.Size = new System.Drawing.Size(190, 20);
            this.lookUpEdit2.TabIndex = 6;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_MovimientoBindingSource, "idconcepto", true));
            this.lookUpEdit1.Location = new System.Drawing.Point(74, 211);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nameconceptobaja", "Concepto", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.tConceptoBajaBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "nameconceptobaja";
            this.lookUpEdit1.Properties.ValueMember = "idconceptobaja";
            this.lookUpEdit1.Size = new System.Drawing.Size(190, 20);
            this.lookUpEdit1.TabIndex = 5;
            // 
            // fechamovMonthCalendar
            // 
            this.fechamovMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.t_MovimientoBindingSource, "fechamov", true));
            this.fechamovMonthCalendar.Location = new System.Drawing.Point(74, 43);
            this.fechamovMonthCalendar.Name = "fechamovMonthCalendar";
            this.fechamovMonthCalendar.TabIndex = 1;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = false;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 524);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.Size = new System.Drawing.Size(502, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.TabIndex = 19;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.nomovTextEdit);
            this.panelControl1.Controls.Add(label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(502, 36);
            this.panelControl1.TabIndex = 20;
            // 
            // nomovTextEdit
            // 
            this.nomovTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_MovimientoBindingSource, "nomov", true));
            this.nomovTextEdit.Location = new System.Drawing.Point(39, 9);
            this.nomovTextEdit.Name = "nomovTextEdit";
            this.nomovTextEdit.Size = new System.Drawing.Size(221, 20);
            this.nomovTextEdit.TabIndex = 19;
            conditionValidationRule1.CaseSensitive = true;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Equals;
            conditionValidationRule1.ErrorText = "El numero de movimento no coincide con el consecutivo";
            conditionValidationRule1.Value1 = "";
            conditionValidationRule1.Value2 = "";
            this.dxValidationProvider1.SetValidationRule(this.nomovTextEdit, conditionValidationRule1);
       
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // FrmNewMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 554);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmNewMovimiento";
            this.Text = "FrmNewMovimiento";
            this.Load += new System.EventHandler(this.FrmNewMovimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_MovimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Plantilla_PlusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PlantillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPlusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCentroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEscalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConceptoBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTreeDept1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Plantilla_PlusGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcentrocostoGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idcentrocostoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEscalaGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idEscalaGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifaMinimaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifaHorariaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condiLabAnSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit2.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomovTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSPlantilla dSPlantilla;
        private System.Windows.Forms.BindingSource t_MovimientoBindingSource;
        private DSPlantillaTableAdapters.T_MovimientoTableAdapter t_MovimientoTableAdapter;
        private DSPlantillaTableAdapters.TableAdapterManager tableAdapterManager;
        private DSPlantillaTableAdapters.T_ConceptoBajaTableAdapter t_ConceptoBajaTableAdapter;
        private System.Windows.Forms.BindingSource tConceptoBajaBindingSource;
        private System.Windows.Forms.BindingSource t_PlantillaBindingSource;
        private DSPlantillaTableAdapters.T_PlantillaTableAdapter t_PlantillaTableAdapter;
        private DSPlantillaTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource tEscalaBindingSource;
        private DSPlantillaTableAdapters.T_EscalaTableAdapter t_EscalaTableAdapter;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tCentroBindingSource;
        private DSDatosTableAdapters.T_CentroTableAdapter t_CentroTableAdapter;
        private System.Windows.Forms.BindingSource t_Plantilla_PlusBindingSource;
        private DSPlantillaTableAdapters.T_Plantilla_PlusTableAdapter t_Plantilla_PlusTableAdapter;
        private System.Windows.Forms.BindingSource tPlusBindingSource;
        private DSPlantillaTableAdapters.T_PlusTableAdapter t_PlusTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colidplusplantilla;
        private DevExpress.XtraGrid.Columns.GridColumn colidplantilla;
        private DevExpress.XtraGrid.Columns.GridColumn colactua;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl t_Plantilla_PlusGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidplus;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn coltarifa;
        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit idcentrocostoGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idcentrocostoGridLookUpEditView;
        private DevExpress.XtraEditors.GridLookUpEdit idEscalaGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idEscalaGridLookUpEditView;
        private DevExpress.XtraEditors.TextEdit tarifaMinimaTextEdit;
        private DevExpress.XtraEditors.TextEdit tarifaHorariaTextEdit;
        private DevExpress.XtraEditors.TextEdit condiLabAnSpinEdit;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit spinEdit1;
        private DevExpress.XtraEditors.TextEdit gridLookUpEdit2;
        private DevExpress.XtraEditors.TextEdit gridLookUpEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.MonthCalendar fechamovMonthCalendar;
        private UPlantilla uPlantilla1;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit nomovTextEdit;
        private DevExpress.XtraEditors.TextEdit popupContainerEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private UTreeDept uTreeDept1;
    }
}
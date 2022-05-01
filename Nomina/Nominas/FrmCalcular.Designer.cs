namespace Nomina.Nominas
{
    partial class FrmCalcular
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
            System.Windows.Forms.Label noSolLabel;
            System.Windows.Forms.Label fInicioLabel;
            System.Windows.Forms.Label fFinalLabel;
            System.Windows.Forms.Label idNominaPagarLabel;
            System.Windows.Forms.Label mesAñoLabel;
            this.dSDatos = new Nomina.DSDatos();
            this.t_SolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_SolicitudTableAdapter = new Nomina.DSDatosTableAdapters.T_SolicitudTableAdapter();
            this.tableAdapterManager = new Nomina.DSDatosTableAdapters.TableAdapterManager();
            this.noSolGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.noSolGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fInicioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fFinalDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.mesAñoTextBox = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.idNominaPagarGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoNomPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idNominaPagarGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tTipoNomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.t_TipoNomPagarTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoNomPagarTableAdapter();
            this.t_TipoNomTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoNomTableAdapter();
            noSolLabel = new System.Windows.Forms.Label();
            fInicioLabel = new System.Windows.Forms.Label();
            fFinalLabel = new System.Windows.Forms.Label();
            idNominaPagarLabel = new System.Windows.Forms.Label();
            mesAñoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSolGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSolGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoNomPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoNomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // noSolLabel
            // 
            noSolLabel.AutoSize = true;
            noSolLabel.Enabled = false;
            noSolLabel.Location = new System.Drawing.Point(8, 15);
            noSolLabel.Name = "noSolLabel";
            noSolLabel.Size = new System.Drawing.Size(66, 13);
            noSolLabel.TabIndex = 1;
            noSolLabel.Text = "No Solicitud:";
            // 
            // fInicioLabel
            // 
            fInicioLabel.AutoSize = true;
            fInicioLabel.Enabled = false;
            fInicioLabel.Location = new System.Drawing.Point(8, 38);
            fInicioLabel.Name = "fInicioLabel";
            fInicioLabel.Size = new System.Drawing.Size(68, 13);
            fInicioLabel.TabIndex = 3;
            fInicioLabel.Text = "Fecha Inicio:";
            // 
            // fFinalLabel
            // 
            fFinalLabel.AutoSize = true;
            fFinalLabel.Enabled = false;
            fFinalLabel.Location = new System.Drawing.Point(186, 38);
            fFinalLabel.Name = "fFinalLabel";
            fFinalLabel.Size = new System.Drawing.Size(65, 13);
            fFinalLabel.TabIndex = 5;
            fFinalLabel.Text = "Fecha Final:";
            // 
            // idNominaPagarLabel
            // 
            idNominaPagarLabel.AutoSize = true;
            idNominaPagarLabel.Enabled = false;
            idNominaPagarLabel.Location = new System.Drawing.Point(186, 15);
            idNominaPagarLabel.Name = "idNominaPagarLabel";
            idNominaPagarLabel.Size = new System.Drawing.Size(90, 13);
            idNominaPagarLabel.TabIndex = 9;
            idNominaPagarLabel.Text = "Id Nomina Pagar:";
            // 
            // mesAñoLabel
            // 
            mesAñoLabel.AutoSize = true;
            mesAñoLabel.Enabled = false;
            mesAñoLabel.Location = new System.Drawing.Point(363, 38);
            mesAñoLabel.Name = "mesAñoLabel";
            mesAñoLabel.Size = new System.Drawing.Size(52, 13);
            mesAñoLabel.TabIndex = 15;
            mesAñoLabel.Text = "Mes Año:";
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_SolicitudBindingSource
            // 
            this.t_SolicitudBindingSource.DataMember = "T_Solicitud";
            this.t_SolicitudBindingSource.DataSource = this.dSDatos;
            // 
            // t_SolicitudTableAdapter
            // 
            this.t_SolicitudTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_Centro_DeptTableAdapter = null;
            this.tableAdapterManager.T_CentroTableAdapter = null;
            this.tableAdapterManager.T_CuentaTableAdapter = null;
            this.tableAdapterManager.T_MesesTableAdapter = null;
            this.tableAdapterManager.T_OtrosPagosTableAdapter = null;
            this.tableAdapterManager.T_PlantillaTableAdapter = null;
            this.tableAdapterManager.T_RepEstadoTableAdapter = null;
            this.tableAdapterManager.T_Report_AllTableAdapter = null;
            this.tableAdapterManager.T_ReporteTiempoAjusteTableAdapter = null;
            this.tableAdapterManager.T_ReporteTiempoEstadoTableAdapter = null;
            this.tableAdapterManager.T_ReporteTiempoNormalTableAdapter = null;
            this.tableAdapterManager.T_ReporteTiempoOtrosPagosTableAdapter = null;
            this.tableAdapterManager.T_ReporteTiempoTableAdapter = null;
            this.tableAdapterManager.T_SolicitudTableAdapter = this.t_SolicitudTableAdapter;
            this.tableAdapterManager.T_TipoCuentaTableAdapter = null;
            this.tableAdapterManager.T_TipoNomDesTableAdapter = null;
            this.tableAdapterManager.T_TipoNomPagarTableAdapter = null;
            this.tableAdapterManager.T_TipoNomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // noSolGridLookUpEditView
            // 
            this.noSolGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.noSolGridLookUpEditView.Name = "noSolGridLookUpEditView";
            this.noSolGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.noSolGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // noSolGridLookUpEdit
            // 
            this.noSolGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "NoSol", true));
            this.noSolGridLookUpEdit.Enabled = false;
            this.noSolGridLookUpEdit.Location = new System.Drawing.Point(80, 12);
            this.noSolGridLookUpEdit.Name = "noSolGridLookUpEdit";
            this.noSolGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.noSolGridLookUpEdit.Properties.DataSource = this.t_SolicitudBindingSource;
            this.noSolGridLookUpEdit.Properties.DisplayMember = "NoSol";
            this.noSolGridLookUpEdit.Properties.ValueMember = "IdSolicitud";
            this.noSolGridLookUpEdit.Properties.View = this.noSolGridLookUpEditView;
            this.noSolGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.noSolGridLookUpEdit.TabIndex = 2;
            // 
            // fInicioDateEdit
            // 
            this.fInicioDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "FInicio", true));
            this.fInicioDateEdit.EditValue = null;
            this.fInicioDateEdit.Enabled = false;
            this.fInicioDateEdit.Location = new System.Drawing.Point(80, 35);
            this.fInicioDateEdit.Name = "fInicioDateEdit";
            this.fInicioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fInicioDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fInicioDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fInicioDateEdit.TabIndex = 4;
            // 
            // fFinalDateEdit
            // 
            this.fFinalDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "FFinal", true));
            this.fFinalDateEdit.EditValue = null;
            this.fFinalDateEdit.Enabled = false;
            this.fFinalDateEdit.Location = new System.Drawing.Point(257, 35);
            this.fFinalDateEdit.Name = "fFinalDateEdit";
            this.fFinalDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fFinalDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fFinalDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fFinalDateEdit.TabIndex = 6;
            // 
            // mesAñoTextBox
            // 
            this.mesAñoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_SolicitudBindingSource, "MesAño", true));
            this.mesAñoTextBox.Enabled = false;
            this.mesAñoTextBox.Location = new System.Drawing.Point(421, 35);
            this.mesAñoTextBox.Name = "mesAñoTextBox";
            this.mesAñoTextBox.Size = new System.Drawing.Size(100, 21);
            this.mesAñoTextBox.TabIndex = 16;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.noSolGridLookUpEdit);
            this.panelControl1.Controls.Add(idNominaPagarLabel);
            this.panelControl1.Controls.Add(this.idNominaPagarGridLookUpEdit);
            this.panelControl1.Controls.Add(fInicioLabel);
            this.panelControl1.Controls.Add(this.fInicioDateEdit);
            this.panelControl1.Controls.Add(mesAñoLabel);
            this.panelControl1.Controls.Add(this.mesAñoTextBox);
            this.panelControl1.Controls.Add(noSolLabel);
            this.panelControl1.Controls.Add(fFinalLabel);
            this.panelControl1.Controls.Add(this.fFinalDateEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(527, 68);
            this.panelControl1.TabIndex = 17;
            // 
            // idNominaPagarGridLookUpEdit
            // 
            this.idNominaPagarGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "IdNominaPagar", true));
            this.idNominaPagarGridLookUpEdit.Enabled = false;
            this.idNominaPagarGridLookUpEdit.Location = new System.Drawing.Point(284, 12);
            this.idNominaPagarGridLookUpEdit.Name = "idNominaPagarGridLookUpEdit";
            this.idNominaPagarGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idNominaPagarGridLookUpEdit.Properties.DataSource = this.tTipoNomPagarBindingSource;
            this.idNominaPagarGridLookUpEdit.Properties.DisplayMember = "NameTipoNomPagar";
            this.idNominaPagarGridLookUpEdit.Properties.ValueMember = "idTipoNomPagar";
            this.idNominaPagarGridLookUpEdit.Properties.View = this.idNominaPagarGridLookUpEditView;
            this.idNominaPagarGridLookUpEdit.Size = new System.Drawing.Size(208, 20);
            this.idNominaPagarGridLookUpEdit.TabIndex = 10;
            // 
            // tTipoNomPagarBindingSource
            // 
            this.tTipoNomPagarBindingSource.DataMember = "T_TipoNomPagar";
            this.tTipoNomPagarBindingSource.DataSource = this.dSDatos;
            // 
            // idNominaPagarGridLookUpEditView
            // 
            this.idNominaPagarGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idNominaPagarGridLookUpEditView.Name = "idNominaPagarGridLookUpEditView";
            this.idNominaPagarGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idNominaPagarGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // tTipoNomBindingSource
            // 
            this.tTipoNomBindingSource.DataMember = "T_TipoNom";
            this.tTipoNomBindingSource.DataSource = this.dSDatos;
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(311, 371);
            this.treeList1.TabIndex = 19;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(698, 250);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Herramientas";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Seleccionar Todo";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Deseleccionar Todo";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 68);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(527, 23);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(527, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Size = new System.Drawing.Size(527, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(527, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.treeList1);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 91);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(527, 375);
            this.panelControl2.TabIndex = 25;
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(313, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(212, 371);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Historial";
            // 
            // t_TipoNomPagarTableAdapter
            // 
            this.t_TipoNomPagarTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoNomTableAdapter
            // 
            this.t_TipoNomTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 491);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmCalcular";
            this.Text = "FrmCalcular";
            this.Load += new System.EventHandler(this.FrmCalcular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSolGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSolGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoNomPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoNomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_SolicitudBindingSource;
        private DSDatosTableAdapters.T_SolicitudTableAdapter t_SolicitudTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Views.Grid.GridView noSolGridLookUpEditView;
        private DevExpress.XtraEditors.GridLookUpEdit noSolGridLookUpEdit;
        private DevExpress.XtraEditors.DateEdit fInicioDateEdit;
        private DevExpress.XtraEditors.DateEdit fFinalDateEdit;
        private System.Windows.Forms.TextBox mesAñoTextBox;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit idNominaPagarGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idNominaPagarGridLookUpEditView;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.BindingSource tTipoNomPagarBindingSource;
        private DSDatosTableAdapters.T_TipoNomPagarTableAdapter t_TipoNomPagarTableAdapter;
        private System.Windows.Forms.BindingSource tTipoNomBindingSource;
        private DSDatosTableAdapters.T_TipoNomTableAdapter t_TipoNomTableAdapter;
    }
}
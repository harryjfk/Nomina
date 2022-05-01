namespace Nomina
{
    partial class FrmInicializar
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
            System.Windows.Forms.Label añoContabilidadLabel;
            System.Windows.Forms.Label idNominaPagarLabel;
            System.Windows.Forms.Label idMesLabel;
            System.Windows.Forms.Label fFinalLabel;
            System.Windows.Forms.Label fInicioLabel;
            System.Windows.Forms.Label noSolLabel;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.nFPCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.idNominaPagarGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.idNominaPagarGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNameTipoNomPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idMesGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.idMesGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMeses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fFinalDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fInicioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.noSolGridLookUpEdit = new DevExpress.XtraEditors.TextEdit();
            this.añoContabilidadGridLookUpEdit = new DevExpress.XtraEditors.TextEdit();
            this.t_SolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new Nomina.DSDatos();
            this.tMesesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTipoNomPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_SolicitudTableAdapter = new Nomina.DSDatosTableAdapters.T_SolicitudTableAdapter();
            this.tableAdapterManager = new Nomina.DSDatosTableAdapters.TableAdapterManager();
            this.t_MesesTableAdapter = new Nomina.DSDatosTableAdapters.T_MesesTableAdapter();
            this.t_TipoNomPagarTableAdapter = new Nomina.DSDatosTableAdapters.T_TipoNomPagarTableAdapter();
            this.queriesTableAdapter1 = new Nomina.DSDatosTableAdapters.QueriesTableAdapter();
            añoContabilidadLabel = new System.Windows.Forms.Label();
            idNominaPagarLabel = new System.Windows.Forms.Label();
            idMesLabel = new System.Windows.Forms.Label();
            fFinalLabel = new System.Windows.Forms.Label();
            fInicioLabel = new System.Windows.Forms.Label();
            noSolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nFPCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idMesGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idMesGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSolGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.añoContabilidadGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMesesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoNomPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // añoContabilidadLabel
            // 
            añoContabilidadLabel.AutoSize = true;
            añoContabilidadLabel.Location = new System.Drawing.Point(6, 139);
            añoContabilidadLabel.Name = "añoContabilidadLabel";
            añoContabilidadLabel.Size = new System.Drawing.Size(92, 13);
            añoContabilidadLabel.TabIndex = 10;
            añoContabilidadLabel.Text = "Año Contabilidad:";
            // 
            // idNominaPagarLabel
            // 
            idNominaPagarLabel.AutoSize = true;
            idNominaPagarLabel.Location = new System.Drawing.Point(6, 85);
            idNominaPagarLabel.Name = "idNominaPagarLabel";
            idNominaPagarLabel.Size = new System.Drawing.Size(86, 13);
            idNominaPagarLabel.TabIndex = 8;
            idNominaPagarLabel.Text = "Nomina a Pagar:";
            // 
            // idMesLabel
            // 
            idMesLabel.AutoSize = true;
            idMesLabel.Location = new System.Drawing.Point(6, 113);
            idMesLabel.Name = "idMesLabel";
            idMesLabel.Size = new System.Drawing.Size(92, 13);
            idMesLabel.TabIndex = 6;
            idMesLabel.Text = "Mes Contabilidad:";
            // 
            // fFinalLabel
            // 
            fFinalLabel.AutoSize = true;
            fFinalLabel.Location = new System.Drawing.Point(6, 58);
            fFinalLabel.Name = "fFinalLabel";
            fFinalLabel.Size = new System.Drawing.Size(65, 13);
            fFinalLabel.TabIndex = 4;
            fFinalLabel.Text = "Fecha Final:";
            // 
            // fInicioLabel
            // 
            fInicioLabel.AutoSize = true;
            fInicioLabel.Location = new System.Drawing.Point(6, 32);
            fInicioLabel.Name = "fInicioLabel";
            fInicioLabel.Size = new System.Drawing.Size(83, 13);
            fInicioLabel.TabIndex = 2;
            fInicioLabel.Text = "Fecha de Inicio:";
            // 
            // noSolLabel
            // 
            noSolLabel.AutoSize = true;
            noSolLabel.Location = new System.Drawing.Point(6, 8);
            noSolLabel.Name = "noSolLabel";
            noSolLabel.Size = new System.Drawing.Size(66, 13);
            noSolLabel.TabIndex = 0;
            noSolLabel.Text = "No Solicitud:";
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 223);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.Size = new System.Drawing.Size(348, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.TabIndex = 24;
            // 
            // nFPCheckEdit
            // 
            this.nFPCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "NFP", true));
            this.nFPCheckEdit.Location = new System.Drawing.Point(7, 165);
            this.nFPCheckEdit.Name = "nFPCheckEdit";
            this.nFPCheckEdit.Properties.Caption = "NFP";
            this.nFPCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.nFPCheckEdit.TabIndex = 13;
            // 
            // idNominaPagarGridLookUpEdit
            // 
            this.idNominaPagarGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "IdNominaPagar", true));
            this.idNominaPagarGridLookUpEdit.Location = new System.Drawing.Point(102, 82);
            this.idNominaPagarGridLookUpEdit.Name = "idNominaPagarGridLookUpEdit";
            this.idNominaPagarGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idNominaPagarGridLookUpEdit.Properties.DataSource = this.tTipoNomPagarBindingSource;
            this.idNominaPagarGridLookUpEdit.Properties.DisplayMember = "NameTipoNomPagar";
            this.idNominaPagarGridLookUpEdit.Properties.ValueMember = "idTipoNomPagar";
            this.idNominaPagarGridLookUpEdit.Properties.View = this.idNominaPagarGridLookUpEditView;
            this.idNominaPagarGridLookUpEdit.Size = new System.Drawing.Size(144, 20);
            this.idNominaPagarGridLookUpEdit.TabIndex = 9;
            this.idNominaPagarGridLookUpEdit.EditValueChanged += new System.EventHandler(this.idNominaPagarGridLookUpEdit_EditValueChanged);
            // 
            // idNominaPagarGridLookUpEditView
            // 
            this.idNominaPagarGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNameTipoNomPagar});
            this.idNominaPagarGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idNominaPagarGridLookUpEditView.Name = "idNominaPagarGridLookUpEditView";
            this.idNominaPagarGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idNominaPagarGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colNameTipoNomPagar
            // 
            this.colNameTipoNomPagar.FieldName = "NameTipoNomPagar";
            this.colNameTipoNomPagar.Name = "colNameTipoNomPagar";
            this.colNameTipoNomPagar.Visible = true;
            this.colNameTipoNomPagar.VisibleIndex = 0;
            // 
            // idMesGridLookUpEdit
            // 
            this.idMesGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "IdMes", true));
            this.idMesGridLookUpEdit.Location = new System.Drawing.Point(104, 110);
            this.idMesGridLookUpEdit.Name = "idMesGridLookUpEdit";
            this.idMesGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idMesGridLookUpEdit.Properties.DataSource = this.tMesesBindingSource;
            this.idMesGridLookUpEdit.Properties.DisplayMember = "Meses";
            this.idMesGridLookUpEdit.Properties.ValueMember = "idMes";
            this.idMesGridLookUpEdit.Properties.View = this.idMesGridLookUpEditView;
            this.idMesGridLookUpEdit.Size = new System.Drawing.Size(144, 20);
            this.idMesGridLookUpEdit.TabIndex = 7;
            // 
            // idMesGridLookUpEditView
            // 
            this.idMesGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMeses});
            this.idMesGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idMesGridLookUpEditView.Name = "idMesGridLookUpEditView";
            this.idMesGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idMesGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colMeses
            // 
            this.colMeses.FieldName = "Meses";
            this.colMeses.Name = "colMeses";
            this.colMeses.Visible = true;
            this.colMeses.VisibleIndex = 0;
            // 
            // fFinalDateEdit
            // 
            this.fFinalDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "FFinal", true));
            this.fFinalDateEdit.EditValue = null;
            this.fFinalDateEdit.Location = new System.Drawing.Point(104, 55);
            this.fFinalDateEdit.Name = "fFinalDateEdit";
            this.fFinalDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fFinalDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fFinalDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fFinalDateEdit.TabIndex = 5;
            // 
            // fInicioDateEdit
            // 
            this.fInicioDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "FInicio", true));
            this.fInicioDateEdit.EditValue = null;
            this.fInicioDateEdit.Location = new System.Drawing.Point(104, 29);
            this.fInicioDateEdit.Name = "fInicioDateEdit";
            this.fInicioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fInicioDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fInicioDateEdit.Properties.EditValueChanged += new System.EventHandler(this.fInicioDateEdit_Properties_EditValueChanged);
            this.fInicioDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fInicioDateEdit.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(noSolLabel);
            this.panelControl1.Controls.Add(fInicioLabel);
            this.panelControl1.Controls.Add(this.fInicioDateEdit);
            this.panelControl1.Controls.Add(fFinalLabel);
            this.panelControl1.Controls.Add(this.fFinalDateEdit);
            this.panelControl1.Controls.Add(idMesLabel);
            this.panelControl1.Controls.Add(this.idMesGridLookUpEdit);
            this.panelControl1.Controls.Add(idNominaPagarLabel);
            this.panelControl1.Controls.Add(this.idNominaPagarGridLookUpEdit);
            this.panelControl1.Controls.Add(añoContabilidadLabel);
            this.panelControl1.Controls.Add(this.nFPCheckEdit);
            this.panelControl1.Controls.Add(this.noSolGridLookUpEdit);
            this.panelControl1.Controls.Add(this.añoContabilidadGridLookUpEdit);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(442, 204);
            this.panelControl1.TabIndex = 23;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // noSolGridLookUpEdit
            // 
            this.noSolGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "NoSol", true));
            this.noSolGridLookUpEdit.EditValue = "";
            this.noSolGridLookUpEdit.Location = new System.Drawing.Point(104, 5);
            this.noSolGridLookUpEdit.Name = "noSolGridLookUpEdit";
            this.noSolGridLookUpEdit.Properties.NullText = "[Vacío]";
            this.noSolGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.noSolGridLookUpEdit.TabIndex = 14;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Equals;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.noSolGridLookUpEdit, conditionValidationRule1);
            // 
            // añoContabilidadGridLookUpEdit
            // 
            this.añoContabilidadGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_SolicitudBindingSource, "AñoContabilidad", true));
            this.añoContabilidadGridLookUpEdit.EditValue = "";
            this.añoContabilidadGridLookUpEdit.Location = new System.Drawing.Point(104, 136);
            this.añoContabilidadGridLookUpEdit.Name = "añoContabilidadGridLookUpEdit";
            this.añoContabilidadGridLookUpEdit.Properties.NullText = "[Vacío]";
            this.añoContabilidadGridLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.añoContabilidadGridLookUpEdit.TabIndex = 15;
            // 
            // t_SolicitudBindingSource
            // 
            this.t_SolicitudBindingSource.DataMember = "T_Solicitud";
            this.t_SolicitudBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMesesBindingSource
            // 
            this.tMesesBindingSource.DataMember = "T_Meses";
            this.tMesesBindingSource.DataSource = this.dSDatos;
            // 
            // tTipoNomPagarBindingSource
            // 
            this.tTipoNomPagarBindingSource.DataMember = "T_TipoNomPagar";
            this.tTipoNomPagarBindingSource.DataSource = this.dSDatos;
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
            this.tableAdapterManager.T_MesesTableAdapter = this.t_MesesTableAdapter;
            this.tableAdapterManager.T_SolicitudTableAdapter = this.t_SolicitudTableAdapter;
            this.tableAdapterManager.T_TipoCuentaTableAdapter = null;
            this.tableAdapterManager.T_TipoNomDesTableAdapter = null;
            this.tableAdapterManager.T_TipoNomPagarTableAdapter = this.t_TipoNomPagarTableAdapter;
            this.tableAdapterManager.T_TipoNomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nomina.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_MesesTableAdapter
            // 
            this.t_MesesTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoNomPagarTableAdapter
            // 
            this.t_TipoNomPagarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInicializar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 253);
            this.Controls.Add(this.ucPieFormulario1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmInicializar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmInicializar";
            this.Load += new System.EventHandler(this.FrmInicializar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFPCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNominaPagarGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idMesGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idMesGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFinalDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInicioDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSolGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.añoContabilidadGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_SolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMesesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoNomPagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_SolicitudBindingSource;
        private DSDatosTableAdapters.T_SolicitudTableAdapter t_SolicitudTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraEditors.CheckEdit nFPCheckEdit;
        private DevExpress.XtraEditors.GridLookUpEdit idNominaPagarGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idNominaPagarGridLookUpEditView;
        private DevExpress.XtraEditors.GridLookUpEdit idMesGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idMesGridLookUpEditView;
        private DevExpress.XtraEditors.DateEdit fFinalDateEdit;
        private DevExpress.XtraEditors.DateEdit fInicioDateEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSDatosTableAdapters.T_MesesTableAdapter t_MesesTableAdapter;
        private System.Windows.Forms.BindingSource tMesesBindingSource;
        private DSDatosTableAdapters.T_TipoNomPagarTableAdapter t_TipoNomPagarTableAdapter;
        private System.Windows.Forms.BindingSource tTipoNomPagarBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNameTipoNomPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colMeses;
        private DSDatosTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraEditors.TextEdit noSolGridLookUpEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit añoContabilidadGridLookUpEdit;

    }
}
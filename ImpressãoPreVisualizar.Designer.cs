namespace EtiquetasClippStore
{
    partial class ImpressãoPreVisualizar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpressãoPreVisualizar));
            this.IMPRESSAO_ETIQUETASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new EtiquetasClippStore.DataSet3();
            this.etiquetasImp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IMPRESSAO_ETIQUETASTableAdapter = new EtiquetasClippStore.DataSet3TableAdapters.IMPRESSAO_ETIQUETASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IMPRESSAO_ETIQUETASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IMPRESSAO_ETIQUETASBindingSource
            // 
            this.IMPRESSAO_ETIQUETASBindingSource.DataMember = "IMPRESSAO_ETIQUETAS";
            this.IMPRESSAO_ETIQUETASBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etiquetasImp
            // 
            this.etiquetasImp.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetEtqImp";
            reportDataSource1.Value = this.IMPRESSAO_ETIQUETASBindingSource;
            this.etiquetasImp.LocalReport.DataSources.Add(reportDataSource1);
            this.etiquetasImp.LocalReport.ReportEmbeddedResource = "EtiquetasClippStore.EtiquetasFinal.rdlc";
            this.etiquetasImp.Location = new System.Drawing.Point(0, 0);
            this.etiquetasImp.Name = "etiquetasImp";
            this.etiquetasImp.ServerReport.BearerToken = null;
            this.etiquetasImp.Size = new System.Drawing.Size(884, 478);
            this.etiquetasImp.TabIndex = 0;
            this.etiquetasImp.Load += new System.EventHandler(this.EtiquetasImp_Load);
            // 
            // dataSet3BindingSource
            // 
            this.dataSet3BindingSource.DataSource = this.dataSet3;
            this.dataSet3BindingSource.Position = 0;
            // 
            // IMPRESSAO_ETIQUETASTableAdapter
            // 
            this.IMPRESSAO_ETIQUETASTableAdapter.ClearBeforeFill = true;
            // 
            // ImpressãoPreVisualizar
            // 
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.Controls.Add(this.etiquetasImp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImpressãoPreVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Etiquetas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImpressãoPreVisualizar_FormClosed);
            this.Load += new System.EventHandler(this.ImpressãoPreVisualizar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.IMPRESSAO_ETIQUETASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer EtiquetasTelaImp;
        private Microsoft.Reporting.WinForms.ReportViewer etiquetasImp;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dataSet3BindingSource;
        private DataSet3TableAdapters.IMPRESSAO_ETIQUETASTableAdapter IMPRESSAO_ETIQUETASTableAdapter;
        private System.Windows.Forms.BindingSource IMPRESSAO_ETIQUETASBindingSource;
    }
}
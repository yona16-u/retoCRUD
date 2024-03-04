namespace retoCRUD.PRESENTACION.REPORTES
{
    partial class Form2_REPORTE_LIST_CLI
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
            this.sPLECTURACLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Reportes = new retoCRUD.PRESENTACION.REPORTES.DS_Reportes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_LECTURA_CLIENTETableAdapter = new retoCRUD.PRESENTACION.REPORTES.DS_ReportesTableAdapters.SP_LECTURA_CLIENTETableAdapter();
            this.Txt_01 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sPLECTURACLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // sPLECTURACLIENTEBindingSource
            // 
            this.sPLECTURACLIENTEBindingSource.DataMember = "SP_LECTURA_CLIENTE";
            this.sPLECTURACLIENTEBindingSource.DataSource = this.dS_Reportes;
            // 
            // dS_Reportes
            // 
            this.dS_Reportes.DataSetName = "DS_Reportes";
            this.dS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPLECTURACLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "retoCRUD.PRESENTACION.REPORTES.Rpt_Listado_cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1357, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_LECTURA_CLIENTETableAdapter
            // 
            this.sP_LECTURA_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Txt_01
            // 
            this.Txt_01.Location = new System.Drawing.Point(34, 53);
            this.Txt_01.Name = "Txt_01";
            this.Txt_01.Size = new System.Drawing.Size(100, 20);
            this.Txt_01.TabIndex = 1;
            this.Txt_01.Visible = false;
            // 
            // Form2_REPORTE_LIST_CLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 450);
            this.Controls.Add(this.Txt_01);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2_REPORTE_LIST_CLI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2_REPORTE_LIST_CLI";
            this.Load += new System.EventHandler(this.Form2_REPORTE_LIST_CLI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPLECTURACLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPLECTURACLIENTEBindingSource;
        private DS_Reportes dS_Reportes;
        private DS_ReportesTableAdapters.SP_LECTURA_CLIENTETableAdapter sP_LECTURA_CLIENTETableAdapter;
        internal System.Windows.Forms.TextBox Txt_01;
    }
}
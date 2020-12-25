namespace DepartmentalStoreApp
{
    partial class BillingForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Billing = new DepartmentalStoreApp.Billing();
            this.SalesCodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesCodeTableTableAdapter = new DepartmentalStoreApp.BillingTableAdapters.SalesCodeTableTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new DepartmentalStoreApp.BillingTableAdapters.DataTable1TableAdapter();
            this.BillTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillTableTableAdapter = new DepartmentalStoreApp.BillingTableAdapters.BillTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Billing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalesCodeTableBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTable1BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.BillTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DepartmentalStoreApp.Billing.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(479, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // Billing
            // 
            this.Billing.DataSetName = "Billing";
            this.Billing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesCodeTableBindingSource
            // 
            this.SalesCodeTableBindingSource.DataMember = "SalesCodeTable";
            this.SalesCodeTableBindingSource.DataSource = this.Billing;
            // 
            // SalesCodeTableTableAdapter
            // 
            this.SalesCodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Billing;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // BillTableBindingSource
            // 
            this.BillTableBindingSource.DataMember = "BillTable";
            this.BillTableBindingSource.DataSource = this.Billing;
            // 
            // BillTableTableAdapter
            // 
            this.BillTableTableAdapter.ClearBeforeFill = true;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Billing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesCodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesCodeTableBindingSource;
        private Billing Billing;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource BillTableBindingSource;
        private BillingTableAdapters.SalesCodeTableTableAdapter SalesCodeTableTableAdapter;
        private BillingTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private BillingTableAdapters.BillTableTableAdapter BillTableTableAdapter;
    }
}
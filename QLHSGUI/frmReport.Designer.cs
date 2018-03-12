namespace QLHSGUI
{
    partial class frmReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SEQLHocSinhDataSet = new QLHSGUI.SEQLHocSinhDataSet();
            this.HocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HocSinhTableAdapter = new QLHSGUI.SEQLHocSinhDataSetTableAdapters.HocSinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SEQLHocSinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHocSinh";
            reportDataSource1.Value = this.HocSinhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLHSGUI.rptHocSinh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(568, 321);
            this.reportViewer1.TabIndex = 0;
            // 
            // SEQLHocSinhDataSet
            // 
            this.SEQLHocSinhDataSet.DataSetName = "SEQLHocSinhDataSet";
            this.SEQLHocSinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HocSinhBindingSource
            // 
            this.HocSinhBindingSource.DataMember = "HocSinh";
            this.HocSinhBindingSource.DataSource = this.SEQLHocSinhDataSet;
            // 
            // HocSinhTableAdapter
            // 
            this.HocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 321);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SEQLHocSinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HocSinhBindingSource;
        private SEQLHocSinhDataSet SEQLHocSinhDataSet;
        private SEQLHocSinhDataSetTableAdapters.HocSinhTableAdapter HocSinhTableAdapter;
    }
}
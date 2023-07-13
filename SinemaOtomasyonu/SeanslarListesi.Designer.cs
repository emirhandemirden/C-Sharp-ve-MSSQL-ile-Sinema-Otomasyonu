namespace SinemaOtomasyonu
{
    partial class SeanslarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeanslarListesi));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.seanslarDataSet = new SinemaOtomasyonu.SeanslarDataSet();
            this.seanslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seanslarTableAdapter = new SinemaOtomasyonu.SeanslarDataSetTableAdapters.SeanslarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.seanslarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SinemaOtomasyonu.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // seanslarDataSet
            // 
            this.seanslarDataSet.DataSetName = "SeanslarDataSet";
            this.seanslarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seanslarBindingSource
            // 
            this.seanslarBindingSource.DataMember = "Seanslar";
            this.seanslarBindingSource.DataSource = this.seanslarDataSet;
            // 
            // seanslarTableAdapter
            // 
            this.seanslarTableAdapter.ClearBeforeFill = true;
            // 
            // SeanslarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeanslarListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seanslar Listesi Raporu";
            this.Load += new System.EventHandler(this.SeanslarListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanslarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SeanslarDataSet seanslarDataSet;
        private System.Windows.Forms.BindingSource seanslarBindingSource;
        private SeanslarDataSetTableAdapters.SeanslarTableAdapter seanslarTableAdapter;
    }
}
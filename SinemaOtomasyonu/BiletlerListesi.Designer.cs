namespace SinemaOtomasyonu
{
    partial class BiletlerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletlerListesi));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.biletlerDataSet = new SinemaOtomasyonu.BiletlerDataSet();
            this.biletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletlerTableAdapter = new SinemaOtomasyonu.BiletlerDataSetTableAdapters.BiletlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.biletlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SinemaOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // biletlerDataSet
            // 
            this.biletlerDataSet.DataSetName = "BiletlerDataSet";
            this.biletlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletlerBindingSource
            // 
            this.biletlerBindingSource.DataMember = "Biletler";
            this.biletlerBindingSource.DataSource = this.biletlerDataSet;
            // 
            // biletlerTableAdapter
            // 
            this.biletlerTableAdapter.ClearBeforeFill = true;
            // 
            // BiletlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiletlerListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biletler Listesi Raporu";
            this.Load += new System.EventHandler(this.BiletlerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BiletlerDataSet biletlerDataSet;
        private System.Windows.Forms.BindingSource biletlerBindingSource;
        private BiletlerDataSetTableAdapters.BiletlerTableAdapter biletlerTableAdapter;
    }
}
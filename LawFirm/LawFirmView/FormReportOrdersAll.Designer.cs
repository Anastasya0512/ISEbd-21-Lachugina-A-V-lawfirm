namespace LawFirmView
{
    partial class FormReportOrdersAll
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
            this.ReportOrdersAllDatesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonToPdf = new System.Windows.Forms.Button();
            this.buttonMake = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrdersAllDatesViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportOrdersAllDatesViewModelBindingSource
            // 
            this.ReportOrdersAllDatesViewModelBindingSource.DataSource = typeof(LawFirmBusinessLogic.ViewModels.ReportOrdersAllDatesViewModel);
            // 
            // buttonToPdf
            // 
            this.buttonToPdf.Location = new System.Drawing.Point(633, 13);
            this.buttonToPdf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToPdf.Name = "buttonToPdf";
            this.buttonToPdf.Size = new System.Drawing.Size(145, 47);
            this.buttonToPdf.TabIndex = 4;
            this.buttonToPdf.Text = "В Pdf";
            this.buttonToPdf.UseVisualStyleBackColor = true;
            this.buttonToPdf.Click += new System.EventHandler(this.buttonToPdf_Click);
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(81, 13);
            this.buttonMake.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(145, 47);
            this.buttonMake.TabIndex = 3;
            this.buttonMake.Text = "Сформировать";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // reportViewer
            //           
            this.reportViewer.LocalReport.ReportEmbeddedResource = "LawFirmView.ReportAll.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(12, 96);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(864, 443);
            this.reportViewer.TabIndex = 5;
            // 
            // FormReportOrdersAllDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 554);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.buttonToPdf);
            this.Controls.Add(this.buttonMake);
            this.Name = "FormReportOrdersAllDates";
            this.Text = "Заказы за весь период";
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrdersAllDatesViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ReportOrdersAllDatesViewModelBindingSource;
        private System.Windows.Forms.Button buttonToPdf;
        private System.Windows.Forms.Button buttonMake;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}
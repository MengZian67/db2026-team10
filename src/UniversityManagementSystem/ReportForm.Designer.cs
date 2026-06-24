namespace UniversityManagementSystem
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStudentReport = new System.Windows.Forms.Button();
            this.btnCourseReport = new System.Windows.Forms.Button();
            this.btnEnrollmentReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStudentAnalytics = new System.Windows.Forms.Button();
            this.chartAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlAnalytics = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCourseAnalytics = new System.Windows.Forms.Button();
            this.btnEnrollmentAnalytics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalytics)).BeginInit();
            this.pnlAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.Location = new System.Drawing.Point(12, 260);
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.Size = new System.Drawing.Size(140, 40);
            this.btnStudentReport.TabIndex = 0;
            this.btnStudentReport.Text = "Student Report";
            this.btnStudentReport.UseVisualStyleBackColor = true;
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // btnCourseReport
            // 
            this.btnCourseReport.Location = new System.Drawing.Point(12, 306);
            this.btnCourseReport.Name = "btnCourseReport";
            this.btnCourseReport.Size = new System.Drawing.Size(140, 40);
            this.btnCourseReport.TabIndex = 1;
            this.btnCourseReport.Text = "Course Report";
            this.btnCourseReport.UseVisualStyleBackColor = true;
            this.btnCourseReport.Click += new System.EventHandler(this.btnCourseReport_Click);
            // 
            // btnEnrollmentReport
            // 
            this.btnEnrollmentReport.Location = new System.Drawing.Point(12, 352);
            this.btnEnrollmentReport.Name = "btnEnrollmentReport";
            this.btnEnrollmentReport.Size = new System.Drawing.Size(140, 40);
            this.btnEnrollmentReport.TabIndex = 2;
            this.btnEnrollmentReport.Text = "Enrollment Report";
            this.btnEnrollmentReport.UseVisualStyleBackColor = true;
            this.btnEnrollmentReport.Click += new System.EventHandler(this.btnEnrollmentReport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(158, 260);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(735, 186);
            this.dgvReport.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStudentAnalytics
            // 
            this.btnStudentAnalytics.Location = new System.Drawing.Point(102, 87);
            this.btnStudentAnalytics.Name = "btnStudentAnalytics";
            this.btnStudentAnalytics.Size = new System.Drawing.Size(174, 40);
            this.btnStudentAnalytics.TabIndex = 6;
            this.btnStudentAnalytics.Text = "Students Analytics";
            this.btnStudentAnalytics.UseVisualStyleBackColor = true;
            this.btnStudentAnalytics.Click += new System.EventHandler(this.btnStudentAnalytics_Click);
            // 
            // chartAnalytics
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAnalytics.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAnalytics.Legends.Add(legend2);
            this.chartAnalytics.Location = new System.Drawing.Point(292, 87);
            this.chartAnalytics.Name = "chartAnalytics";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAnalytics.Series.Add(series2);
            this.chartAnalytics.Size = new System.Drawing.Size(600, 159);
            this.chartAnalytics.TabIndex = 7;
            this.chartAnalytics.Text = "chart1";
            // 
            // pnlAnalytics
            // 
            this.pnlAnalytics.Controls.Add(this.lblTitle);
            this.pnlAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnalytics.Location = new System.Drawing.Point(0, 0);
            this.pnlAnalytics.Name = "pnlAnalytics";
            this.pnlAnalytics.Size = new System.Drawing.Size(905, 72);
            this.pnlAnalytics.TabIndex = 9;
            this.pnlAnalytics.Tag = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(314, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REPORTS & ANALYTICS";
            // 
            // btnCourseAnalytics
            // 
            this.btnCourseAnalytics.Location = new System.Drawing.Point(102, 145);
            this.btnCourseAnalytics.Name = "btnCourseAnalytics";
            this.btnCourseAnalytics.Size = new System.Drawing.Size(174, 40);
            this.btnCourseAnalytics.TabIndex = 10;
            this.btnCourseAnalytics.Text = "Course Analytics";
            this.btnCourseAnalytics.UseVisualStyleBackColor = true;
            this.btnCourseAnalytics.Click += new System.EventHandler(this.btnCourseAnalytics_Click);
            // 
            // btnEnrollmentAnalytics
            // 
            this.btnEnrollmentAnalytics.Location = new System.Drawing.Point(102, 206);
            this.btnEnrollmentAnalytics.Name = "btnEnrollmentAnalytics";
            this.btnEnrollmentAnalytics.Size = new System.Drawing.Size(174, 40);
            this.btnEnrollmentAnalytics.TabIndex = 11;
            this.btnEnrollmentAnalytics.Text = "Enrollment Analytics";
            this.btnEnrollmentAnalytics.UseVisualStyleBackColor = true;
            this.btnEnrollmentAnalytics.Click += new System.EventHandler(this.btnEnrollmentAnalytics_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.btnEnrollmentAnalytics);
            this.Controls.Add(this.btnCourseAnalytics);
            this.Controls.Add(this.pnlAnalytics);
            this.Controls.Add(this.chartAnalytics);
            this.Controls.Add(this.btnStudentAnalytics);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnEnrollmentReport);
            this.Controls.Add(this.btnCourseReport);
            this.Controls.Add(this.btnStudentReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalytics)).EndInit();
            this.pnlAnalytics.ResumeLayout(false);
            this.pnlAnalytics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentReport;
        private System.Windows.Forms.Button btnCourseReport;
        private System.Windows.Forms.Button btnEnrollmentReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStudentAnalytics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics;
        private System.Windows.Forms.Panel pnlAnalytics;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCourseAnalytics;
        private System.Windows.Forms.Button btnEnrollmentAnalytics;
    }
}
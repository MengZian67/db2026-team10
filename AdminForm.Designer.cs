namespace UniversityManagementSystem
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(33, 135);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(166, 130);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnInstructors
            // 
            this.btnInstructors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInstructors.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInstructors.Location = new System.Drawing.Point(219, 135);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(166, 130);
            this.btnInstructors.TabIndex = 2;
            this.btnInstructors.Text = "Instructors";
            this.btnInstructors.UseVisualStyleBackColor = false;
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDepartments.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.Location = new System.Drawing.Point(588, 135);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(199, 130);
            this.btnDepartments.TabIndex = 3;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(588, 296);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 69);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCourse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(33, 296);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(166, 130);
            this.btnCourse.TabIndex = 5;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnEnrollment
            // 
            this.btnEnrollment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnrollment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollment.Location = new System.Drawing.Point(402, 135);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(166, 130);
            this.btnEnrollment.TabIndex = 6;
            this.btnEnrollment.Text = "Enrollment";
            this.btnEnrollment.UseVisualStyleBackColor = false;
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(219, 296);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(166, 130);
            this.btnSchedule.TabIndex = 7;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(402, 296);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(166, 130);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnEnrollment);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDepartments);
            this.Controls.Add(this.btnInstructors);
            this.Controls.Add(this.btnStudents);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnReports;
    }
}
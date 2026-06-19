namespace UniversityManagementSystem
{
    partial class ScheduleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCourseID = new System.Windows.Forms.ComboBox();
            this.cmbSectionID = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbBuilding = new System.Windows.Forms.ComboBox();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Building";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Room Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Time Slot";
            // 
            // cmbCourseID
            // 
            this.cmbCourseID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseID.FormattingEnabled = true;
            this.cmbCourseID.Location = new System.Drawing.Point(205, 137);
            this.cmbCourseID.Name = "cmbCourseID";
            this.cmbCourseID.Size = new System.Drawing.Size(121, 28);
            this.cmbCourseID.TabIndex = 7;
            // 
            // cmbSectionID
            // 
            this.cmbSectionID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSectionID.FormattingEnabled = true;
            this.cmbSectionID.Location = new System.Drawing.Point(205, 186);
            this.cmbSectionID.Name = "cmbSectionID";
            this.cmbSectionID.Size = new System.Drawing.Size(121, 28);
            this.cmbSectionID.TabIndex = 8;
            // 
            // cmbSemester
            // 
            this.cmbSemester.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(205, 231);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 28);
            this.cmbSemester.TabIndex = 9;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(205, 270);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 28);
            this.cmbYear.TabIndex = 10;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuilding.FormattingEnabled = true;
            this.cmbBuilding.Location = new System.Drawing.Point(205, 318);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.Size = new System.Drawing.Size(121, 28);
            this.cmbBuilding.TabIndex = 11;
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(205, 357);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(121, 28);
            this.cmbRoomNumber.TabIndex = 12;
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Location = new System.Drawing.Point(205, 403);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(121, 28);
            this.cmbTimeSlot.TabIndex = 13;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(373, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(465, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(566, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(674, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(353, 136);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(422, 329);
            this.dgvSchedule.TabIndex = 18;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "SCHEDULING AND TIME SLOT";
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbTimeSlot);
            this.Controls.Add(this.cmbRoomNumber);
            this.Controls.Add(this.cmbBuilding);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbSectionID);
            this.Controls.Add(this.cmbCourseID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCourseID;
        private System.Windows.Forms.ComboBox cmbSectionID;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbBuilding;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label label8;
    }
}
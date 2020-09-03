namespace WindowsFormsApp2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeNbr = new System.Windows.Forms.TextBox();
            this.txtHourlySalary = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonday1 = new System.Windows.Forms.TextBox();
            this.txtTuesday1 = new System.Windows.Forms.TextBox();
            this.txtWednesday2 = new System.Windows.Forms.TextBox();
            this.txtWednesday1 = new System.Windows.Forms.TextBox();
            this.txtThursday1 = new System.Windows.Forms.TextBox();
            this.txtMonday2 = new System.Windows.Forms.TextBox();
            this.txtTuesday2 = new System.Windows.Forms.TextBox();
            this.txtFriday1 = new System.Windows.Forms.TextBox();
            this.txtFriday2 = new System.Windows.Forms.TextBox();
            this.txtThursday2 = new System.Windows.Forms.TextBox();
            this.txtSaturday1 = new System.Windows.Forms.TextBox();
            this.txtSaturday2 = new System.Windows.Forms.TextBox();
            this.txtSunday1 = new System.Windows.Forms.TextBox();
            this.txtSunday2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRegularHours = new System.Windows.Forms.TextBox();
            this.txtRegularAmount = new System.Windows.Forms.TextBox();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.txtOvertimeAmount = new System.Windows.Forms.TextBox();
            this.btnProcessIt = new System.Windows.Forms.Button();
            this.txtTotalEarnings = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHourlySalary);
            this.groupBox1.Controls.Add(this.txtEmployeeNbr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // txtEmployeeNbr
            // 
            this.txtEmployeeNbr.Location = new System.Drawing.Point(88, 37);
            this.txtEmployeeNbr.Name = "txtEmployeeNbr";
            this.txtEmployeeNbr.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNbr.TabIndex = 2;
            // 
            // txtHourlySalary
            // 
            this.txtHourlySalary.Location = new System.Drawing.Point(88, 76);
            this.txtHourlySalary.Name = "txtHourlySalary";
            this.txtHourlySalary.Size = new System.Drawing.Size(100, 20);
            this.txtHourlySalary.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Controls.Add(this.dtpStartingDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(369, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start/End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Time";
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(92, 37);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartingDate.TabIndex = 7;
            this.dtpStartingDate.CloseUp += new System.EventHandler(this.dtpStartingDate_CloseUp);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(92, 76);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtSunday2);
            this.groupBox3.Controls.Add(this.txtSunday1);
            this.groupBox3.Controls.Add(this.txtSaturday2);
            this.groupBox3.Controls.Add(this.txtSaturday1);
            this.groupBox3.Controls.Add(this.txtThursday2);
            this.groupBox3.Controls.Add(this.txtFriday2);
            this.groupBox3.Controls.Add(this.txtFriday1);
            this.groupBox3.Controls.Add(this.txtTuesday2);
            this.groupBox3.Controls.Add(this.txtMonday2);
            this.groupBox3.Controls.Add(this.txtThursday1);
            this.groupBox3.Controls.Add(this.txtWednesday1);
            this.groupBox3.Controls.Add(this.txtWednesday2);
            this.groupBox3.Controls.Add(this.txtTuesday1);
            this.groupBox3.Controls.Add(this.txtMonday1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(0, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 169);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TimeSheet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Week";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Week";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mon.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tues.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Wed.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Thurs.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Fri.";
            // 
            // txtMonday1
            // 
            this.txtMonday1.Location = new System.Drawing.Point(150, 59);
            this.txtMonday1.Name = "txtMonday1";
            this.txtMonday1.Size = new System.Drawing.Size(38, 20);
            this.txtMonday1.TabIndex = 7;
            // 
            // txtTuesday1
            // 
            this.txtTuesday1.Location = new System.Drawing.Point(213, 59);
            this.txtTuesday1.Name = "txtTuesday1";
            this.txtTuesday1.Size = new System.Drawing.Size(38, 20);
            this.txtTuesday1.TabIndex = 8;
            // 
            // txtWednesday2
            // 
            this.txtWednesday2.Location = new System.Drawing.Point(283, 101);
            this.txtWednesday2.Name = "txtWednesday2";
            this.txtWednesday2.Size = new System.Drawing.Size(38, 20);
            this.txtWednesday2.TabIndex = 9;
            // 
            // txtWednesday1
            // 
            this.txtWednesday1.Location = new System.Drawing.Point(283, 59);
            this.txtWednesday1.Name = "txtWednesday1";
            this.txtWednesday1.Size = new System.Drawing.Size(38, 20);
            this.txtWednesday1.TabIndex = 10;
            // 
            // txtThursday1
            // 
            this.txtThursday1.Location = new System.Drawing.Point(344, 59);
            this.txtThursday1.Name = "txtThursday1";
            this.txtThursday1.Size = new System.Drawing.Size(38, 20);
            this.txtThursday1.TabIndex = 11;
            // 
            // txtMonday2
            // 
            this.txtMonday2.Location = new System.Drawing.Point(150, 101);
            this.txtMonday2.Name = "txtMonday2";
            this.txtMonday2.Size = new System.Drawing.Size(38, 20);
            this.txtMonday2.TabIndex = 12;
            // 
            // txtTuesday2
            // 
            this.txtTuesday2.Location = new System.Drawing.Point(213, 101);
            this.txtTuesday2.Name = "txtTuesday2";
            this.txtTuesday2.Size = new System.Drawing.Size(38, 20);
            this.txtTuesday2.TabIndex = 13;
            // 
            // txtFriday1
            // 
            this.txtFriday1.Location = new System.Drawing.Point(415, 59);
            this.txtFriday1.Name = "txtFriday1";
            this.txtFriday1.Size = new System.Drawing.Size(38, 20);
            this.txtFriday1.TabIndex = 14;
            // 
            // txtFriday2
            // 
            this.txtFriday2.Location = new System.Drawing.Point(415, 101);
            this.txtFriday2.Name = "txtFriday2";
            this.txtFriday2.Size = new System.Drawing.Size(38, 20);
            this.txtFriday2.TabIndex = 15;
            // 
            // txtThursday2
            // 
            this.txtThursday2.Location = new System.Drawing.Point(344, 101);
            this.txtThursday2.Name = "txtThursday2";
            this.txtThursday2.Size = new System.Drawing.Size(38, 20);
            this.txtThursday2.TabIndex = 16;
            // 
            // txtSaturday1
            // 
            this.txtSaturday1.Location = new System.Drawing.Point(488, 59);
            this.txtSaturday1.Name = "txtSaturday1";
            this.txtSaturday1.Size = new System.Drawing.Size(38, 20);
            this.txtSaturday1.TabIndex = 17;
            // 
            // txtSaturday2
            // 
            this.txtSaturday2.Location = new System.Drawing.Point(488, 101);
            this.txtSaturday2.Name = "txtSaturday2";
            this.txtSaturday2.Size = new System.Drawing.Size(38, 20);
            this.txtSaturday2.TabIndex = 18;
            // 
            // txtSunday1
            // 
            this.txtSunday1.Location = new System.Drawing.Point(555, 59);
            this.txtSunday1.Name = "txtSunday1";
            this.txtSunday1.Size = new System.Drawing.Size(38, 20);
            this.txtSunday1.TabIndex = 19;
            // 
            // txtSunday2
            // 
            this.txtSunday2.Location = new System.Drawing.Point(555, 101);
            this.txtSunday2.Name = "txtSunday2";
            this.txtSunday2.Size = new System.Drawing.Size(38, 20);
            this.txtSunday2.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sat.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(552, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Sun.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(275, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Amount:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtTotalEarnings);
            this.groupBox4.Controls.Add(this.btnProcessIt);
            this.groupBox4.Controls.Add(this.txtOvertimeAmount);
            this.groupBox4.Controls.Add(this.txtOvertimeHours);
            this.groupBox4.Controls.Add(this.txtRegularAmount);
            this.groupBox4.Controls.Add(this.txtRegularHours);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(0, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(690, 185);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payroll Processing";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(147, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Regular:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Hours:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(147, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "OT";
            // 
            // txtRegularHours
            // 
            this.txtRegularHours.Location = new System.Drawing.Point(208, 89);
            this.txtRegularHours.Name = "txtRegularHours";
            this.txtRegularHours.Size = new System.Drawing.Size(38, 20);
            this.txtRegularHours.TabIndex = 26;
            // 
            // txtRegularAmount
            // 
            this.txtRegularAmount.Location = new System.Drawing.Point(278, 89);
            this.txtRegularAmount.Name = "txtRegularAmount";
            this.txtRegularAmount.Size = new System.Drawing.Size(54, 20);
            this.txtRegularAmount.TabIndex = 27;
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Location = new System.Drawing.Point(208, 126);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(38, 20);
            this.txtOvertimeHours.TabIndex = 28;
            // 
            // txtOvertimeAmount
            // 
            this.txtOvertimeAmount.Location = new System.Drawing.Point(278, 126);
            this.txtOvertimeAmount.Name = "txtOvertimeAmount";
            this.txtOvertimeAmount.Size = new System.Drawing.Size(54, 20);
            this.txtOvertimeAmount.TabIndex = 29;
            // 
            // btnProcessIt
            // 
            this.btnProcessIt.Location = new System.Drawing.Point(6, 118);
            this.btnProcessIt.Name = "btnProcessIt";
            this.btnProcessIt.Size = new System.Drawing.Size(110, 57);
            this.btnProcessIt.TabIndex = 30;
            this.btnProcessIt.Text = "Process it!";
            this.btnProcessIt.UseVisualStyleBackColor = true;
            this.btnProcessIt.Click += new System.EventHandler(this.btnProcessIt_Click);
            // 
            // txtTotalEarnings
            // 
            this.txtTotalEarnings.Location = new System.Drawing.Point(507, 89);
            this.txtTotalEarnings.Name = "txtTotalEarnings";
            this.txtTotalEarnings.Size = new System.Drawing.Size(135, 20);
            this.txtTotalEarnings.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(424, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Total Earnings:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 57);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 558);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHourlySalary;
        private System.Windows.Forms.TextBox txtEmployeeNbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSunday2;
        private System.Windows.Forms.TextBox txtSunday1;
        private System.Windows.Forms.TextBox txtSaturday2;
        private System.Windows.Forms.TextBox txtSaturday1;
        private System.Windows.Forms.TextBox txtThursday2;
        private System.Windows.Forms.TextBox txtFriday2;
        private System.Windows.Forms.TextBox txtFriday1;
        private System.Windows.Forms.TextBox txtTuesday2;
        private System.Windows.Forms.TextBox txtMonday2;
        private System.Windows.Forms.TextBox txtThursday1;
        private System.Windows.Forms.TextBox txtWednesday1;
        private System.Windows.Forms.TextBox txtWednesday2;
        private System.Windows.Forms.TextBox txtTuesday1;
        private System.Windows.Forms.TextBox txtMonday1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalEarnings;
        private System.Windows.Forms.Button btnProcessIt;
        private System.Windows.Forms.TextBox txtOvertimeAmount;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.TextBox txtRegularAmount;
        private System.Windows.Forms.TextBox txtRegularHours;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}


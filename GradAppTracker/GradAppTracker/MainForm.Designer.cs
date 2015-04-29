namespace GradAppTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pending = new System.Windows.Forms.TabPage();
            this.dgvCurrent = new System.Windows.Forms.DataGridView();
            this.Completed = new System.Windows.Forms.TabPage();
            this.dgvPast = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateExistingLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateNewLogin = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewDegreeEvaluationBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchByAdvisorName = new System.Windows.Forms.TextBox();
            this.addTrackingRecordbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbFilterBySemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYearFilter = new System.Windows.Forms.TextBox();
            this.btnCreateGradApp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchByStudentIdNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Pending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).BeginInit();
            this.Completed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPast)).BeginInit();
            this.Admin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pending);
            this.tabControl1.Controls.Add(this.Completed);
            this.tabControl1.Controls.Add(this.Admin);
            this.tabControl1.Location = new System.Drawing.Point(181, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 596);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // Pending
            // 
            this.Pending.Controls.Add(this.dgvCurrent);
            this.Pending.Location = new System.Drawing.Point(4, 22);
            this.Pending.Name = "Pending";
            this.Pending.Padding = new System.Windows.Forms.Padding(3);
            this.Pending.Size = new System.Drawing.Size(1022, 570);
            this.Pending.TabIndex = 0;
            this.Pending.Text = "Current Applications";
            this.Pending.UseVisualStyleBackColor = true;
            // 
            // dgvCurrent
            // 
            this.dgvCurrent.AllowUserToAddRows = false;
            this.dgvCurrent.AllowUserToDeleteRows = false;
            this.dgvCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrent.Location = new System.Drawing.Point(3, 3);
            this.dgvCurrent.Name = "dgvCurrent";
            this.dgvCurrent.ReadOnly = true;
            this.dgvCurrent.Size = new System.Drawing.Size(1016, 564);
            this.dgvCurrent.TabIndex = 0;
            // 
            // Completed
            // 
            this.Completed.Controls.Add(this.dgvPast);
            this.Completed.Location = new System.Drawing.Point(4, 22);
            this.Completed.Name = "Completed";
            this.Completed.Padding = new System.Windows.Forms.Padding(3);
            this.Completed.Size = new System.Drawing.Size(1022, 570);
            this.Completed.TabIndex = 1;
            this.Completed.Text = "Past Applications";
            this.Completed.UseVisualStyleBackColor = true;
            // 
            // dgvPast
            // 
            this.dgvPast.AllowUserToAddRows = false;
            this.dgvPast.AllowUserToDeleteRows = false;
            this.dgvPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPast.Location = new System.Drawing.Point(3, 3);
            this.dgvPast.Name = "dgvPast";
            this.dgvPast.ReadOnly = true;
            this.dgvPast.Size = new System.Drawing.Size(1016, 564);
            this.dgvPast.TabIndex = 0;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.flowLayoutPanel1);
            this.Admin.Controls.Add(this.panel2);
            this.Admin.Location = new System.Drawing.Point(4, 22);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(1022, 570);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Advisor Tools";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.dgvUsers);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(659, 266);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateExistingLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCreateNewLogin);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdateExistingLogin
            // 
            this.btnUpdateExistingLogin.Location = new System.Drawing.Point(3, 72);
            this.btnUpdateExistingLogin.Name = "btnUpdateExistingLogin";
            this.btnUpdateExistingLogin.Size = new System.Drawing.Size(177, 23);
            this.btnUpdateExistingLogin.TabIndex = 2;
            this.btnUpdateExistingLogin.Text = "Update Existing Login";
            this.btnUpdateExistingLogin.UseVisualStyleBackColor = true;
            this.btnUpdateExistingLogin.Click += new System.EventHandler(this.btnUpdateExistingLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Tools:";
            // 
            // btnCreateNewLogin
            // 
            this.btnCreateNewLogin.Location = new System.Drawing.Point(3, 43);
            this.btnCreateNewLogin.Name = "btnCreateNewLogin";
            this.btnCreateNewLogin.Size = new System.Drawing.Size(177, 23);
            this.btnCreateNewLogin.TabIndex = 0;
            this.btnCreateNewLogin.Text = "Create New Login";
            this.btnCreateNewLogin.UseVisualStyleBackColor = true;
            this.btnCreateNewLogin.Click += new System.EventHandler(this.btnCreateNewLogin_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(192, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsers.Size = new System.Drawing.Size(449, 250);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(6, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 100);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "??";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "More Tools:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "??";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewDegreeEvaluationBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSearchByAdvisorName);
            this.groupBox1.Controls.Add(this.addTrackingRecordbtn);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cbFilterBySemester);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbYearFilter);
            this.groupBox1.Controls.Add(this.btnCreateGradApp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSearchByStudentIdNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSearchByName);
            this.groupBox1.Controls.Add(this.tbSearchByName);
            this.groupBox1.Location = new System.Drawing.Point(5, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 523);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // viewDegreeEvaluationBtn
            // 
            this.viewDegreeEvaluationBtn.Location = new System.Drawing.Point(6, 285);
            this.viewDegreeEvaluationBtn.Name = "viewDegreeEvaluationBtn";
            this.viewDegreeEvaluationBtn.Size = new System.Drawing.Size(156, 53);
            this.viewDegreeEvaluationBtn.TabIndex = 24;
            this.viewDegreeEvaluationBtn.Text = "View Degree Evaluation";
            this.viewDegreeEvaluationBtn.UseVisualStyleBackColor = true;
            this.viewDegreeEvaluationBtn.Click += new System.EventHandler(this.viewDegreeEvaluationBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Search by Advisor Name:";
            // 
            // tbSearchByAdvisorName
            // 
            this.tbSearchByAdvisorName.Location = new System.Drawing.Point(6, 126);
            this.tbSearchByAdvisorName.Name = "tbSearchByAdvisorName";
            this.tbSearchByAdvisorName.Size = new System.Drawing.Size(156, 20);
            this.tbSearchByAdvisorName.TabIndex = 21;
            this.tbSearchByAdvisorName.TextChanged += new System.EventHandler(this.tbSearchByAdvisorName_TextChanged);
            // 
            // addTrackingRecordbtn
            // 
            this.addTrackingRecordbtn.Location = new System.Drawing.Point(6, 344);
            this.addTrackingRecordbtn.Name = "addTrackingRecordbtn";
            this.addTrackingRecordbtn.Size = new System.Drawing.Size(156, 53);
            this.addTrackingRecordbtn.TabIndex = 1;
            this.addTrackingRecordbtn.Text = "Add Tracking Record";
            this.addTrackingRecordbtn.UseVisualStyleBackColor = true;
            this.addTrackingRecordbtn.Click += new System.EventHandler(this.addTrackingRecordbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 53);
            this.button3.TabIndex = 20;
            this.button3.Text = "Update Approval Status";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbFilterBySemester
            // 
            this.cbFilterBySemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBySemester.FormattingEnabled = true;
            this.cbFilterBySemester.Items.AddRange(new object[] {
            "All",
            "Fall",
            "Spring",
            "Summer"});
            this.cbFilterBySemester.Location = new System.Drawing.Point(6, 173);
            this.cbFilterBySemester.Name = "cbFilterBySemester";
            this.cbFilterBySemester.Size = new System.Drawing.Size(157, 21);
            this.cbFilterBySemester.TabIndex = 18;
            this.cbFilterBySemester.SelectedIndexChanged += new System.EventHandler(this.cbFilterBySemester_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter By Grad Year:";
            // 
            // tbYearFilter
            // 
            this.tbYearFilter.Location = new System.Drawing.Point(7, 222);
            this.tbYearFilter.Name = "tbYearFilter";
            this.tbYearFilter.Size = new System.Drawing.Size(156, 20);
            this.tbYearFilter.TabIndex = 14;
            this.tbYearFilter.TextChanged += new System.EventHandler(this.tbYearFilter_TextChanged);
            // 
            // btnCreateGradApp
            // 
            this.btnCreateGradApp.Location = new System.Drawing.Point(6, 463);
            this.btnCreateGradApp.Name = "btnCreateGradApp";
            this.btnCreateGradApp.Size = new System.Drawing.Size(156, 53);
            this.btnCreateGradApp.TabIndex = 13;
            this.btnCreateGradApp.Text = "Create New Graduation Application";
            this.btnCreateGradApp.UseVisualStyleBackColor = true;
            this.btnCreateGradApp.Click += new System.EventHandler(this.btnCreateGradApp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search By Student ID Number:";
            // 
            // tbSearchByStudentIdNumber
            // 
            this.tbSearchByStudentIdNumber.Location = new System.Drawing.Point(7, 80);
            this.tbSearchByStudentIdNumber.Name = "tbSearchByStudentIdNumber";
            this.tbSearchByStudentIdNumber.Size = new System.Drawing.Size(156, 20);
            this.tbSearchByStudentIdNumber.TabIndex = 11;
            this.tbSearchByStudentIdNumber.TextChanged += new System.EventHandler(this.tbSearchByStudentIdNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter By Semester:";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(6, 15);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(129, 13);
            this.lblSearchByName.TabIndex = 3;
            this.lblSearchByName.Text = "Search by Student Name:";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.Location = new System.Drawing.Point(6, 32);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.Size = new System.Drawing.Size(156, 20);
            this.tbSearchByName.TabIndex = 2;
            this.tbSearchByName.TextChanged += new System.EventHandler(this.tbSearchByName_TextChanged);
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoBox.InitialImage")));
            this.logoBox.Location = new System.Drawing.Point(5, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(177, 67);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 613);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1364, 659);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAFS Graduation Application Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Pending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).EndInit();
            this.Completed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPast)).EndInit();
            this.Admin.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pending;
        private System.Windows.Forms.TabPage Completed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.DataGridView dgvCurrent;
        private System.Windows.Forms.DataGridView dgvPast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearchByStudentIdNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateNewLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateExistingLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnCreateGradApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYearFilter;
        private System.Windows.Forms.ComboBox cbFilterBySemester;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addTrackingRecordbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearchByAdvisorName;
        private System.Windows.Forms.Button viewDegreeEvaluationBtn;
    }
}


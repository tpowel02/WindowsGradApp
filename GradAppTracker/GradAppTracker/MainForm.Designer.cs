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
            this.Current = new System.Windows.Forms.TabPage();
            this.dgvCurrent = new System.Windows.Forms.DataGridView();
            this.Past = new System.Windows.Forms.TabPage();
            this.dgvPast = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbFilterBySemester = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchByStudentIdNumber = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Current.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).BeginInit();
            this.Past.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPast)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Current);
            this.tabControl1.Controls.Add(this.Past);
            this.tabControl1.Controls.Add(this.Admin);
            this.tabControl1.Location = new System.Drawing.Point(179, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 596);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // Current
            // 
            this.Current.Controls.Add(this.dgvCurrent);
            this.Current.Location = new System.Drawing.Point(4, 22);
            this.Current.Name = "Current";
            this.Current.Padding = new System.Windows.Forms.Padding(3);
            this.Current.Size = new System.Drawing.Size(1173, 570);
            this.Current.TabIndex = 0;
            this.Current.Text = "Current Applications";
            this.Current.UseVisualStyleBackColor = true;
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
            this.dgvCurrent.Size = new System.Drawing.Size(1167, 564);
            this.dgvCurrent.TabIndex = 0;
            // 
            // Past
            // 
            this.Past.Controls.Add(this.dgvPast);
            this.Past.Location = new System.Drawing.Point(4, 22);
            this.Past.Name = "Past";
            this.Past.Padding = new System.Windows.Forms.Padding(3);
            this.Past.Size = new System.Drawing.Size(1173, 570);
            this.Past.TabIndex = 1;
            this.Past.Text = "Past Applications";
            this.Past.UseVisualStyleBackColor = true;
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
            this.dgvPast.Size = new System.Drawing.Size(1167, 564);
            this.dgvPast.TabIndex = 0;
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(4, 22);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(1173, 570);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Administration";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSearchByStudentIdNumber);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clbFilterBySemester);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSearchByName);
            this.groupBox1.Controls.Add(this.tbSearchByName);
            this.groupBox1.Location = new System.Drawing.Point(5, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 523);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // clbFilterBySemester
            // 
            this.clbFilterBySemester.FormattingEnabled = true;
            this.clbFilterBySemester.Items.AddRange(new object[] {
            "Fall Graduation",
            "Spring Graduation",
            "Summer Graduation"});
            this.clbFilterBySemester.Location = new System.Drawing.Point(6, 127);
            this.clbFilterBySemester.Name = "clbFilterBySemester";
            this.clbFilterBySemester.Size = new System.Drawing.Size(156, 49);
            this.clbFilterBySemester.TabIndex = 9;
            this.clbFilterBySemester.SelectedIndexChanged += new System.EventHandler(this.clbFilterBySemester_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter By Semester:";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Location = new System.Drawing.Point(6, 16);
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
            this.logoBox.Size = new System.Drawing.Size(172, 67);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By Status:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 208);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(156, 34);
            this.checkedListBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 620);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAFS Graduation Application Tracker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Current.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrent)).EndInit();
            this.Past.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Current;
        private System.Windows.Forms.TabPage Past;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox tbSearchByName;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.DataGridView dgvCurrent;
        private System.Windows.Forms.DataGridView dgvPast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbFilterBySemester;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearchByStudentIdNumber;
    }
}


namespace GradAppTracker
{
    partial class AddTrackingRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrackingRecordForm));
            this.button1 = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGradSem = new System.Windows.Forms.ComboBox();
            this.tbGradYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdvisorName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDeptChair = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(14, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(91, 188);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(111, 33);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Graduation \r\nSemester:";
            // 
            // tbGradSem
            // 
            this.tbGradSem.FormattingEnabled = true;
            this.tbGradSem.Items.AddRange(new object[] {
            "Fall",
            "Spring",
            "Summer"});
            this.tbGradSem.Location = new System.Drawing.Point(90, 125);
            this.tbGradSem.Name = "tbGradSem";
            this.tbGradSem.Size = new System.Drawing.Size(111, 21);
            this.tbGradSem.TabIndex = 4;
            // 
            // tbGradYear
            // 
            this.tbGradYear.Location = new System.Drawing.Point(90, 162);
            this.tbGradYear.Name = "tbGradYear";
            this.tbGradYear.Size = new System.Drawing.Size(112, 20);
            this.tbGradYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Graduation \r\nYear:";
            // 
            // tbAdvisorName
            // 
            this.tbAdvisorName.FormattingEnabled = true;
            this.tbAdvisorName.Location = new System.Drawing.Point(90, 45);
            this.tbAdvisorName.Name = "tbAdvisorName";
            this.tbAdvisorName.Size = new System.Drawing.Size(111, 21);
            this.tbAdvisorName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Advisor Name:";
            // 
            // tbDeptChair
            // 
            this.tbDeptChair.FormattingEnabled = true;
            this.tbDeptChair.Location = new System.Drawing.Point(90, 83);
            this.tbDeptChair.Name = "tbDeptChair";
            this.tbDeptChair.Size = new System.Drawing.Size(111, 21);
            this.tbDeptChair.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dept. Chair\r\nName:";
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(90, 12);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(112, 20);
            this.tbStudentID.TabIndex = 1;
            // 
            // AddTrackingRecordForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(211, 294);
            this.ControlBox = false;
            this.Controls.Add(this.tbStudentID);
            this.Controls.Add(this.tbDeptChair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAdvisorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGradYear);
            this.Controls.Add(this.tbGradSem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTrackingRecordForm";
            this.Text = "Add Tracking Record";
            this.Load += new System.EventHandler(this.AddTrackingRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbGradSem;
        private System.Windows.Forms.TextBox tbGradYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tbAdvisorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tbDeptChair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStudentID;
    }
}
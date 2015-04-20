namespace GradAppTracker
{
    partial class DGVUpdateStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGVUpdateStatusForm));
            this.dgvUpdateStatus = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.AdvisorApproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DeptChairApproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DeanApproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RecordsApproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateStatus
            // 
            this.dgvUpdateStatus.AllowUserToAddRows = false;
            this.dgvUpdateStatus.AllowUserToDeleteRows = false;
            this.dgvUpdateStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpdateStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUpdateStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdvisorApproval,
            this.DeptChairApproval,
            this.DeanApproval,
            this.RecordsApproval});
            this.dgvUpdateStatus.Location = new System.Drawing.Point(12, 33);
            this.dgvUpdateStatus.Name = "dgvUpdateStatus";
            this.dgvUpdateStatus.RowHeadersVisible = false;
            this.dgvUpdateStatus.Size = new System.Drawing.Size(491, 71);
            this.dgvUpdateStatus.TabIndex = 0;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(154, 110);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(283, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Graduation Application For:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(275, 9);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(72, 13);
            this.studentLabel.TabIndex = 4;
            this.studentLabel.Text = "StudentName";
            // 
            // AdvisorApproval
            // 
            this.AdvisorApproval.HeaderText = "Advisor Approval";
            this.AdvisorApproval.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.AdvisorApproval.Name = "AdvisorApproval";
            this.AdvisorApproval.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AdvisorApproval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeptChairApproval
            // 
            this.DeptChairApproval.HeaderText = "Dept. Chair Approval";
            this.DeptChairApproval.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.DeptChairApproval.Name = "DeptChairApproval";
            // 
            // DeanApproval
            // 
            this.DeanApproval.HeaderText = "Dean Approval";
            this.DeanApproval.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.DeanApproval.Name = "DeanApproval";
            // 
            // RecordsApproval
            // 
            this.RecordsApproval.HeaderText = "Records Approval";
            this.RecordsApproval.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.RecordsApproval.Name = "RecordsApproval";
            // 
            // DGVUpdateStatusForm
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(513, 139);
            this.ControlBox = false;
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dgvUpdateStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DGVUpdateStatusForm";
            this.Text = "Update Degree Status";
            this.Load += new System.EventHandler(this.DGVUpdateStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateStatus;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn AdvisorApproval;
        private System.Windows.Forms.DataGridViewComboBoxColumn DeptChairApproval;
        private System.Windows.Forms.DataGridViewComboBoxColumn DeanApproval;
        private System.Windows.Forms.DataGridViewComboBoxColumn RecordsApproval;
    }
}
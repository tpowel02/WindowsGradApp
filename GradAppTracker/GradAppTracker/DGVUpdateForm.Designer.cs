namespace GradAppTracker
{
    partial class DGVUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DGVUpdateForm));
            this.updateUserDgv = new System.Windows.Forms.DataGridView();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateUserDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // updateUserDgv
            // 
            this.updateUserDgv.AllowUserToAddRows = false;
            this.updateUserDgv.AllowUserToDeleteRows = false;
            this.updateUserDgv.AllowUserToResizeColumns = false;
            this.updateUserDgv.AllowUserToResizeRows = false;
            this.updateUserDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updateUserDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateUserDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIRST_NAME,
            this.LAST_NAME,
            this.EMAIL});
            this.updateUserDgv.Location = new System.Drawing.Point(12, 12);
            this.updateUserDgv.Name = "updateUserDgv";
            this.updateUserDgv.RowHeadersVisible = false;
            this.updateUserDgv.Size = new System.Drawing.Size(462, 51);
            this.updateUserDgv.TabIndex = 0;
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.HeaderText = "First Name";
            this.FIRST_NAME.Name = "FIRST_NAME";
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.HeaderText = "Last Name";
            this.LAST_NAME.Name = "LAST_NAME";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DGVUpdateForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(486, 95);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updateUserDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DGVUpdateForm";
            this.Text = "Update User Information";
            this.Load += new System.EventHandler(this.DGVUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateUserDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView updateUserDgv;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}
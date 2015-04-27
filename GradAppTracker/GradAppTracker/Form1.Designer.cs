namespace GradAppTracker
{
    partial class ViewDegreeEvaluation
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
            this.lblEvalStudentID = new System.Windows.Forms.Label();
            this.tbEvalStudentID = new System.Windows.Forms.TextBox();
            this.btnEvalCancel = new System.Windows.Forms.Button();
            this.btnEvalSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEvalStudentID
            // 
            this.lblEvalStudentID.AutoSize = true;
            this.lblEvalStudentID.Location = new System.Drawing.Point(13, 13);
            this.lblEvalStudentID.Name = "lblEvalStudentID";
            this.lblEvalStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblEvalStudentID.TabIndex = 0;
            this.lblEvalStudentID.Text = "Student ID:";
            // 
            // tbEvalStudentID
            // 
            this.tbEvalStudentID.Location = new System.Drawing.Point(80, 10);
            this.tbEvalStudentID.Name = "tbEvalStudentID";
            this.tbEvalStudentID.Size = new System.Drawing.Size(100, 20);
            this.tbEvalStudentID.TabIndex = 1;
            // 
            // btnEvalCancel
            // 
            this.btnEvalCancel.Location = new System.Drawing.Point(16, 62);
            this.btnEvalCancel.Name = "btnEvalCancel";
            this.btnEvalCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEvalCancel.TabIndex = 2;
            this.btnEvalCancel.Text = "Cancel";
            this.btnEvalCancel.UseVisualStyleBackColor = true;
            this.btnEvalCancel.Click += new System.EventHandler(this.btnEvalCancel_Click);
            // 
            // btnEvalSubmit
            // 
            this.btnEvalSubmit.Location = new System.Drawing.Point(97, 62);
            this.btnEvalSubmit.Name = "btnEvalSubmit";
            this.btnEvalSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnEvalSubmit.TabIndex = 3;
            this.btnEvalSubmit.Text = "Submit";
            this.btnEvalSubmit.UseVisualStyleBackColor = true;
            this.btnEvalSubmit.Click += new System.EventHandler(this.btnEvalSubmit_Click);
            // 
            // ViewDegreeEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 95);
            this.Controls.Add(this.btnEvalSubmit);
            this.Controls.Add(this.btnEvalCancel);
            this.Controls.Add(this.tbEvalStudentID);
            this.Controls.Add(this.lblEvalStudentID);
            this.Name = "ViewDegreeEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Degree Evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvalStudentID;
        private System.Windows.Forms.TextBox tbEvalStudentID;
        private System.Windows.Forms.Button btnEvalCancel;
        private System.Windows.Forms.Button btnEvalSubmit;
    }
}
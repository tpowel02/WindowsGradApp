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
            this.btnEvalSubmit = new System.Windows.Forms.Button();
            this.btnEvalCancel = new System.Windows.Forms.Button();
            this.tbEvalStudentID = new System.Windows.Forms.TextBox();
            this.lblEvalStudentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEvalSubmit
            // 
            this.btnEvalSubmit.Location = new System.Drawing.Point(141, 81);
            this.btnEvalSubmit.Name = "btnEvalSubmit";
            this.btnEvalSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnEvalSubmit.TabIndex = 7;
            this.btnEvalSubmit.Text = "Submit";
            this.btnEvalSubmit.UseVisualStyleBackColor = true;
            this.btnEvalSubmit.Click += new System.EventHandler(this.btnEvalSubmit_Click);
            // 
            // btnEvalCancel
            // 
            this.btnEvalCancel.Location = new System.Drawing.Point(60, 81);
            this.btnEvalCancel.Name = "btnEvalCancel";
            this.btnEvalCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEvalCancel.TabIndex = 6;
            this.btnEvalCancel.Text = "Cancel";
            this.btnEvalCancel.UseVisualStyleBackColor = true;
            this.btnEvalCancel.Click += new System.EventHandler(this.btnEvalCancel_Click);
            // 
            // tbEvalStudentID
            // 
            this.tbEvalStudentID.Location = new System.Drawing.Point(124, 29);
            this.tbEvalStudentID.Name = "tbEvalStudentID";
            this.tbEvalStudentID.Size = new System.Drawing.Size(100, 20);
            this.tbEvalStudentID.TabIndex = 5;
            // 
            // lblEvalStudentID
            // 
            this.lblEvalStudentID.AutoSize = true;
            this.lblEvalStudentID.Location = new System.Drawing.Point(57, 32);
            this.lblEvalStudentID.Name = "lblEvalStudentID";
            this.lblEvalStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblEvalStudentID.TabIndex = 4;
            this.lblEvalStudentID.Text = "Student ID:";
            // 
            // ViewDegreeEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
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

        private System.Windows.Forms.Button btnEvalSubmit;
        private System.Windows.Forms.Button btnEvalCancel;
        private System.Windows.Forms.TextBox tbEvalStudentID;
        private System.Windows.Forms.Label lblEvalStudentID;
    }
}
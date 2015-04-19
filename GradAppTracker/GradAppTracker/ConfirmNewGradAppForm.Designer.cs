namespace GradAppTracker
{
    partial class ConfirmNewGradAppForm
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
            this.ConfirmNewGradAppButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM CURRENTLY NOT IN USE";
            // 
            // ConfirmNewGradAppButton
            // 
            this.ConfirmNewGradAppButton.Location = new System.Drawing.Point(121, 217);
            this.ConfirmNewGradAppButton.Name = "ConfirmNewGradAppButton";
            this.ConfirmNewGradAppButton.Size = new System.Drawing.Size(126, 33);
            this.ConfirmNewGradAppButton.TabIndex = 11;
            this.ConfirmNewGradAppButton.Text = "Confirm";
            this.ConfirmNewGradAppButton.UseVisualStyleBackColor = true;
            this.ConfirmNewGradAppButton.Click += new System.EventHandler(this.ConfirmNewGradAppButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(58, 217);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(58, 33);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(58, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 2);
            this.label4.TabIndex = 10;
            // 
            // ConfirmNewGradAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ConfirmNewGradAppButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmNewGradAppForm";
            this.Text = "ConfirmNewGradAppForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmNewGradAppButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
    }
}

namespace Kursova
{
    partial class AddSubjectForm
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
            this.SubjectTitle = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectTitle
            // 
            this.SubjectTitle.Location = new System.Drawing.Point(117, 46);
            this.SubjectTitle.Name = "SubjectTitle";
            this.SubjectTitle.Size = new System.Drawing.Size(194, 27);
            this.SubjectTitle.TabIndex = 4;
            this.SubjectTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(8, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 27);
            this.label.TabIndex = 3;
            this.label.Text = "Назва:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkButton.Location = new System.Drawing.Point(179, 103);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(132, 54);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(8, 103);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 54);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 169);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubjectTitle);
            this.Controls.Add(this.label);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSubjectForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SubjectTitle;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
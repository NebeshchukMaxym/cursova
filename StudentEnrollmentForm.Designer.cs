
namespace Kursova
{
    partial class StudentEnrollmentForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.StudentYear)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(12, 340);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 54);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkButton.Location = new System.Drawing.Point(183, 340);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(132, 54);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прізвище";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentSurname
            // 
            this.StudentSurname.Location = new System.Drawing.Point(121, 45);
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.Size = new System.Drawing.Size(194, 27);
            this.StudentSurname.TabIndex = 2;
            this.StudentSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(121, 91);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(194, 27);
            this.StudentName.TabIndex = 2;
            this.StudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Курс";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentYear
            // 
            this.StudentYear.Location = new System.Drawing.Point(121, 141);
            this.StudentYear.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.StudentYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StudentYear.Name = "StudentYear";
            this.StudentYear.Size = new System.Drawing.Size(194, 27);
            this.StudentYear.TabIndex = 3;
            this.StudentYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StudentYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StudentEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 406);
            this.Controls.Add(this.StudentYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "StudentEnrollmentForm";
            this.Text = "StudentEnrollmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentEnrollmentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StudentYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StudentYear;
    }
}
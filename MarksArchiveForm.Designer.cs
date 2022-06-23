
namespace Kursova
{
    partial class MarksArchiveForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.SubjectsList = new System.Windows.Forms.ListBox();
            this.EnrollStudentButton = new System.Windows.Forms.Button();
            this.ExpelStudentButton = new System.Windows.Forms.Button();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.RemoveSubjectButton = new System.Windows.Forms.Button();
            this.AddMarkButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.StudentMarksList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveMarkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "СПИСОК СТУДЕНТІВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "СПИСОК ДИСЦИПЛІН";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentsList
            // 
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.ItemHeight = 20;
            this.StudentsList.Location = new System.Drawing.Point(13, 54);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(301, 404);
            this.StudentsList.TabIndex = 2;
            this.StudentsList.SelectedIndexChanged += new System.EventHandler(this.StudentsList_SelectedIndexChanged);
            // 
            // SubjectsList
            // 
            this.SubjectsList.FormattingEnabled = true;
            this.SubjectsList.ItemHeight = 20;
            this.SubjectsList.Location = new System.Drawing.Point(330, 53);
            this.SubjectsList.Name = "SubjectsList";
            this.SubjectsList.Size = new System.Drawing.Size(337, 404);
            this.SubjectsList.TabIndex = 2;
            this.SubjectsList.SelectedIndexChanged += new System.EventHandler(this.SubjectsList_SelectedIndexChanged);
            // 
            // EnrollStudentButton
            // 
            this.EnrollStudentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnrollStudentButton.Location = new System.Drawing.Point(13, 522);
            this.EnrollStudentButton.Name = "EnrollStudentButton";
            this.EnrollStudentButton.Size = new System.Drawing.Size(301, 29);
            this.EnrollStudentButton.TabIndex = 6;
            this.EnrollStudentButton.Text = "ЗАРАХУВАТИ СТУДЕНТА";
            this.EnrollStudentButton.UseVisualStyleBackColor = true;
            this.EnrollStudentButton.Click += new System.EventHandler(this.EnrollStudentButton_Click);
            // 
            // ExpelStudentButton
            // 
            this.ExpelStudentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExpelStudentButton.Location = new System.Drawing.Point(13, 478);
            this.ExpelStudentButton.Name = "ExpelStudentButton";
            this.ExpelStudentButton.Size = new System.Drawing.Size(301, 29);
            this.ExpelStudentButton.TabIndex = 6;
            this.ExpelStudentButton.Text = "ВИКЛЮЧИТИ СТУДЕНТА";
            this.ExpelStudentButton.UseVisualStyleBackColor = true;
            this.ExpelStudentButton.Click += new System.EventHandler(this.ExpelStudentButton_Click);
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSubjectButton.Location = new System.Drawing.Point(330, 522);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(337, 29);
            this.AddSubjectButton.TabIndex = 6;
            this.AddSubjectButton.Text = "ДОДАТИ ДИСЦИПЛІНУ";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // RemoveSubjectButton
            // 
            this.RemoveSubjectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveSubjectButton.Location = new System.Drawing.Point(330, 478);
            this.RemoveSubjectButton.Name = "RemoveSubjectButton";
            this.RemoveSubjectButton.Size = new System.Drawing.Size(337, 29);
            this.RemoveSubjectButton.TabIndex = 6;
            this.RemoveSubjectButton.Text = "ЗАБРАТИ ДИСЦИПЛІНУ";
            this.RemoveSubjectButton.UseVisualStyleBackColor = true;
            this.RemoveSubjectButton.Click += new System.EventHandler(this.RemoveSubjectButton_Click);
            // 
            // AddMarkButton
            // 
            this.AddMarkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMarkButton.Location = new System.Drawing.Point(1070, 522);
            this.AddMarkButton.Name = "AddMarkButton";
            this.AddMarkButton.Size = new System.Drawing.Size(428, 44);
            this.AddMarkButton.TabIndex = 6;
            this.AddMarkButton.Text = "ДОДАТИ ОЦІНКУ";
            this.AddMarkButton.UseVisualStyleBackColor = true;
            this.AddMarkButton.Click += new System.EventHandler(this.AddMarkButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveToFileButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveToFileButton.Location = new System.Drawing.Point(0, 647);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(1498, 68);
            this.SaveToFileButton.TabIndex = 6;
            this.SaveToFileButton.Text = "ЗАПИСАТИ ІНФОРМЦІЮ ПРО ОЦІНКИ В ФАЙЛ";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // StudentMarksList
            // 
            this.StudentMarksList.FormattingEnabled = true;
            this.StudentMarksList.ItemHeight = 20;
            this.StudentMarksList.Location = new System.Drawing.Point(1070, 53);
            this.StudentMarksList.Name = "StudentMarksList";
            this.StudentMarksList.Size = new System.Drawing.Size(416, 404);
            this.StudentMarksList.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1070, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 41);
            this.label7.TabIndex = 9;
            this.label7.Text = "ОЦІНЕНІ ДИСЦИПЛІНИ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveMarkButton
            // 
            this.RemoveMarkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveMarkButton.Location = new System.Drawing.Point(1070, 468);
            this.RemoveMarkButton.Name = "RemoveMarkButton";
            this.RemoveMarkButton.Size = new System.Drawing.Size(428, 44);
            this.RemoveMarkButton.TabIndex = 6;
            this.RemoveMarkButton.Text = "ЗАБРАТИ ОЦІНКУ";
            this.RemoveMarkButton.UseVisualStyleBackColor = true;
            this.RemoveMarkButton.Click += new System.EventHandler(this.RemoveMarkButton_Click);
            // 
            // MarksArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 715);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.RemoveMarkButton);
            this.Controls.Add(this.AddMarkButton);
            this.Controls.Add(this.RemoveSubjectButton);
            this.Controls.Add(this.ExpelStudentButton);
            this.Controls.Add(this.AddSubjectButton);
            this.Controls.Add(this.EnrollStudentButton);
            this.Controls.Add(this.SubjectsList);
            this.Controls.Add(this.StudentMarksList);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MarksArchiveForm";
            this.Text = "Marks Archive UI";
            this.Load += new System.EventHandler(this.MarksArchive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.ListBox SubjectsList;
        private System.Windows.Forms.Button EnrollStudentButton;
        private System.Windows.Forms.Button ExpelStudentButton;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button RemoveSubjectButton;
        private System.Windows.Forms.Button AddMarkButton;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.ListBox StudentMarksList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RemoveMarkButton;
    }
}


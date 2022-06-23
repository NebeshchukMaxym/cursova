
namespace Kursova
{
    partial class AddMarkForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.MarkComboBox = new System.Windows.Forms.ComboBox();
            this.MarkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оцінка:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предмет:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студент:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkButton.Location = new System.Drawing.Point(181, 384);
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
            this.CancelButton.Location = new System.Drawing.Point(10, 384);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 54);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тип Оцінки:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(129, 38);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(184, 28);
            this.StudentComboBox.TabIndex = 7;
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(129, 84);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(184, 28);
            this.SubjectComboBox.TabIndex = 7;
            // 
            // MarkComboBox
            // 
            this.MarkComboBox.FormattingEnabled = true;
            this.MarkComboBox.Location = new System.Drawing.Point(129, 132);
            this.MarkComboBox.Name = "MarkComboBox";
            this.MarkComboBox.Size = new System.Drawing.Size(184, 28);
            this.MarkComboBox.TabIndex = 7;
            // 
            // MarkTypeComboBox
            // 
            this.MarkTypeComboBox.FormattingEnabled = true;
            this.MarkTypeComboBox.Location = new System.Drawing.Point(129, 184);
            this.MarkTypeComboBox.Name = "MarkTypeComboBox";
            this.MarkTypeComboBox.Size = new System.Drawing.Size(184, 28);
            this.MarkTypeComboBox.TabIndex = 7;
            // 
            // AddMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.MarkTypeComboBox);
            this.Controls.Add(this.MarkComboBox);
            this.Controls.Add(this.SubjectComboBox);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMarkForm";
            this.Text = "AddMarkForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMarkForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.ComboBox MarkComboBox;
        private System.Windows.Forms.ComboBox MarkTypeComboBox;
    }
}
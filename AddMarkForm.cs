using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Data;

namespace Kursova
{
    public partial class AddMarkForm : Form
    {
        public AddMarkForm(IEnumerable<Student> students, IEnumerable<Subject> subjects)
        {
            InitializeComponent();

            StudentComboBox.DataSource = students.ToArray();
            SubjectComboBox.DataSource = subjects.ToArray();
            MarkComboBox.DataSource = Enum.GetValues(typeof(Mark));
            MarkTypeComboBox.DataSource = Enum.GetValues(typeof(MarkType));
        }

        private void AddMarkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StudentComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не можу додати оцінку, якщо не вказано студента");
                e.Cancel = true;
            }
            else if (SubjectComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не можу додати оцінку, якщо не вказано дисципліни");
                e.Cancel = true;
            }
            else if (MarkComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не можу додати оцінку, якщо не вказано оцінки");
                e.Cancel = true;
            }
            else if (MarkTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не можу додати оцінку, якщо не вказано типу оцінки");
                e.Cancel = true;
            }

        }
    }
}

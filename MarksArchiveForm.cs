using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using Data;

namespace Kursova
{
    public partial class MarksArchiveForm : Form
    {

        private List<Student> _students = new List<Student>();
        private List<Subject> _subjects = new List<Subject>();
        private List<StudentMark> _studentMarks = new List<StudentMark>();


        public MarksArchiveForm()
        {
            InitializeComponent();
        }

        private void MarksArchive_Load(object sender, EventArgs e)
        {
            _students.Add(new Student { Id = 1, Surname = "Романенко", Name = "Віталій", Year = 3 });
            _students.Add(new Student { Id = 2, Surname = "Білогірський", Name = "Максим", Year = 2 });
            _students.Add(new Student { Id = 3, Surname = "Білик", Name = "Галина", Year = 3 });

            _subjects.Add(new Subject { Id = 1, Title = "Дискретна Математика" });
            _subjects.Add(new Subject { Id = 2, Title = "Веб Розробка" });
            _subjects.Add(new Subject { Id = 3, Title = "Системи Штучного Інтелекту" });


            _studentMarks.Add(new StudentMark { StudentId = 1, SubjectId = 1, Mark = Mark.B, MarkType = MarkType.MKP });
            _studentMarks.Add(new StudentMark { StudentId = 1, SubjectId = 2, Mark = Mark.C, MarkType = MarkType.Exam });
            _studentMarks.Add(new StudentMark { StudentId = 2, SubjectId = 2, Mark = Mark.A, MarkType = MarkType.HW });
            _studentMarks.Add(new StudentMark { StudentId = 2, SubjectId = 3, Mark = Mark.D, MarkType = MarkType.MKP });
            _studentMarks.Add(new StudentMark { StudentId = 3, SubjectId = 1, Mark = Mark.C, MarkType = MarkType.CP });
            _studentMarks.Add(new StudentMark { StudentId = 3, SubjectId = 3, Mark = Mark.A, MarkType = MarkType.Exam });


            RefreshLists();
        }

        private void ExpelStudentButton_Click(object sender, EventArgs e)
        {
            Student selected = (Student)StudentsList.SelectedItem;
            _students.Remove(selected);

            _studentMarks.RemoveAll(sm => sm.StudentId == selected.Id);
            RefreshLists();
        }

        private void EnrollStudentButton_Click(object sender, EventArgs e)
        {
            StudentEnrollmentForm form = new StudentEnrollmentForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                string surname = form.Controls["StudentSurname"].Text;
                string name = form.Controls["StudentName"].Text;
                int year = int.Parse(form.Controls["StudentYear"].Text);

                if (_students.Any(student => student.Surname == surname && student.Name == name && student.Year == year))
                {
                    MessageBox.Show("Такий студент вже доданий");
                    return;
                }

                _students.Add(new Student
                {
                    Id = _students.Select(student => student.Id).Max() + 1,
                    Surname = surname,
                    Name = name,
                    Year = year 
                });
                RefreshLists();
            }
        }

        private void RemoveSubjectButton_Click(object sender, EventArgs e)
        {
            Subject selected = (Subject)SubjectsList.SelectedItem;
            _subjects.Remove(selected);

            _studentMarks.RemoveAll(sm => sm.SubjectId == selected.Id);
            RefreshLists();
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            AddSubjectForm form = new AddSubjectForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                string title = form.Controls["SubjectTitle"].Text;
                if (_subjects.Any(subject => subject.Title == title))
                {
                    MessageBox.Show("Така дисципліна вже додана");
                    return;
                }

                _subjects.Add(new Subject
                {
                    Id = _subjects.Select(subject => subject.Id).Max() + 1,
                    Title = title
                });
                RefreshLists();
            }
        }

        private void RemoveMarkButton_Click(object sender, EventArgs e)
        {
            string[] selected = StudentMarksList.SelectedItem.ToString().Split(", ");
            Mark mark = Enum.Parse<Mark>(selected[0].Split(": ")[1]);
            MarkType type = Enum.Parse<MarkType>(selected[1].Split(": ")[1]);
            Subject subject = (Subject)SubjectsList.SelectedItem;
            Student student = (Student)StudentsList.SelectedItem;
           
            _studentMarks.RemoveAll(sm => sm.SubjectId == subject.Id && sm.StudentId == student.Id && sm.Mark == mark && sm.MarkType == type);

            RefreshLists();
        }

        private void AddMarkButton_Click(object sender, EventArgs e)
        {
            AddMarkForm form = new AddMarkForm(_students, _subjects);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _studentMarks.Add(new StudentMark
                {
                    StudentId = ((Student)((ComboBox)form.Controls["StudentComboBox"]).SelectedItem).Id,
                    SubjectId = ((Subject)((ComboBox)form.Controls["SubjectComboBox"]).SelectedItem).Id,
                    Mark = (Mark)((ComboBox)form.Controls["MarkComboBox"]).SelectedItem,
                    MarkType = (MarkType)((ComboBox)form.Controls["MarkTypeComboBox"]).SelectedItem
                });
                RefreshLists();
            }
        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLists();
        }
        private void SubjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
           RefreshLists();
        }


        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            var query = from sm in _studentMarks
                        join student in _students on sm.StudentId equals student.Id
                        join subject in _subjects on sm.SubjectId equals subject.Id
                        group new { sm, subject } by student into g
                        select new
                        {
                            Student = $"{g.Key.Surname} {g.Key.Name}",
                            Marks = g.Select(x => new { Subject = x.subject.Title, x.sm.Mark, MarkType = x.sm.MarkType.ToString() })
                        };

            string json = JsonSerializer.Serialize(
                query,
                new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }
            );

            File.WriteAllText(@$"..\..\..\Успішність{DateTime.Today.ToString("d")}", json);

            MessageBox.Show("Поточні оцінки успішно записані в файл");
        }

        private void RefreshLists()
        {
            StudentsList.DataSource = null;
            StudentsList.DataSource = _students;

            SubjectsList.DataSource = null;
            SubjectsList.DataSource = _subjects;


            StudentMarksList.Items.Clear();
            Student selectedStudent = (Student)StudentsList.SelectedItem;
            Subject selectedSubject = (Subject)SubjectsList.SelectedItem;

            if (selectedStudent is not null && selectedSubject is not null)
            {
                StudentMarksList
                    .Items
                    .AddRange(_studentMarks
                                .Where(sm => sm.StudentId == selectedStudent.Id && sm.SubjectId == selectedSubject.Id)
                                .Select(sm => $"Оцінка: {sm.Mark}, Тип: {sm.MarkType}, Дисципліна: {selectedSubject.Title}")
                                .ToArray()
                    );
            }
            
        }

    }
}

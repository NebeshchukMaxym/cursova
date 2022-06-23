using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class StudentEnrollmentForm : Form
    {
        public StudentEnrollmentForm()
        {
            InitializeComponent();
        }

        private void StudentEnrollmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StudentSurname.Text == string.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("Не можу додати студента без прізвища");
            }
            else if (StudentName.Text == string.Empty)
            {
                e.Cancel = true;
                MessageBox.Show("Не можу додати студента без імені");
            }
        }
    }
}

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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddSubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (label.Text == string.Empty)
            {
                MessageBox.Show("Не можу додати дисципліну без назви");
            }
        }
    }
}

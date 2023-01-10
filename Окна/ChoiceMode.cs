using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ChoiceMode : Form
    {
        public ChoiceMode()
        {
            InitializeComponent();
        }

        private void StudentModeButton_Click(object sender, EventArgs e) => CurrentApplicationContext.ShowOnlyStudentModeWin();
        private void TeacherModeButton_Click(object sender, EventArgs e) => CurrentApplicationContext.ShowOnlyTeacherModeWin();
        private void ExitApplicationButton_Click(object sender, EventArgs e) => Application.Exit();
        private void ChoiceMode_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}

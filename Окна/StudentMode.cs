using CourseWork.Бэкэнд;
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
    public partial class StudentMode : Form
    {
        public StudentMode()
        {
            InitializeComponent();
        }

        private void ReturnToChoiceModeButton_Click(object sender, EventArgs e) => CurrentApplicationContext.ShowOnlyChoiceModeWin();

        private void StudentMode_FormClosing(object sender, FormClosingEventArgs e) =>Application.Exit();

        private void OpenCourseButton_Click(object sender, EventArgs e)
        {
            if (OpenCourseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentApplicationContext.OpenCourse(OpenCourseDialog.FileName);
                Course CurrentCourse = CurrentApplicationContext.GetCourse();
                if (CurrentCourse.IsInDevelopment())
                    MessageBox.Show("Данный курс не завершен преподавателем.", "Курс в разработке", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    CurrentApplicationContext.ShowOnlyStudentCourseViewWin();
            }
        }
    }
}

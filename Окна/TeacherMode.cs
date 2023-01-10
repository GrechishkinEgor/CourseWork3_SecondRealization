using CourseWork.Бэкэнд;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    using CourseWork.Бэкэнд;
    using CourseWork.Окна;

    public partial class TeacherMode : Form
    {
        public TeacherMode()
        {
            InitializeComponent();
        }

        private void ReturnToChoiceModeButton_Click(object sender, EventArgs e) => CurrentApplicationContext.ShowOnlyChoiceModeWin();

        private void CreatingNewCourseButton_Click(object sender, EventArgs e)
        {
            CreatingNewCourse CreatingNewCourseWin = new CreatingNewCourse();
            if (CreatingNewCourseWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                CurrentApplicationContext.ShowOnlyTeacherCourseViewWin();
        }
        private void TeacherMode_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
        private void OpenCourseButton_Click(object sender, EventArgs e)
        {
            if (OpenCourseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentApplicationContext.OpenCourse(OpenCourseDialog.FileName);
                PasswordCheck PasswordCheckWin = new PasswordCheck();
                if (PasswordCheckWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    CurrentApplicationContext.ShowOnlyTeacherCourseViewWin();
            }
        }

        private void CheckTestButton_Click(object sender, EventArgs e)
        {
            if (OpenTestDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream TestFile = new FileStream(OpenTestDialog.FileName, FileMode.Open);
                BinaryReader TestReader = new BinaryReader(TestFile);
                ReadyTest CurrentTest = new ReadyTest(TestReader);
                TestResult TestResultWin = new TestResult(CurrentTest);
                TestResultWin.ShowDialog();
                TestFile.Close();
            }
        }
    }
}

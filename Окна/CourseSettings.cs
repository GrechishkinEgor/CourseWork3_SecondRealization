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

namespace CourseWork.Окна
{
    public partial class CourseSettings : Form
    {
        public CourseSettings()
        {
            InitializeComponent();
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            if (!CurrentCourse.IsInDevelopment())
            {
                CourseNameTextBox.Enabled = false;
                TeacherNameTextBox.Enabled = false;
                ChangePasswordButton.Enabled = false;
                FinishDevelopmentButton.Enabled = false;
            }
            CourseNameTextBox.Text = CurrentCourse.GetCourseName();
            TeacherNameTextBox.Text = CurrentCourse.GetTeacherName();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            if (CurrentCourse.IsInDevelopment())
            {
                CurrentCourse.SetCourseName(CourseNameTextBox.Text);
                CurrentCourse.SetTeacherName(TeacherNameTextBox.Text);
            }
            this.Close();
        }

        private void FinishDevelopmentButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Вы уверены, что хотите завершить разработку курса? После завершения курс будет доступен учащимся, но поменять настройки будет невозможно.", "Завершение разработки", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Exclamation)
        == System.Windows.Forms.DialogResult.OK)
            {
                Course CurrentCourse = CurrentApplicationContext.GetCourse();
                Test[] TestsList = CurrentCourse.GetListOfTests();
                if (TestsList.Length == 0)
                {
                    MessageBox.Show("В курсе нет ни одного теста.", "Нет тестов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < TestsList.Length; i++)
                {
                    if (TestsList[i].GetTasksList().Length == 0)
                    {
                        MessageBox.Show("В тесте \"" + TestsList[i].GetTestName() + "\" нет ни одного задания", "Нет заданий", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                CurrentApplicationContext.GetCourse().FinishDevelopment();
                CurrentApplicationContext.ShowOnlyTeacherCourseViewWin();
                this.Close();
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeTeacherPassword ChangeTeacherPasswordWin = new ChangeTeacherPassword();
            ChangeTeacherPasswordWin.ShowDialog();
        }
    }
}

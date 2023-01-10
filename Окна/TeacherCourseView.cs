using CourseWork.Бэкэнд;
using CourseWork.Окна;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class TeacherCourseView : Form
    {
        public TeacherCourseView()
        {
            InitializeComponent();
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            Test[] TestList = CurrentCourse.GetListOfTests();
            for (int i = 0; i < TestList.Length; i++)
                this.TestsDataGridView.Rows.Add(TestList[i].GetId(), TestList[i].GetTestName());

            if (!CurrentApplicationContext.GetCourse().IsInDevelopment())
            {
                сохранитьToolStripMenuItem.Enabled = false;
                //сохранитьКакToolStripMenuItem->Enabled = false;
                новыйТестToolStripMenuItem.Enabled = false;
            }
            return;
        }

        private void настройкиКурсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseSettings CourseSettingsWin = new CourseSettings();
            CourseSettingsWin.ShowDialog();
        }

        private void TeacherCourseView_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentApplicationContext.GetPath() == "")
            {
                if (SaveCourseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    CurrentApplicationContext.SaveCourse(SaveCourseDialog.FileName);
            }
            else
                CurrentApplicationContext.SaveCourse(CurrentApplicationContext.GetPath());
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveCourseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                CurrentApplicationContext.SaveCourse(SaveCourseDialog.FileName);
        }

        private void новыйТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatingNewTest CreatingNewTestWin = new CreatingNewTest();
            if (CreatingNewTestWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Course CurrentCourse = CurrentApplicationContext.GetCourse();
                Test[] TestList = CurrentCourse.GetListOfTests();
                this.TestsDataGridView.Rows.Add(TestList[TestList.Length - 1].GetId(), TestList[TestList.Length - 1].GetTestName());
            }
        }

        private void выйтиИзКурсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentApplicationContext.ShowOnlyTeacherModeWin();
        }

        private void TestsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            int TestId = Convert.ToInt32(this.TestsDataGridView[0, this.TestsDataGridView.CurrentCell.RowIndex].Value);
            Test CurrentTest = CurrentCourse.GetTestWithId(TestId);
            TestView TestViewWin = new TestView(CurrentTest);
            this.Hide();
            if (TestViewWin.ShowDialog() == System.Windows.Forms.DialogResult.Abort)
            {
                CurrentCourse.RemoveTestWithId(TestId);
                this.TestsDataGridView.Rows.Remove(this.TestsDataGridView.Rows[this.TestsDataGridView.CurrentCell.RowIndex]);
            }
            else
                this.TestsDataGridView[1, this.TestsDataGridView.CurrentCell.RowIndex].Value = CurrentTest.GetTestName();
            this.Show();
        }
    }
}

using CourseWork.Бэкэнд;
using CourseWork.Окна;
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
    public partial class StudentCourseView : Form
    {
        public StudentCourseView()
        {
            InitializeComponent();
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            CourseNameTextBox.Text = CurrentCourse.GetCourseName();
            Test[] TestList = CurrentCourse.GetListOfTests();
            for (int i = 0; i < TestList.Length; i++)
                this.TestsDataGridView.Rows.Add(TestList[i].GetId(), TestList[i].GetTestName());
        }

        private void StudentCourseView_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void TestsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            Test CurrentTest = CurrentCourse.GetTestWithId(Convert.ToInt32(TestsDataGridView[0, TestsDataGridView.CurrentCell.RowIndex].Value));
            ReadyTest ReadyCurrentTest = new ReadyTest(CurrentTest);
            StartTest StartTestWin = new StartTest(ReadyCurrentTest);
            if (StartTestWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                ReadyTask[] TasksList = ReadyCurrentTest.GetTasksList();
                System.Windows.Forms.DialogResult Result;
                int IndexCurrentTask = 0;
                do
                {
                    StudentTaskView StudentTaskViewWin = new StudentTaskView(TasksList[IndexCurrentTask], IndexCurrentTask + 1, TasksList.Length);
                    Result = StudentTaskViewWin.ShowDialog();
                    if (Result == System.Windows.Forms.DialogResult.OK)
                        IndexCurrentTask++;
                    if (Result == System.Windows.Forms.DialogResult.Cancel)
                        IndexCurrentTask--;
                } while (Result != System.Windows.Forms.DialogResult.Abort);
                FileStream TestFile = new FileStream(ReadyCurrentTest.GetStudentName() + ".test", FileMode.Create);
                BinaryWriter TestWriter = new BinaryWriter(TestFile);
                ReadyCurrentTest.WriteInFile(TestWriter);
                TestWriter.Close();
                this.Show();
                MessageBox.Show("Вы набрали " + Convert.ToString(ReadyCurrentTest.CalculateTotalMarkInPercent()) + "% за тест.");
            }
        }

        private void ExitCourseButton_Click(object sender, EventArgs e) => CurrentApplicationContext.ShowOnlyStudentModeWin();
    }
}

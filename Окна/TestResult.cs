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
    public partial class TestResult : Form
    {
        private ReadyTest CurrentTest;
        public TestResult(ReadyTest CurrentTest)
        {
            InitializeComponent();
            this.CurrentTest = CurrentTest;
            TestNameTextBox.Text = CurrentTest.GetTestName();
            ReadyTask[] TasksList = CurrentTest.GetTasksList();
            for (int i = 0; i < TasksList.Length; i++)
                TasksGridView.Rows.Add(TasksList[i].GetQuestion(), Convert.ToString(TasksList[i].GetLastUserMark()) + "/" + Convert.ToString(TasksList[i].GetMaxMark()) + " - " + Convert.ToString((int)((double)TasksList[i].GetLastUserMark() / TasksList[i].GetMaxMark() * 100)) + "%");
            TotalMarkLabel.Text = TotalMarkLabel.Text + " " + Convert.ToString(CurrentTest.CalculateTotalMarkInPercent()) + "%";
        }

        private void TasksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TaskResult TaskResultWin = new TaskResult(CurrentTest.GetTasksList()[TasksGridView.CurrentCell.RowIndex]);
            TaskResultWin.ShowDialog();
        }
    }
}

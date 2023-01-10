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
    public partial class TestView : Form
    {
        private Test CurrentTest;
        public TestView(Test CurrentTest)
        {
            InitializeComponent();
            this.CurrentTest = CurrentTest;
            this.TestNameTextBox.Text = CurrentTest.GetTestName();
            CourseWork.Бэкэнд.Task[] TasksList = CurrentTest.GetTasksList();
            for (int i = 0; i < TasksList.Length; i++)
                TasksGridView.Rows.Add(TasksList[i].GetId(), TasksList[i].GetQuestion());
            RandomOrderCheckBox.CheckState = CurrentTest.IsTaskInRandomOrder() ? CheckState.Checked : CheckState.Unchecked;

            if (!CurrentApplicationContext.GetCourse().IsInDevelopment())
            {
                TestNameTextBox.Enabled = false;
                добавитьЗаданиеToolStripMenuItem.Enabled = false;
                удалитьТестToolStripMenuItem.Enabled = false;
                RandomOrderCheckBox.Enabled = false;
            }

            return;
        }

        private void TestNameTextBox_Leave(object sender, EventArgs e)
        {
            this.CurrentTest.SetTestName(this.TestNameTextBox.Text);
        }

        private void удалитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Вы уверены, что хотите безвозвратно удалить тест?", "Удаление теста", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Exclamation)
            == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                this.Close();
            }
        }

        private void TestView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TestNameTextBox_Leave(sender, e);
        }

        private void добавитьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseWork.Бэкэнд.Task NewTask = new CourseWork.Бэкэнд.Task();
            EditChoiceFewAnswer EditChoiceFewAnswersWin = new EditChoiceFewAnswer(NewTask);
            if (EditChoiceFewAnswersWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentTest.AddNewTask(NewTask);
                TasksGridView.Rows.Add(NewTask.GetId(), NewTask.GetQuestion());
            }
        }

        private void TasksGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int TaskId = Convert.ToInt32(this.TasksGridView[0, this.TasksGridView.CurrentCell.RowIndex].Value);
            CourseWork.Бэкэнд.Task CurrentTask = CurrentTest.GetTaskWithId(TaskId);
            EditChoiceFewAnswer EditChoiceFewAnswerWin = new EditChoiceFewAnswer(CurrentTask);
            if (EditChoiceFewAnswerWin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                TasksGridView[1, this.TasksGridView.CurrentCell.RowIndex].Value = CurrentTask.GetQuestion();
        }

        private void RandomOrderCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CurrentTest.SetRandomOrderFlag(RandomOrderCheckBox.CheckState == CheckState.Checked);
        }
    }
}

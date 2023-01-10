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
    public partial class StudentTaskView : Form
    {
        private ReadyTask CurrentTask;
        public StudentTaskView(ReadyTask CurrentTask, int NumTask, int TaskCount)
        {
            InitializeComponent();
            QuestionTextBox.Text = CurrentTask.GetQuestion();
            String[] Answers = CurrentTask.GetAnswers();
            bool[] UserAnswer = CurrentTask.GetUserAnswer();
            for (int i = 0; i < Answers.Length; i++)
                AnswersGridView.Rows.Add(UserAnswer[i] ? "+" : "", Answers[i]);
            NumQuestionLabel.Text = NumQuestionLabel.Text + " " + Convert.ToString(NumTask) + "/" + Convert.ToString(TaskCount);

            if (NumTask == TaskCount)
                NextButton.Enabled = false;
            if (NumTask == 1)
                BackButton.Enabled = false;

            this.CurrentTask = CurrentTask;
        }

        private void EndTestButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Close();
        }

        private void AnswersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AnswersGridView.CurrentCell.ColumnIndex == 0)
                if (AnswersGridView.CurrentCell.Value == "")
                    AnswersGridView.CurrentCell.Value = "+";
                else
                    AnswersGridView.CurrentCell.Value = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void StudentTaskView_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool[] UserAnswers = { };
            Array.Resize(ref UserAnswers, CurrentTask.GetAnswers().Length);
            for (int i = 0; i < UserAnswers.Length; i++)
                if (AnswersGridView[0, i].Value == "+")
                    UserAnswers[i] = true;
                else
                    UserAnswers[i] = false;
            CurrentTask.CheckAnswer(UserAnswers);
        }
    }
}

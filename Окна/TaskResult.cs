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
    public partial class TaskResult : Form
    {
        private ReadyTask CurrentTask;
        public TaskResult(ReadyTask CurrentTask)
        {
            InitializeComponent();
            this.CurrentTask = CurrentTask;
            QuestionTextBox.Text = CurrentTask.GetQuestion();
            String[]Answers = CurrentTask.GetAnswers();
            bool[] RightAnswers = CurrentTask.GetNumsOfRightAnswers();
            bool[] UserAnswers = CurrentTask.GetUserAnswer();
            for (int i = 0; i < Answers.Length; i++)
                AnswersGridView.Rows.Add(Answers[i], UserAnswers[i] ? "+" : "", RightAnswers[i] ? "+" : "");
            MarkLabel.Text = MarkLabel.Text + " " + Convert.ToString(CurrentTask.GetLastUserMark()) + "/" + Convert.ToString(CurrentTask.GetMaxMark()) + " - " + Convert.ToString((int)((double)CurrentTask.GetLastUserMark() / CurrentTask.GetMaxMark() * 100)) + "%";
        }
    }
}

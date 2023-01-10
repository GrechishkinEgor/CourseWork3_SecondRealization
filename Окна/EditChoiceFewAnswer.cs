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
    public partial class EditChoiceFewAnswer : Form
    {
        private CourseWork.Бэкэнд.Task CurrentTask;
        public EditChoiceFewAnswer(Бэкэнд.Task CurrentTask)
        {
            InitializeComponent();
            this.CurrentTask = CurrentTask;
            OneAnswerCheckBox.CheckState = CurrentTask.IsTaskWithOneRightAnswer() ? CheckState.Checked : CheckState.Unchecked;
            QuestionTextBox.Text = CurrentTask.GetQuestion();
            if (CurrentTask.IsAnswersRandomOrder())
                RandomOrderOfAnswersCheckBox.CheckState = CheckState.Checked;
            else
                RandomOrderOfAnswersCheckBox.CheckState = CheckState.Unchecked;
            TotalMarkTextBox.Text = Convert.ToString(CurrentTask.GetMaxMark());
            String[] Answers = CurrentTask.GetAnswers();
            bool[] NumsOfRightAnswers = CurrentTask.GetNumsOfRightAnswers();
            for (int i = 0; i < Answers.Length; i++)
                AnswersGridView.Rows.Add(Answers[i], NumsOfRightAnswers[i] ? "Правильный" : "");

            if (!CurrentApplicationContext.GetCourse().IsInDevelopment())
            {
                QuestionTextBox.Enabled = false;
                RandomOrderOfAnswersCheckBox.Enabled = false;
                TotalMarkTextBox.Enabled = false;
                AnswersGridView.Enabled = false;
            }

            return;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!CurrentApplicationContext.GetCourse().IsInDevelopment())
                this.Close();


            if (QuestionTextBox.Text == "")
            {
                MessageBox.Show("Не указан вопрос.", "Вопрос", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                Convert.ToInt32(TotalMarkTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Указано некорректное значение полного балла", "Балл за задание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(TotalMarkTextBox.Text) <= 0)
            {
                MessageBox.Show("Полный балл за задание не может быть отрицательным или нулевым", "Балл за задание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool FlagRightAnswers = false;
            if (AnswersGridView.Rows.Count < 3)
            {
                MessageBox.Show("Количество ответов должно быть не меньше 2.", "Ответы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            for (int i = 0; i < AnswersGridView.Rows.Count; i++)
            {
                if (AnswersGridView[0, i].Value == "")
                {
                    MessageBox.Show("Пустые варианты ответов не допускаются.", "Ответы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataGridViewButtonCell CurrentCell = (DataGridViewButtonCell)AnswersGridView.Rows[i].Cells[1];
                if (CurrentCell.Value == "Правильный")
                    FlagRightAnswers = true;
            }
            if (!FlagRightAnswers)
            {
                MessageBox.Show("Ни один ответ не является правильным.", "Ответы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CurrentTask.SetQuestion(QuestionTextBox.Text);
            CurrentTask.ClearAnswers();
            for (int i = 0; i < AnswersGridView.Rows.Count - 1; i++)
                CurrentTask.AddNewAnswer(Convert.ToString(AnswersGridView[0, i].Value), AnswersGridView.Rows[i].Cells[1].Value == "Правильный");
            CurrentTask.SetAnswersRandomOrder(RandomOrderOfAnswersCheckBox.CheckState == CheckState.Checked);
            CurrentTask.SetMaxMark(Convert.ToInt32(TotalMarkTextBox.Text));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

            }

        private void AnswersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AnswersGridView.CurrentCell.ColumnIndex == 1)
            {
                if (CurrentTask.IsTaskWithOneRightAnswer())
                    for (int i = 0; i < AnswersGridView.Rows.Count; i++)
                        if (i != AnswersGridView.CurrentCell.RowIndex)
                            AnswersGridView[1, i].Value = "";
                if (AnswersGridView.CurrentCell.Value == "Правильный")
                    AnswersGridView.CurrentCell.Value = "";
                else
                    AnswersGridView.CurrentCell.Value = "Правильный";
            }
        }

        private void OneAnswerCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CurrentTask.SetFlagOfOneRightAnswer(OneAnswerCheckBox.CheckState == CheckState.Checked);
            for (int i = 0; i < AnswersGridView.Rows.Count; i++)
                AnswersGridView[1, i].Value = "";
        }
    }
    }

namespace CourseWork.Окна
{
    partial class TaskResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswersGridView = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InfoPanel.Controls.Add(this.MarkLabel);
            this.InfoPanel.Controls.Add(this.QuestionTextBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(455, 104);
            this.InfoPanel.TabIndex = 0;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(12, 78);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(51, 15);
            this.MarkLabel.TabIndex = 1;
            this.MarkLabel.Text = "Оценка:";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Enabled = false;
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionTextBox.Size = new System.Drawing.Size(431, 63);
            this.QuestionTextBox.TabIndex = 0;
            // 
            // AnswersGridView
            // 
            this.AnswersGridView.AllowUserToAddRows = false;
            this.AnswersGridView.AllowUserToDeleteRows = false;
            this.AnswersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AnswersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnswersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer,
            this.UserAnswer,
            this.RightAnswer});
            this.AnswersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswersGridView.Location = new System.Drawing.Point(0, 104);
            this.AnswersGridView.Name = "AnswersGridView";
            this.AnswersGridView.ReadOnly = true;
            this.AnswersGridView.RowTemplate.Height = 25;
            this.AnswersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnswersGridView.Size = new System.Drawing.Size(455, 215);
            this.AnswersGridView.TabIndex = 1;
            // 
            // Answer
            // 
            this.Answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Answer.HeaderText = "Вариант ответа";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserAnswer
            // 
            this.UserAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserAnswer.HeaderText = "Ответ учащегося";
            this.UserAnswer.Name = "UserAnswer";
            this.UserAnswer.ReadOnly = true;
            this.UserAnswer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserAnswer.Width = 96;
            // 
            // RightAnswer
            // 
            this.RightAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RightAnswer.HeaderText = "Правильный ответ";
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.ReadOnly = true;
            this.RightAnswer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RightAnswer.Width = 105;
            // 
            // TaskResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 319);
            this.Controls.Add(this.AnswersGridView);
            this.Controls.Add(this.InfoPanel);
            this.Name = "TaskResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel InfoPanel;
        private Label MarkLabel;
        private TextBox QuestionTextBox;
        private DataGridView AnswersGridView;
        private DataGridViewTextBoxColumn Answer;
        private DataGridViewTextBoxColumn UserAnswer;
        private DataGridViewTextBoxColumn RightAnswer;
    }
}
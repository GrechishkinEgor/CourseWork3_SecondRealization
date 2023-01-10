namespace CourseWork.Окна
{
    partial class StudentTaskView
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NumQuestionLabel = new System.Windows.Forms.Label();
            this.EndTestButton = new System.Windows.Forms.Button();
            this.NextBackButtonsPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswersGridView = new System.Windows.Forms.DataGridView();
            this.RightFlag = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Answers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.NextBackButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Info;
            this.TopPanel.Controls.Add(this.NumQuestionLabel);
            this.TopPanel.Controls.Add(this.EndTestButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(644, 47);
            this.TopPanel.TabIndex = 0;
            // 
            // NumQuestionLabel
            // 
            this.NumQuestionLabel.AutoSize = true;
            this.NumQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumQuestionLabel.Location = new System.Drawing.Point(12, 12);
            this.NumQuestionLabel.Name = "NumQuestionLabel";
            this.NumQuestionLabel.Size = new System.Drawing.Size(58, 16);
            this.NumQuestionLabel.TabIndex = 1;
            this.NumQuestionLabel.Text = "Вопрос:";
            // 
            // EndTestButton
            // 
            this.EndTestButton.Location = new System.Drawing.Point(481, 12);
            this.EndTestButton.Name = "EndTestButton";
            this.EndTestButton.Size = new System.Drawing.Size(151, 23);
            this.EndTestButton.TabIndex = 0;
            this.EndTestButton.Text = "Завершить тест";
            this.EndTestButton.UseVisualStyleBackColor = true;
            this.EndTestButton.Click += new System.EventHandler(this.EndTestButton_Click);
            // 
            // NextBackButtonsPanel
            // 
            this.NextBackButtonsPanel.BackColor = System.Drawing.SystemColors.Info;
            this.NextBackButtonsPanel.Controls.Add(this.BackButton);
            this.NextBackButtonsPanel.Controls.Add(this.NextButton);
            this.NextBackButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextBackButtonsPanel.Location = new System.Drawing.Point(0, 297);
            this.NextBackButtonsPanel.Name = "NextBackButtonsPanel";
            this.NextBackButtonsPanel.Size = new System.Drawing.Size(644, 51);
            this.NextBackButtonsPanel.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 16);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(151, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Предыдущий вопрос";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(481, 16);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(151, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Следующий вопрос";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Enabled = false;
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 53);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionTextBox.Size = new System.Drawing.Size(620, 56);
            this.QuestionTextBox.TabIndex = 2;
            // 
            // AnswersGridView
            // 
            this.AnswersGridView.AllowUserToAddRows = false;
            this.AnswersGridView.AllowUserToDeleteRows = false;
            this.AnswersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnswersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RightFlag,
            this.Answers});
            this.AnswersGridView.Location = new System.Drawing.Point(12, 115);
            this.AnswersGridView.Name = "AnswersGridView";
            this.AnswersGridView.ReadOnly = true;
            this.AnswersGridView.RowTemplate.Height = 25;
            this.AnswersGridView.Size = new System.Drawing.Size(620, 176);
            this.AnswersGridView.TabIndex = 3;
            this.AnswersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnswersGridView_CellClick);
            // 
            // RightFlag
            // 
            this.RightFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RightFlag.HeaderText = "";
            this.RightFlag.Name = "RightFlag";
            this.RightFlag.ReadOnly = true;
            this.RightFlag.Width = 50;
            // 
            // Answers
            // 
            this.Answers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Answers.HeaderText = "";
            this.Answers.Name = "Answers";
            this.Answers.ReadOnly = true;
            this.Answers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StudentTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 348);
            this.Controls.Add(this.AnswersGridView);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.NextBackButtonsPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentTaskView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentTaskView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentTaskView_FormClosed);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.NextBackButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TopPanel;
        private Label NumQuestionLabel;
        private Button EndTestButton;
        private Panel NextBackButtonsPanel;
        private Button BackButton;
        private Button NextButton;
        private TextBox QuestionTextBox;
        private DataGridView AnswersGridView;
        private DataGridViewButtonColumn RightFlag;
        private DataGridViewTextBoxColumn Answers;
    }
}
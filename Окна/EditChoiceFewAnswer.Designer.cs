namespace CourseWork.Окна
{
    partial class EditChoiceFewAnswer
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
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.RandomOrderOfAnswersCheckBox = new System.Windows.Forms.CheckBox();
            this.OneAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalMarkLabel = new System.Windows.Forms.Label();
            this.TotalMarkTextBox = new System.Windows.Forms.TextBox();
            this.AnswersGridView = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRight = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OKButton = new System.Windows.Forms.Button();
            this.QuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.SystemColors.Info;
            this.QuestionPanel.Controls.Add(this.TotalMarkTextBox);
            this.QuestionPanel.Controls.Add(this.TotalMarkLabel);
            this.QuestionPanel.Controls.Add(this.OneAnswerCheckBox);
            this.QuestionPanel.Controls.Add(this.RandomOrderOfAnswersCheckBox);
            this.QuestionPanel.Controls.Add(this.QuestionTextBox);
            this.QuestionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(484, 120);
            this.QuestionPanel.TabIndex = 0;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionTextBox.Size = new System.Drawing.Size(460, 51);
            this.QuestionTextBox.TabIndex = 0;
            // 
            // RandomOrderOfAnswersCheckBox
            // 
            this.RandomOrderOfAnswersCheckBox.AutoSize = true;
            this.RandomOrderOfAnswersCheckBox.Location = new System.Drawing.Point(12, 69);
            this.RandomOrderOfAnswersCheckBox.Name = "RandomOrderOfAnswersCheckBox";
            this.RandomOrderOfAnswersCheckBox.Size = new System.Drawing.Size(224, 19);
            this.RandomOrderOfAnswersCheckBox.TabIndex = 1;
            this.RandomOrderOfAnswersCheckBox.Text = "Случайный порядок ответов в тесте";
            this.RandomOrderOfAnswersCheckBox.UseVisualStyleBackColor = true;
            // 
            // OneAnswerCheckBox
            // 
            this.OneAnswerCheckBox.AutoSize = true;
            this.OneAnswerCheckBox.Location = new System.Drawing.Point(12, 94);
            this.OneAnswerCheckBox.Name = "OneAnswerCheckBox";
            this.OneAnswerCheckBox.Size = new System.Drawing.Size(214, 19);
            this.OneAnswerCheckBox.TabIndex = 2;
            this.OneAnswerCheckBox.Text = "Задание с одним верным ответом";
            this.OneAnswerCheckBox.UseVisualStyleBackColor = true;
            this.OneAnswerCheckBox.CheckStateChanged += new System.EventHandler(this.OneAnswerCheckBox_CheckStateChanged);
            // 
            // TotalMarkLabel
            // 
            this.TotalMarkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalMarkLabel.AutoSize = true;
            this.TotalMarkLabel.Location = new System.Drawing.Point(326, 72);
            this.TotalMarkLabel.Name = "TotalMarkLabel";
            this.TotalMarkLabel.Size = new System.Drawing.Size(146, 15);
            this.TotalMarkLabel.TabIndex = 3;
            this.TotalMarkLabel.Text = "Полный балл за задание:";
            // 
            // TotalMarkTextBox
            // 
            this.TotalMarkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalMarkTextBox.Location = new System.Drawing.Point(372, 90);
            this.TotalMarkTextBox.MaxLength = 4;
            this.TotalMarkTextBox.Name = "TotalMarkTextBox";
            this.TotalMarkTextBox.Size = new System.Drawing.Size(100, 23);
            this.TotalMarkTextBox.TabIndex = 4;
            // 
            // AnswersGridView
            // 
            this.AnswersGridView.AllowUserToDeleteRows = false;
            this.AnswersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AnswersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnswersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer,
            this.IsRight});
            this.AnswersGridView.Location = new System.Drawing.Point(0, 119);
            this.AnswersGridView.Name = "AnswersGridView";
            this.AnswersGridView.ReadOnly = true;
            this.AnswersGridView.RowTemplate.Height = 25;
            this.AnswersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnswersGridView.Size = new System.Drawing.Size(484, 175);
            this.AnswersGridView.TabIndex = 1;
            this.AnswersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnswersGridView_CellClick);
            // 
            // Answer
            // 
            this.Answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Answer.HeaderText = "Ответ";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // IsRight
            // 
            this.IsRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsRight.HeaderText = "Правильность";
            this.IsRight.Name = "IsRight";
            this.IsRight.ReadOnly = true;
            this.IsRight.Width = 92;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(191, 326);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(141, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // EditChoiceFewAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AnswersGridView);
            this.Controls.Add(this.QuestionPanel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "EditChoiceFewAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вопрос";
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel QuestionPanel;
        private TextBox TotalMarkTextBox;
        private Label TotalMarkLabel;
        private CheckBox OneAnswerCheckBox;
        private CheckBox RandomOrderOfAnswersCheckBox;
        private TextBox QuestionTextBox;
        private DataGridView AnswersGridView;
        private DataGridViewTextBoxColumn Answer;
        private DataGridViewButtonColumn IsRight;
        private Button OKButton;
    }
}
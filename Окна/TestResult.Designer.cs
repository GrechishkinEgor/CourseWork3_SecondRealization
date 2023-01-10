namespace CourseWork.Окна
{
    partial class TestResult
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
            this.TotalMarkLabel = new System.Windows.Forms.Label();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTestLabel = new System.Windows.Forms.Label();
            this.TasksGridView = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InfoPanel.Controls.Add(this.TotalMarkLabel);
            this.InfoPanel.Controls.Add(this.TestNameTextBox);
            this.InfoPanel.Controls.Add(this.NameTestLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(554, 67);
            this.InfoPanel.TabIndex = 0;
            // 
            // TotalMarkLabel
            // 
            this.TotalMarkLabel.AutoSize = true;
            this.TotalMarkLabel.Location = new System.Drawing.Point(12, 38);
            this.TotalMarkLabel.Name = "TotalMarkLabel";
            this.TotalMarkLabel.Size = new System.Drawing.Size(161, 15);
            this.TotalMarkLabel.TabIndex = 2;
            this.TotalMarkLabel.Text = "Процент выполнения теста:";
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestNameTextBox.Enabled = false;
            this.TestNameTextBox.Location = new System.Drawing.Point(111, 6);
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(431, 23);
            this.TestNameTextBox.TabIndex = 1;
            // 
            // NameTestLabel
            // 
            this.NameTestLabel.AutoSize = true;
            this.NameTestLabel.Location = new System.Drawing.Point(12, 9);
            this.NameTestLabel.Name = "NameTestLabel";
            this.NameTestLabel.Size = new System.Drawing.Size(93, 15);
            this.NameTestLabel.TabIndex = 0;
            this.NameTestLabel.Text = "Название теста:";
            // 
            // TasksGridView
            // 
            this.TasksGridView.AllowUserToAddRows = false;
            this.TasksGridView.AllowUserToDeleteRows = false;
            this.TasksGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Mark});
            this.TasksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksGridView.Location = new System.Drawing.Point(0, 67);
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.ReadOnly = true;
            this.TasksGridView.RowTemplate.Height = 25;
            this.TasksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksGridView.Size = new System.Drawing.Size(554, 234);
            this.TasksGridView.TabIndex = 1;
            this.TasksGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGridView_CellDoubleClick);
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Question.HeaderText = "Вопрос";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mark.HeaderText = "Оценка";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mark.Width = 54;
            // 
            // TestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 301);
            this.Controls.Add(this.TasksGridView);
            this.Controls.Add(this.InfoPanel);
            this.Name = "TestResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты теста";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel InfoPanel;
        private Label TotalMarkLabel;
        private TextBox TestNameTextBox;
        private Label NameTestLabel;
        private DataGridView TasksGridView;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Mark;
    }
}
namespace CourseWork
{
    partial class StudentCourseView
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
            this.ExitCourseButton = new System.Windows.Forms.Button();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.TestsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InfoPanel.Controls.Add(this.ExitCourseButton);
            this.InfoPanel.Controls.Add(this.CourseNameTextBox);
            this.InfoPanel.Controls.Add(this.CourseNameLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(670, 35);
            this.InfoPanel.TabIndex = 0;
            // 
            // ExitCourseButton
            // 
            this.ExitCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitCourseButton.Location = new System.Drawing.Point(548, 5);
            this.ExitCourseButton.Name = "ExitCourseButton";
            this.ExitCourseButton.Size = new System.Drawing.Size(110, 23);
            this.ExitCourseButton.TabIndex = 2;
            this.ExitCourseButton.Text = "Выйти из курса";
            this.ExitCourseButton.UseVisualStyleBackColor = true;
            this.ExitCourseButton.Click += new System.EventHandler(this.ExitCourseButton_Click);
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseNameTextBox.Enabled = false;
            this.CourseNameTextBox.Location = new System.Drawing.Point(54, 6);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(488, 23);
            this.CourseNameTextBox.TabIndex = 1;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(36, 15);
            this.CourseNameLabel.TabIndex = 0;
            this.CourseNameLabel.Text = "Курс:";
            // 
            // TestsDataGridView
            // 
            this.TestsDataGridView.AllowUserToAddRows = false;
            this.TestsDataGridView.AllowUserToDeleteRows = false;
            this.TestsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TestName});
            this.TestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestsDataGridView.Location = new System.Drawing.Point(0, 35);
            this.TestsDataGridView.Name = "TestsDataGridView";
            this.TestsDataGridView.ReadOnly = true;
            this.TestsDataGridView.RowTemplate.Height = 25;
            this.TestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestsDataGridView.Size = new System.Drawing.Size(670, 309);
            this.TestsDataGridView.TabIndex = 1;
            this.TestsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TestsDataGridView_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestName.HeaderText = "Название теста";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // StudentCourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 344);
            this.Controls.Add(this.TestsDataGridView);
            this.Controls.Add(this.InfoPanel);
            this.Name = "StudentCourseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим учащегося";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentCourseView_FormClosing);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel InfoPanel;
        private Button ExitCourseButton;
        private TextBox CourseNameTextBox;
        private Label CourseNameLabel;
        private DataGridView TestsDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TestName;
    }
}
namespace CourseWork.Окна
{
    partial class TestView
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
            this.GeneralMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавитьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.RandomOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.TasksGridView = new System.Windows.Forms.DataGridView();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasksList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneralMenuStrip.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralMenuStrip
            // 
            this.GeneralMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаданиеToolStripMenuItem,
            this.удалитьТестToolStripMenuItem});
            this.GeneralMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GeneralMenuStrip.Name = "GeneralMenuStrip";
            this.GeneralMenuStrip.Size = new System.Drawing.Size(499, 24);
            this.GeneralMenuStrip.TabIndex = 0;
            this.GeneralMenuStrip.Text = "menuStrip1";
            // 
            // добавитьЗаданиеToolStripMenuItem
            // 
            this.добавитьЗаданиеToolStripMenuItem.Name = "добавитьЗаданиеToolStripMenuItem";
            this.добавитьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.добавитьЗаданиеToolStripMenuItem.Text = "Добавить задание";
            this.добавитьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаданиеToolStripMenuItem_Click);
            // 
            // удалитьТестToolStripMenuItem
            // 
            this.удалитьТестToolStripMenuItem.Name = "удалитьТестToolStripMenuItem";
            this.удалитьТестToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.удалитьТестToolStripMenuItem.Text = "Удалить тест";
            this.удалитьТестToolStripMenuItem.Click += new System.EventHandler(this.удалитьТестToolStripMenuItem_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.InfoPanel.Controls.Add(this.RandomOrderCheckBox);
            this.InfoPanel.Controls.Add(this.TestNameTextBox);
            this.InfoPanel.Controls.Add(this.TestNameLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 24);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(499, 72);
            this.InfoPanel.TabIndex = 1;
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Location = new System.Drawing.Point(12, 13);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(33, 15);
            this.TestNameLabel.TabIndex = 0;
            this.TestNameLabel.Text = "Тест:";
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestNameTextBox.Location = new System.Drawing.Point(51, 10);
            this.TestNameTextBox.MaxLength = 256;
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(436, 23);
            this.TestNameTextBox.TabIndex = 1;
            this.TestNameTextBox.Leave += new System.EventHandler(this.TestNameTextBox_Leave);
            // 
            // RandomOrderCheckBox
            // 
            this.RandomOrderCheckBox.AutoSize = true;
            this.RandomOrderCheckBox.Location = new System.Drawing.Point(12, 39);
            this.RandomOrderCheckBox.Name = "RandomOrderCheckBox";
            this.RandomOrderCheckBox.Size = new System.Drawing.Size(276, 19);
            this.RandomOrderCheckBox.TabIndex = 2;
            this.RandomOrderCheckBox.Text = "Выдавать задания теста в случайном порядке";
            this.RandomOrderCheckBox.UseVisualStyleBackColor = true;
            this.RandomOrderCheckBox.CheckStateChanged += new System.EventHandler(this.RandomOrderCheckBox_CheckStateChanged);
            // 
            // TasksGridView
            // 
            this.TasksGridView.AllowUserToAddRows = false;
            this.TasksGridView.AllowUserToDeleteRows = false;
            this.TasksGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.TasksList});
            this.TasksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksGridView.Location = new System.Drawing.Point(0, 96);
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.ReadOnly = true;
            this.TasksGridView.RowTemplate.Height = 25;
            this.TasksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksGridView.Size = new System.Drawing.Size(499, 229);
            this.TasksGridView.TabIndex = 2;
            this.TasksGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksGridView_CellDoubleClick);
            // 
            // TaskId
            // 
            this.TaskId.HeaderText = "Id";
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            this.TaskId.Visible = false;
            // 
            // TasksList
            // 
            this.TasksList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TasksList.HeaderText = "Задания";
            this.TasksList.Name = "TasksList";
            this.TasksList.ReadOnly = true;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 325);
            this.Controls.Add(this.TasksGridView);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.GeneralMenuStrip);
            this.MainMenuStrip = this.GeneralMenuStrip;
            this.Name = "TestView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestView_FormClosing);
            this.GeneralMenuStrip.ResumeLayout(false);
            this.GeneralMenuStrip.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip GeneralMenuStrip;
        private ToolStripMenuItem добавитьЗаданиеToolStripMenuItem;
        private ToolStripMenuItem удалитьТестToolStripMenuItem;
        private Panel InfoPanel;
        private TextBox TestNameTextBox;
        private Label TestNameLabel;
        private CheckBox RandomOrderCheckBox;
        private DataGridView TasksGridView;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TasksList;
    }
}
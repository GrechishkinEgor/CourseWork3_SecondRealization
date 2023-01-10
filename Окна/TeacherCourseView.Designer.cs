namespace CourseWork
{
    partial class TeacherCourseView
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
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиКурсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзКурсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveCourseDialog = new System.Windows.Forms.SaveFileDialog();
            this.GeneralMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralMenuStrip
            // 
            this.GeneralMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.новыйТестToolStripMenuItem,
            this.настройкиКурсаToolStripMenuItem,
            this.выйтиИзКурсаToolStripMenuItem});
            this.GeneralMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GeneralMenuStrip.Name = "GeneralMenuStrip";
            this.GeneralMenuStrip.Size = new System.Drawing.Size(688, 24);
            this.GeneralMenuStrip.TabIndex = 0;
            this.GeneralMenuStrip.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // новыйТестToolStripMenuItem
            // 
            this.новыйТестToolStripMenuItem.Name = "новыйТестToolStripMenuItem";
            this.новыйТестToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.новыйТестToolStripMenuItem.Text = "Новый тест";
            this.новыйТестToolStripMenuItem.Click += new System.EventHandler(this.новыйТестToolStripMenuItem_Click);
            // 
            // настройкиКурсаToolStripMenuItem
            // 
            this.настройкиКурсаToolStripMenuItem.Name = "настройкиКурсаToolStripMenuItem";
            this.настройкиКурсаToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.настройкиКурсаToolStripMenuItem.Text = "Настройки курса";
            this.настройкиКурсаToolStripMenuItem.Click += new System.EventHandler(this.настройкиКурсаToolStripMenuItem_Click);
            // 
            // выйтиИзКурсаToolStripMenuItem
            // 
            this.выйтиИзКурсаToolStripMenuItem.Name = "выйтиИзКурсаToolStripMenuItem";
            this.выйтиИзКурсаToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.выйтиИзКурсаToolStripMenuItem.Text = "Выйти из курса";
            this.выйтиИзКурсаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзКурсаToolStripMenuItem_Click);
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
            this.TestsDataGridView.Location = new System.Drawing.Point(0, 24);
            this.TestsDataGridView.Name = "TestsDataGridView";
            this.TestsDataGridView.ReadOnly = true;
            this.TestsDataGridView.RowTemplate.Height = 25;
            this.TestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TestsDataGridView.Size = new System.Drawing.Size(688, 340);
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
            // SaveCourseDialog
            // 
            this.SaveCourseDialog.DefaultExt = "course;";
            this.SaveCourseDialog.Filter = "Курсы|*.course";
            // 
            // TeacherCourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 364);
            this.Controls.Add(this.TestsDataGridView);
            this.Controls.Add(this.GeneralMenuStrip);
            this.MainMenuStrip = this.GeneralMenuStrip;
            this.Name = "TeacherCourseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим преподавателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherCourseView_FormClosing);
            this.GeneralMenuStrip.ResumeLayout(false);
            this.GeneralMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip GeneralMenuStrip;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem новыйТестToolStripMenuItem;
        private ToolStripMenuItem настройкиКурсаToolStripMenuItem;
        private ToolStripMenuItem выйтиИзКурсаToolStripMenuItem;
        private DataGridView TestsDataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TestName;
        private SaveFileDialog SaveCourseDialog;
    }
}
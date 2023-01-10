namespace CourseWork
{
    partial class TeacherMode
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CreatingNewCourseButton = new System.Windows.Forms.Button();
            this.OpenCourseButton = new System.Windows.Forms.Button();
            this.CheckTestButton = new System.Windows.Forms.Button();
            this.ReturnToChoiceModeButton = new System.Windows.Forms.Button();
            this.OpenCourseDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenTestDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(26, 52);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(234, 18);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Режим работы: преподаватель";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatingNewCourseButton
            // 
            this.CreatingNewCourseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatingNewCourseButton.Location = new System.Drawing.Point(35, 99);
            this.CreatingNewCourseButton.Name = "CreatingNewCourseButton";
            this.CreatingNewCourseButton.Size = new System.Drawing.Size(213, 38);
            this.CreatingNewCourseButton.TabIndex = 2;
            this.CreatingNewCourseButton.Text = "Создать новый курс";
            this.CreatingNewCourseButton.UseVisualStyleBackColor = true;
            this.CreatingNewCourseButton.Click += new System.EventHandler(this.CreatingNewCourseButton_Click);
            // 
            // OpenCourseButton
            // 
            this.OpenCourseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenCourseButton.Location = new System.Drawing.Point(35, 143);
            this.OpenCourseButton.Name = "OpenCourseButton";
            this.OpenCourseButton.Size = new System.Drawing.Size(213, 38);
            this.OpenCourseButton.TabIndex = 3;
            this.OpenCourseButton.Text = "Открыть существующий курс";
            this.OpenCourseButton.UseVisualStyleBackColor = true;
            this.OpenCourseButton.Click += new System.EventHandler(this.OpenCourseButton_Click);
            // 
            // CheckTestButton
            // 
            this.CheckTestButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckTestButton.Location = new System.Drawing.Point(35, 187);
            this.CheckTestButton.Name = "CheckTestButton";
            this.CheckTestButton.Size = new System.Drawing.Size(213, 38);
            this.CheckTestButton.TabIndex = 4;
            this.CheckTestButton.Text = "Посмотреть результаты теста";
            this.CheckTestButton.UseVisualStyleBackColor = true;
            this.CheckTestButton.Click += new System.EventHandler(this.CheckTestButton_Click);
            // 
            // ReturnToChoiceModeButton
            // 
            this.ReturnToChoiceModeButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnToChoiceModeButton.Location = new System.Drawing.Point(35, 231);
            this.ReturnToChoiceModeButton.Name = "ReturnToChoiceModeButton";
            this.ReturnToChoiceModeButton.Size = new System.Drawing.Size(213, 38);
            this.ReturnToChoiceModeButton.TabIndex = 5;
            this.ReturnToChoiceModeButton.Text = "Вернуться";
            this.ReturnToChoiceModeButton.UseVisualStyleBackColor = true;
            this.ReturnToChoiceModeButton.Click += new System.EventHandler(this.ReturnToChoiceModeButton_Click);
            // 
            // OpenCourseDialog
            // 
            this.OpenCourseDialog.Filter = "Курсы|*.course";
            // 
            // OpenTestDialog
            // 
            this.OpenTestDialog.Filter = "Тесты|*.test";
            // 
            // TeacherMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 307);
            this.Controls.Add(this.ReturnToChoiceModeButton);
            this.Controls.Add(this.CheckTestButton);
            this.Controls.Add(this.OpenCourseButton);
            this.Controls.Add(this.CreatingNewCourseButton);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeacherMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим преподавателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherMode_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InfoLabel;
        private Button CreatingNewCourseButton;
        private Button OpenCourseButton;
        private Button CheckTestButton;
        private Button ReturnToChoiceModeButton;
        private OpenFileDialog OpenCourseDialog;
        private OpenFileDialog OpenTestDialog;
    }
}
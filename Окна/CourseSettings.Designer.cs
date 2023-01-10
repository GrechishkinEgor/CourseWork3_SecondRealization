namespace CourseWork.Окна
{
    partial class CourseSettings
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
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.FinishDevelopmentButton = new System.Windows.Forms.Button();
            this.SettingsCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.TeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SettingsCourseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(12, 12);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(212, 29);
            this.ChangePasswordButton.TabIndex = 0;
            this.ChangePasswordButton.Text = "Сменить пароль преподавателя";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // FinishDevelopmentButton
            // 
            this.FinishDevelopmentButton.Location = new System.Drawing.Point(251, 12);
            this.FinishDevelopmentButton.Name = "FinishDevelopmentButton";
            this.FinishDevelopmentButton.Size = new System.Drawing.Size(212, 29);
            this.FinishDevelopmentButton.TabIndex = 1;
            this.FinishDevelopmentButton.Text = "Завершить разработку курса";
            this.FinishDevelopmentButton.UseVisualStyleBackColor = true;
            this.FinishDevelopmentButton.Click += new System.EventHandler(this.FinishDevelopmentButton_Click);
            // 
            // SettingsCourseGroupBox
            // 
            this.SettingsCourseGroupBox.Controls.Add(this.OKButton);
            this.SettingsCourseGroupBox.Controls.Add(this.TeacherNameTextBox);
            this.SettingsCourseGroupBox.Controls.Add(this.TeacherNameLabel);
            this.SettingsCourseGroupBox.Controls.Add(this.CourseNameTextBox);
            this.SettingsCourseGroupBox.Controls.Add(this.CourseNameLabel);
            this.SettingsCourseGroupBox.Location = new System.Drawing.Point(20, 56);
            this.SettingsCourseGroupBox.Name = "SettingsCourseGroupBox";
            this.SettingsCourseGroupBox.Size = new System.Drawing.Size(443, 143);
            this.SettingsCourseGroupBox.TabIndex = 2;
            this.SettingsCourseGroupBox.TabStop = false;
            this.SettingsCourseGroupBox.Text = "Настройки курса";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CourseNameLabel.Location = new System.Drawing.Point(6, 28);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(100, 15);
            this.CourseNameLabel.TabIndex = 0;
            this.CourseNameLabel.Text = "Название курса:";
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(143, 22);
            this.CourseNameTextBox.MaxLength = 256;
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(294, 23);
            this.CourseNameTextBox.TabIndex = 1;
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeacherNameLabel.Location = new System.Drawing.Point(6, 54);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(126, 15);
            this.TeacherNameLabel.TabIndex = 2;
            this.TeacherNameLabel.Text = "Имя преподавателя:";
            // 
            // TeacherNameTextBox
            // 
            this.TeacherNameTextBox.Location = new System.Drawing.Point(143, 51);
            this.TeacherNameTextBox.MaxLength = 256;
            this.TeacherNameTextBox.Name = "TeacherNameTextBox";
            this.TeacherNameTextBox.Size = new System.Drawing.Size(294, 23);
            this.TeacherNameTextBox.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(171, 103);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(97, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CourseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 211);
            this.Controls.Add(this.SettingsCourseGroupBox);
            this.Controls.Add(this.FinishDevelopmentButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CourseSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки курса";
            this.SettingsCourseGroupBox.ResumeLayout(false);
            this.SettingsCourseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ChangePasswordButton;
        private Button FinishDevelopmentButton;
        private GroupBox SettingsCourseGroupBox;
        private Button OKButton;
        private TextBox TeacherNameTextBox;
        private Label TeacherNameLabel;
        private TextBox CourseNameTextBox;
        private Label CourseNameLabel;
    }
}
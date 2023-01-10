namespace CourseWork.Окна
{
    partial class CreatingNewCourse
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
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.TeacherPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.TeacherPasswordLabel = new System.Windows.Forms.Label();
            this.TeacherNameLabel = new System.Windows.Forms.Label();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GeneralGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.TeacherPasswordTextBox);
            this.GeneralGroupBox.Controls.Add(this.TeacherNameTextBox);
            this.GeneralGroupBox.Controls.Add(this.CourseNameTextBox);
            this.GeneralGroupBox.Controls.Add(this.TeacherPasswordLabel);
            this.GeneralGroupBox.Controls.Add(this.TeacherNameLabel);
            this.GeneralGroupBox.Controls.Add(this.CourseNameLabel);
            this.GeneralGroupBox.Location = new System.Drawing.Point(27, 12);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(444, 112);
            this.GeneralGroupBox.TabIndex = 0;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "Основная информация";
            // 
            // TeacherPasswordTextBox
            // 
            this.TeacherPasswordTextBox.Location = new System.Drawing.Point(158, 81);
            this.TeacherPasswordTextBox.MaxLength = 64;
            this.TeacherPasswordTextBox.Name = "TeacherPasswordTextBox";
            this.TeacherPasswordTextBox.PasswordChar = '*';
            this.TeacherPasswordTextBox.Size = new System.Drawing.Size(280, 23);
            this.TeacherPasswordTextBox.TabIndex = 5;
            // 
            // TeacherNameTextBox
            // 
            this.TeacherNameTextBox.Location = new System.Drawing.Point(158, 52);
            this.TeacherNameTextBox.MaxLength = 256;
            this.TeacherNameTextBox.Name = "TeacherNameTextBox";
            this.TeacherNameTextBox.Size = new System.Drawing.Size(280, 23);
            this.TeacherNameTextBox.TabIndex = 4;
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(158, 20);
            this.CourseNameTextBox.MaxLength = 256;
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(280, 23);
            this.CourseNameTextBox.TabIndex = 3;
            // 
            // TeacherPasswordLabel
            // 
            this.TeacherPasswordLabel.AutoSize = true;
            this.TeacherPasswordLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeacherPasswordLabel.Location = new System.Drawing.Point(7, 81);
            this.TeacherPasswordLabel.Name = "TeacherPasswordLabel";
            this.TeacherPasswordLabel.Size = new System.Drawing.Size(145, 15);
            this.TeacherPasswordLabel.TabIndex = 2;
            this.TeacherPasswordLabel.Text = "Пароль преподавателя:";
            // 
            // TeacherNameLabel
            // 
            this.TeacherNameLabel.AutoSize = true;
            this.TeacherNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeacherNameLabel.Location = new System.Drawing.Point(6, 52);
            this.TeacherNameLabel.Name = "TeacherNameLabel";
            this.TeacherNameLabel.Size = new System.Drawing.Size(126, 15);
            this.TeacherNameLabel.TabIndex = 1;
            this.TeacherNameLabel.Text = "Имя преподавателя:";
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CourseNameLabel.Location = new System.Drawing.Point(7, 20);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(100, 15);
            this.CourseNameLabel.TabIndex = 0;
            this.CourseNameLabel.Text = "Название курса:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(120, 183);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(114, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(264, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreatingNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 228);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.GeneralGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreatingNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового курса";
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GeneralGroupBox;
        private TextBox TeacherPasswordTextBox;
        private TextBox TeacherNameTextBox;
        private TextBox CourseNameTextBox;
        private Label TeacherPasswordLabel;
        private Label TeacherNameLabel;
        private Label CourseNameLabel;
        private Button OKButton;
        private Button CancelButton;
    }
}
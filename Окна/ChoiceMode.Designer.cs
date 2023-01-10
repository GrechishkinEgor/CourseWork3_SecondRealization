namespace CourseWork
{
    partial class ChoiceMode
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
            this.StudentModeButton = new System.Windows.Forms.Button();
            this.TeacherModeButton = new System.Windows.Forms.Button();
            this.ExitApplicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(56, 32);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(177, 36);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Выберите дальнейший \r\nрежим работы";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentModeButton
            // 
            this.StudentModeButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentModeButton.Location = new System.Drawing.Point(47, 92);
            this.StudentModeButton.Name = "StudentModeButton";
            this.StudentModeButton.Size = new System.Drawing.Size(195, 38);
            this.StudentModeButton.TabIndex = 1;
            this.StudentModeButton.Text = "Режим учащегося";
            this.StudentModeButton.UseVisualStyleBackColor = true;
            this.StudentModeButton.Click += new System.EventHandler(this.StudentModeButton_Click);
            // 
            // TeacherModeButton
            // 
            this.TeacherModeButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeacherModeButton.Location = new System.Drawing.Point(47, 136);
            this.TeacherModeButton.Name = "TeacherModeButton";
            this.TeacherModeButton.Size = new System.Drawing.Size(195, 38);
            this.TeacherModeButton.TabIndex = 2;
            this.TeacherModeButton.Text = "Режим преподавателя";
            this.TeacherModeButton.UseVisualStyleBackColor = true;
            this.TeacherModeButton.Click += new System.EventHandler(this.TeacherModeButton_Click);
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitApplicationButton.Location = new System.Drawing.Point(47, 180);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(195, 38);
            this.ExitApplicationButton.TabIndex = 3;
            this.ExitApplicationButton.Text = "Выйти из программы";
            this.ExitApplicationButton.UseVisualStyleBackColor = true;
            this.ExitApplicationButton.Click += new System.EventHandler(this.ExitApplicationButton_Click);
            // 
            // ChoiceMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitApplicationButton);
            this.Controls.Add(this.TeacherModeButton);
            this.Controls.Add(this.StudentModeButton);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChoiceMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор режима работы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChoiceMode_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InfoLabel;
        private Button StudentModeButton;
        private Button TeacherModeButton;
        private Button ExitApplicationButton;
    }
}
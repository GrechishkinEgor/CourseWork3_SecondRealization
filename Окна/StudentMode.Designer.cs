namespace CourseWork
{
    partial class StudentMode
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
            this.OpenCourseButton = new System.Windows.Forms.Button();
            this.ReturnToChoiceModeButton = new System.Windows.Forms.Button();
            this.OpenCourseDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(46, 63);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(191, 18);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Режим работы: учащийся";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenCourseButton
            // 
            this.OpenCourseButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenCourseButton.Location = new System.Drawing.Point(37, 121);
            this.OpenCourseButton.Name = "OpenCourseButton";
            this.OpenCourseButton.Size = new System.Drawing.Size(213, 38);
            this.OpenCourseButton.TabIndex = 4;
            this.OpenCourseButton.Text = "Открыть курс";
            this.OpenCourseButton.UseVisualStyleBackColor = true;
            this.OpenCourseButton.Click += new System.EventHandler(this.OpenCourseButton_Click);
            // 
            // ReturnToChoiceModeButton
            // 
            this.ReturnToChoiceModeButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnToChoiceModeButton.Location = new System.Drawing.Point(37, 165);
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
            // StudentMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ReturnToChoiceModeButton);
            this.Controls.Add(this.OpenCourseButton);
            this.Controls.Add(this.InfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим учащегося";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentMode_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InfoLabel;
        private Button OpenCourseButton;
        private Button ReturnToChoiceModeButton;
        private OpenFileDialog OpenCourseDialog;
    }
}
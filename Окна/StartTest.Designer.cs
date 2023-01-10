namespace CourseWork.Окна
{
    partial class StartTest
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
            this.NameTestLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(12, 41);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(97, 15);
            this.StudentNameLabel.TabIndex = 1;
            this.StudentNameLabel.Text = "Имя учащегося:";
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Enabled = false;
            this.TestNameTextBox.Location = new System.Drawing.Point(111, 6);
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(263, 23);
            this.TestNameTextBox.TabIndex = 2;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(111, 38);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(263, 23);
            this.StudentNameTextBox.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(129, 93);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Начать тест";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 128);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.TestNameTextBox);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.NameTestLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начать тест";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameTestLabel;
        private Label StudentNameLabel;
        private TextBox TestNameTextBox;
        private TextBox StudentNameTextBox;
        private Button StartButton;
    }
}
namespace CourseWork.Окна
{
    partial class CreatingNewTest
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
            this.RandomOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.GeneralGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.RandomOrderCheckBox);
            this.GeneralGroupBox.Controls.Add(this.TestNameTextBox);
            this.GeneralGroupBox.Controls.Add(this.TestNameLabel);
            this.GeneralGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(332, 84);
            this.GeneralGroupBox.TabIndex = 0;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "Параметры теста";
            // 
            // RandomOrderCheckBox
            // 
            this.RandomOrderCheckBox.AutoSize = true;
            this.RandomOrderCheckBox.Location = new System.Drawing.Point(6, 59);
            this.RandomOrderCheckBox.Name = "RandomOrderCheckBox";
            this.RandomOrderCheckBox.Size = new System.Drawing.Size(245, 19);
            this.RandomOrderCheckBox.TabIndex = 2;
            this.RandomOrderCheckBox.Text = "Выдавать задания в случайном порядке";
            this.RandomOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Location = new System.Drawing.Point(105, 21);
            this.TestNameTextBox.MaxLength = 256;
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(221, 23);
            this.TestNameTextBox.TabIndex = 1;
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Location = new System.Drawing.Point(6, 24);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(93, 15);
            this.TestNameLabel.TabIndex = 0;
            this.TestNameLabel.Text = "Название теста:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(128, 126);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(96, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CreatingNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 161);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.GeneralGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreatingNewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый тест";
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GeneralGroupBox;
        private CheckBox RandomOrderCheckBox;
        private TextBox TestNameTextBox;
        private Label TestNameLabel;
        private Button OKButton;
    }
}
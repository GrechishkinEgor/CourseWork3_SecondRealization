using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Окна
{
    using CourseWork.Бэкэнд;
    public partial class StartTest : Form
    {
        private ReadyTest CurrentTest;
        public StartTest(ReadyTest CurrentTest)
        {
            InitializeComponent();
            TestNameTextBox.Text = CurrentTest.GetTestName();
            this.CurrentTest = CurrentTest;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StudentNameTextBox.Text.Trim() == "")
                MessageBox.Show("Не указано имя учащегося.", "Имя учащегося", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    FileStream NewFile = new FileStream(StudentNameTextBox.Text + ".test", FileMode.CreateNew);
                    NewFile.Close();
                }
                catch (IOException)
		        {
                    MessageBox.Show("Учащийся с данным именем уже прошел тест.", "Имя учащегося", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                catch (ArgumentException)
		        {
                    MessageBox.Show("Имя учащегося содержит некорректные символы.", "Имя учащегося", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                CurrentTest.SetStudentName(StudentNameTextBox.Text.Trim());
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            return;
        }
    }
}

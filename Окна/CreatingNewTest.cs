using CourseWork.Бэкэнд;
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
    public partial class CreatingNewTest : Form
    {
        public CreatingNewTest()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (TestNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Не заполнено поле \"Название теста\"", "Название теста", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Test NewTest = new Test(this.TestNameTextBox.Text);
            NewTest.SetRandomOrderFlag(RandomOrderCheckBox.CheckState == CheckState.Checked);
            Course CurrentCourse = CurrentApplicationContext.GetCourse();
            CurrentCourse.AddNewTest(NewTest);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}

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
    public partial class CreatingNewCourse : Form
    {
        public CreatingNewCourse()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e) => Close();

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CourseNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Не заполнено поле \"Название курса\"", "Название курса", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (TeacherNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Не заполнено поле \"Имя преподавателя\"", "Имя преподавателя", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (TeacherPasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Не заполнено поле \"Пароль преподавателя\"", "Пароль преподавателя", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Course NewCourse = new Course(CourseNameTextBox.Text, TeacherNameTextBox.Text, TeacherPasswordTextBox.Text);
            CurrentApplicationContext.SetNewCourse(NewCourse);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

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
    public partial class ChangeTeacherPassword : Form
    {
        public ChangeTeacherPassword()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text != RepeatPasswordTextBox.Text)
                System.Windows.Forms.MessageBox.Show("Поля \"Новый пароль\" и \"Повторите пароль\" не совпадают", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
        if (CurrentApplicationContext.GetCourse().SetNewPassword(OldPasswordTextBox.Text, NewPasswordTextBox.Text))
                this.Close();
            else
                System.Windows.Forms.MessageBox.Show("Введен неверный старый пароль", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

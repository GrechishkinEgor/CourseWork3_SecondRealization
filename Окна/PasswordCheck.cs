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
    public partial class PasswordCheck : Form
    {
        public PasswordCheck()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!CurrentApplicationContext.CheckTeacherPassword(PasswordTextBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Неверный пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PasswordTextBox.Text = "";
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void PasswordTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.OKButton_Click(sender, e);
        }
    }
}

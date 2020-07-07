using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public struct Log
    {
        public string name;
        public string type;
        public string login;
        public string password;
    }
    public partial class FormAutorization : Form
    {
        public static Log login = new Log();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void buttonVoity_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "" && comboBoxVib.Text == "" && textBoxName.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool f = false;
                foreach (Autorization log in Program.PDb.Autorization)
                {
                    if (textBoxLogin.Text == log.Login && textBoxPassword.Text == log.Password && textBoxName.Text == log.Name && comboBoxVib.Text == log.Type)
                    {
                        f = true;
                        login.name = log.Name;
                        login.type = log.Type;
                        login.login = log.Login;
                        login.password = log.Password;
                    }
                }
                if (!f)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxName.Text = "";
                    comboBoxVib.Text = "";
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    FormMenu men = new FormMenu();
                    men.Show();
                    this.Hide();
                }
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Form formreg = new FormRegistration();
            formreg.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

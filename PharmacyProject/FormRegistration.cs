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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Name = textBoxName.Text;
            reg.Login = textBoxLogin.Text;
            reg.Password = textBoxPassword.Text;
            reg.Type = comboBoxVib.Text;
            Autorization aut = new Autorization();
            aut.Name = textBoxName.Text;
            aut.Login = textBoxLogin.Text;
            aut.Password = textBoxPassword.Text;
            aut.Type = comboBoxVib.Text;
            Program.PDb.Registration.Add(reg);
            Program.PDb.Autorization.Add(aut);
            Program.PDb.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonPokup_Click(object sender, EventArgs e)
        {
            Form formp = new FormPokup();
            formp.Show();
        }

        private void buttonMed_Click(object sender, EventArgs e)
        {
            Form formmed = new FormMedecine();
            formmed.Show();
        }
    }
}

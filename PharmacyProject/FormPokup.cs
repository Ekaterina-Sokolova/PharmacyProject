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
    public partial class FormPokup : Form
    {
        public FormPokup()
        {
            InitializeComponent();
            ShowPokup();
        }
        public void ShowPokup()
        {
            listViewPokup.Items.Clear();
            foreach (Pokup po in Program.PDb.Pokup)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    po.Id.ToString(),
                    po.LastName,
                    po.Name,
                    po.MiddleName,
                    po.Phone,
                    po.Mail
                });
                item.Tag = po;
                listViewPokup.Items.Add(item);
            }
            listViewPokup.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPokup.SelectedItems.Count == 1)
            {
                Pokup po = listViewPokup.SelectedItems[0].Tag as Pokup;
                po.LastName = textBoxLastName.Text;
                po.Name = textBoxName.Text;
                po.MiddleName = textBoxMiddleName.Text;
                po.Phone = textBoxPhone.Text;
                po.Mail = textBoxMail.Text;
                Program.PDb.SaveChanges();
                ShowPokup();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pokup po = new Pokup();
            po.LastName = textBoxLastName.Text;
            po.Name = textBoxName.Text;
            po.MiddleName = textBoxMiddleName.Text;
            po.Phone = textBoxPhone.Text;
            po.Mail = textBoxMail.Text;
            Program.PDb.Pokup.Add(po);
            Program.PDb.SaveChanges();
            ShowPokup();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                 if (listViewPokup.SelectedItems.Count == 1)
                 {
                     Pokup po = listViewPokup.SelectedItems[0].Tag as Pokup;
                     Program.PDb.Pokup.Remove(po);
                     Program.PDb.SaveChanges();
                     ShowPokup();
                    }
                 textBoxLastName.Text = "";
                 textBoxName.Text = "";
                 textBoxMiddleName.Text = "";
                 textBoxPhone.Text = "";
                 textBoxMail.Text = ""; 
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPokup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPokup.SelectedItems.Count == 1)
            {
                Pokup po = listViewPokup.SelectedItems[0].Tag as Pokup;
                textBoxLastName.Text = po.LastName;
                textBoxName.Text = po.Name;
                textBoxMiddleName.Text = po.MiddleName;
                textBoxPhone.Text = po.Phone;
                textBoxMail.Text = po.Mail;
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxMail.Text = "";
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }
    }
}

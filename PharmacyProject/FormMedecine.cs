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
    public partial class FormMedecine : Form
    {
        public FormMedecine()
        {
            InitializeComponent();
            ShowMed();
            if (FormAutorization.login.type == "Покупатель")
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
                textBoxName.Enabled = false;
                comboBoxFormRel.Enabled = false;
                textBoxDoza.Enabled = false;
                textBoxManufacturer.Enabled = false;
                textBoxShelfLife.Enabled = false;
            }
        }
        public void ShowMed()
        {
            listViewMed.Items.Clear();
            foreach (Medicine me in Program.PDb.Medicine)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    me.Id.ToString(),
                    me.Name,
                    me.FormRel,
                    me.Doza,
                    me.Manufacturer,
                    me.ShelfLife
                });
                item.Tag = me;
                listViewMed.Items.Add(item);
            }
            listViewMed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicine me = new Medicine();
            me.Name = textBoxName.Text;
            me.FormRel = comboBoxFormRel.Text;
            me.Doza = textBoxDoza.Text;
            me.Manufacturer = textBoxManufacturer.Text;
            me.ShelfLife = textBoxShelfLife.Text;
            Program.PDb.Medicine.Add(me);
            Program.PDb.SaveChanges();
            ShowMed();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMed.SelectedItems.Count == 1)
            {
                Medicine me = listViewMed.SelectedItems[0].Tag as Medicine;
                me.Name = textBoxName.Text;
                me.FormRel = comboBoxFormRel.Text;
                me.Doza = textBoxDoza.Text;
                me.Manufacturer = textBoxManufacturer.Text;
                me.ShelfLife = textBoxShelfLife.Text;
                Program.PDb.SaveChanges();
                ShowMed();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMed.SelectedItems.Count == 1)
                {
                    Medicine me = listViewMed.SelectedItems[0].Tag as Medicine;
                    Program.PDb.Medicine.Remove(me);
                    Program.PDb.SaveChanges();
                    ShowMed();
                }
                textBoxName.Text = "";
                comboBoxFormRel.Text = "";
                textBoxDoza.Text = "";
                textBoxManufacturer.Text = "";
                textBoxShelfLife.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMed.SelectedItems.Count == 1)
            {
                Medicine me = listViewMed.SelectedItems[0].Tag as Medicine;
                textBoxName.Text = me.Name;
                comboBoxFormRel.Text = me.FormRel;
                textBoxDoza.Text = me.Doza;
                textBoxManufacturer.Text = me.Manufacturer;
                textBoxShelfLife.Text = me.ShelfLife;
            }
            else
            {
                textBoxName.Text = "";
                comboBoxFormRel.Text = "";
                textBoxDoza.Text = "";
                textBoxManufacturer.Text = "";
                textBoxShelfLife.Text = "";
            }
        }
    }
}

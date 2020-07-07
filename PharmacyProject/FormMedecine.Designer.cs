namespace PharmacyProject
{
    partial class FormMedecine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelFormRel = new System.Windows.Forms.Label();
            this.labelDoza = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDoza = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxShelfLife = new System.Windows.Forms.TextBox();
            this.comboBoxFormRel = new System.Windows.Forms.ComboBox();
            this.listViewMed = new System.Windows.Forms.ListView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormRel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Man = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shelf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 16);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование";
            // 
            // labelFormRel
            // 
            this.labelFormRel.AutoSize = true;
            this.labelFormRel.Location = new System.Drawing.Point(8, 82);
            this.labelFormRel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormRel.Name = "labelFormRel";
            this.labelFormRel.Size = new System.Drawing.Size(115, 19);
            this.labelFormRel.TabIndex = 1;
            this.labelFormRel.Text = "Форма выпуска";
            // 
            // labelDoza
            // 
            this.labelDoza.AutoSize = true;
            this.labelDoza.Location = new System.Drawing.Point(8, 152);
            this.labelDoza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoza.Name = "labelDoza";
            this.labelDoza.Size = new System.Drawing.Size(81, 19);
            this.labelDoza.TabIndex = 2;
            this.labelDoza.Text = "Дозировка";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(8, 226);
            this.labelManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(118, 19);
            this.labelManufacturer.TabIndex = 3;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Location = new System.Drawing.Point(8, 300);
            this.labelShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(111, 19);
            this.labelShelfLife.TabIndex = 4;
            this.labelShelfLife.Text = "Срок годности";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDoza
            // 
            this.textBoxDoza.Location = new System.Drawing.Point(12, 174);
            this.textBoxDoza.Name = "textBoxDoza";
            this.textBoxDoza.Size = new System.Drawing.Size(180, 27);
            this.textBoxDoza.TabIndex = 6;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(12, 248);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(180, 27);
            this.textBoxManufacturer.TabIndex = 7;
            // 
            // textBoxShelfLife
            // 
            this.textBoxShelfLife.Location = new System.Drawing.Point(12, 322);
            this.textBoxShelfLife.Name = "textBoxShelfLife";
            this.textBoxShelfLife.Size = new System.Drawing.Size(180, 27);
            this.textBoxShelfLife.TabIndex = 8;
            // 
            // comboBoxFormRel
            // 
            this.comboBoxFormRel.FormattingEnabled = true;
            this.comboBoxFormRel.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxFormRel.Location = new System.Drawing.Point(12, 105);
            this.comboBoxFormRel.Name = "comboBoxFormRel";
            this.comboBoxFormRel.Size = new System.Drawing.Size(180, 27);
            this.comboBoxFormRel.TabIndex = 9;
            // 
            // listViewMed
            // 
            this.listViewMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Namee,
            this.FormRel,
            this.Doza,
            this.Man,
            this.Shelf});
            this.listViewMed.FullRowSelect = true;
            this.listViewMed.GridLines = true;
            this.listViewMed.HideSelection = false;
            this.listViewMed.Location = new System.Drawing.Point(224, 16);
            this.listViewMed.MultiSelect = false;
            this.listViewMed.Name = "listViewMed";
            this.listViewMed.Size = new System.Drawing.Size(727, 333);
            this.listViewMed.TabIndex = 10;
            this.listViewMed.UseCompatibleStateImageBehavior = false;
            this.listViewMed.View = System.Windows.Forms.View.Details;
            this.listViewMed.SelectedIndexChanged += new System.EventHandler(this.listViewMed_SelectedIndexChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(757, 381);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(194, 48);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить информацию";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(557, 381);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(194, 48);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить информацию";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(357, 381);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(194, 48);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить информацию";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Namee
            // 
            this.Namee.Text = "Наименование";
            this.Namee.Width = 119;
            // 
            // FormRel
            // 
            this.FormRel.Text = "Форма выпуска";
            this.FormRel.Width = 143;
            // 
            // Doza
            // 
            this.Doza.Text = "Дозировка";
            this.Doza.Width = 101;
            // 
            // Man
            // 
            this.Man.Text = "Производитель";
            this.Man.Width = 123;
            // 
            // Shelf
            // 
            this.Shelf.Text = "Срок годности";
            this.Shelf.Width = 176;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PharmacyProject.Properties.Resources._1234;
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 356);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(76, 73);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMedecine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(963, 441);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMed);
            this.Controls.Add(this.comboBoxFormRel);
            this.Controls.Add(this.textBoxShelfLife);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxDoza);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelDoza);
            this.Controls.Add(this.labelFormRel);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMedecine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лекарства";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFormRel;
        private System.Windows.Forms.Label labelDoza;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDoza;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxShelfLife;
        private System.Windows.Forms.ComboBox comboBoxFormRel;
        private System.Windows.Forms.ListView listViewMed;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Namee;
        private System.Windows.Forms.ColumnHeader FormRel;
        private System.Windows.Forms.ColumnHeader Doza;
        private System.Windows.Forms.ColumnHeader Man;
        private System.Windows.Forms.ColumnHeader Shelf;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
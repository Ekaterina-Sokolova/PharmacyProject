namespace PharmacyProject
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPokup = new System.Windows.Forms.Button();
            this.buttonMed = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPokup
            // 
            this.buttonPokup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonPokup.FlatAppearance.BorderSize = 0;
            this.buttonPokup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPokup.Location = new System.Drawing.Point(13, 174);
            this.buttonPokup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPokup.Name = "buttonPokup";
            this.buttonPokup.Size = new System.Drawing.Size(265, 48);
            this.buttonPokup.TabIndex = 0;
            this.buttonPokup.Text = "Покупатели";
            this.buttonPokup.UseVisualStyleBackColor = false;
            this.buttonPokup.Click += new System.EventHandler(this.buttonPokup_Click);
            // 
            // buttonMed
            // 
            this.buttonMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonMed.FlatAppearance.BorderSize = 0;
            this.buttonMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMed.Location = new System.Drawing.Point(13, 240);
            this.buttonMed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMed.Name = "buttonMed";
            this.buttonMed.Size = new System.Drawing.Size(265, 48);
            this.buttonMed.TabIndex = 1;
            this.buttonMed.Text = "Лекарства";
            this.buttonMed.UseVisualStyleBackColor = false;
            this.buttonMed.Click += new System.EventHandler(this.buttonMed_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PharmacyProject.Properties.Resources._1234;
            this.pictureBoxLogo.Location = new System.Drawing.Point(35, 13);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(220, 139);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 15;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(291, 312);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonMed);
            this.Controls.Add(this.buttonPokup);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPokup;
        private System.Windows.Forms.Button buttonMed;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}


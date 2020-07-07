namespace PharmacyProject
{
    partial class FormAutorization
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
            this.labelAv = new System.Windows.Forms.Label();
            this.buttonVoity = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxVib = new System.Windows.Forms.ComboBox();
            this.labelVib = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAv
            // 
            this.labelAv.AutoSize = true;
            this.labelAv.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAv.Location = new System.Drawing.Point(117, 9);
            this.labelAv.Name = "labelAv";
            this.labelAv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAv.Size = new System.Drawing.Size(148, 29);
            this.labelAv.TabIndex = 0;
            this.labelAv.Text = "Авторизация";
            // 
            // buttonVoity
            // 
            this.buttonVoity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonVoity.FlatAppearance.BorderSize = 0;
            this.buttonVoity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVoity.Location = new System.Drawing.Point(12, 357);
            this.buttonVoity.Name = "buttonVoity";
            this.buttonVoity.Size = new System.Drawing.Size(357, 43);
            this.buttonVoity.TabIndex = 1;
            this.buttonVoity.Text = "Войти";
            this.buttonVoity.UseVisualStyleBackColor = false;
            this.buttonVoity.Click += new System.EventHandler(this.buttonVoity_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReg.Location = new System.Drawing.Point(12, 422);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(357, 43);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(12, 489);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 46);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Выйти из программы";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(40, 128);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 19);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(40, 191);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 19);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(40, 260);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 19);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(44, 150);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(44, 213);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(294, 27);
            this.textBoxLogin.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(44, 282);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(294, 27);
            this.textBoxPassword.TabIndex = 9;
            // 
            // comboBoxVib
            // 
            this.comboBoxVib.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxVib.FormattingEnabled = true;
            this.comboBoxVib.Items.AddRange(new object[] {
            "Фармацевт",
            "Покупатель"});
            this.comboBoxVib.Location = new System.Drawing.Point(100, 82);
            this.comboBoxVib.Name = "comboBoxVib";
            this.comboBoxVib.Size = new System.Drawing.Size(186, 27);
            this.comboBoxVib.TabIndex = 10;
            // 
            // labelVib
            // 
            this.labelVib.AutoSize = true;
            this.labelVib.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVib.Location = new System.Drawing.Point(152, 60);
            this.labelVib.Name = "labelVib";
            this.labelVib.Size = new System.Drawing.Size(81, 19);
            this.labelVib.TabIndex = 11;
            this.labelVib.Text = "Войти как";
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(381, 547);
            this.Controls.Add(this.labelVib);
            this.Controls.Add(this.comboBoxVib);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonVoity);
            this.Controls.Add(this.labelAv);
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAv;
        private System.Windows.Forms.Button buttonVoity;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxVib;
        private System.Windows.Forms.Label labelVib;
    }
}
namespace ProjectCloud
{
    partial class Form1
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
            this.mtb = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mtbSelect = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Alogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Apass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Aremember = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Rlogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rpass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mtb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb
            // 
            this.mtb.Controls.Add(this.tabPage1);
            this.mtb.Controls.Add(this.tabPage2);
            this.mtb.Controls.Add(this.tabPage3);
            this.mtb.Depth = 0;
            this.mtb.Location = new System.Drawing.Point(2, 91);
            this.mtb.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtb.Name = "mtb";
            this.mtb.SelectedIndex = 0;
            this.mtb.Size = new System.Drawing.Size(488, 397);
            this.mtb.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Aremember);
            this.tabPage1.Controls.Add(this.Apass);
            this.tabPage1.Controls.Add(this.Alogin);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialFlatButton2);
            this.tabPage2.Controls.Add(this.mail);
            this.tabPage2.Controls.Add(this.Rpass2);
            this.tabPage2.Controls.Add(this.Rpass);
            this.tabPage2.Controls.Add(this.Rlogin);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mtbSelect
            // 
            this.mtbSelect.BaseTabControl = this.mtb;
            this.mtbSelect.Depth = 0;
            this.mtbSelect.Location = new System.Drawing.Point(2, 67);
            this.mtbSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbSelect.Name = "mtbSelect";
            this.mtbSelect.Size = new System.Drawing.Size(546, 23);
            this.mtbSelect.TabIndex = 1;
            this.mtbSelect.Text = "materialTabSelector1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialFlatButton3);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Восстановление пароля";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(166, 257);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(58, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Войти";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(162, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Логин или Почта";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(162, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Пароль";
            // 
            // Alogin
            // 
            this.Alogin.Depth = 0;
            this.Alogin.Hint = "";
            this.Alogin.Location = new System.Drawing.Point(166, 69);
            this.Alogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Alogin.Name = "Alogin";
            this.Alogin.PasswordChar = '\0';
            this.Alogin.SelectedText = "";
            this.Alogin.SelectionLength = 0;
            this.Alogin.SelectionStart = 0;
            this.Alogin.Size = new System.Drawing.Size(127, 23);
            this.Alogin.TabIndex = 3;
            this.Alogin.UseSystemPasswordChar = false;
            // 
            // Apass
            // 
            this.Apass.Depth = 0;
            this.Apass.Hint = "";
            this.Apass.Location = new System.Drawing.Point(166, 156);
            this.Apass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Apass.Name = "Apass";
            this.Apass.PasswordChar = '\0';
            this.Apass.SelectedText = "";
            this.Apass.SelectionLength = 0;
            this.Apass.SelectionStart = 0;
            this.Apass.Size = new System.Drawing.Size(127, 23);
            this.Apass.TabIndex = 4;
            this.Apass.UseSystemPasswordChar = false;
            // 
            // Aremember
            // 
            this.Aremember.AutoSize = true;
            this.Aremember.Depth = 0;
            this.Aremember.Font = new System.Drawing.Font("Roboto", 10F);
            this.Aremember.Location = new System.Drawing.Point(166, 209);
            this.Aremember.Margin = new System.Windows.Forms.Padding(0);
            this.Aremember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Aremember.MouseState = MaterialSkin.MouseState.HOVER;
            this.Aremember.Name = "Aremember";
            this.Aremember.Ripple = true;
            this.Aremember.Size = new System.Drawing.Size(138, 30);
            this.Aremember.TabIndex = 6;
            this.Aremember.Text = "Запомнить меня";
            this.Aremember.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(142, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Логин";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(142, 94);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Пароль";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(142, 179);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(141, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Повторить пароль";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(143, 266);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Почта";
            // 
            // Rlogin
            // 
            this.Rlogin.Depth = 0;
            this.Rlogin.Hint = "";
            this.Rlogin.Location = new System.Drawing.Point(146, 58);
            this.Rlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rlogin.Name = "Rlogin";
            this.Rlogin.PasswordChar = '\0';
            this.Rlogin.SelectedText = "";
            this.Rlogin.SelectionLength = 0;
            this.Rlogin.SelectionStart = 0;
            this.Rlogin.Size = new System.Drawing.Size(137, 23);
            this.Rlogin.TabIndex = 4;
            this.Rlogin.UseSystemPasswordChar = false;
            // 
            // Rpass
            // 
            this.Rpass.Depth = 0;
            this.Rpass.Hint = "";
            this.Rpass.Location = new System.Drawing.Point(146, 132);
            this.Rpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rpass.Name = "Rpass";
            this.Rpass.PasswordChar = '\0';
            this.Rpass.SelectedText = "";
            this.Rpass.SelectionLength = 0;
            this.Rpass.SelectionStart = 0;
            this.Rpass.Size = new System.Drawing.Size(137, 23);
            this.Rpass.TabIndex = 5;
            this.Rpass.UseSystemPasswordChar = false;
            // 
            // Rpass2
            // 
            this.Rpass2.Depth = 0;
            this.Rpass2.Hint = "";
            this.Rpass2.Location = new System.Drawing.Point(146, 217);
            this.Rpass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rpass2.Name = "Rpass2";
            this.Rpass2.PasswordChar = '\0';
            this.Rpass2.SelectedText = "";
            this.Rpass2.SelectionLength = 0;
            this.Rpass2.SelectionStart = 0;
            this.Rpass2.Size = new System.Drawing.Size(137, 23);
            this.Rpass2.TabIndex = 6;
            this.Rpass2.UseSystemPasswordChar = false;
            // 
            // mail
            // 
            this.mail.Depth = 0;
            this.mail.Hint = "";
            this.mail.Location = new System.Drawing.Point(146, 295);
            this.mail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mail.Name = "mail";
            this.mail.PasswordChar = '\0';
            this.mail.SelectedText = "";
            this.mail.SelectionLength = 0;
            this.mail.SelectionStart = 0;
            this.mail.Size = new System.Drawing.Size(137, 23);
            this.mail.TabIndex = 7;
            this.mail.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(160, 331);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(110, 36);
            this.materialFlatButton2.TabIndex = 8;
            this.materialFlatButton2.Text = "Регистрация";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(158, 39);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(131, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Почта или Логин";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(162, 82);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(127, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(162, 132);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "Восстановить";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 489);
            this.Controls.Add(this.mtbSelect);
            this.Controls.Add(this.mtb);
            this.Name = "Form1";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mtb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector mtbSelect;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Apass;
        private MaterialSkin.Controls.MaterialSingleLineTextField Alogin;
        private MaterialSkin.Controls.MaterialCheckBox Aremember;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField mail;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rpass2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rpass;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rlogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}


﻿namespace ProjectCloud
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
            this.components = new System.ComponentModel.Container();
            this.mtb = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.AuthOffline = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Aremember = new MaterialSkin.Controls.MaterialCheckBox();
            this.Apass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Auth = new MaterialSkin.Controls.MaterialFlatButton();
            this.Alogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resetCaptch = new System.Windows.Forms.Button();
            this.captch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hardpass = new MaterialSkin.Controls.MaterialLabel();
            this.registr = new MaterialSkin.Controls.MaterialFlatButton();
            this.Rmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rpass2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rlogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RestorePass = new MaterialSkin.Controls.MaterialFlatButton();
            this.restore = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.mtbSelect = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mtb.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb
            // 
            this.mtb.Controls.Add(this.tabPage1);
            this.mtb.Controls.Add(this.tabPage2);
            this.mtb.Controls.Add(this.tabPage3);
            this.mtb.Depth = 0;
            this.mtb.Location = new System.Drawing.Point(2, 81);
            this.mtb.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtb.Name = "mtb";
            this.mtb.SelectedIndex = 0;
            this.mtb.Size = new System.Drawing.Size(488, 407);
            this.mtb.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Controls.Add(this.AuthOffline);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Aremember);
            this.tabPage1.Controls.Add(this.Apass);
            this.tabPage1.Controls.Add(this.Auth);
            this.tabPage1.Controls.Add(this.Alogin);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(370, 365);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(110, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "О программе";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // AuthOffline
            // 
            this.AuthOffline.AutoSize = true;
            this.AuthOffline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AuthOffline.Depth = 0;
            this.AuthOffline.Location = new System.Drawing.Point(166, 285);
            this.AuthOffline.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AuthOffline.MouseState = MaterialSkin.MouseState.HOVER;
            this.AuthOffline.Name = "AuthOffline";
            this.AuthOffline.Primary = false;
            this.AuthOffline.Size = new System.Drawing.Size(147, 36);
            this.AuthOffline.TabIndex = 8;
            this.AuthOffline.Text = "Войти Автономно";
            this.AuthOffline.UseVisualStyleBackColor = true;
            this.AuthOffline.Click += new System.EventHandler(this.AuthOffline_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aremember
            // 
            this.Aremember.AutoSize = true;
            this.Aremember.Depth = 0;
            this.Aremember.Font = new System.Drawing.Font("Roboto", 10F);
            this.Aremember.Location = new System.Drawing.Point(166, 191);
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
            // Apass
            // 
            this.Apass.Depth = 0;
            this.Apass.Hint = "";
            this.Apass.Location = new System.Drawing.Point(166, 156);
            this.Apass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Apass.Name = "Apass";
            this.Apass.PasswordChar = '*';
            this.Apass.SelectedText = "";
            this.Apass.SelectionLength = 0;
            this.Apass.SelectionStart = 0;
            this.Apass.Size = new System.Drawing.Size(127, 23);
            this.Apass.TabIndex = 4;
            this.Apass.UseSystemPasswordChar = false;
            // 
            // Auth
            // 
            this.Auth.AutoSize = true;
            this.Auth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Auth.Depth = 0;
            this.Auth.Location = new System.Drawing.Point(166, 237);
            this.Auth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Auth.MouseState = MaterialSkin.MouseState.HOVER;
            this.Auth.Name = "Auth";
            this.Auth.Primary = false;
            this.Auth.Size = new System.Drawing.Size(58, 36);
            this.Auth.TabIndex = 0;
            this.Auth.Text = "Войти";
            this.Auth.UseVisualStyleBackColor = true;
            this.Auth.Click += new System.EventHandler(this.Auth_Click);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.resetCaptch);
            this.tabPage2.Controls.Add(this.captch);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.hardpass);
            this.tabPage2.Controls.Add(this.registr);
            this.tabPage2.Controls.Add(this.Rmail);
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
            this.tabPage2.Size = new System.Drawing.Size(480, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            // 
            // resetCaptch
            // 
            this.resetCaptch.Location = new System.Drawing.Point(294, 238);
            this.resetCaptch.Name = "resetCaptch";
            this.resetCaptch.Size = new System.Drawing.Size(75, 23);
            this.resetCaptch.TabIndex = 12;
            this.resetCaptch.Text = "обновить";
            this.resetCaptch.UseVisualStyleBackColor = true;
            this.resetCaptch.Click += new System.EventHandler(this.resetCaptch_Click);
            // 
            // captch
            // 
            this.captch.Depth = 0;
            this.captch.Hint = "";
            this.captch.Location = new System.Drawing.Point(294, 286);
            this.captch.MouseState = MaterialSkin.MouseState.HOVER;
            this.captch.Name = "captch";
            this.captch.PasswordChar = '\0';
            this.captch.SelectedText = "";
            this.captch.SelectionLength = 0;
            this.captch.SelectionStart = 0;
            this.captch.Size = new System.Drawing.Size(131, 23);
            this.captch.TabIndex = 11;
            this.captch.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(294, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // hardpass
            // 
            this.hardpass.AutoSize = true;
            this.hardpass.Depth = 0;
            this.hardpass.Font = new System.Drawing.Font("Roboto", 11F);
            this.hardpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hardpass.Location = new System.Drawing.Point(290, 132);
            this.hardpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hardpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.hardpass.Name = "hardpass";
            this.hardpass.Size = new System.Drawing.Size(0, 19);
            this.hardpass.TabIndex = 9;
            // 
            // registr
            // 
            this.registr.AutoSize = true;
            this.registr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registr.Depth = 0;
            this.registr.Location = new System.Drawing.Point(5, 330);
            this.registr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registr.MouseState = MaterialSkin.MouseState.HOVER;
            this.registr.Name = "registr";
            this.registr.Primary = false;
            this.registr.Size = new System.Drawing.Size(170, 36);
            this.registr.TabIndex = 8;
            this.registr.Text = "Зарегистрироваться";
            this.registr.UseVisualStyleBackColor = true;
            this.registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // Rmail
            // 
            this.Rmail.Depth = 0;
            this.Rmail.Hint = "";
            this.Rmail.Location = new System.Drawing.Point(9, 286);
            this.Rmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rmail.Name = "Rmail";
            this.Rmail.PasswordChar = '\0';
            this.Rmail.SelectedText = "";
            this.Rmail.SelectionLength = 0;
            this.Rmail.SelectionStart = 0;
            this.Rmail.Size = new System.Drawing.Size(265, 23);
            this.Rmail.TabIndex = 7;
            this.Rmail.UseSystemPasswordChar = false;
            // 
            // Rpass2
            // 
            this.Rpass2.Depth = 0;
            this.Rpass2.Hint = "";
            this.Rpass2.Location = new System.Drawing.Point(9, 208);
            this.Rpass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rpass2.Name = "Rpass2";
            this.Rpass2.PasswordChar = '*';
            this.Rpass2.SelectedText = "";
            this.Rpass2.SelectionLength = 0;
            this.Rpass2.SelectionStart = 0;
            this.Rpass2.Size = new System.Drawing.Size(265, 23);
            this.Rpass2.TabIndex = 6;
            this.Rpass2.UseSystemPasswordChar = false;
            // 
            // Rpass
            // 
            this.Rpass.Depth = 0;
            this.Rpass.Hint = "";
            this.Rpass.Location = new System.Drawing.Point(9, 132);
            this.Rpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rpass.Name = "Rpass";
            this.Rpass.PasswordChar = '*';
            this.Rpass.SelectedText = "";
            this.Rpass.SelectionLength = 0;
            this.Rpass.SelectionStart = 0;
            this.Rpass.Size = new System.Drawing.Size(265, 23);
            this.Rpass.TabIndex = 5;
            this.Rpass.UseSystemPasswordChar = false;
            this.Rpass.TextChanged += new System.EventHandler(this.Rpass_TextChanged);
            // 
            // Rlogin
            // 
            this.Rlogin.Depth = 0;
            this.Rlogin.Hint = "";
            this.Rlogin.Location = new System.Drawing.Point(6, 52);
            this.Rlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rlogin.Name = "Rlogin";
            this.Rlogin.PasswordChar = '\0';
            this.Rlogin.SelectedText = "";
            this.Rlogin.SelectionLength = 0;
            this.Rlogin.SelectionStart = 0;
            this.Rlogin.Size = new System.Drawing.Size(268, 23);
            this.Rlogin.TabIndex = 4;
            this.Rlogin.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 257);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Почта";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(4, 170);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(141, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Повторить пароль";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 96);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Пароль";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Логин";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.RestorePass);
            this.tabPage3.Controls.Add(this.restore);
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Восстановление пароля";
            // 
            // RestorePass
            // 
            this.RestorePass.AutoSize = true;
            this.RestorePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestorePass.Depth = 0;
            this.RestorePass.Location = new System.Drawing.Point(161, 131);
            this.RestorePass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RestorePass.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestorePass.Name = "RestorePass";
            this.RestorePass.Primary = false;
            this.RestorePass.Size = new System.Drawing.Size(120, 36);
            this.RestorePass.TabIndex = 2;
            this.RestorePass.Text = "Восстановить";
            this.RestorePass.UseVisualStyleBackColor = true;
            this.RestorePass.Click += new System.EventHandler(this.RestorePass_Click);
            // 
            // restore
            // 
            this.restore.Depth = 0;
            this.restore.Hint = "";
            this.restore.Location = new System.Drawing.Point(161, 78);
            this.restore.MouseState = MaterialSkin.MouseState.HOVER;
            this.restore.Name = "restore";
            this.restore.PasswordChar = '\0';
            this.restore.SelectedText = "";
            this.restore.SelectionLength = 0;
            this.restore.SelectionStart = 0;
            this.restore.Size = new System.Drawing.Size(127, 23);
            this.restore.TabIndex = 1;
            this.restore.UseSystemPasswordChar = false;
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
            // mtbSelect
            // 
            this.mtbSelect.BaseTabControl = this.mtb;
            this.mtbSelect.Depth = 0;
            this.mtbSelect.Location = new System.Drawing.Point(2, 52);
            this.mtbSelect.MaximumSize = new System.Drawing.Size(488, 23);
            this.mtbSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbSelect.Name = "mtbSelect";
            this.mtbSelect.Size = new System.Drawing.Size(488, 23);
            this.mtbSelect.TabIndex = 1;
            this.mtbSelect.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 489);
            this.Controls.Add(this.mtbSelect);
            this.Controls.Add(this.mtb);
            this.MaximumSize = new System.Drawing.Size(491, 489);
            this.MinimumSize = new System.Drawing.Size(491, 489);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mtb.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MaterialSkin.Controls.MaterialFlatButton Auth;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Apass;
        private MaterialSkin.Controls.MaterialSingleLineTextField Alogin;
        private MaterialSkin.Controls.MaterialCheckBox Aremember;
        private MaterialSkin.Controls.MaterialFlatButton registr;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rpass2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rpass;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rlogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton RestorePass;
        private MaterialSkin.Controls.MaterialSingleLineTextField restore;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel hardpass;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialSingleLineTextField captch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resetCaptch;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialFlatButton AuthOffline;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}


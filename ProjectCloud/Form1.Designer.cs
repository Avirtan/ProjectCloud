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
            this.components = new System.ComponentModel.Container();
            this.mtb = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Aremember = new MaterialSkin.Controls.MaterialCheckBox();
            this.Apass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Auth = new MaterialSkin.Controls.MaterialFlatButton();
            this.Alogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.mtbSelect = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.mtb.Location = new System.Drawing.Point(3, 100);
            this.mtb.Margin = new System.Windows.Forms.Padding(4);
            this.mtb.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtb.Name = "mtb";
            this.mtb.SelectedIndex = 0;
            this.mtb.Size = new System.Drawing.Size(651, 501);
            this.mtb.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Aremember);
            this.tabPage1.Controls.Add(this.Apass);
            this.tabPage1.Controls.Add(this.Auth);
            this.tabPage1.Controls.Add(this.Alogin);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(643, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            // 
            // Aremember
            // 
            this.Aremember.AutoSize = true;
            this.Aremember.Depth = 0;
            this.Aremember.Font = new System.Drawing.Font("Roboto", 10F);
            this.Aremember.Location = new System.Drawing.Point(221, 257);
            this.Aremember.Margin = new System.Windows.Forms.Padding(0);
            this.Aremember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Aremember.MouseState = MaterialSkin.MouseState.HOVER;
            this.Aremember.Name = "Aremember";
            this.Aremember.Ripple = true;
            this.Aremember.Size = new System.Drawing.Size(167, 30);
            this.Aremember.TabIndex = 6;
            this.Aremember.Text = "Запомнить меня";
            this.Aremember.UseVisualStyleBackColor = true;
            // 
            // Apass
            // 
            this.Apass.Depth = 0;
            this.Apass.Hint = "";
            this.Apass.Location = new System.Drawing.Point(221, 192);
            this.Apass.Margin = new System.Windows.Forms.Padding(4);
            this.Apass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Apass.Name = "Apass";
            this.Apass.PasswordChar = '\0';
            this.Apass.SelectedText = "";
            this.Apass.SelectionLength = 0;
            this.Apass.SelectionStart = 0;
            this.Apass.Size = new System.Drawing.Size(169, 28);
            this.Apass.TabIndex = 4;
            this.Apass.UseSystemPasswordChar = false;
            // 
            // Auth
            // 
            this.Auth.AutoSize = true;
            this.Auth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Auth.Depth = 0;
            this.Auth.Location = new System.Drawing.Point(221, 316);
            this.Auth.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Auth.MouseState = MaterialSkin.MouseState.HOVER;
            this.Auth.Name = "Auth";
            this.Auth.Primary = false;
            this.Auth.Size = new System.Drawing.Size(70, 36);
            this.Auth.TabIndex = 0;
            this.Auth.Text = "Войти";
            this.Auth.UseVisualStyleBackColor = true;
            this.Auth.Click += new System.EventHandler(this.Auth_Click);
            // 
            // Alogin
            // 
            this.Alogin.Depth = 0;
            this.Alogin.Hint = "";
            this.Alogin.Location = new System.Drawing.Point(221, 85);
            this.Alogin.Margin = new System.Windows.Forms.Padding(4);
            this.Alogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Alogin.Name = "Alogin";
            this.Alogin.PasswordChar = '\0';
            this.Alogin.SelectedText = "";
            this.Alogin.SelectionLength = 0;
            this.Alogin.SelectionStart = 0;
            this.Alogin.Size = new System.Drawing.Size(169, 28);
            this.Alogin.TabIndex = 3;
            this.Alogin.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(216, 139);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Пароль";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(216, 27);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Логин или Почта";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(643, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            // 
            // hardpass
            // 
            this.hardpass.AutoSize = true;
            this.hardpass.Depth = 0;
            this.hardpass.Font = new System.Drawing.Font("Roboto", 11F);
            this.hardpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hardpass.Location = new System.Drawing.Point(387, 163);
            this.hardpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.hardpass.Name = "hardpass";
            this.hardpass.Size = new System.Drawing.Size(0, 24);
            this.hardpass.TabIndex = 9;
            // 
            // registr
            // 
            this.registr.AutoSize = true;
            this.registr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registr.Depth = 0;
            this.registr.Location = new System.Drawing.Point(12, 391);
            this.registr.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.registr.MouseState = MaterialSkin.MouseState.HOVER;
            this.registr.Name = "registr";
            this.registr.Primary = false;
            this.registr.Size = new System.Drawing.Size(135, 36);
            this.registr.TabIndex = 8;
            this.registr.Text = "Регистрация";
            this.registr.UseVisualStyleBackColor = true;
            this.registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // Rmail
            // 
            this.Rmail.Depth = 0;
            this.Rmail.Hint = "";
            this.Rmail.Location = new System.Drawing.Point(12, 352);
            this.Rmail.Margin = new System.Windows.Forms.Padding(4);
            this.Rmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rmail.Name = "Rmail";
            this.Rmail.PasswordChar = '\0';
            this.Rmail.SelectedText = "";
            this.Rmail.SelectionLength = 0;
            this.Rmail.SelectionStart = 0;
            this.Rmail.Size = new System.Drawing.Size(436, 28);
            this.Rmail.TabIndex = 7;
            this.Rmail.UseSystemPasswordChar = false;
            // 
            // Rpass2
            // 
            this.Rpass2.Depth = 0;
            this.Rpass2.Hint = "";
            this.Rpass2.Location = new System.Drawing.Point(12, 256);
            this.Rpass2.Margin = new System.Windows.Forms.Padding(4);
            this.Rpass2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rpass2.Name = "Rpass2";
            this.Rpass2.PasswordChar = '\0';
            this.Rpass2.SelectedText = "";
            this.Rpass2.SelectionLength = 0;
            this.Rpass2.SelectionStart = 0;
            this.Rpass2.Size = new System.Drawing.Size(436, 28);
            this.Rpass2.TabIndex = 6;
            this.Rpass2.UseSystemPasswordChar = false;
            // 
            // Rpass
            // 
            this.Rpass.Depth = 0;
            this.Rpass.Hint = "";
            this.Rpass.Location = new System.Drawing.Point(12, 163);
            this.Rpass.Margin = new System.Windows.Forms.Padding(4);
            this.Rpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rpass.Name = "Rpass";
            this.Rpass.PasswordChar = '*';
            this.Rpass.SelectedText = "";
            this.Rpass.SelectionLength = 0;
            this.Rpass.SelectionStart = 0;
            this.Rpass.Size = new System.Drawing.Size(436, 28);
            this.Rpass.TabIndex = 5;
            this.Rpass.UseSystemPasswordChar = false;
            this.Rpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rpass_KeyPress);
            // 
            // Rlogin
            // 
            this.Rlogin.Depth = 0;
            this.Rlogin.Hint = "";
            this.Rlogin.Location = new System.Drawing.Point(8, 64);
            this.Rlogin.Margin = new System.Windows.Forms.Padding(4);
            this.Rlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rlogin.Name = "Rlogin";
            this.Rlogin.PasswordChar = '\0';
            this.Rlogin.SelectedText = "";
            this.Rlogin.SelectionLength = 0;
            this.Rlogin.SelectionStart = 0;
            this.Rlogin.Size = new System.Drawing.Size(440, 28);
            this.Rlogin.TabIndex = 4;
            this.Rlogin.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(8, 316);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 24);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Почта";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 209);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(176, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Повторить пароль";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 118);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Пароль";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 36);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(64, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Логин";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.RestorePass);
            this.tabPage3.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage3.Controls.Add(this.materialLabel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(643, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Восстановление пароля";
            // 
            // RestorePass
            // 
            this.RestorePass.AutoSize = true;
            this.RestorePass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestorePass.Depth = 0;
            this.RestorePass.Location = new System.Drawing.Point(215, 161);
            this.RestorePass.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.RestorePass.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestorePass.Name = "RestorePass";
            this.RestorePass.Primary = false;
            this.RestorePass.Size = new System.Drawing.Size(148, 36);
            this.RestorePass.TabIndex = 2;
            this.RestorePass.Text = "Восстановить";
            this.RestorePass.UseVisualStyleBackColor = true;
            this.RestorePass.Click += new System.EventHandler(this.RestorePass_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(215, 96);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(4);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(169, 28);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(211, 48);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(161, 24);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Почта или Логин";
            // 
            // mtbSelect
            // 
            this.mtbSelect.BaseTabControl = this.mtb;
            this.mtbSelect.Depth = 0;
            this.mtbSelect.Location = new System.Drawing.Point(3, 64);
            this.mtbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.mtbSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbSelect.Name = "mtbSelect";
            this.mtbSelect.Size = new System.Drawing.Size(651, 28);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 602);
            this.Controls.Add(this.mtbSelect);
            this.Controls.Add(this.mtb);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel hardpass;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace ProjectCloud
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Локальные", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Глобальные", System.Windows.Forms.HorizontalAlignment.Left);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FileView = new System.Windows.Forms.ListView();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.посмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.извлечьВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationFile = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.SeeFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.Down = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.SeeUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.Sync = new MaterialSkin.Controls.MaterialFlatButton();
            this.Upload = new MaterialSkin.Controls.MaterialFlatButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbUserId = new System.Windows.Forms.ComboBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DeleteUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.hideTable = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialContextMenuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Local1.jpg");
            this.imageList1.Images.SetKeyName(1, "gLobal.jpg");
            // 
            // FileView
            // 
            this.FileView.ContextMenuStrip = this.materialContextMenuStrip1;
            listViewGroup1.Header = "Локальные";
            listViewGroup1.Name = "local";
            listViewGroup2.Header = "Глобальные";
            listViewGroup2.Name = "global";
            this.FileView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.FileView.LargeImageList = this.imageList1;
            this.FileView.Location = new System.Drawing.Point(252, 64);
            this.FileView.Margin = new System.Windows.Forms.Padding(2);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(553, 397);
            this.FileView.SmallImageList = this.imageList1;
            this.FileView.TabIndex = 1;
            this.FileView.UseCompatibleStateImageBehavior = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.извлечьВToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(138, 92);
            // 
            // посмотретьToolStripMenuItem
            // 
            this.посмотретьToolStripMenuItem.Name = "посмотретьToolStripMenuItem";
            this.посмотретьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.посмотретьToolStripMenuItem.Text = "Посмотреть";
            this.посмотретьToolStripMenuItem.Click += new System.EventHandler(this.SeeFile_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // извлечьВToolStripMenuItem
            // 
            this.извлечьВToolStripMenuItem.Name = "извлечьВToolStripMenuItem";
            this.извлечьВToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.извлечьВToolStripMenuItem.Text = "Извлечь в";
            this.извлечьВToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.InformationFile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeeToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.ExtractToolStripMenuItem,
            this.InformationFile});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 92);
            // 
            // SeeToolStripMenuItem
            // 
            this.SeeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.SeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SeeToolStripMenuItem.Name = "SeeToolStripMenuItem";
            this.SeeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.SeeToolStripMenuItem.Text = "Посмотреть";
            this.SeeToolStripMenuItem.Click += new System.EventHandler(this.SeeFile_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // ExtractToolStripMenuItem
            // 
            this.ExtractToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ExtractToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExtractToolStripMenuItem.Name = "ExtractToolStripMenuItem";
            this.ExtractToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ExtractToolStripMenuItem.Text = "Извелчь в папку";
            this.ExtractToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
            // 
            // InformationFile
            // 
            this.InformationFile.BackColor = System.Drawing.Color.Black;
            this.InformationFile.ForeColor = System.Drawing.Color.White;
            this.InformationFile.Name = "InformationFile";
            this.InformationFile.Size = new System.Drawing.Size(158, 22);
            this.InformationFile.Text = "Информация";
            this.InformationFile.Click += new System.EventHandler(this.InformationFile_Click);
            // 
            // RefreshFile
            // 
            this.RefreshFile.AutoSize = true;
            this.RefreshFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshFile.Depth = 0;
            this.RefreshFile.Location = new System.Drawing.Point(12, 66);
            this.RefreshFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefreshFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshFile.Name = "RefreshFile";
            this.RefreshFile.Primary = false;
            this.RefreshFile.Size = new System.Drawing.Size(140, 36);
            this.RefreshFile.TabIndex = 4;
            this.RefreshFile.Text = "Обновить файлы";
            this.RefreshFile.UseVisualStyleBackColor = true;
            this.RefreshFile.Click += new System.EventHandler(this.RefreshFile_Click);
            // 
            // SeeFile
            // 
            this.SeeFile.AutoSize = true;
            this.SeeFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeFile.Depth = 0;
            this.SeeFile.Location = new System.Drawing.Point(13, 110);
            this.SeeFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SeeFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeeFile.Name = "SeeFile";
            this.SeeFile.Primary = false;
            this.SeeFile.Size = new System.Drawing.Size(146, 36);
            this.SeeFile.TabIndex = 5;
            this.SeeFile.Text = "Посмотреть файл";
            this.SeeFile.UseVisualStyleBackColor = true;
            this.SeeFile.Click += new System.EventHandler(this.SeeFile_Click);
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Down.Depth = 0;
            this.Down.Location = new System.Drawing.Point(12, 158);
            this.Down.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Down.MouseState = MaterialSkin.MouseState.HOVER;
            this.Down.Name = "Down";
            this.Down.Primary = false;
            this.Down.Size = new System.Drawing.Size(117, 36);
            this.Down.TabIndex = 6;
            this.Down.Text = "Скачать файл";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // AddFile
            // 
            this.AddFile.AutoSize = true;
            this.AddFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddFile.Depth = 0;
            this.AddFile.Location = new System.Drawing.Point(0, 4);
            this.AddFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddFile.Name = "AddFile";
            this.AddFile.Primary = false;
            this.AddFile.Size = new System.Drawing.Size(128, 36);
            this.AddFile.TabIndex = 7;
            this.AddFile.Text = "Добавить файл \r\n";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // DeleteFile
            // 
            this.DeleteFile.AutoSize = true;
            this.DeleteFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteFile.Depth = 0;
            this.DeleteFile.Location = new System.Drawing.Point(1, 102);
            this.DeleteFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Primary = false;
            this.DeleteFile.Size = new System.Drawing.Size(119, 36);
            this.DeleteFile.TabIndex = 8;
            this.DeleteFile.Text = "Удалить файл";
            this.DeleteFile.UseVisualStyleBackColor = true;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // SeeUser
            // 
            this.SeeUser.AutoSize = true;
            this.SeeUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeUser.Depth = 0;
            this.SeeUser.Location = new System.Drawing.Point(2, 198);
            this.SeeUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SeeUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeeUser.Name = "SeeUser";
            this.SeeUser.Primary = false;
            this.SeeUser.Size = new System.Drawing.Size(223, 36);
            this.SeeUser.TabIndex = 9;
            this.SeeUser.Text = "Посмотреть пользователей";
            this.SeeUser.UseVisualStyleBackColor = true;
            this.SeeUser.Click += new System.EventHandler(this.SeeUser_Click);
            // 
            // Sync
            // 
            this.Sync.AutoSize = true;
            this.Sync.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sync.Depth = 0;
            this.Sync.Location = new System.Drawing.Point(2, 150);
            this.Sync.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Sync.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sync.Name = "Sync";
            this.Sync.Primary = false;
            this.Sync.Size = new System.Drawing.Size(133, 36);
            this.Sync.TabIndex = 10;
            this.Sync.Text = "Синхронизация";
            this.Sync.UseVisualStyleBackColor = true;
            this.Sync.Click += new System.EventHandler(this.Sync_Click);
            // 
            // Upload
            // 
            this.Upload.AutoSize = true;
            this.Upload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Upload.Depth = 0;
            this.Upload.Location = new System.Drawing.Point(0, 52);
            this.Upload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Upload.MouseState = MaterialSkin.MouseState.HOVER;
            this.Upload.Name = "Upload";
            this.Upload.Primary = false;
            this.Upload.Size = new System.Drawing.Size(132, 36);
            this.Upload.TabIndex = 11;
            this.Upload.Text = "Загрузить файл";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Upload);
            this.Panel1.Controls.Add(this.AddFile);
            this.Panel1.Controls.Add(this.DeleteFile);
            this.Panel1.Controls.Add(this.Sync);
            this.Panel1.Controls.Add(this.SeeUser);
            this.Panel1.Location = new System.Drawing.Point(12, 206);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(225, 230);
            this.Panel1.TabIndex = 12;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvUser.Location = new System.Drawing.Point(810, 64);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(240, 397);
            this.dgvUser.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Логин";
            this.Column2.Name = "Column2";
            // 
            // cbUserId
            // 
            this.cbUserId.FormattingEnabled = true;
            this.cbUserId.Location = new System.Drawing.Point(1056, 92);
            this.cbUserId.Name = "cbUserId";
            this.cbUserId.Size = new System.Drawing.Size(121, 21);
            this.cbUserId.TabIndex = 15;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(1055, 67);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(121, 23);
            this.materialSingleLineTextField1.TabIndex = 16;
            this.materialSingleLineTextField1.Text = "ID пользователя";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteUser.Depth = 0;
            this.DeleteUser.Location = new System.Drawing.Point(1057, 120);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Primary = false;
            this.DeleteUser.Size = new System.Drawing.Size(76, 36);
            this.DeleteUser.TabIndex = 17;
            this.DeleteUser.Text = "Удалить";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // hideTable
            // 
            this.hideTable.AutoSize = true;
            this.hideTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hideTable.Depth = 0;
            this.hideTable.Location = new System.Drawing.Point(1055, 168);
            this.hideTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.hideTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.hideTable.Name = "hideTable";
            this.hideTable.Primary = false;
            this.hideTable.Size = new System.Drawing.Size(67, 36);
            this.hideTable.TabIndex = 18;
            this.hideTable.Text = "Скрыть";
            this.hideTable.UseVisualStyleBackColor = true;
            this.hideTable.Click += new System.EventHandler(this.hideTable_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 465);
            this.Controls.Add(this.hideTable);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.cbUserId);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.SeeFile);
            this.Controls.Add(this.RefreshFile);
            this.Controls.Add(this.FileView);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файл Сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView FileView;
        private MaterialSkin.Controls.MaterialFlatButton RefreshFile;
        private MaterialSkin.Controls.MaterialFlatButton SeeFile;
        private MaterialSkin.Controls.MaterialFlatButton Down;
        private MaterialSkin.Controls.MaterialFlatButton AddFile;
        private MaterialSkin.Controls.MaterialFlatButton DeleteFile;
        private MaterialSkin.Controls.MaterialFlatButton SeeUser;
        private MaterialSkin.Controls.MaterialFlatButton Sync;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformationFile;
        private System.Windows.Forms.ToolStripMenuItem ExtractToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton Upload;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridView dgvUser;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem посмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem извлечьВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbUserId;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton DeleteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MaterialSkin.Controls.MaterialFlatButton hideTable;
    }
}
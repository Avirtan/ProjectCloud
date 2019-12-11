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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.SeeFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.Down = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.SeeUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.Sync = new MaterialSkin.Controls.MaterialFlatButton();
            this.Upload = new MaterialSkin.Controls.MaterialFlatButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "gLobal.jpg");
            this.imageList1.Images.SetKeyName(1, "Local1.jpg");
            // 
            // FileView
            // 
            this.FileView.ContextMenuStrip = this.contextMenuStrip1;
            listViewGroup1.Header = "Локальные";
            listViewGroup1.Name = "local";
            listViewGroup2.Header = "Глобальные";
            listViewGroup2.Name = "global";
            this.FileView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.FileView.HideSelection = false;
            this.FileView.LargeImageList = this.imageList1;
            this.FileView.Location = new System.Drawing.Point(252, 64);
            this.FileView.Margin = new System.Windows.Forms.Padding(2);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(553, 397);
            this.FileView.SmallImageList = this.imageList2;
            this.FileView.TabIndex = 1;
            this.FileView.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDownMenuItem,
            this.SeeToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.ExtractToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 114);
            // 
            // SaveDownMenuItem
            // 
            this.SaveDownMenuItem.BackColor = System.Drawing.Color.Black;
            this.SaveDownMenuItem.ForeColor = System.Drawing.Color.White;
            this.SaveDownMenuItem.Name = "SaveDownMenuItem";
            this.SaveDownMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SaveDownMenuItem.Text = "Скачать";
            this.SaveDownMenuItem.Click += new System.EventHandler(this.Down_Click);
            // 
            // SeeToolStripMenuItem
            // 
            this.SeeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.SeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SeeToolStripMenuItem.Name = "SeeToolStripMenuItem";
            this.SeeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.SeeToolStripMenuItem.Text = "Посмотреть";
            this.SeeToolStripMenuItem.Click += new System.EventHandler(this.SeeFile_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // ExtractToolStripMenuItem
            // 
            this.ExtractToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ExtractToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExtractToolStripMenuItem.Name = "ExtractToolStripMenuItem";
            this.ExtractToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ExtractToolStripMenuItem.Text = "Извлечь в папку";
            this.ExtractToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.информацияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Local1.jpg");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Sync.Size = new System.Drawing.Size(142, 36);
            this.Sync.TabIndex = 10;
            this.Sync.Text = "Синахронизация";
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
            this.Upload.Click += new System.EventHandler(this.DownMenuItem_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.SeeFile);
            this.Controls.Add(this.RefreshFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileView);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файл Сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView FileView;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialFlatButton RefreshFile;
        private MaterialSkin.Controls.MaterialFlatButton SeeFile;
        private MaterialSkin.Controls.MaterialFlatButton Down;
        private MaterialSkin.Controls.MaterialFlatButton AddFile;
        private MaterialSkin.Controls.MaterialFlatButton DeleteFile;
        private MaterialSkin.Controls.MaterialFlatButton SeeUser;
        private MaterialSkin.Controls.MaterialFlatButton Sync;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SaveDownMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExtractToolStripMenuItem;
        private MaterialSkin.Controls.MaterialFlatButton Upload;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ImageList imageList2;
    }
}
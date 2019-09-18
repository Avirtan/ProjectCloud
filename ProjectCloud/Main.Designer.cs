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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Локальные", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Глобальные", System.Windows.Forms.HorizontalAlignment.Left);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FileView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RefreshFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.SeeFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.Down = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteFile = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Sync = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Безымянный.png");
            this.imageList1.Images.SetKeyName(1, "Безымянный1.png");
            // 
            // FileView
            // 
            listViewGroup3.Header = "Локальные";
            listViewGroup3.Name = "local";
            listViewGroup4.Header = "Глобальные";
            listViewGroup4.Name = "global";
            this.FileView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.FileView.LargeImageList = this.imageList1;
            this.FileView.Location = new System.Drawing.Point(252, 66);
            this.FileView.Margin = new System.Windows.Forms.Padding(2);
            this.FileView.Name = "FileView";
            this.FileView.Size = new System.Drawing.Size(556, 399);
            this.FileView.SmallImageList = this.imageList1;
            this.FileView.TabIndex = 1;
            this.FileView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.AddFile.Location = new System.Drawing.Point(13, 204);
            this.AddFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddFile.Name = "AddFile";
            this.AddFile.Primary = false;
            this.AddFile.Size = new System.Drawing.Size(128, 36);
            this.AddFile.TabIndex = 7;
            this.AddFile.Text = "Добавить файл";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // DeleteFile
            // 
            this.DeleteFile.AutoSize = true;
            this.DeleteFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteFile.Depth = 0;
            this.DeleteFile.Location = new System.Drawing.Point(13, 250);
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
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(12, 345);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(223, 36);
            this.materialFlatButton6.TabIndex = 9;
            this.materialFlatButton6.Text = "Посмотреть пользователей";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // Sync
            // 
            this.Sync.AutoSize = true;
            this.Sync.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sync.Depth = 0;
            this.Sync.Location = new System.Drawing.Point(13, 297);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(809, 464);
            this.Controls.Add(this.Sync);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.DeleteFile);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.SeeFile);
            this.Controls.Add(this.RefreshFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileView);
            this.MaximumSize = new System.Drawing.Size(809, 464);
            this.MinimumSize = new System.Drawing.Size(809, 464);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файл Сервер";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView FileView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialFlatButton RefreshFile;
        private MaterialSkin.Controls.MaterialFlatButton SeeFile;
        private MaterialSkin.Controls.MaterialFlatButton Down;
        private MaterialSkin.Controls.MaterialFlatButton AddFile;
        private MaterialSkin.Controls.MaterialFlatButton DeleteFile;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton Sync;
    }
}
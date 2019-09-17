using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.IO;
using Ionic.Zip;

namespace ProjectCloud
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string path = @"test\";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Remove(0, file.LastIndexOf(@"\") + 1);
                lvi.ImageIndex = 0;
                lvi.Group = listView1.Groups[0];
                listView1.Items.Add(lvi);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ZipFile zip = new ZipFile();
            zip.AddDirectory(@"C:\Zip");
            zip.Save(@"C:\Users\svini\OneDrive\Desktop\проект\rar\e.rar");
            ZipFile zip2 = new ZipFile();
            zip2.Password = "123";
            zip2.AddDirectory(@"C:\Users\svini\OneDrive\Desktop\проект\rar");
            zip2.Save(@"C:\Users\svini\OneDrive\Desktop\проект\e.zip");
            //using (ZipFile z =new  ZipFile(@"C:\Users\svini\OneDrive\Desktop\проект\e.zip"))
            //{
            //    z.ExtractAll(@"C:\Users\svini\OneDrive\Desktop\проект\rar");
            //}
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lst = (ListView)sender;
            //MessageBox.Show(listView1.SelectedItems.);
        }
    }
}

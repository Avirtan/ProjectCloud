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
using System.Net;
using System.Collections;

namespace ProjectCloud
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private string pathArchiv = @"archiv\e.zip";
        private string ftpLogin = "z95230kj_root";
        private string ftpPass = "VOcxjN%0";
        private string ftpUrl = @"ftp://z95230kj.beget.tech/Cloud/";
        private string pathLocal = @"Temp\";
        private ArrayList listFileFtp = new ArrayList();


        private void Main_Load(object sender, EventArgs e)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            string[] files = Directory.GetFiles(pathLocal);
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Remove(0, file.LastIndexOf(@"\") + 1);
                lvi.ImageIndex = 0;
                lvi.Group = FileView.Groups[0];
                FileView.Items.Add(lvi);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ZipFile zip = new ZipFile();
            zip.AddDirectory(@"archiv");
            zip.Save(pathArchiv);
            //ZipFile zip2 = new ZipFile();
            //zip2.Password = "123";
            //zip2.AddDirectory(@"C:\Users\svini\OneDrive\Desktop\проект\rar");
            //zip2.Save(@"C:\Users\svini\OneDrive\Desktop\проект\e.zip");
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (ZipFile zp = ZipFile.Read(pathArchiv))
            {
                foreach (ZipEntry z in zp)
                {
                    //z.Extract("to/");
                    MessageBox.Show(z.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* FtpWebRequest request =
             (FtpWebRequest)WebRequest.Create("ftp://z95230kj.beget.tech");
             request.Credentials = new NetworkCredential(ftpLogin, ftpPass);
             request.Method = WebRequestMethods.Ftp.UploadFile;
             MessageBox.Show(request.ToString());
             using (Stream fileStream = File.OpenRead(@"1.txt"))
             using (Stream ftpStream = request.GetRequestStream())
             {
                 fileStream.CopyTo(ftpStream);
             }*/
            //MessageBox.Show(listView1.FocusedItem.Text);
            //WebClient client = new WebClient();
            //client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
            //client.UploadFile("ftp://z95230kj.beget.tech/1.jpg", @"to\1.jpg");
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.contoso.com/");
            //request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            
            

            //WebClient client = new WebClient();
            //client.Credentials = new NetworkCredential(ftpLogin,ftpPass);
            //client.UploadFile("ftp://ftp.example.com/remote/path/file.zip", @"C:\local\path\file.zip");

        }

        private void RefreshFile_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(ftpLogin, ftpPass);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string line;
            while ((line = reader.ReadLine()) != null) listFileFtp.Add(line);
            reader.Close();
            response.Close();
            foreach (object o in listFileFtp)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = o.ToString();
                lvi.ImageIndex = 0;
                lvi.Group = FileView.Groups[1];
                FileView.Items.Add(lvi);
            }
        }
    }
}

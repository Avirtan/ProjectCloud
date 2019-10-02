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
using System.IO.Compression;
using System.Threading;

namespace ProjectCloud
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }
        private string ftpLogin = "z95230kj_root";
        private string ftpPass = "VOcxjN%0";
        private string ftpUrl = @"ftp://z95230kj.beget.tech/Cloud/";
        private string pass = "12345";
        
        private void Main_Load(object sender, EventArgs e)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.Green900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Green700, TextShade.WHITE);
            if(User.staff == "0")
            {
                //SeeUser.Visible = false;
                //Down.Visible = false;
                //Upload.Visible = false;
                //Sync.Visible = false;
                //SeeUser.Visible = false;
                //DeleteFile.Visible = false;
                //AddFile.Visible = false;
                Panel1.Visible = false;
            }
            if (User.Offline)
            {
                Down.Enabled = false;
                Upload.Enabled = false;
                Sync.Enabled = false;
                SeeUser.Enabled = false;
                contextMenuStrip1.Items[0].Dispose();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           ZipFile zip2 = new ZipFile();
           zip2.AddFile("1.txt");
           zip2.Save("Cloud.zip");
        }

        private bool CheckNetwork()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        private void RefreshFile_Click(object sender, EventArgs e)
        {
            try
            {
                FileView.Items.Clear();
                if (CheckNetwork())
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    request.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);
                    string line;
                    ArrayList listFileFtp = new ArrayList();
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
                using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                {
                    foreach (ZipEntry z in zip)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = z.FileName;
                        lvi.ImageIndex = 0;
                        lvi.Group = FileView.Groups[0];
                        FileView.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileView.FocusedItem.Group.ToString() == "Глобальные" && CheckNetwork())
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl + FileView.FocusedItem.Text);
                    request.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    response.Close();
                    Button btn = new Button();
                    btn.Click += RefreshFile_Click;
                    btn.PerformClick();
                }
                if (FileView.FocusedItem.Group.ToString() == "Локальные")
                {
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        zip.RemoveEntry(FileView.FocusedItem.Text);
                        zip.Save();
                    }
                    Button btn = new Button();
                    btn.Click += RefreshFile_Click;
                    btn.PerformClick();
                }
            }
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false };
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)return;
                string filename = openFileDialog1.FileName;
                ZipFile zip = ZipFile.Read("Cloud.zip");
                zip.AlternateEncoding = Encoding.UTF8;
                zip.Password = pass;
                zip.AddFile(filename, "");
                zip.Save();
                Button btn = new Button();
                btn.Click += RefreshFile_Click;
                btn.PerformClick();
            }
            catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        private void SeeFile_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                DeleteFolder();
                using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                {
                    foreach (ZipEntry z in zip)
                    {
                        if (FileView.FocusedItem.Group.ToString() == "Локальные" && z.FileName == FileView.FocusedItem.Text)
                        {
                            z.ExtractWithPassword(@"Temp\", pass);
                            flag = true;
                            break;
                        }
                    }
                }
                if (FileView.FocusedItem.Group.ToString() == "Глобальные") MessageBox.Show("Выберете локальный файл");
                if (!flag) return;
                string commandText = @"Temp\" + FileView.FocusedItem.Text;
                var proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = commandText;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();

            }
            catch { }
        }

        private void Sync_Click(object sender, EventArgs e)
        {
           // try
           // {
                if (CheckNetwork())
                {
                    DeleteFolder();
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    ArrayList FileName = new ArrayList();
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        foreach (ZipEntry z in zip)
                        {
                            FileName.Add(z.FileName);
                            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpUrl + z.FileName);
                            req.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                            req.Method = WebRequestMethods.Ftp.DeleteFile;
                            try
                            {
                                FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                                res.Close();
                            }
                            catch { }
                            z.ExtractWithPassword(@"Temp\", pass);
                            client.UploadFile(ftpUrl + z.FileName, @"Temp\" + z.FileName);
                        }
                    }
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        for(int i = 0; i < FileName.Count; i++)
                        {
                            zip.RemoveEntry(FileName[i].ToString());
                            zip.Save();
                        }
                    }
                    DeleteFolder();
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    request.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);
                    string line;
                    ArrayList listFileFtp = new ArrayList();
                    while ((line = reader.ReadLine()) != null) listFileFtp.Add(line);
                    reader.Close();
                    response.Close();
                    foreach (string o in listFileFtp)
                    {
                        client.DownloadFile(ftpUrl + o, @"Temp\" + o);
                        ZipFile zp = new ZipFile("Cloud.zip");
                        zp.AlternateEncoding = Encoding.UTF8;
                        zp.Password = pass;
                        Console.WriteLine(o.ToString());
                        zp.AddFile(@"Temp\" + o.ToString(),"");
                        zp.Save();
                        File.Delete(@"Temp\" + o);
                    }
                    DeleteFolder();
                    Button btn = new Button();
                    btn.Click += RefreshFile_Click;
                    btn.PerformClick();
                }
                else MessageBox.Show("Нет интернета");
           // }
            //catch { }
        }

        private void Down_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNetwork() && FileView.FocusedItem.Group.ToString() == "Глобальные")
                {
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    client.DownloadFile(ftpUrl + FileView.FocusedItem.Text,FileView.FocusedItem.Text);
                    ZipFile zip = ZipFile.Read("Cloud.zip");
                    zip.AlternateEncoding = Encoding.UTF8;
                    zip.Password = pass;
                    zip.AddFile(FileView.FocusedItem.Text, "");
                    zip.Save();
                    File.Delete(FileView.FocusedItem.Text);
                    Button btn = new Button();
                    btn.Click += RefreshFile_Click;
                    btn.PerformClick();
                }
                else MessageBox.Show("Нет интернета или выбран локальный файл");
            }
            catch { }
        }

        private void DeleteFolder()
        {
           Directory.Delete(@"Temp\", true);
           Directory.CreateDirectory(@"Temp\");
        }

        private void DownMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNetwork())
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false };
                    if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                    string filename = openFileDialog1.FileName;
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    client.UploadFile(ftpUrl + filename.Split('\\')[filename.Split('\\').Length-1], filename);
                    Button btn = new Button();
                    btn.Click += RefreshFile_Click;
                    btn.PerformClick();
                }
                else MessageBox.Show("Нет интернета");
            }
            catch(Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void ExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.Cancel) return;
                string path = fbd.SelectedPath;
                if (FileView.FocusedItem.Group.ToString() == "Глобальные" && CheckNetwork())
                {
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    client.DownloadFile(ftpUrl + FileView.FocusedItem.Text,path+@"\"+ FileView.FocusedItem.Text);
                }
                if (FileView.FocusedItem.Group.ToString() == "Локальные")
                {
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        zip.AlternateEncoding = Encoding.UTF8;
                        zip[FileView.FocusedItem.Text].ExtractWithPassword(path,pass);
                    }
                    Button btn = new Button();
                    btn.Click += RefreshFile_Click;
                    btn.PerformClick();
                }
            }
            catch (Exception ex){MessageBox.Show("Файл уже существует");}
        }
    }
}

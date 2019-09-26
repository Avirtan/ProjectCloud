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
using System.Security.AccessControl;
using MySql.Data.MySqlClient;

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
        byte[] key = { 60, 193, 108, 168, 202, 110, 29, 20, 202, 228, 187, 190, 27, 241, 75, 68, 81, 119, 125, 85, 190, 246, 40, 176, 145, 54, 27, 174, 67, 173, 46, 45 };
        byte[] iv = { 132, 193, 67, 244, 8, 174, 175, 121, 190, 248, 26, 32, 149, 151, 33, 89 };
        private MySqlConnection conn;

        private void Main_Load(object sender, EventArgs e)
        {
            DeleteFolder();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            if(User.staff == "0")
            {
                Panel1.Visible = false;
                materialContextMenuStrip1.Items[1].Dispose();
            }
            if (User.staff == "1") SeeUser.Visible = false;
            if (User.Offline)
            {
                Down.Enabled = false;
                Upload.Enabled = false;
                Sync.Enabled = false;
                SeeUser.Enabled = false;
                contextMenuStrip1.Items[0].Dispose();
            }
            if (!User.Offline) conn = Connection.GetDBConnection();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ZipFile zip = new ZipFile();
            zip.Save("Cloud.zip");
        }

        private bool CheckNetwork()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        private void RefreshFile_Click(object sender, EventArgs e)
        {
            DeleteFolder();
            try
            {
                FileView.Items.Clear();
                if (CheckNetwork())
                {
                    ArrayList listFileFtp = GetDirectoryList();
                    RefreshViewList(listFileFtp, 1,1);
                }
                using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                {
                    ArrayList listFileZip = new ArrayList();
                    foreach (ZipEntry z in zip) listFileZip.Add(z.FileName);
                    RefreshViewList(listFileZip, 0,0);
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
                    RefreshButtonClick();
                }
                if (FileView.FocusedItem.Group.ToString() == "Локальные")
                {
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        zip.RemoveEntry(FileView.FocusedItem.Text);
                        zip.Save();
                    }
                    RefreshButtonClick();
                }
            }
            catch{}
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
                string encriptFile = "Temp\\"+filename.Split('\\')[filename.Split('\\').Length - 1];
                RijndaelHelper.EncryptFile(filename,encriptFile,key,iv);
                zip.Password = pass;
                zip.AddFile(encriptFile, "");
                zip.Save();
                RefreshButtonClick();
            }
            catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        private void SeeFile_Click(object sender, EventArgs e)
        {
            DeleteFolder();
            try
            {
                if (FileView.FocusedItem.Group.ToString() == "Глобальные") { MessageBox.Show("Выберете локальный файл"); return; }
                using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                {
                    foreach (ZipEntry z in zip)
                    {
                        if (FileView.FocusedItem.Group.ToString() == "Локальные" && z.FileName == FileView.FocusedItem.Text)
                        {
                            z.ExtractWithPassword(@"Temp\", pass);  
                            break;
                        }
                    }
                }
                RijndaelHelper.DecryptFile(@"Temp\" + FileView.FocusedItem.Text, @"Temp\" +"1"+FileView.FocusedItem.Text, key, iv);
                string commandText = @"Temp\" + "1" + FileView.FocusedItem.Text;
                var proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = commandText;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Sync_Click(object sender, EventArgs e)
        {
           try
           { 
                if (CheckNetwork())
                {
                    //DeleteFolder();
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
                    ArrayList listFileFtp = GetDirectoryList();
                    foreach (string o in listFileFtp)
                    {
                        client.DownloadFile(ftpUrl + o,  o);
                        ZipFile zp = new ZipFile("Cloud.zip");
                        zp.AlternateEncodingUsage = ZipOption.Always;
                        zp.AlternateEncoding = Encoding.UTF8;
                        zp.Password = pass;
                        zp.AddFile(o.ToString(),"");
                        zp.Save();
                        File.Delete(o);
                    }
                    RefreshButtonClick();
                }
                else MessageBox.Show("Нет интернета");
           }
           catch { }
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
                    RefreshButtonClick();
                }
                else MessageBox.Show("Нет интернета или выбран локальный файл");
            }
            catch { MessageBox.Show("Файл уже скачан"); }
        }

        private void DeleteFolder()
        {
           try {Directory.Delete(@"Temp\", true); Directory.CreateDirectory(@"Temp\"); }
           catch { Directory.CreateDirectory(@"Temp\"); }
           
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNetwork() && FileView.FocusedItem.Group.ToString() == "Глобальные")
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false };
                    if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                    string filename = openFileDialog1.FileName;
                    string name = filename.Split('\\')[filename.Split('\\').Length - 1];
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    RijndaelHelper.EncryptFile(filename,@"Temp\" + name,key,iv);
                    client.UploadFile(ftpUrl + name, @"Temp\"+ name);
                    RefreshButtonClick();
                }
                if (FileView.FocusedItem.Group.ToString() == "Локальные")
                {
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        zip[FileView.FocusedItem.Text].ExtractWithPassword(@"Temp\", pass);
                        client.UploadFile(ftpUrl + FileView.FocusedItem.Text, @"Temp\" + FileView.FocusedItem.Text);
                    }
                    RefreshButtonClick();
                }
                else MessageBox.Show("Нет интернета или выбран локальный файл");
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
                    client.DownloadFile(ftpUrl + FileView.FocusedItem.Text,@"Temp\" + FileView.FocusedItem.Text);
                    RijndaelHelper.DecryptFile(@"Temp\" + FileView.FocusedItem.Text,path+ @"\" + FileView.FocusedItem.Text,key,iv);
                }
                if (FileView.FocusedItem.Group.ToString() == "Локальные")
                {
                    using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                    {
                        foreach (ZipEntry z in zip)
                        {
                            if (FileView.FocusedItem.Group.ToString() == "Локальные" && z.FileName == FileView.FocusedItem.Text)
                            {
                                z.ExtractWithPassword(@"Temp\", pass);
                                break;
                            }
                        }
                        RijndaelHelper.DecryptFile(@"Temp\" + FileView.FocusedItem.Text, path + @"\" + FileView.FocusedItem.Text, key, iv);
                    }
                    RefreshButtonClick();
                }
            }
            catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFolder();
            Application.Exit();
        }

        private void RefreshButtonClick()
        {
            Button btn = new Button();
            btn.Click += RefreshFile_Click;
            btn.PerformClick();
        }

        private void RefreshViewList(ArrayList arr,int group,int img)
        {
            foreach (object obj in arr)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = obj.ToString();
                lvi.ImageIndex = img;
                lvi.Group = FileView.Groups[group];
                FileView.Items.Add(lvi);
            }
        }

        private ArrayList GetDirectoryList()
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
            return listFileFtp;
        }

        private void InformationFile_Click(object sender, EventArgs e)
        {
            long size = 0;
            if (FileView.FocusedItem.Group.ToString() == "Глобальные" && CheckNetwork())
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl+ FileView.FocusedItem.Text);
                request.Credentials = new NetworkCredential(ftpLogin, ftpPass);
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                size = response.ContentLength;
                response.Close();
                MessageBox.Show("Размер: "+size.ToString()+"байт");
            }
            if (FileView.FocusedItem.Group.ToString() == "Локальные" )
            {
                using (ZipFile zip = ZipFile.Read("Cloud.zip"))
                {
                   size = zip[FileView.FocusedItem.Text].CompressedSize;
                }
                MessageBox.Show("Размер: " + size.ToString() + "байт");
            }
        }

        private void SeeUser_Click(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(1175, 465);
                conn.Open();
                string sql = "SELECT * FROM user ";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                dgvUser.Rows.Clear();
                cbUserId.Items.Clear();
                dgvUser.AllowUserToResizeColumns = false;
                dgvUser.AllowUserToResizeRows = false;
                while (reader.Read())
                {
                    dgvUser.Rows.Add();
                    dgvUser.Rows[i].Cells[0].Value = reader[0].ToString();
                    dgvUser.Rows[i].Cells[1].Value = reader[2].ToString();
                    dgvUser.Rows[i].ReadOnly = true;
                    cbUserId.Items.Add(reader[0].ToString());
                    i++;
                }
                if (cbUserId.Items.Count > 0) cbUserId.SelectedIndex = 0;
                conn.Close();
            }catch(Exception ex) { MessageBox.Show(ex.Message); conn.Close(); } 
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbUserId.Text != "")
                {
                    conn.Open();
                    string sql = "SELECT * FROM user where idUser = "+cbUserId.Text;
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    string email = "";
                    while (reader.Read()) email = reader[3].ToString();
                    if (email != "") SendMail.Send(email, "Ваш аккаунт удалён", "Удаление аккаунта");
                    else MessageBox.Show("У пользователя нет почты");
                    conn.Close();
                    conn.Open();
                    sql = "DELETE FROM user where iduser = " + cbUserId.Text + "; ";
                    command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    if(email!="") MessageBox.Show("пользователь удалён");
                    conn.Close();
                    Button btn = new Button();
                    btn.Click += SeeUser_Click;
                    btn.PerformClick();
                }
                else
                    MessageBox.Show("Выберете пользователя");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void hideTable_Click(object sender, EventArgs e)
        {
            this.Size = new Size(807, 465);
        }
    }
}

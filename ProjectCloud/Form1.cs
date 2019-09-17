﻿using System;
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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using Ionic.Zip;

namespace ProjectCloud
{
    public partial class Form1 : MaterialForm
    {
        static class Password
        {
            public enum Strength { Простой = 1, Средний, Сложный };

            public static Strength PasswordStrength(string password)
            {
                int score = 0;
                Dictionary<string, int> patterns = new Dictionary<string, int> { { @"\d", 10 }, //включает цифры
                                                                         { @"[a-zA-ZА-Яа-я]", 15 }, //буквы
                                                                         { @"[!,@,#,\$,%,\^,&,\*,?,_,~]", 25 } }; //символы
                if (password.Length > 6)
                    foreach (var pattern in patterns)
                        score += Regex.Matches(password, pattern.Key).Count * pattern.Value;
                Strength result;
                switch (score / 50)
                {
                    case 0: result = Strength.Простой; break;
                    case 1: result = Strength.Средний; break;
                    case 2: result = Strength.Средний; break;
                    default: result = Strength.Сложный; break;
                }
                return result;
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                if (email.IndexOf("@") == -1 || email.IndexOf(".") == -1 || email.IndexOf(".") == email.Length - 1)
                    throw new Exception();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);
            Brush[] colors = { Brushes.Black,
                     Brushes.Red};
            Graphics g = Graphics.FromImage((Image)result);
            g.Clear(Color.Gray);
            textCaptch = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                textCaptch += ALF[rnd.Next(ALF.Length)];
            g.DrawString(textCaptch,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            return result;
        }

        private bool CheckNetwork()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }

        //--------------------------------------------------------------------//
        private MySqlConnection conn;
        private int flag = 0;
        private string textCaptch = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.BlueGrey800,Primary.BlueGrey900,Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
            conn = Connection.GetDBConnection();
            try
            {
                using (StreamReader sr = new StreamReader("1.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        Alogin.Text = line;
                        Apass.Text = sr.ReadLine();
                        //Console.WriteLine(line);
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Auth_Click(object sender, EventArgs e)
        {
            bool f = false;
            try
            {
                conn = Connection.GetDBConnection();
                conn.Open();
                string sql = "SELECT * FROM user where (login = @login or email = @login) and pass  = @password";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@login", Alogin.Text);
                command.Parameters.AddWithValue("@password", Apass.Text);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((Alogin.Text == reader[2].ToString()|| Alogin.Text == reader[3].ToString()) && Apass.Text == reader[1].ToString())
                    {
                        User.id = reader[0].ToString();
                        User.pass = reader[1].ToString();
                        User.login = reader[2].ToString();
                        User.email = reader[3].ToString();
                        User.staff = reader[4].ToString();
                        Main form2 = new Main();
                        form2.Show();
                        this.Hide();
                        f = true;
                        if (Aremember.Checked)
                        {
                            try
                            {
                                using (StreamWriter sw = new StreamWriter("1.txt", false, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine(Alogin.Text);
                                    sw.WriteLine(Apass.Text);
                                }
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                using (StreamWriter sw = new StreamWriter("1.txt", false, System.Text.Encoding.Default))
                                {
                                    sw.WriteLine("");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                    };
                }
                if (!f)
                    MessageBox.Show("неверный логин или пароль");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string error = "";
                if (IsValidEmail(Rmail.Text) && Rpass.Text.Length >= 6 && Rlogin.Text != "" && Rpass.Text == Rpass2.Text && captch.Text == textCaptch && CheckNetwork())
                {
                    string sql = "SELECT * FROM user";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Rlogin.Text == reader[2].ToString())
                        {
                            error = "Логин уже занят";
                            break;
                        };
                        if (Rmail.Text == reader[3].ToString() && Rmail.Text != "")
                        {
                            error = "email уже занят";
                            break;
                        };
                    }
                    conn.Close();
                    if (error == "")
                    {
                        //MOXHATKA@protonmail.com
                        conn.Open();
                        string text = "ВАШ ЛОГИН: " + Rlogin.Text + "\nПАРОЛЬ: " + Rpass.Text;
                        SendMail.Send(Rmail.Text, text, "Cloud69");
                        sql = "insert into user(login,pass,email) values('" + Rlogin.Text + "','" + Rpass.Text + "','" + Rmail.Text + "')";
                        command = new MySqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        Rlogin.Text = "";
                        Rpass.Text = "";
                        Rmail.Text = "";
                        Rpass2.Text = "";
                        hardpass.Text = "";
                    }
                    else
                        MessageBox.Show(error);
                }
                else
                    MessageBox.Show("неверные данные, или неверная капча, проверьте подключение к интернету");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void Rpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            hardpass.Text = Password.PasswordStrength(Rpass.Text).ToString();
            switch (Password.PasswordStrength(Rpass.Text).ToString())
            {
                case "Простой":hardpass.Text = "Простой";hardpass.ForeColor = Color.Green;break;
                case "Средний": hardpass.Text = "Средний"; hardpass.ForeColor = Color.Yellow; break;
                case "Сложный": hardpass.Text = "Сложный"; hardpass.ForeColor = Color.Red; break;
            }
        }
        
        private void RestorePass_Click(object sender, EventArgs e)
        {
            conn = Connection.GetDBConnection();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM user where (login = @login or email = @login)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@login", restore.Text);
                command.Parameters.AddWithValue("@password", restore.Text);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((restore.Text == reader[2].ToString() || restore.Text == reader[3].ToString()))
                    {
                        string text = "ВАШ ЛОГИН: " + Rlogin.Text + "\nПАРОЛЬ: " + reader[1].ToString();
                        SendMail.Send(reader[3].ToString(), text, "Cloud69");
                        MessageBox.Show("отпарвиь");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            restore.Text = "";
            flag++;
            if (flag == 3)
            {
                RestorePass.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RestorePass.Enabled = true;
            timer1.Enabled = false;
            flag = 0;
        }

        private void resetCaptch_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
    }
}

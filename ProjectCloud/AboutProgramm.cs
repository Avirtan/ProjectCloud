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

namespace ProjectCloud
{
    public partial class AboutProgramm : MaterialForm
    {
        public AboutProgramm()
        {
            InitializeComponent();
        }

        private void AboutProgramm_Load(object sender, EventArgs e)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            label1.Text = "Обновить файлы - обновляет список локальных и \nнаходящихся на сервере файлов;";
            label2.Text = "Просмотреть файл - открывает локальный файл для \nпросмотра, нельзя редактировать находясь в \nпросмотре находящихся на сервере файлов;";
            label3.Text = "Скачать файл - позволяет скачать файл\n в локальный архив,но в локальном архиве\n не должно быть уже такого файла;";
            label4.Text = "Добавить файл - позволяет добавить файл\n в локальный архив, функция доступна \nдля преподавателей и для админа;";
            label5.Text = "Загрузить файл - позволяет загрузить файл на сервер\n из проводника или выбрать из локальных файлов,\nфункция доступна для преподавателей и для админа;";
            label6.Text = "Удалить файл - позволяет удалить файл из списка,\nфункция доступна для преподавателей и для админа;";
            label7.Text = "Синхронизация - позволяет обновить локальные файлы\n и файлы находящиеся на сервере,функция доступна\n для преподавателей и для админа;";
            label8.Text = "Посмотреть пользователей - открывает таблицу\n пользователей, и позволяет удалять пользователей,\n функция доступна для админа;";
        }
    }
}

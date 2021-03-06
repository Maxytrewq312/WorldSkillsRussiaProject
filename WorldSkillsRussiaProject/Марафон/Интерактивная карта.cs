using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsRussiaProject.Марафон
{
    public partial class Интерактивная_карта : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public Интерактивная_карта()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            infoPanel.Hide();
        }
        private void showInfo(string name, string description1, string description2, string description3) //Передача данных в окошко с информацией
        {
            infoPanel.Show();
            markNameLabel.Text = name;
            description1Label.Text = description1;
            description2Label.Text = description2;
            description3Label.Text = description3;
        }

        private void startPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Старт", "Начать марафон", "Места болельщиков", "Получение призов");
        }

        private void infoPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Стойка информации", "Получить информацию", "Купить предметы", "Зарегистрироваться");
        }

        private void healthPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Медпункт", "Получить первую помощь", "Завершить досрочно", "Взять воды");
        }

        private void drinkUpPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Стенд питья", "Взять воды", "Места болельщиков", "Место отдыха");
        }

        private void toiletPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Туалет", "Место отдыха", "Медпункт", "Взять воды");
        }

        private void energyPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Энергетические батончики", "Бесплатные батончики", "Места болельщиков", "Купить предметы");
        }

        private void drinkBottomPictureBox_Click(object sender, EventArgs e)
        {
            showInfo("Стенд питья", "Взять воды", "Места болельщиков", "Место отдыха");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            labelTime.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Меню_марафона mm = new Меню_марафона();
            mm.Show();
        }
    }
}

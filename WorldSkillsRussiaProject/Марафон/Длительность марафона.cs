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
    public partial class Длиетльность_марафона : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public Длиетльность_марафона()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void distance5PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void distance4PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void distance3PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void distance2PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void distance1PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void speed1PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = speed1PictureBox.Image;
            nameSelectLabel.Text = speed1Label.Text;
            descriptionLabel.Text = $"Максимальная скорость Формулы 1 - 370 км/ч. Это займет 6 минут чтобы завершить 42км марафон";
        }

        private void speed2PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = speed2PictureBox.Image;
            nameSelectLabel.Text = speed2Label.Text;
            descriptionLabel.Text = $"Максимальная скорость червя - 1 км/ч. Это займет 42 часа чтобы завершить 42км марафон";
        }

        private void speed3PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = speed3PictureBox.Image;
            nameSelectLabel.Text = speed3Label.Text;
            descriptionLabel.Text = $"Максимальная скорость ленивца - 0,27 км/ч. Это займет 155 часов и 33 минуты чтобы завершить 42км марафон";
        }

        private void speed4PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = speed4PictureBox.Image;
            nameSelectLabel.Text = speed4Label.Text;
            descriptionLabel.Text = $"Максимальная скорость капибара - 35 км/ч. Это займет 1 час и 12 минут чтобы завершить 42км марафон";
        }

        private void speed5PictureBox_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = speed5PictureBox.Image;
            nameSelectLabel.Text = speed5Label.Text;
            descriptionLabel.Text = $"Максимальная скорость ягуара - 80 км/ч. Это займет 31,5 минут чтобы завершить 42км марафон";
        }

        private void distance1PictureBox_Click_1(object sender, EventArgs e)
        {
            pictureBox11.Image = distance1PictureBox.Image;
            nameSelectLabel.Text = distance1Label.Text;
            descriptionLabel.Text = $"Длина Airbus A380 - 73 метра. Это займет 575 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void distance2PictureBox_Click_1(object sender, EventArgs e)
        {
            pictureBox11.Image = distance2PictureBox.Image;
            nameSelectLabel.Text = distance2Label.Text;
            descriptionLabel.Text = $"Длина шлепанцев - 26 сантиметров. Это займет 161 538 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void distance3PictureBox_Click_1(object sender, EventArgs e)
        {
            pictureBox11.Image = distance3PictureBox.Image;
            nameSelectLabel.Text = distance3Label.Text;
            descriptionLabel.Text = $"Длина футбольного поля - 120 метра. Это займет 350 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void distance4PictureBox_Click_1(object sender, EventArgs e)
        {
            pictureBox11.Image = distance4PictureBox.Image;
            nameSelectLabel.Text = distance4Label.Text;
            descriptionLabel.Text = $"Длина Роналдиньо - 1,83 метра. Это займет 23 204 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void distance5PictureBox_Click_1(object sender, EventArgs e)
        {
            pictureBox11.Image = distance5PictureBox.Image;
            nameSelectLabel.Text = distance5Label.Text;
            descriptionLabel.Text = $"Длина автобуса - 20 метров. Это займет 2 100 из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

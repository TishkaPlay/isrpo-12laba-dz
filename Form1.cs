using System;
using System.Windows.Forms;

namespace isrpo_12laba_dz
{
    public partial class Form1 : Form
    {
        private int time = 10;
        private int clicks = 0;
        private bool isActive = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            time = 10;
            clicks = 0;
            isActive = true;

            labelTime.Text = $"Время: {time}";
            labelClicks.Text = $"Нажатий: {clicks}";

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            labelTime.Text = $"Время: {time}";

            if (time <= 0)
            {
                timer1.Stop();
                isActive = false;

                MessageBox.Show($"Конец игры! Твои нажатия: {clicks}");
                clicks = 0;
                labelClicks.Text = $"Нажатий: {clicks}";
            }
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                clicks++;
                labelClicks.Text = $"Нажатий: {clicks}";
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time = 0;
            clicks = 0;
            isActive = false;

            labelTime.Text = $"Время: {time}";
            labelClicks.Text = $"Нажатий: {clicks}";
        }
    }
}

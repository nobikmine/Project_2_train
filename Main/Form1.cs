using System;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxInHour.Text = Properties.Settings.Default.inHour.ToString();
            textBoxInMin.Text = Properties.Settings.Default.inMin.ToString();

            textBoxOutHour.Text = Properties.Settings.Default.outHour.ToString();
            textBoxOutMin.Text = Properties.Settings.Default.outMin.ToString();

            textBoxHereHour.Text = Properties.Settings.Default.hereHour.ToString();
            textBoxHereMin.Text = Properties.Settings.Default.hereMin.ToString();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxInHour.Text);
                int b = int.Parse(textBoxInMin.Text);

                int c = int.Parse(textBoxOutHour.Text);
                int d = int.Parse(textBoxOutMin.Text);

                int n = int.Parse(textBoxHereHour.Text);
                int m = int.Parse(textBoxHereMin.Text);

                // сохранение
                Properties.Settings.Default.inHour = a;
                Properties.Settings.Default.inMin = b;
                Properties.Settings.Default.outHour = c;
                Properties.Settings.Default.outMin = d;
                Properties.Settings.Default.hereHour = n;
                Properties.Settings.Default.hereMin = m;
                Properties.Settings.Default.Save();

                string result = Logic.CountTime(a, b, c, d, n, m);
                labelResult.Text = result;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInHour.Clear();
            textBoxInMin.Clear();

            textBoxOutHour.Clear();
            textBoxOutMin.Clear();

            textBoxHereHour.Clear();
            textBoxHereMin.Clear();

            labelResult.Text = "Результат";
            textBoxInHour.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl == buttonCheck)
                {
                    buttonClear.Focus();
                }
                else if (ActiveControl == buttonClear)
                {
                    buttonClear.PerformClick();
                    textBoxInHour.Focus();
                }
                else
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                }

                e.SuppressKeyPress = true;
            }
        }
    }

    public static class Logic
    {
        public static string CountTime(int a, int b, int c, int d, int n, int m)
        {
            if (a < 0 || a > 23 || c < 0 || c > 23 || n < 0 || n > 23 ||
                b < 0 || b > 59 || d < 0 || d > 59 || m < 0 || m > 59)
            {
                return "Ошибка: некорректное время";
            }

            int minutesIn = a * 60 + b;
            int minutesOut = c * 60 + d;
            int minutesHere = n * 60 + m;

            bool isTrainAtStation;

            if (minutesIn == minutesOut)
                isTrainAtStation = false;
            else if (minutesIn < minutesOut)
                isTrainAtStation = minutesHere >= minutesIn && minutesHere <= minutesOut;
            else
                isTrainAtStation = minutesHere >= minutesIn || minutesHere <= minutesOut;

            return isTrainAtStation
                ? "Поезд стоит на платформе"
                : "Поезда нет на платформе";
        }
    }
}
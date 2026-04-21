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
                int trainHourIn = int.Parse(textBoxInHour.Text);
                int trainMinIn = int.Parse(textBoxInMin.Text);

                int trianHourOut = int.Parse(textBoxOutHour.Text);
                int trainMinOut = int.Parse(textBoxOutMin.Text);

                int humanHour = int.Parse(textBoxHereHour.Text);
                int humanMin = int.Parse(textBoxHereMin.Text);

                Properties.Settings.Default.inHour = trainHourIn;
                Properties.Settings.Default.inMin = trainMinIn;
                Properties.Settings.Default.outHour = trianHourOut;
                Properties.Settings.Default.outMin = trainMinOut;
                Properties.Settings.Default.hereHour = humanHour;
                Properties.Settings.Default.hereMin = humanMin;
                Properties.Settings.Default.Save();

                string result = Logic.CountTime(trainHourIn, trainMinIn, trianHourOut, trainMinOut, humanHour, humanMin);
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
        public static string CountTime(int trainHourIn, int trainMinIn, int trianHourOut, int trainMinOut, int humanHour, int humanMin)
        {
            if (trainHourIn < 0 || trainHourIn > 23 || trianHourOut < 0 || trianHourOut > 23 || humanHour < 0 || humanHour > 23 ||
                trainMinIn < 0 || trainMinIn > 59 || trainMinOut < 0 || trainMinOut > 59 || humanMin < 0 || humanMin > 59)
            {
                return "Ошибка: некорректное время";
            }

            int minutesIn = trainHourIn * 60 + trainMinIn;
            int minutesOut = trianHourOut * 60 + trainMinOut;
            int minutesHere = humanHour * 60 + humanMin;

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
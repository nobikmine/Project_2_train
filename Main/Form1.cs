using System;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxTrainIn.Text = Properties.Settings.Default.trainIn.ToString();
            textBoxTrainOut.Text = Properties.Settings.Default.trainOut.ToString();
            textBoxHuman.Text = Properties.Settings.Default.human.ToString();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string trainIn = textBoxTrainIn.Text;
                string trainOut = textBoxTrainOut.Text;
                string human = textBoxHuman.Text;

                Properties.Settings.Default.trainIn = trainIn;
                Properties.Settings.Default.trainOut = trainOut;
                Properties.Settings.Default.human = human;

                Properties.Settings.Default.Save();

                string[] trainInArr = trainIn.Split(' ');
                string[] trainOutArr = trainOut.Split(' ');
                string[] humanArr = human.Split(' ');

                string result = Logic.CountTime(trainInArr, trainOutArr, humanArr);
                labelResult.Text = result;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.ActiveControl == buttonCheck)
                {
                    buttonClear.Focus();
                }
                else if (this.ActiveControl == buttonClear)
                {
                    buttonClear.PerformClick();
                    textBoxTrainIn.Focus();
                }
                else
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }

                e.SuppressKeyPress = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTrainIn.Clear();
            textBoxTrainOut.Clear();
            textBoxHuman.Clear();
            labelResult.Text = "Результат";

            textBoxTrainIn.Focus();
        }

    }
    public static class Logic
    {
        public static string CountTime(string[] trainIn, string[] trainOut, string[] humanHere)
        {
            if (trainIn.Length < 2 || trainOut.Length < 2 || humanHere.Length < 2 ||
                string.IsNullOrWhiteSpace(trainIn[0]) || string.IsNullOrWhiteSpace(trainIn[1]) ||
                string.IsNullOrWhiteSpace(trainOut[0]) || string.IsNullOrWhiteSpace(trainOut[1]) ||
                string.IsNullOrWhiteSpace(humanHere[0]) || string.IsNullOrWhiteSpace(humanHere[1]))
            {
                return "Ошибка: введены не все значения времени";
            }

            int a = int.Parse(trainIn[0]);
            int b = int.Parse(trainIn[1]);

            int c = int.Parse(trainOut[0]);
            int d = int.Parse(trainOut[1]);

            int n = int.Parse(humanHere[0]);
            int m = int.Parse(humanHere[1]);

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
            {
                isTrainAtStation = false;
            }
            else if (minutesIn < minutesOut)
            {
                isTrainAtStation = minutesHere >= minutesIn && minutesHere <= minutesOut;
            }
            else
            {
                isTrainAtStation = minutesHere >= minutesIn || minutesHere <= minutesOut;
            }

            return isTrainAtStation ? "Поезд стоит на платформе" : "Поезда нет на платформе";
        }
    }

}
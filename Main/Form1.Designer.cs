namespace Main
{
    partial class Form1
    {
        public System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void InitializeComponent()
        {
            textBoxInHour = new TextBox();
            textBoxInMin = new TextBox();
            textBoxHereHour = new TextBox();
            textBoxHereMin = new TextBox();
            textBoxOutHour = new TextBox();
            textBoxOutMin = new TextBox();
            buttonCheck = new Button();
            buttonClear = new Button();
            labelResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxInHour
            // 
            textBoxInHour.Location = new Point(52, 27);
            textBoxInHour.Name = "textBoxInHour";
            textBoxInHour.PlaceholderText = "Часы";
            textBoxInHour.Size = new Size(100, 23);
            textBoxInHour.TabIndex = 0;
            // 
            // textBoxInMin
            // 
            textBoxInMin.Location = new Point(52, 56);
            textBoxInMin.Name = "textBoxInMin";
            textBoxInMin.PlaceholderText = "Мин.";
            textBoxInMin.Size = new Size(100, 23);
            textBoxInMin.TabIndex = 1;
            // 
            // textBoxHereHour
            // 
            textBoxHereHour.Location = new Point(269, 27);
            textBoxHereHour.Name = "textBoxHereHour";
            textBoxHereHour.PlaceholderText = "Часы";
            textBoxHereHour.Size = new Size(100, 23);
            textBoxHereHour.TabIndex = 2;
            // 
            // textBoxHereMin
            // 
            textBoxHereMin.Location = new Point(269, 56);
            textBoxHereMin.Name = "textBoxHereMin";
            textBoxHereMin.PlaceholderText = "Мин.";
            textBoxHereMin.Size = new Size(100, 23);
            textBoxHereMin.TabIndex = 3;
            // 
            // textBoxOutHour
            // 
            textBoxOutHour.Location = new Point(467, 27);
            textBoxOutHour.Name = "textBoxOutHour";
            textBoxOutHour.PlaceholderText = "Часы";
            textBoxOutHour.Size = new Size(100, 23);
            textBoxOutHour.TabIndex = 4;
            // 
            // textBoxOutMin
            // 
            textBoxOutMin.Location = new Point(467, 56);
            textBoxOutMin.Name = "textBoxOutMin";
            textBoxOutMin.PlaceholderText = "Мин.";
            textBoxOutMin.Size = new Size(100, 23);
            textBoxOutMin.TabIndex = 5;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(235, 115);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(75, 23);
            buttonCheck.TabIndex = 6;
            buttonCheck.Text = "Вывести результат";
            buttonCheck.Click += buttonCheck_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(520, 141);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Очистить";
            buttonClear.Click += buttonClear_Click;
            // 
            // labelResult
            // 
            labelResult.Location = new Point(235, 141);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(267, 23);
            labelResult.TabIndex = 8;
            labelResult.Text = "Результат";
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "Время прибытия поезда";
            // 
            // label2
            // 
            label2.Location = new Point(217, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 10;
            label2.Text = "Время прихода пассажира";
            // 
            // label3
            // 
            label3.Location = new Point(439, 9);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 11;
            label3.Text = "Время ухода поезда";
            // 
            // Form1
            // 
            ClientSize = new Size(607, 192);
            Controls.Add(textBoxInHour);
            Controls.Add(textBoxInMin);
            Controls.Add(textBoxHereHour);
            Controls.Add(textBoxHereMin);
            Controls.Add(textBoxOutHour);
            Controls.Add(textBoxOutMin);
            Controls.Add(buttonCheck);
            Controls.Add(buttonClear);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            KeyPreview = true;
            Name = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        public TextBox textBoxInHour;
        public TextBox textBoxInMin;
        public TextBox textBoxHereHour;
        public TextBox textBoxHereMin;
        public TextBox textBoxOutHour;
        public TextBox textBoxOutMin;

        public Button buttonCheck;
        private Button buttonClear;

        public Label labelResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
namespace Main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            textBoxTrainIn = new TextBox();
            textBoxTrainOut = new TextBox();
            textBoxHuman = new TextBox();
            buttonCheck = new Button();
            labelResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxTrainIn
            // 
            textBoxTrainIn.Location = new Point(12, 27);
            textBoxTrainIn.Name = "textBoxTrainIn";
            textBoxTrainIn.PlaceholderText = "введите время прибытия поезда";
            textBoxTrainIn.Size = new Size(187, 23);
            textBoxTrainIn.TabIndex = 0;
            // 
            // textBoxTrainOut
            // 
            textBoxTrainOut.Location = new Point(437, 27);
            textBoxTrainOut.Name = "textBoxTrainOut";
            textBoxTrainOut.PlaceholderText = "введи время ухода поезда";
            textBoxTrainOut.Size = new Size(155, 23);
            textBoxTrainOut.TabIndex = 1;
            // 
            // textBoxHuman
            // 
            textBoxHuman.Location = new Point(215, 27);
            textBoxHuman.Name = "textBoxHuman";
            textBoxHuman.PlaceholderText = "введите время прихода пассажира";
            textBoxHuman.Size = new Size(201, 23);
            textBoxHuman.TabIndex = 2;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(235, 65);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(135, 23);
            buttonCheck.TabIndex = 3;
            buttonCheck.Text = "Вывести результат";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(269, 91);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "Результат";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 5;
            label1.Text = "Время прибытия поезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 6;
            label2.Text = "Время прихода пассажира";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 9);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 7;
            label3.Text = "Время ухода поезда";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(517, 91);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 124);
            Controls.Add(buttonClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxHuman);
            Controls.Add(textBoxTrainOut);
            Controls.Add(textBoxTrainIn);
            KeyPreview = true;
            Name = "Form1";
            Text = "Расчет наличия поезда на станции";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxTrainIn;
        public TextBox textBoxTrainOut;
        public TextBox textBoxHuman;
        public Button buttonCheck;
        public Label labelResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonClear;
    }
}

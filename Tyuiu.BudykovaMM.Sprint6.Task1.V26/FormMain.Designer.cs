namespace Tyuiu.BudykovaMM.Sprint6.Task1.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_BMM = new GroupBox();
            pictureBox1 = new PictureBox();
            labelTask2_BMM = new Label();
            labelTask1_BMM = new Label();
            groupBoxResult_BMM = new GroupBox();
            labelResult_BMM = new Label();
            textBoxResult_BMM = new TextBox();
            groupBoxData_BMM = new GroupBox();
            textBoxStop_BMM = new TextBox();
            textBoxStart_BMM = new TextBox();
            labelStop_BMM = new Label();
            labelStart_BMM = new Label();
            buttonHelp_BMM = new Button();
            buttonDone = new Button();
            groupBoxTask_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxResult_BMM.SuspendLayout();
            groupBoxData_BMM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(pictureBox1);
            groupBoxTask_BMM.Controls.Add(labelTask2_BMM);
            groupBoxTask_BMM.Controls.Add(labelTask1_BMM);
            groupBoxTask_BMM.Location = new Point(0, 0);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(532, 342);
            groupBoxTask_BMM.TabIndex = 0;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask2_BMM
            // 
            labelTask2_BMM.AutoSize = true;
            labelTask2_BMM.Location = new Point(6, 43);
            labelTask2_BMM.Name = "labelTask2_BMM";
            labelTask2_BMM.Size = new Size(252, 20);
            labelTask2_BMM.TabIndex = 1;
            labelTask2_BMM.Text = "Результат вывести в виде таблицы.";
            // 
            // labelTask1_BMM
            // 
            labelTask1_BMM.AutoSize = true;
            labelTask1_BMM.Location = new Point(6, 23);
            labelTask1_BMM.Name = "labelTask1_BMM";
            labelTask1_BMM.Size = new Size(380, 20);
            labelTask1_BMM.TabIndex = 0;
            labelTask1_BMM.Text = "Протабулировать функцию на заданном диапазоне. ";
            // 
            // groupBoxResult_BMM
            // 
            groupBoxResult_BMM.Controls.Add(labelResult_BMM);
            groupBoxResult_BMM.Controls.Add(textBoxResult_BMM);
            groupBoxResult_BMM.Location = new Point(538, 0);
            groupBoxResult_BMM.Name = "groupBoxResult_BMM";
            groupBoxResult_BMM.Size = new Size(259, 432);
            groupBoxResult_BMM.TabIndex = 0;
            groupBoxResult_BMM.TabStop = false;
            groupBoxResult_BMM.Text = "Вывод данных ";
            // 
            // labelResult_BMM
            // 
            labelResult_BMM.AutoSize = true;
            labelResult_BMM.Location = new Point(6, 23);
            labelResult_BMM.Name = "labelResult_BMM";
            labelResult_BMM.Size = new Size(78, 20);
            labelResult_BMM.TabIndex = 1;
            labelResult_BMM.Text = "Результат:";
            // 
            // textBoxResult_BMM
            // 
            textBoxResult_BMM.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_BMM.Location = new Point(6, 43);
            textBoxResult_BMM.Multiline = true;
            textBoxResult_BMM.Name = "textBoxResult_BMM";
            textBoxResult_BMM.ReadOnly = true;
            textBoxResult_BMM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BMM.Size = new Size(247, 392);
            textBoxResult_BMM.TabIndex = 0;
            // 
            // groupBoxData_BMM
            // 
            groupBoxData_BMM.Controls.Add(textBoxStop_BMM);
            groupBoxData_BMM.Controls.Add(textBoxStart_BMM);
            groupBoxData_BMM.Controls.Add(labelStop_BMM);
            groupBoxData_BMM.Controls.Add(labelStart_BMM);
            groupBoxData_BMM.Location = new Point(0, 342);
            groupBoxData_BMM.Name = "groupBoxData_BMM";
            groupBoxData_BMM.Size = new Size(288, 90);
            groupBoxData_BMM.TabIndex = 2;
            groupBoxData_BMM.TabStop = false;
            groupBoxData_BMM.Text = "Ввод данных";
            // 
            // textBoxStop_BMM
            // 
            textBoxStop_BMM.Location = new Point(156, 46);
            textBoxStop_BMM.Name = "textBoxStop_BMM";
            textBoxStop_BMM.Size = new Size(125, 27);
            textBoxStop_BMM.TabIndex = 3;
            // 
            // textBoxStart_BMM
            // 
            textBoxStart_BMM.Location = new Point(6, 46);
            textBoxStart_BMM.Name = "textBoxStart_BMM";
            textBoxStart_BMM.Size = new Size(125, 27);
            textBoxStart_BMM.TabIndex = 2;
            // 
            // labelStop_BMM
            // 
            labelStop_BMM.AutoSize = true;
            labelStop_BMM.Location = new Point(156, 23);
            labelStop_BMM.Name = "labelStop_BMM";
            labelStop_BMM.Size = new Size(94, 20);
            labelStop_BMM.TabIndex = 1;
            labelStop_BMM.Text = "Конец шага:";
            // 
            // labelStart_BMM
            // 
            labelStart_BMM.AutoSize = true;
            labelStart_BMM.Location = new Point(6, 23);
            labelStart_BMM.Name = "labelStart_BMM";
            labelStart_BMM.Size = new Size(88, 20);
            labelStart_BMM.TabIndex = 0;
            labelStart_BMM.Text = "Старт шага:";
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.BackColor = SystemColors.MenuHighlight;
            buttonHelp_BMM.Location = new Point(294, 351);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(96, 84);
            buttonHelp_BMM.TabIndex = 4;
            buttonHelp_BMM.Text = "Справка";
            buttonHelp_BMM.UseVisualStyleBackColor = false;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(396, 351);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(142, 84);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp_BMM);
            Controls.Add(groupBoxData_BMM);
            Controls.Add(groupBoxResult_BMM);
            Controls.Add(groupBoxTask_BMM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Будыкова М. М.";
            groupBoxTask_BMM.ResumeLayout(false);
            groupBoxTask_BMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxResult_BMM.ResumeLayout(false);
            groupBoxResult_BMM.PerformLayout();
            groupBoxData_BMM.ResumeLayout(false);
            groupBoxData_BMM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BMM;
        private GroupBox groupBoxResult_BMM;
        private TextBox textBoxResult_BMM;
        private Label labelTask1_BMM;
        private Label labelTask2_BMM;
        private PictureBox pictureBox1;
        private Label labelResult_BMM;
        private GroupBox groupBoxData_BMM;
        private Label labelStop_BMM;
        private Label labelStart_BMM;
        private TextBox textBoxStart_BMM;
        private TextBox textBoxStop_BMM;
        private Button buttonHelp_BMM;
        private Button buttonDone;
    }
}

namespace Tyuiu.BudykovaMM.Sprint6.Task3.V17
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
            groupBoxTask_BMM = new GroupBox();
            dataGridViewMatrix_BMM = new DataGridView();
            labelTask_BMM = new Label();
            groupBoxResult_BMM = new GroupBox();
            textBoxResult_BMM = new TextBox();
            labelResult_BMM = new Label();
            buttonDone_BMM = new Button();
            buttonHelp_BMM = new Button();
            groupBoxTask_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BMM).BeginInit();
            groupBoxResult_BMM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(dataGridViewMatrix_BMM);
            groupBoxTask_BMM.Controls.Add(labelTask_BMM);
            groupBoxTask_BMM.Location = new Point(0, 12);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(587, 436);
            groupBoxTask_BMM.TabIndex = 0;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие";
            // 
            // dataGridViewMatrix_BMM
            // 
            dataGridViewMatrix_BMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BMM.Location = new Point(326, 37);
            dataGridViewMatrix_BMM.Name = "dataGridViewMatrix_BMM";
            dataGridViewMatrix_BMM.RowHeadersWidth = 51;
            dataGridViewMatrix_BMM.Size = new Size(256, 289);
            dataGridViewMatrix_BMM.TabIndex = 2;
            // 
            // labelTask_BMM
            // 
            labelTask_BMM.Location = new Point(6, 23);
            labelTask_BMM.Name = "labelTask_BMM";
            labelTask_BMM.Size = new Size(332, 171);
            labelTask_BMM.TabIndex = 0;
            labelTask_BMM.Text = "Дана матрица 5 на 5 \r\n22  32 -16  24  27\r\n 3 -20  24 -20  25\r\n21  17  -8 -19  17\r\n 8  22  28  27  19\r\n11  20  12  27  29\r\nВыполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // groupBoxResult_BMM
            // 
            groupBoxResult_BMM.Controls.Add(textBoxResult_BMM);
            groupBoxResult_BMM.Controls.Add(labelResult_BMM);
            groupBoxResult_BMM.Location = new Point(593, 12);
            groupBoxResult_BMM.Name = "groupBoxResult_BMM";
            groupBoxResult_BMM.Size = new Size(203, 395);
            groupBoxResult_BMM.TabIndex = 0;
            groupBoxResult_BMM.TabStop = false;
            groupBoxResult_BMM.Text = "Вывод данных";
            // 
            // textBoxResult_BMM
            // 
            textBoxResult_BMM.Location = new Point(0, 46);
            textBoxResult_BMM.Multiline = true;
            textBoxResult_BMM.Name = "textBoxResult_BMM";
            textBoxResult_BMM.ReadOnly = true;
            textBoxResult_BMM.Size = new Size(195, 280);
            textBoxResult_BMM.TabIndex = 1;
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
            // buttonDone_BMM
            // 
            buttonDone_BMM.Location = new Point(689, 413);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(99, 29);
            buttonDone_BMM.TabIndex = 3;
            buttonDone_BMM.Text = "Выполнить";
            buttonDone_BMM.UseVisualStyleBackColor = true;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.Location = new Point(641, 413);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(37, 29);
            buttonHelp_BMM.TabIndex = 4;
            buttonHelp_BMM.Text = "?";
            buttonHelp_BMM.UseVisualStyleBackColor = true;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_BMM);
            Controls.Add(buttonDone_BMM);
            Controls.Add(groupBoxResult_BMM);
            Controls.Add(groupBoxTask_BMM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 17 | Будыкова М. М.";
            Load += FormMain_Load;
            groupBoxTask_BMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BMM).EndInit();
            groupBoxResult_BMM.ResumeLayout(false);
            groupBoxResult_BMM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BMM;
        private Label labelTask_BMM;
        private GroupBox groupBoxResult_BMM;
        private DataGridView dataGridViewMatrix_BMM;
        private TextBox textBoxResult_BMM;
        private Label labelResult_BMM;
        private Button buttonDone_BMM;
        private Button buttonHelp_BMM;
    }
}

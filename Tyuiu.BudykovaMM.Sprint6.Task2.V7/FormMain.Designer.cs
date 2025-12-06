namespace Tyuiu.BudykovaMM.Sprint6.Task2.V7
{
    partial class FormMain_BMM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_BMM = new GroupBox();
            labelTask2_BMM = new Label();
            labelTask1_BMM = new Label();
            groupBoxData_BMM = new GroupBox();
            textBoxStop_BMM = new TextBox();
            textBoxStart_BMM = new TextBox();
            labelStop_BMM = new Label();
            labelStart_BMM = new Label();
            buttonHelp_BMM = new Button();
            buttonDone_BMM = new Button();
            groupBoxResult_BMM = new GroupBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            f = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelResult_BMM = new Label();
            groupBoxTask_BMM.SuspendLayout();
            groupBoxData_BMM.SuspendLayout();
            groupBoxResult_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(labelTask2_BMM);
            groupBoxTask_BMM.Controls.Add(labelTask1_BMM);
            groupBoxTask_BMM.Location = new Point(0, 0);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(579, 215);
            groupBoxTask_BMM.TabIndex = 0;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие";
            // 
            // labelTask2_BMM
            // 
            labelTask2_BMM.AutoSize = true;
            labelTask2_BMM.Location = new Point(6, 43);
            labelTask2_BMM.Name = "labelTask2_BMM";
            labelTask2_BMM.Size = new Size(450, 20);
            labelTask2_BMM.TabIndex = 2;
            labelTask2_BMM.Text = "Результат вывести в DataGridView и построить график функции";
            // 
            // labelTask1_BMM
            // 
            labelTask1_BMM.AutoSize = true;
            labelTask1_BMM.Location = new Point(6, 23);
            labelTask1_BMM.Name = "labelTask1_BMM";
            labelTask1_BMM.Size = new Size(569, 20);
            labelTask1_BMM.TabIndex = 1;
            labelTask1_BMM.Text = "Протабулировать функцию 3*x + 2 - x/(Math.Cos(x) + 1) на заданном диапазоне ";
            // 
            // groupBoxData_BMM
            // 
            groupBoxData_BMM.Controls.Add(textBoxStop_BMM);
            groupBoxData_BMM.Controls.Add(textBoxStart_BMM);
            groupBoxData_BMM.Controls.Add(labelStop_BMM);
            groupBoxData_BMM.Controls.Add(labelStart_BMM);
            groupBoxData_BMM.Location = new Point(0, 215);
            groupBoxData_BMM.Name = "groupBoxData_BMM";
            groupBoxData_BMM.Size = new Size(291, 85);
            groupBoxData_BMM.TabIndex = 3;
            groupBoxData_BMM.TabStop = false;
            groupBoxData_BMM.Text = "Ввод данных";
            // 
            // textBoxStop_BMM
            // 
            textBoxStop_BMM.Location = new Point(142, 52);
            textBoxStop_BMM.Name = "textBoxStop_BMM";
            textBoxStop_BMM.Size = new Size(125, 27);
            textBoxStop_BMM.TabIndex = 3;
            // 
            // textBoxStart_BMM
            // 
            textBoxStart_BMM.Location = new Point(3, 52);
            textBoxStart_BMM.Name = "textBoxStart_BMM";
            textBoxStart_BMM.Size = new Size(125, 27);
            textBoxStart_BMM.TabIndex = 2;
            // 
            // labelStop_BMM
            // 
            labelStop_BMM.AutoSize = true;
            labelStop_BMM.Location = new Point(142, 23);
            labelStop_BMM.Name = "labelStop_BMM";
            labelStop_BMM.Size = new Size(94, 20);
            labelStop_BMM.TabIndex = 1;
            labelStop_BMM.Text = "Конец шага:";
            // 
            // labelStart_BMM
            // 
            labelStart_BMM.AutoSize = true;
            labelStart_BMM.Location = new Point(3, 23);
            labelStart_BMM.Name = "labelStart_BMM";
            labelStart_BMM.Size = new Size(88, 20);
            labelStart_BMM.TabIndex = 0;
            labelStart_BMM.Text = "Старт шага:";
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.BackColor = SystemColors.Highlight;
            buttonHelp_BMM.Location = new Point(297, 229);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(126, 71);
            buttonHelp_BMM.TabIndex = 4;
            buttonHelp_BMM.Text = "Справка";
            buttonHelp_BMM.UseVisualStyleBackColor = false;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            // 
            // buttonDone_BMM
            // 
            buttonDone_BMM.BackColor = Color.Green;
            buttonDone_BMM.Location = new Point(429, 229);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(146, 71);
            buttonDone_BMM.TabIndex = 5;
            buttonDone_BMM.Text = "Выполнить";
            buttonDone_BMM.UseVisualStyleBackColor = false;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            buttonDone_BMM.MouseDown += buttonDone_BMM_MouseDown;
            buttonDone_BMM.MouseEnter += buttonDone_BMM_MouseEnter;
            buttonDone_BMM.MouseLeave += buttonDone_BMM_MouseLeave;
            // 
            // groupBoxResult_BMM
            // 
            groupBoxResult_BMM.Controls.Add(dataGridViewFunction);
            groupBoxResult_BMM.Controls.Add(chartFunction);
            groupBoxResult_BMM.Controls.Add(labelResult_BMM);
            groupBoxResult_BMM.Location = new Point(581, 12);
            groupBoxResult_BMM.Name = "groupBoxResult_BMM";
            groupBoxResult_BMM.Size = new Size(443, 282);
            groupBoxResult_BMM.TabIndex = 6;
            groupBoxResult_BMM.TabStop = false;
            groupBoxResult_BMM.Text = "Вывод данных";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, f });
            dataGridViewFunction.Location = new Point(6, 46);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(160, 236);
            dataGridViewFunction.TabIndex = 8;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // f
            // 
            f.HeaderText = "F(X)";
            f.MinimumWidth = 6;
            f.Name = "f";
            f.Width = 50;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(169, 11);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(268, 265);
            chartFunction.TabIndex = 7;
            chartFunction.Text = "chart1";
            // 
            // labelResult_BMM
            // 
            labelResult_BMM.AutoSize = true;
            labelResult_BMM.Location = new Point(3, 23);
            labelResult_BMM.Name = "labelResult_BMM";
            labelResult_BMM.Size = new Size(78, 20);
            labelResult_BMM.TabIndex = 0;
            labelResult_BMM.Text = "Результат:";
            // 
            // FormMain_BMM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 306);
            Controls.Add(groupBoxResult_BMM);
            Controls.Add(buttonDone_BMM);
            Controls.Add(buttonHelp_BMM);
            Controls.Add(groupBoxData_BMM);
            Controls.Add(groupBoxTask_BMM);
            Name = "FormMain_BMM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 7 | Будыкова М. М.";
            groupBoxTask_BMM.ResumeLayout(false);
            groupBoxTask_BMM.PerformLayout();
            groupBoxData_BMM.ResumeLayout(false);
            groupBoxData_BMM.PerformLayout();
            groupBoxResult_BMM.ResumeLayout(false);
            groupBoxResult_BMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BMM;
        private Label labelTask2_BMM;
        private Label labelTask1_BMM;
        private GroupBox groupBoxData_BMM;
        private Label labelStop_BMM;
        private Label labelStart_BMM;
        private TextBox textBoxStop_BMM;
        private TextBox textBoxStart_BMM;
        private Button buttonHelp_BMM;
        private Button buttonDone_BMM;
        private GroupBox groupBoxResult_BMM;
        private Label labelResult_BMM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn f;
    }
}

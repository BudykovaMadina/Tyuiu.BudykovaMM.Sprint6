namespace Tyuiu.BudykovaMM.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_BMM = new Panel();
            groupBoxData_BMM = new GroupBox();
            textBoxStop_BMM = new TextBox();
            buttonHelp_BMM = new Button();
            buttonSave_BMM = new Button();
            buttonResult_BMM = new Button();
            textBoxStart_BMM = new TextBox();
            labelStart_BMM = new Label();
            labelStop_BMM = new Label();
            groupBoxTask_BMM = new GroupBox();
            labelTask_BMM = new Label();
            groupBoxD_BMM = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxRes_BMM = new TextBox();
            panelFill_BMM = new Panel();
            groupBoxDone_BMM = new GroupBox();
            textBoxDone_BMM = new TextBox();
            chartFunction_BMM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_BMM.SuspendLayout();
            groupBoxData_BMM.SuspendLayout();
            groupBoxTask_BMM.SuspendLayout();
            groupBoxD_BMM.SuspendLayout();
            panelFill_BMM.SuspendLayout();
            groupBoxDone_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BMM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BMM
            // 
            panelTop_BMM.BackColor = SystemColors.Control;
            panelTop_BMM.Controls.Add(groupBoxData_BMM);
            panelTop_BMM.Dock = DockStyle.Top;
            panelTop_BMM.Location = new Point(0, 0);
            panelTop_BMM.Name = "panelTop_BMM";
            panelTop_BMM.Size = new Size(1182, 95);
            panelTop_BMM.TabIndex = 0;
            // 
            // groupBoxData_BMM
            // 
            groupBoxData_BMM.Controls.Add(textBoxStop_BMM);
            groupBoxData_BMM.Controls.Add(buttonHelp_BMM);
            groupBoxData_BMM.Controls.Add(buttonSave_BMM);
            groupBoxData_BMM.Controls.Add(buttonResult_BMM);
            groupBoxData_BMM.Controls.Add(textBoxStart_BMM);
            groupBoxData_BMM.Controls.Add(labelStart_BMM);
            groupBoxData_BMM.Controls.Add(labelStop_BMM);
            groupBoxData_BMM.Location = new Point(565, 0);
            groupBoxData_BMM.Name = "groupBoxData_BMM";
            groupBoxData_BMM.Size = new Size(614, 89);
            groupBoxData_BMM.TabIndex = 0;
            groupBoxData_BMM.TabStop = false;
            groupBoxData_BMM.Text = "Ввод данных";
            // 
            // textBoxStop_BMM
            // 
            textBoxStop_BMM.Location = new Point(137, 46);
            textBoxStop_BMM.Name = "textBoxStop_BMM";
            textBoxStop_BMM.Size = new Size(125, 27);
            textBoxStop_BMM.TabIndex = 8;
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BMM.BackColor = SystemColors.MenuHighlight;
            buttonHelp_BMM.Location = new Point(493, 12);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(102, 71);
            buttonHelp_BMM.TabIndex = 6;
            buttonHelp_BMM.Text = "Справка";
            buttonHelp_BMM.UseVisualStyleBackColor = false;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            // 
            // buttonSave_BMM
            // 
            buttonSave_BMM.BackColor = Color.SlateBlue;
            buttonSave_BMM.Location = new Point(383, 12);
            buttonSave_BMM.Name = "buttonSave_BMM";
            buttonSave_BMM.Size = new Size(104, 71);
            buttonSave_BMM.TabIndex = 5;
            buttonSave_BMM.Text = "Сохранить";
            buttonSave_BMM.UseVisualStyleBackColor = false;
            buttonSave_BMM.Click += buttonSave_BMM_Click;
            // 
            // buttonResult_BMM
            // 
            buttonResult_BMM.BackColor = Color.Green;
            buttonResult_BMM.Location = new Point(268, 12);
            buttonResult_BMM.Name = "buttonResult_BMM";
            buttonResult_BMM.Size = new Size(109, 71);
            buttonResult_BMM.TabIndex = 4;
            buttonResult_BMM.Text = "Выполнить";
            buttonResult_BMM.UseVisualStyleBackColor = false;
            buttonResult_BMM.Click += buttonResult_BMM_Click;
            // 
            // textBoxStart_BMM
            // 
            textBoxStart_BMM.Location = new Point(6, 46);
            textBoxStart_BMM.Name = "textBoxStart_BMM";
            textBoxStart_BMM.Size = new Size(125, 27);
            textBoxStart_BMM.TabIndex = 3;
            // 
            // labelStart_BMM
            // 
            labelStart_BMM.AutoSize = true;
            labelStart_BMM.Location = new Point(6, 23);
            labelStart_BMM.Name = "labelStart_BMM";
            labelStart_BMM.Size = new Size(88, 20);
            labelStart_BMM.TabIndex = 1;
            labelStart_BMM.Text = "Старт шага:";
            // 
            // labelStop_BMM
            // 
            labelStop_BMM.AutoSize = true;
            labelStop_BMM.Location = new Point(146, 23);
            labelStop_BMM.Name = "labelStop_BMM";
            labelStop_BMM.Size = new Size(94, 20);
            labelStop_BMM.TabIndex = 2;
            labelStop_BMM.Text = "Конец шага:";
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(labelTask_BMM);
            groupBoxTask_BMM.Location = new Point(0, 0);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(559, 89);
            groupBoxTask_BMM.TabIndex = 1;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие";
            // 
            // labelTask_BMM
            // 
            labelTask_BMM.AutoSize = true;
            labelTask_BMM.Location = new Point(6, 23);
            labelTask_BMM.Name = "labelTask_BMM";
            labelTask_BMM.Size = new Size(538, 60);
            labelTask_BMM.TabIndex = 0;
            labelTask_BMM.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V23 по нажатию кнопки.";
            // 
            // groupBoxD_BMM
            // 
            groupBoxD_BMM.Controls.Add(groupBox1);
            groupBoxD_BMM.Controls.Add(textBoxRes_BMM);
            groupBoxD_BMM.Location = new Point(3, 3);
            groupBoxD_BMM.Name = "groupBoxD_BMM";
            groupBoxD_BMM.Size = new Size(324, 359);
            groupBoxD_BMM.TabIndex = 0;
            groupBoxD_BMM.TabStop = false;
            groupBoxD_BMM.Text = "Вывод";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxRes_BMM
            // 
            textBoxRes_BMM.BackColor = SystemColors.ControlLightLight;
            textBoxRes_BMM.Location = new Point(3, 23);
            textBoxRes_BMM.Multiline = true;
            textBoxRes_BMM.Name = "textBoxRes_BMM";
            textBoxRes_BMM.ReadOnly = true;
            textBoxRes_BMM.Size = new Size(315, 330);
            textBoxRes_BMM.TabIndex = 0;
            // 
            // panelFill_BMM
            // 
            panelFill_BMM.Controls.Add(groupBoxDone_BMM);
            panelFill_BMM.Controls.Add(chartFunction_BMM);
            panelFill_BMM.Dock = DockStyle.Fill;
            panelFill_BMM.Location = new Point(0, 95);
            panelFill_BMM.Name = "panelFill_BMM";
            panelFill_BMM.Size = new Size(1182, 408);
            panelFill_BMM.TabIndex = 2;
            // 
            // groupBoxDone_BMM
            // 
            groupBoxDone_BMM.Controls.Add(textBoxDone_BMM);
            groupBoxDone_BMM.Dock = DockStyle.Left;
            groupBoxDone_BMM.Location = new Point(0, 0);
            groupBoxDone_BMM.Name = "groupBoxDone_BMM";
            groupBoxDone_BMM.Size = new Size(559, 408);
            groupBoxDone_BMM.TabIndex = 8;
            groupBoxDone_BMM.TabStop = false;
            groupBoxDone_BMM.Text = "Вывод";
            // 
            // textBoxDone_BMM
            // 
            textBoxDone_BMM.BackColor = SystemColors.ControlLightLight;
            textBoxDone_BMM.Location = new Point(3, 23);
            textBoxDone_BMM.Multiline = true;
            textBoxDone_BMM.Name = "textBoxDone_BMM";
            textBoxDone_BMM.ReadOnly = true;
            textBoxDone_BMM.Size = new Size(358, 358);
            textBoxDone_BMM.TabIndex = 0;
            // 
            // chartFunction_BMM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BMM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BMM.Legends.Add(legend1);
            chartFunction_BMM.Location = new Point(586, 6);
            chartFunction_BMM.Name = "chartFunction_BMM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BMM.Series.Add(series1);
            chartFunction_BMM.Size = new Size(375, 375);
            chartFunction_BMM.TabIndex = 7;
            chartFunction_BMM.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 503);
            Controls.Add(panelFill_BMM);
            Controls.Add(groupBoxTask_BMM);
            Controls.Add(panelTop_BMM);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 23 | Будыкова М. М.";
            panelTop_BMM.ResumeLayout(false);
            groupBoxData_BMM.ResumeLayout(false);
            groupBoxData_BMM.PerformLayout();
            groupBoxTask_BMM.ResumeLayout(false);
            groupBoxTask_BMM.PerformLayout();
            groupBoxD_BMM.ResumeLayout(false);
            groupBoxD_BMM.PerformLayout();
            panelFill_BMM.ResumeLayout(false);
            groupBoxDone_BMM.ResumeLayout(false);
            groupBoxDone_BMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BMM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BMM;
        private Splitter splitter1;
        private ColorDialog colorDialog1;
        private GroupBox groupBoxData_BMM;
        private GroupBox groupBoxD_BMM;
        private GroupBox groupBoxTask_BMM;
        private Label labelStart_BMM;
        private Label labelStop_BMM;
        private Label labelTask_BMM;
        private TextBox textBoxDone_BMM;
        private TextBox textBoxStart_BMM;
        private Panel panelFill_BMM;
        private Button buttonHelp_BMM;
        private Button buttonSave_BMM;
        private Button buttonResult_BMM;
        private TextBox textBoxRes_BMM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BMM;
        private Panel panelRight_BMM;
        private TextBox textBoxStop_BMM;
        private GroupBox groupBox1;
        private GroupBox groupBoxDone_BMM;
        private GroupBox groupBox2;
    }
}

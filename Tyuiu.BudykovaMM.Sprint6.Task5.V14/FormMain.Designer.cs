namespace Tyuiu.BudykovaMM.Sprint6.Task5.V14
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
            buttonHelp_BMM = new Button();
            buttonFile_BMM = new Button();
            buttonDone_BMM = new Button();
            groupBoxTask_BMM = new GroupBox();
            labelTask_BMM = new Label();
            splitContainer1 = new SplitContainer();
            groupBoxResult_BMM = new GroupBox();
            dataGridViewResult_BMM = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            chartFunction_BMM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_BMM.SuspendLayout();
            groupBoxTask_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxResult_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BMM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BMM
            // 
            panelTop_BMM.Controls.Add(buttonHelp_BMM);
            panelTop_BMM.Controls.Add(buttonFile_BMM);
            panelTop_BMM.Controls.Add(buttonDone_BMM);
            panelTop_BMM.Controls.Add(groupBoxTask_BMM);
            panelTop_BMM.Dock = DockStyle.Top;
            panelTop_BMM.Location = new Point(0, 0);
            panelTop_BMM.Name = "panelTop_BMM";
            panelTop_BMM.Size = new Size(832, 125);
            panelTop_BMM.TabIndex = 0;
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BMM.BackColor = SystemColors.Highlight;
            buttonHelp_BMM.Location = new Point(722, 23);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(104, 71);
            buttonHelp_BMM.TabIndex = 3;
            buttonHelp_BMM.Text = "Справка";
            buttonHelp_BMM.UseVisualStyleBackColor = false;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            // 
            // buttonFile_BMM
            // 
            buttonFile_BMM.BackColor = SystemColors.HotTrack;
            buttonFile_BMM.Location = new Point(601, 23);
            buttonFile_BMM.Name = "buttonFile_BMM";
            buttonFile_BMM.Size = new Size(115, 71);
            buttonFile_BMM.TabIndex = 2;
            buttonFile_BMM.Text = "Открыть \r\nфайл";
            buttonFile_BMM.UseVisualStyleBackColor = false;
            buttonFile_BMM.Click += buttonFile_BMM_Click;
            // 
            // buttonDone_BMM
            // 
            buttonDone_BMM.BackColor = Color.Green;
            buttonDone_BMM.Location = new Point(487, 23);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(108, 69);
            buttonDone_BMM.TabIndex = 1;
            buttonDone_BMM.Text = "Выполнить";
            buttonDone_BMM.UseVisualStyleBackColor = false;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(labelTask_BMM);
            groupBoxTask_BMM.Location = new Point(0, 0);
            groupBoxTask_BMM.MinimumSize = new Size(427, 125);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(481, 125);
            groupBoxTask_BMM.TabIndex = 0;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие";
            // 
            // labelTask_BMM
            // 
            labelTask_BMM.Location = new Point(3, 23);
            labelTask_BMM.Name = "labelTask_BMM";
            labelTask_BMM.Size = new Size(468, 80);
            labelTask_BMM.TabIndex = 0;
            labelTask_BMM.Text = "Прочитать данные из файла InPutFileTask5V14.txt. Вывести в dataGridView. \r\nВывести все числа, больше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 125);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxResult_BMM);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chartFunction_BMM);
            splitContainer1.Size = new Size(832, 328);
            splitContainer1.SplitterDistance = 189;
            splitContainer1.TabIndex = 1;
            // 
            // groupBoxResult_BMM
            // 
            groupBoxResult_BMM.Controls.Add(dataGridViewResult_BMM);
            groupBoxResult_BMM.Location = new Point(3, 3);
            groupBoxResult_BMM.Name = "groupBoxResult_BMM";
            groupBoxResult_BMM.Size = new Size(183, 322);
            groupBoxResult_BMM.TabIndex = 4;
            groupBoxResult_BMM.TabStop = false;
            groupBoxResult_BMM.Text = "Вывод данных";
            // 
            // dataGridViewResult_BMM
            // 
            dataGridViewResult_BMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BMM.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dataGridViewResult_BMM.Dock = DockStyle.Left;
            dataGridViewResult_BMM.Location = new Point(3, 23);
            dataGridViewResult_BMM.Name = "dataGridViewResult_BMM";
            dataGridViewResult_BMM.RowHeadersVisible = false;
            dataGridViewResult_BMM.RowHeadersWidth = 51;
            dataGridViewResult_BMM.Size = new Size(180, 296);
            dataGridViewResult_BMM.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // chartFunction_BMM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BMM.ChartAreas.Add(chartArea1);
            chartFunction_BMM.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_BMM.Legends.Add(legend1);
            chartFunction_BMM.Location = new Point(0, 0);
            chartFunction_BMM.Name = "chartFunction_BMM";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BMM.Series.Add(series1);
            chartFunction_BMM.Size = new Size(639, 328);
            chartFunction_BMM.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(splitContainer1);
            Controls.Add(panelTop_BMM);
            MinimumSize = new Size(850, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 14 | Будыкова М. М.";
            panelTop_BMM.ResumeLayout(false);
            groupBoxTask_BMM.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxResult_BMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BMM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BMM;
        private GroupBox groupBoxTask_BMM;
        private SplitContainer splitContainer1;
        private Label labelTask_BMM;
        private Button buttonHelp_BMM;
        private Button buttonFile_BMM;
        private Button buttonDone_BMM;
        private GroupBox groupBoxResult_BMM;
        private DataGridView dataGridViewResult_BMM;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BMM;
    }
}

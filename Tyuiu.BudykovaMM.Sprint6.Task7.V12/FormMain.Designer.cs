namespace Tyuiu.BudykovaMM.Sprint6.Task7.V12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_BMM = new Panel();
            buttonHelp_BMM = new Button();
            buttonSaveFile_BMM = new Button();
            buttonDone_BMM = new Button();
            buttonOpenFile_BMM = new Button();
            panelMiddle_BMM = new Panel();
            groupBoxTask_BMM = new GroupBox();
            labelTask_BMM = new Label();
            splitContainerData_BMM = new SplitContainer();
            groupBoxData_BMM = new GroupBox();
            dataGridViewDataInput_BMM = new DataGridView();
            dataGridViewDataOutput_BMM = new DataGridView();
            groupBoxResult_BMM = new GroupBox();
            openFileDialogTask_BMM = new OpenFileDialog();
            toolTipButton_BMM = new ToolTip(components);
            saveFileDialogMatrix_BMM = new SaveFileDialog();
            panelTop_BMM.SuspendLayout();
            panelMiddle_BMM.SuspendLayout();
            groupBoxTask_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerData_BMM).BeginInit();
            splitContainerData_BMM.Panel1.SuspendLayout();
            splitContainerData_BMM.Panel2.SuspendLayout();
            splitContainerData_BMM.SuspendLayout();
            groupBoxData_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataInput_BMM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataOutput_BMM).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BMM
            // 
            panelTop_BMM.Controls.Add(buttonHelp_BMM);
            panelTop_BMM.Controls.Add(buttonSaveFile_BMM);
            panelTop_BMM.Controls.Add(buttonDone_BMM);
            panelTop_BMM.Controls.Add(buttonOpenFile_BMM);
            panelTop_BMM.Dock = DockStyle.Top;
            panelTop_BMM.Location = new Point(0, 0);
            panelTop_BMM.Name = "panelTop_BMM";
            panelTop_BMM.Size = new Size(1021, 61);
            panelTop_BMM.TabIndex = 0;
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BMM.FlatStyle = FlatStyle.Flat;
            buttonHelp_BMM.Image = (Image)resources.GetObject("buttonHelp_BMM.Image");
            buttonHelp_BMM.Location = new Point(943, 3);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(75, 55);
            buttonHelp_BMM.TabIndex = 3;
            toolTipButton_BMM.SetToolTip(buttonHelp_BMM, "Сведение о программе");
            buttonHelp_BMM.UseVisualStyleBackColor = true;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            buttonHelp_BMM.MouseEnter += buttonHelp_BMM_MouseEnter;
            // 
            // buttonSaveFile_BMM
            // 
            buttonSaveFile_BMM.Enabled = false;
            buttonSaveFile_BMM.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_BMM.Image = (Image)resources.GetObject("buttonSaveFile_BMM.Image");
            buttonSaveFile_BMM.Location = new Point(165, 2);
            buttonSaveFile_BMM.Name = "buttonSaveFile_BMM";
            buttonSaveFile_BMM.Size = new Size(75, 55);
            buttonSaveFile_BMM.TabIndex = 2;
            toolTipButton_BMM.SetToolTip(buttonSaveFile_BMM, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_BMM.UseVisualStyleBackColor = true;
            buttonSaveFile_BMM.Click += buttonSaveFile_BMM_Click;
            buttonSaveFile_BMM.MouseEnter += buttonSaveFile_BMM_MouseEnter;
            // 
            // buttonDone_BMM
            // 
            buttonDone_BMM.Enabled = false;
            buttonDone_BMM.FlatStyle = FlatStyle.Flat;
            buttonDone_BMM.Image = (Image)resources.GetObject("buttonDone_BMM.Image");
            buttonDone_BMM.Location = new Point(84, 2);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(75, 55);
            buttonDone_BMM.TabIndex = 1;
            toolTipButton_BMM.SetToolTip(buttonDone_BMM, "Выполнить обработку данных ");
            buttonDone_BMM.UseVisualStyleBackColor = true;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            buttonDone_BMM.MouseEnter += buttonDone_BMM_MouseEnter;
            // 
            // buttonOpenFile_BMM
            // 
            buttonOpenFile_BMM.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_BMM.Image = (Image)resources.GetObject("buttonOpenFile_BMM.Image");
            buttonOpenFile_BMM.Location = new Point(3, 2);
            buttonOpenFile_BMM.Name = "buttonOpenFile_BMM";
            buttonOpenFile_BMM.Size = new Size(75, 55);
            buttonOpenFile_BMM.TabIndex = 0;
            toolTipButton_BMM.SetToolTip(buttonOpenFile_BMM, "Открыть файл для обработки данных в формате csv");
            buttonOpenFile_BMM.UseVisualStyleBackColor = true;
            buttonOpenFile_BMM.Click += buttonOpenFile_BMM_Click;
            buttonOpenFile_BMM.MouseEnter += buttonOpenFile_BMM_MouseEnter;
            // 
            // panelMiddle_BMM
            // 
            panelMiddle_BMM.Controls.Add(groupBoxTask_BMM);
            panelMiddle_BMM.Dock = DockStyle.Top;
            panelMiddle_BMM.Location = new Point(0, 61);
            panelMiddle_BMM.Name = "panelMiddle_BMM";
            panelMiddle_BMM.Size = new Size(1021, 90);
            panelMiddle_BMM.TabIndex = 0;
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(labelTask_BMM);
            groupBoxTask_BMM.Dock = DockStyle.Fill;
            groupBoxTask_BMM.Location = new Point(0, 0);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(1021, 90);
            groupBoxTask_BMM.TabIndex = 0;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие:";
            // 
            // labelTask_BMM
            // 
            labelTask_BMM.AutoSize = true;
            labelTask_BMM.Location = new Point(3, 21);
            labelTask_BMM.Name = "labelTask_BMM";
            labelTask_BMM.Size = new Size(799, 60);
            labelTask_BMM.TabIndex = 0;
            labelTask_BMM.Text = resources.GetString("labelTask_BMM.Text");
            // 
            // splitContainerData_BMM
            // 
            splitContainerData_BMM.Dock = DockStyle.Fill;
            splitContainerData_BMM.Location = new Point(0, 151);
            splitContainerData_BMM.Name = "splitContainerData_BMM";
            // 
            // splitContainerData_BMM.Panel1
            // 
            splitContainerData_BMM.Panel1.Controls.Add(groupBoxData_BMM);
            // 
            // splitContainerData_BMM.Panel2
            // 
            splitContainerData_BMM.Panel2.Controls.Add(dataGridViewDataOutput_BMM);
            splitContainerData_BMM.Panel2.Controls.Add(groupBoxResult_BMM);
            splitContainerData_BMM.Size = new Size(1021, 324);
            splitContainerData_BMM.SplitterDistance = 530;
            splitContainerData_BMM.TabIndex = 1;
            // 
            // groupBoxData_BMM
            // 
            groupBoxData_BMM.Controls.Add(dataGridViewDataInput_BMM);
            groupBoxData_BMM.Dock = DockStyle.Fill;
            groupBoxData_BMM.Location = new Point(0, 0);
            groupBoxData_BMM.Name = "groupBoxData_BMM";
            groupBoxData_BMM.Size = new Size(530, 324);
            groupBoxData_BMM.TabIndex = 0;
            groupBoxData_BMM.TabStop = false;
            groupBoxData_BMM.Text = "Вывод";
            // 
            // dataGridViewDataInput_BMM
            // 
            dataGridViewDataInput_BMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataInput_BMM.Dock = DockStyle.Fill;
            dataGridViewDataInput_BMM.Location = new Point(3, 23);
            dataGridViewDataInput_BMM.Name = "dataGridViewDataInput_BMM";
            dataGridViewDataInput_BMM.RowHeadersWidth = 51;
            dataGridViewDataInput_BMM.Size = new Size(524, 298);
            dataGridViewDataInput_BMM.TabIndex = 4;
            // 
            // dataGridViewDataOutput_BMM
            // 
            dataGridViewDataOutput_BMM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDataOutput_BMM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataOutput_BMM.Location = new Point(0, 23);
            dataGridViewDataOutput_BMM.Name = "dataGridViewDataOutput_BMM";
            dataGridViewDataOutput_BMM.RowHeadersWidth = 51;
            dataGridViewDataOutput_BMM.Size = new Size(487, 301);
            dataGridViewDataOutput_BMM.TabIndex = 5;
            // 
            // groupBoxResult_BMM
            // 
            groupBoxResult_BMM.Dock = DockStyle.Fill;
            groupBoxResult_BMM.Location = new Point(0, 0);
            groupBoxResult_BMM.Name = "groupBoxResult_BMM";
            groupBoxResult_BMM.Size = new Size(487, 324);
            groupBoxResult_BMM.TabIndex = 0;
            groupBoxResult_BMM.TabStop = false;
            groupBoxResult_BMM.Text = "Вывод";
            // 
            // openFileDialogTask_BMM
            // 
            openFileDialogTask_BMM.FileName = "openFileDialog1";
            // 
            // toolTipButton_BMM
            // 
            toolTipButton_BMM.ForeColor = SystemColors.Highlight;
            toolTipButton_BMM.IsBalloon = true;
            toolTipButton_BMM.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_BMM.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 475);
            Controls.Add(splitContainerData_BMM);
            Controls.Add(panelMiddle_BMM);
            Controls.Add(panelTop_BMM);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 12 | Будыкова М. М.";
            WindowState = FormWindowState.Maximized;
            panelTop_BMM.ResumeLayout(false);
            panelMiddle_BMM.ResumeLayout(false);
            groupBoxTask_BMM.ResumeLayout(false);
            groupBoxTask_BMM.PerformLayout();
            splitContainerData_BMM.Panel1.ResumeLayout(false);
            splitContainerData_BMM.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerData_BMM).EndInit();
            splitContainerData_BMM.ResumeLayout(false);
            groupBoxData_BMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataInput_BMM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataOutput_BMM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BMM;
        private Panel panelMiddle_BMM;
        private SplitContainer splitContainerData_BMM;
        private GroupBox groupBoxData_BMM;
        private GroupBox groupBoxResult_BMM;
        private Button buttonDone_BMM;
        private Button buttonOpenFile_BMM;
        private Button buttonHelp_BMM;
        private Button buttonSaveFile_BMM;
        private GroupBox groupBoxTask_BMM;
        private Label labelTask_BMM;
        private OpenFileDialog openFileDialogTask_BMM;
        private ToolTip toolTipButton_BMM;
        private SaveFileDialog saveFileDialogMatrix_BMM;
        private DataGridView dataGridViewDataOutput_BMM;
        private DataGridView dataGridViewDataInput_BMM;
    }
}

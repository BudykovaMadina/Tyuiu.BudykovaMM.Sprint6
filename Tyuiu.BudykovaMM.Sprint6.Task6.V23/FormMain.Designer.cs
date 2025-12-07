namespace Tyuiu.BudykovaMM.Sprint6.Task6.V23
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
            buttonDone_BMM = new Button();
            buttonOpenFile_BMM = new Button();
            panelMiddle_BMM = new Panel();
            groupBoxTask_BMM = new GroupBox();
            labelTask_BMM = new Label();
            splitContainer1 = new SplitContainer();
            textBoxData_BMM = new TextBox();
            textBoxDone_BMM = new TextBox();
            openFileDialogTask_BMM = new OpenFileDialog();
            toolTipTask_BMM = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            panelTop_BMM.SuspendLayout();
            panelMiddle_BMM.SuspendLayout();
            groupBoxTask_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_BMM
            // 
            panelTop_BMM.Controls.Add(buttonHelp_BMM);
            panelTop_BMM.Controls.Add(buttonDone_BMM);
            panelTop_BMM.Controls.Add(buttonOpenFile_BMM);
            panelTop_BMM.Dock = DockStyle.Top;
            panelTop_BMM.Location = new Point(0, 0);
            panelTop_BMM.Name = "panelTop_BMM";
            panelTop_BMM.Size = new Size(901, 80);
            panelTop_BMM.TabIndex = 0;
            // 
            // buttonHelp_BMM
            // 
            buttonHelp_BMM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BMM.Location = new Point(804, 3);
            buttonHelp_BMM.Name = "buttonHelp_BMM";
            buttonHelp_BMM.Size = new Size(94, 74);
            buttonHelp_BMM.TabIndex = 2;
            buttonHelp_BMM.Text = "?";
            buttonHelp_BMM.UseVisualStyleBackColor = true;
            buttonHelp_BMM.Click += buttonHelp_BMM_Click;
            // 
            // buttonDone_BMM
            // 
            buttonDone_BMM.Location = new Point(106, 5);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(92, 71);
            buttonDone_BMM.TabIndex = 1;
            buttonDone_BMM.Text = "Done";
            buttonDone_BMM.UseVisualStyleBackColor = true;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            // 
            // buttonOpenFile_BMM
            // 
            buttonOpenFile_BMM.Location = new Point(3, 3);
            buttonOpenFile_BMM.Name = "buttonOpenFile_BMM";
            buttonOpenFile_BMM.Size = new Size(97, 71);
            buttonOpenFile_BMM.TabIndex = 0;
            buttonOpenFile_BMM.Text = "Файл";
            toolTipTask_BMM.SetToolTip(buttonOpenFile_BMM, "Открыть файл.\r\nВыберите нужный файл для обработки.");
            buttonOpenFile_BMM.UseVisualStyleBackColor = true;
            buttonOpenFile_BMM.Click += buttonOpenFile_BMM_Click;
            // 
            // panelMiddle_BMM
            // 
            panelMiddle_BMM.Controls.Add(groupBoxTask_BMM);
            panelMiddle_BMM.Dock = DockStyle.Top;
            panelMiddle_BMM.Location = new Point(0, 80);
            panelMiddle_BMM.Name = "panelMiddle_BMM";
            panelMiddle_BMM.Size = new Size(901, 89);
            panelMiddle_BMM.TabIndex = 0;
            // 
            // groupBoxTask_BMM
            // 
            groupBoxTask_BMM.Controls.Add(labelTask_BMM);
            groupBoxTask_BMM.Dock = DockStyle.Fill;
            groupBoxTask_BMM.Location = new Point(0, 0);
            groupBoxTask_BMM.Name = "groupBoxTask_BMM";
            groupBoxTask_BMM.Size = new Size(901, 89);
            groupBoxTask_BMM.TabIndex = 3;
            groupBoxTask_BMM.TabStop = false;
            groupBoxTask_BMM.Text = "Условие";
            // 
            // labelTask_BMM
            // 
            labelTask_BMM.AutoSize = true;
            labelTask_BMM.Location = new Point(3, 23);
            labelTask_BMM.Name = "labelTask_BMM";
            labelTask_BMM.Size = new Size(816, 40);
            labelTask_BMM.TabIndex = 0;
            labelTask_BMM.Text = resources.GetString("labelTask_BMM.Text");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 169);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBoxData_BMM);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxDone_BMM);
            splitContainer1.Size = new Size(901, 347);
            splitContainer1.SplitterDistance = 413;
            splitContainer1.TabIndex = 1;
            // 
            // textBoxData_BMM
            // 
            textBoxData_BMM.Location = new Point(0, 0);
            textBoxData_BMM.Multiline = true;
            textBoxData_BMM.Name = "textBoxData_BMM";
            textBoxData_BMM.ScrollBars = ScrollBars.Vertical;
            textBoxData_BMM.Size = new Size(410, 347);
            textBoxData_BMM.TabIndex = 2;
            // 
            // textBoxDone_BMM
            // 
            textBoxDone_BMM.Dock = DockStyle.Right;
            textBoxDone_BMM.Location = new Point(3, 0);
            textBoxDone_BMM.Multiline = true;
            textBoxDone_BMM.Name = "textBoxDone_BMM";
            textBoxDone_BMM.ScrollBars = ScrollBars.Vertical;
            textBoxDone_BMM.Size = new Size(481, 347);
            textBoxDone_BMM.TabIndex = 3;
            // 
            // openFileDialogTask_BMM
            // 
            openFileDialogTask_BMM.FileName = "openFileDialog1";
            // 
            // toolTipTask_BMM
            // 
            toolTipTask_BMM.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_BMM.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 516);
            Controls.Add(splitContainer1);
            Controls.Add(panelMiddle_BMM);
            Controls.Add(panelTop_BMM);
            MinimumSize = new Size(818, 497);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Будыкова М. М.";
            panelTop_BMM.ResumeLayout(false);
            panelMiddle_BMM.ResumeLayout(false);
            groupBoxTask_BMM.ResumeLayout(false);
            groupBoxTask_BMM.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BMM;
        private Panel panelMiddle_BMM;
        private SplitContainer splitContainer1;
        private Button buttonHelp_BMM;
        private Button buttonDone_BMM;
        private Button buttonOpenFile_BMM;
        private GroupBox groupBoxTask_BMM;
        private Label labelTask_BMM;
        private TextBox textBoxDone_BMM;
        private OpenFileDialog openFileDialogTask_BMM;
        private ToolTip toolTipTask_BMM;
        private TextBox textBoxData_BMM;
        private OpenFileDialog openFileDialog1;
    }
}

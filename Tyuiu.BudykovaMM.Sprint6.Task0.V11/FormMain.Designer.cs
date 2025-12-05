namespace Tyuiu.BudykovaMM.Sprint6.Task0.V11
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
            groupBoxTitle_BMM = new GroupBox();
            textBoxCondition_BMM = new TextBox();
            pictureBoxFormula_BMM = new PictureBox();
            groupBox2 = new GroupBox();
            textBoxTitleForParameter_BMM = new TextBox();
            textBoxParameter_BMM = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult_BMM = new TextBox();
            textBoxTitleForResult_BMM = new TextBox();
            buttonInfo_BMM = new Button();
            buttonDone_BMM = new Button();
            groupBoxTitle_BMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BMM).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTitle_BMM
            // 
            groupBoxTitle_BMM.Controls.Add(textBoxCondition_BMM);
            groupBoxTitle_BMM.Controls.Add(pictureBoxFormula_BMM);
            groupBoxTitle_BMM.Location = new Point(35, 12);
            groupBoxTitle_BMM.Name = "groupBoxTitle_BMM";
            groupBoxTitle_BMM.Size = new Size(733, 264);
            groupBoxTitle_BMM.TabIndex = 0;
            groupBoxTitle_BMM.TabStop = false;
            groupBoxTitle_BMM.Text = "Условие";
            // 
            // textBoxCondition_BMM
            // 
            textBoxCondition_BMM.BackColor = SystemColors.Menu;
            textBoxCondition_BMM.Location = new Point(0, 26);
            textBoxCondition_BMM.Multiline = true;
            textBoxCondition_BMM.Name = "textBoxCondition_BMM";
            textBoxCondition_BMM.Size = new Size(419, 238);
            textBoxCondition_BMM.TabIndex = 2;
            textBoxCondition_BMM.Text = "Вычислить выражение по формуле";
            
            // 
            // pictureBoxFormula_BMM
            // 
            pictureBoxFormula_BMM.Image = Properties.Resources.photo_2025_12_05_20_52_28;
            pictureBoxFormula_BMM.Location = new Point(425, 26);
            pictureBoxFormula_BMM.Name = "pictureBoxFormula_BMM";
            pictureBoxFormula_BMM.Size = new Size(302, 44);
            pictureBoxFormula_BMM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_BMM.TabIndex = 1;
            pictureBoxFormula_BMM.TabStop = false;
            
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxTitleForParameter_BMM);
            groupBox2.Controls.Add(textBoxParameter_BMM);
            groupBox2.Location = new Point(35, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            
            // 
            // textBoxTitleForParameter_BMM
            // 
            textBoxTitleForParameter_BMM.BackColor = SystemColors.Menu;
            textBoxTitleForParameter_BMM.Location = new Point(6, 26);
            textBoxTitleForParameter_BMM.Name = "textBoxTitleForParameter_BMM";
            textBoxTitleForParameter_BMM.Size = new Size(125, 27);
            textBoxTitleForParameter_BMM.TabIndex = 2;
            textBoxTitleForParameter_BMM.Text = "Переменная X:";
            
            // 
            // textBoxParameter_BMM
            // 
            textBoxParameter_BMM.Location = new Point(6, 69);
            textBoxParameter_BMM.Name = "textBoxParameter_BMM";
            textBoxParameter_BMM.Size = new Size(125, 27);
            textBoxParameter_BMM.TabIndex = 1;
            textBoxParameter_BMM.KeyPress += textBoxParameter_BMM_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_BMM);
            groupBox3.Controls.Add(textBoxTitleForResult_BMM);
            groupBox3.Location = new Point(559, 282);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult_BMM
            // 
            textBoxResult_BMM.Location = new Point(6, 69);
            textBoxResult_BMM.Name = "textBoxResult_BMM";
            textBoxResult_BMM.ReadOnly = true;
            textBoxResult_BMM.Size = new Size(125, 27);
            textBoxResult_BMM.TabIndex = 0;
            // 
            // textBoxTitleForResult_BMM
            // 
            textBoxTitleForResult_BMM.BackColor = SystemColors.Menu;
            textBoxTitleForResult_BMM.Location = new Point(6, 26);
            textBoxTitleForResult_BMM.Name = "textBoxTitleForResult_BMM";
            textBoxTitleForResult_BMM.Size = new Size(125, 27);
            textBoxTitleForResult_BMM.TabIndex = 2;
            textBoxTitleForResult_BMM.Text = "Результат:";
            
            // 
            // buttonInfo_BMM
            // 
            buttonInfo_BMM.FlatStyle = FlatStyle.Flat;
            buttonInfo_BMM.Location = new Point(559, 413);
            buttonInfo_BMM.Name = "buttonInfo_BMM";
            buttonInfo_BMM.Size = new Size(52, 32);
            buttonInfo_BMM.TabIndex = 3;
            buttonInfo_BMM.Text = "?";
            buttonInfo_BMM.UseVisualStyleBackColor = true;
            buttonInfo_BMM.Click += buttonInfo_BMM_Click;
            // 
            // buttonDone_BMM
            // 
            buttonDone_BMM.Location = new Point(617, 413);
            buttonDone_BMM.Name = "buttonDone_BMM";
            buttonDone_BMM.Size = new Size(151, 32);
            buttonDone_BMM.TabIndex = 4;
            buttonDone_BMM.Text = "Выполнить";
            buttonDone_BMM.UseVisualStyleBackColor = true;
            buttonDone_BMM.Click += buttonDone_BMM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_BMM);
            Controls.Add(buttonInfo_BMM);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxTitle_BMM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 11 | Будыкова М. М. ";
            
            groupBoxTitle_BMM.ResumeLayout(false);
            groupBoxTitle_BMM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BMM).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTitle_BMM;
        private PictureBox pictureBoxFormula_BMM;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxParameter_BMM;
        private TextBox textBoxTitleForResult_BMM;
        private TextBox textBoxTitleForParameter_BMM;
        private TextBox textBoxCondition_BMM;
        private TextBox textBoxResult_BMM;
        private Button buttonInfo_BMM;
        private Button buttonDone_BMM;
    }
}

namespace Tyuiu.BudykovaMM.Sprint6.Task6.V23
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_BMM = new Label();
            buttonOk_BMM = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_BMM
            // 
            labelInfo_BMM.AutoSize = true;
            labelInfo_BMM.Location = new Point(248, 27);
            labelInfo_BMM.Name = "labelInfo_BMM";
            labelInfo_BMM.Size = new Size(387, 180);
            labelInfo_BMM.TabIndex = 0;
            labelInfo_BMM.Text = resources.GetString("labelInfo_BMM.Text");
            // 
            // buttonOk_BMM
            // 
            buttonOk_BMM.Location = new Point(565, 210);
            buttonOk_BMM.Name = "buttonOk_BMM";
            buttonOk_BMM.Size = new Size(86, 29);
            buttonOk_BMM.TabIndex = 1;
            buttonOk_BMM.Text = "Ок";
            buttonOk_BMM.UseVisualStyleBackColor = true;
            buttonOk_BMM.Click += buttonOk_BMM_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 245);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOk_BMM);
            Controls.Add(labelInfo_BMM);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_BMM;
        private Button buttonOk_BMM;
        private PictureBox pictureBox1;
    }
}
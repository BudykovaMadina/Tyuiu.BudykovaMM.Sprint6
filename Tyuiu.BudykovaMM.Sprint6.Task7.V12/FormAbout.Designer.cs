namespace Tyuiu.BudykovaMM.Sprint6.Task7.V12
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
            pictureBoxAvatar_BMM = new PictureBox();
            labelInfo_BMM = new Label();
            buttonOK_BMM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_BMM).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_BMM
            // 
            pictureBoxAvatar_BMM.Image = (Image)resources.GetObject("pictureBoxAvatar_BMM.Image");
            pictureBoxAvatar_BMM.Location = new Point(29, 9);
            pictureBoxAvatar_BMM.Name = "pictureBoxAvatar_BMM";
            pictureBoxAvatar_BMM.Size = new Size(161, 224);
            pictureBoxAvatar_BMM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_BMM.TabIndex = 0;
            pictureBoxAvatar_BMM.TabStop = false;
            // 
            // labelInfo_BMM
            // 
            labelInfo_BMM.AutoSize = true;
            labelInfo_BMM.Location = new Point(229, 19);
            labelInfo_BMM.Name = "labelInfo_BMM";
            labelInfo_BMM.Size = new Size(387, 180);
            labelInfo_BMM.TabIndex = 1;
            labelInfo_BMM.Text = resources.GetString("labelInfo_BMM.Text");
            // 
            // buttonOK_BMM
            // 
            buttonOK_BMM.Location = new Point(554, 204);
            buttonOK_BMM.Name = "buttonOK_BMM";
            buttonOK_BMM.Size = new Size(94, 29);
            buttonOK_BMM.TabIndex = 2;
            buttonOK_BMM.Text = "OK";
            buttonOK_BMM.UseVisualStyleBackColor = true;
            buttonOK_BMM.Click += buttonOK_BMM_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 245);
            Controls.Add(buttonOK_BMM);
            Controls.Add(labelInfo_BMM);
            Controls.Add(pictureBoxAvatar_BMM);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_BMM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_BMM;
        private Label labelInfo_BMM;
        private Button buttonOK_BMM;
    }
}
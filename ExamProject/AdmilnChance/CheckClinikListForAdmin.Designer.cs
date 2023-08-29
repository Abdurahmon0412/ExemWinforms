namespace WInforms.AdmilnChance
{
    partial class CheckClinikListForAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ForAdminPicture = new PictureBox();
            BackButton = new Button();
            ClinikasButton = new Button();
            DoctorsButton = new Button();
            ServicesButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ForAdminPicture).BeginInit();
            SuspendLayout();
            // 
            // ForAdminPicture
            // 
            ForAdminPicture.Image = ExamProject.Properties.Resources.ClinikPicture;
            ForAdminPicture.Location = new Point(318, 4);
            ForAdminPicture.Margin = new Padding(3, 4, 3, 4);
            ForAdminPicture.Name = "ForAdminPicture";
            ForAdminPicture.Size = new Size(482, 561);
            ForAdminPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ForAdminPicture.TabIndex = 5;
            ForAdminPicture.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Blue;
            BackButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(0, 0);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(116, 56);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ClinikasButton
            // 
            ClinikasButton.BackColor = Color.FromArgb(128, 255, 255);
            ClinikasButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ClinikasButton.Location = new Point(26, 98);
            ClinikasButton.Margin = new Padding(3, 4, 3, 4);
            ClinikasButton.Name = "ClinikasButton";
            ClinikasButton.Size = new Size(286, 56);
            ClinikasButton.TabIndex = 8;
            ClinikasButton.Text = "Clinikas";
            ClinikasButton.UseVisualStyleBackColor = false;
            ClinikasButton.Click += ClinikasButton_Click;
            // 
            // DoctorsButton
            // 
            DoctorsButton.BackColor = Color.FromArgb(0, 192, 0);
            DoctorsButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorsButton.Location = new Point(26, 260);
            DoctorsButton.Margin = new Padding(3, 4, 3, 4);
            DoctorsButton.Name = "DoctorsButton";
            DoctorsButton.Size = new Size(286, 56);
            DoctorsButton.TabIndex = 9;
            DoctorsButton.Text = "Doctors";
            DoctorsButton.UseVisualStyleBackColor = false;
            DoctorsButton.Click += DoctorsButton_Click;
            // 
            // ServicesButton
            // 
            ServicesButton.BackColor = Color.Red;
            ServicesButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ServicesButton.ForeColor = Color.White;
            ServicesButton.Location = new Point(26, 440);
            ServicesButton.Margin = new Padding(3, 4, 3, 4);
            ServicesButton.Name = "ServicesButton";
            ServicesButton.Size = new Size(286, 56);
            ServicesButton.TabIndex = 10;
            ServicesButton.Text = "Services";
            ServicesButton.UseVisualStyleBackColor = false;
            ServicesButton.Click += ServicesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aqua;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 98);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 11;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 440);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 12;
            label2.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSeaGreen;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 260);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 13;
            label3.Text = "2";
            // 
            // CheckClinikListForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ServicesButton);
            Controls.Add(DoctorsButton);
            Controls.Add(ClinikasButton);
            Controls.Add(BackButton);
            Controls.Add(ForAdminPicture);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CheckClinikListForAdmin";
            Size = new Size(803, 547);
            ((System.ComponentModel.ISupportInitialize)ForAdminPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ForAdminPicture;
        private Button BackButton;
        private Button ClinikasButton;
        private Button DoctorsButton;
        private Button ServicesButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

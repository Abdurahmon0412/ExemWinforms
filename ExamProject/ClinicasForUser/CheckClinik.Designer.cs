namespace WInforms.Clinicas
{
    partial class CheckClinik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckClinik));
            DoctorsButton = new Button();
            ServicesButton = new Button();
            CoastsButton = new Button();
            BackButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DoctorsButton
            // 
            DoctorsButton.BackColor = Color.FromArgb(128, 255, 255);
            DoctorsButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorsButton.Location = new Point(32, 130);
            DoctorsButton.Margin = new Padding(3, 4, 3, 4);
            DoctorsButton.Name = "DoctorsButton";
            DoctorsButton.Size = new Size(286, 56);
            DoctorsButton.TabIndex = 0;
            DoctorsButton.Text = "Doctors";
            DoctorsButton.UseVisualStyleBackColor = false;
            DoctorsButton.Click += DoctorsButton_Click;
            // 
            // ServicesButton
            // 
            ServicesButton.BackColor = Color.FromArgb(0, 192, 0);
            ServicesButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ServicesButton.Location = new Point(32, 249);
            ServicesButton.Margin = new Padding(3, 4, 3, 4);
            ServicesButton.Name = "ServicesButton";
            ServicesButton.Size = new Size(286, 56);
            ServicesButton.TabIndex = 1;
            ServicesButton.Text = "Services";
            ServicesButton.UseVisualStyleBackColor = false;
            // 
            // CoastsButton
            // 
            CoastsButton.BackColor = Color.Red;
            CoastsButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CoastsButton.ForeColor = Color.White;
            CoastsButton.Location = new Point(32, 352);
            CoastsButton.Margin = new Padding(3, 4, 3, 4);
            CoastsButton.Name = "CoastsButton";
            CoastsButton.Size = new Size(286, 56);
            CoastsButton.TabIndex = 2;
            CoastsButton.Text = "Coasts";
            CoastsButton.UseVisualStyleBackColor = false;
            CoastsButton.Click += CoastsButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Blue;
            BackButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(0, 0);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(116, 56);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aqua;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 130);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 8;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 352);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 9;
            label2.Text = "3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 249);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 10;
            label3.Text = "2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Yellow;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = ExamProject.Properties.Resources.ClinikPicture;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(321, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 561);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // CheckClinik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(pictureBox1);
            Controls.Add(CoastsButton);
            Controls.Add(ServicesButton);
            Controls.Add(DoctorsButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CheckClinik";
            Size = new Size(803, 547);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DoctorsButton;
        private Button ServicesButton;
        private Button CoastsButton;
        private PictureBox pictureBox1;
        private Button BackButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

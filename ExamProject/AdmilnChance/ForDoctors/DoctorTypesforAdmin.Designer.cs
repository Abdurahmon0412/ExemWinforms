namespace WInforms.AdmilnChance.ForDoctors
{
    partial class DoctorTypesforAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorTypesforAdmin));
            Exit = new Button();
            EnterButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            DearchBox = new TextBox();
            Confirm = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            resources.ApplyResources(Exit, "Exit");
            Exit.BackColor = Color.Navy;
            Exit.ForeColor = SystemColors.ButtonHighlight;
            Exit.Name = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // EnterButton
            // 
            resources.ApplyResources(EnterButton, "EnterButton");
            EnterButton.BackColor = Color.Green;
            EnterButton.Name = "EnterButton";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // DearchBox
            // 
            resources.ApplyResources(DearchBox, "DearchBox");
            DearchBox.BackColor = Color.FromArgb(255, 224, 192);
            DearchBox.Name = "DearchBox";
            DearchBox.TextChanged += DearchBox_TextChanged;
            // 
            // Confirm
            // 
            resources.ApplyResources(Confirm, "Confirm");
            Confirm.BackColor = Color.FromArgb(255, 128, 0);
            Confirm.ForeColor = SystemColors.ButtonHighlight;
            Confirm.Name = "Confirm";
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += Confirm_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = ExamProject.Properties.Resources.ClinikPicture;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // DoctorTypesforAdmin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(pictureBox1);
            Controls.Add(Confirm);
            Controls.Add(DearchBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(EnterButton);
            Controls.Add(Exit);
            Name = "DoctorTypesforAdmin";
            Load += DoctorTypesforAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Exit;
        private Button EnterButton;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox DearchBox;
        private Button Confirm;
        private PictureBox pictureBox1;
    }
}

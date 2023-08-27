namespace WInforms.UserControllsFolder
{
    partial class RegistrationUserControl
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.FirsnameLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.ClinikCombobox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(92, 94);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(40, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Login";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 38);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 207);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 35);
            this.textBox2.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(92, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 289);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 38);
            this.textBox3.TabIndex = 6;
            // 
            // FirsnameLabel
            // 
            this.FirsnameLabel.AutoSize = true;
            this.FirsnameLabel.Location = new System.Drawing.Point(92, 260);
            this.FirsnameLabel.Name = "FirsnameLabel";
            this.FirsnameLabel.Size = new System.Drawing.Size(63, 16);
            this.FirsnameLabel.TabIndex = 5;
            this.FirsnameLabel.Text = "Firsname";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 367);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(208, 38);
            this.textBox4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "LastName";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 37);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(511, 345);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(239, 58);
            this.EnterButton.TabIndex = 10;
            this.EnterButton.Text = "Enter =>";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.Location = new System.Drawing.Point(335, 82);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(155, 25);
            this.notificationLabel.TabIndex = 12;
            this.notificationLabel.Text = "Clinikani tanlang";
            // 
            // ClinikCombobox
            // 
            this.ClinikCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClinikCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinikCombobox.FormattingEnabled = true;
            this.ClinikCombobox.Items.AddRange(new object[] {
            "MedPuls",
            "Hayat",
            "Guanjou",
            "ShifoMEd",
            "Darmon"});
            this.ClinikCombobox.Location = new System.Drawing.Point(511, 83);
            this.ClinikCombobox.Name = "ClinikCombobox";
            this.ClinikCombobox.Size = new System.Drawing.Size(239, 33);
            this.ClinikCombobox.TabIndex = 13;
            this.ClinikCombobox.SelectedIndexChanged += new System.EventHandler(this.ClinikCombobox_SelectedIndexChanged);
            this.ClinikCombobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClinikCombobox_MouseClick);
            // 
            // RegistrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClinikCombobox);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.FirsnameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usernameLabel);
            this.Name = "RegistrationUserControl";
            this.Size = new System.Drawing.Size(803, 452);
            this.Load += new System.EventHandler(this.RegistrationUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label FirsnameLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.ComboBox ClinikCombobox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

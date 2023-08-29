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
            usernameLabel = new Label();
            LoginTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            PasswordLabel = new Label();
            Firstnametextbox = new TextBox();
            FirsnameLabel = new Label();
            Lastnametextbox = new TextBox();
            label1 = new Label();
            BackButton = new Button();
            EnterButton = new Button();
            notificationLabel = new Label();
            ClinikCombobox = new ComboBox();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(92, 118);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(46, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Login";
            usernameLabel.Click += label1_Click;
            // 
            // LoginTextbox
            // 
            LoginTextbox.Location = new Point(95, 159);
            LoginTextbox.Margin = new Padding(3, 4, 3, 4);
            LoginTextbox.Multiline = true;
            LoginTextbox.Name = "LoginTextbox";
            LoginTextbox.Size = new Size(208, 46);
            LoginTextbox.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(95, 259);
            PasswordTextbox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextbox.Multiline = true;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(208, 43);
            PasswordTextbox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(92, 221);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // Firstnametextbox
            // 
            Firstnametextbox.Location = new Point(95, 361);
            Firstnametextbox.Margin = new Padding(3, 4, 3, 4);
            Firstnametextbox.Multiline = true;
            Firstnametextbox.Name = "Firstnametextbox";
            Firstnametextbox.Size = new Size(208, 46);
            Firstnametextbox.TabIndex = 6;
            // 
            // FirsnameLabel
            // 
            FirsnameLabel.AutoSize = true;
            FirsnameLabel.Location = new Point(92, 325);
            FirsnameLabel.Name = "FirsnameLabel";
            FirsnameLabel.Size = new Size(68, 20);
            FirsnameLabel.TabIndex = 5;
            FirsnameLabel.Text = "Firsname";
            // 
            // Lastnametextbox
            // 
            Lastnametextbox.Location = new Point(95, 459);
            Lastnametextbox.Margin = new Padding(3, 4, 3, 4);
            Lastnametextbox.Multiline = true;
            Lastnametextbox.Name = "Lastnametextbox";
            Lastnametextbox.Size = new Size(208, 46);
            Lastnametextbox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 435);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 7;
            label1.Text = "LastName";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(0, 0);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(96, 46);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = SystemColors.ActiveCaption;
            EnterButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EnterButton.Location = new Point(511, 431);
            EnterButton.Margin = new Padding(3, 4, 3, 4);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(239, 72);
            EnterButton.TabIndex = 10;
            EnterButton.Text = "Enter =>";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.BackColor = Color.PaleGreen;
            notificationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notificationLabel.Location = new Point(335, 102);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(155, 25);
            notificationLabel.TabIndex = 12;
            notificationLabel.Text = "Clinikani tanlang";
            // 
            // ClinikCombobox
            // 
            ClinikCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClinikCombobox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClinikCombobox.FormattingEnabled = true;
            ClinikCombobox.ImeMode = ImeMode.Hiragana;
            ClinikCombobox.Location = new Point(511, 104);
            ClinikCombobox.Margin = new Padding(3, 4, 3, 4);
            ClinikCombobox.Name = "ClinikCombobox";
            ClinikCombobox.Size = new Size(239, 33);
            ClinikCombobox.TabIndex = 13;
            ClinikCombobox.SelectedIndexChanged += ClinikCombobox_SelectedIndexChanged;
            ClinikCombobox.MouseClick += ClinikCombobox_MouseClick;
            // 
            // RegistrationUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClinikCombobox);
            Controls.Add(notificationLabel);
            Controls.Add(EnterButton);
            Controls.Add(BackButton);
            Controls.Add(Lastnametextbox);
            Controls.Add(label1);
            Controls.Add(Firstnametextbox);
            Controls.Add(FirsnameLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginTextbox);
            Controls.Add(usernameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationUserControl";
            Size = new Size(803, 547);
            Load += RegistrationUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private TextBox LoginTextbox;
        private TextBox PasswordTextbox;
        private Label PasswordLabel;
        private TextBox Firstnametextbox;
        private Label FirsnameLabel;
        private TextBox Lastnametextbox;
        private Label label1;
        private Button BackButton;
        private Button EnterButton;
        private Label notificationLabel;
        private ComboBox ClinikCombobox;
        private ColorDialog colorDialog1;
    }
}

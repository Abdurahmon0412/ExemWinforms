namespace WInforms.AdmilnChance.ForClinika
{
    partial class AddClinika
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
            NameLabel = new Label();
            ClinikAddress = new Label();
            PhoneNumber = new Label();
            NameTextBox = new TextBox();
            AddressTextBoxs = new TextBox();
            PhonenumberText = new TextBox();
            AddButton = new Button();
            OKButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(15, 54);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(168, 25);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Enter Clinik Name";
            // 
            // ClinikAddress
            // 
            ClinikAddress.AutoSize = true;
            ClinikAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClinikAddress.Location = new Point(15, 170);
            ClinikAddress.Name = "ClinikAddress";
            ClinikAddress.Size = new Size(189, 25);
            ClinikAddress.TabIndex = 3;
            ClinikAddress.Text = "Enter Clinik Address";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber.Location = new Point(15, 299);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(178, 25);
            PhoneNumber.TabIndex = 4;
            PhoneNumber.Text = "Enter Clinik Phone ";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(208, 54);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(379, 42);
            NameTextBox.TabIndex = 5;
            // 
            // AddressTextBoxs
            // 
            AddressTextBoxs.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTextBoxs.Location = new Point(208, 170);
            AddressTextBoxs.Margin = new Padding(3, 4, 3, 4);
            AddressTextBoxs.Multiline = true;
            AddressTextBoxs.Name = "AddressTextBoxs";
            AddressTextBoxs.Size = new Size(379, 42);
            AddressTextBoxs.TabIndex = 6;
            // 
            // PhonenumberText
            // 
            PhonenumberText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhonenumberText.Location = new Point(208, 299);
            PhonenumberText.Margin = new Padding(3, 4, 3, 4);
            PhonenumberText.Multiline = true;
            PhonenumberText.Name = "PhonenumberText";
            PhonenumberText.Size = new Size(379, 42);
            PhonenumberText.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Blue;
            AddButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = SystemColors.ButtonHighlight;
            AddButton.Location = new Point(129, 404);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 71);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.FromArgb(0, 192, 0);
            OKButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.Location = new Point(486, 404);
            OKButton.Margin = new Padding(3, 4, 3, 4);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 71);
            OKButton.TabIndex = 9;
            OKButton.Text = "Exit";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // AddClinika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OKButton);
            Controls.Add(AddButton);
            Controls.Add(PhonenumberText);
            Controls.Add(AddressTextBoxs);
            Controls.Add(NameTextBox);
            Controls.Add(PhoneNumber);
            Controls.Add(ClinikAddress);
            Controls.Add(NameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddClinika";
            Size = new Size(803, 547);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label ClinikAddress;
        private Label PhoneNumber;
        private TextBox NameTextBox;
        private TextBox AddressTextBoxs;
        private TextBox PhonenumberText;
        private Button AddButton;
        private Button OKButton;
    }
}

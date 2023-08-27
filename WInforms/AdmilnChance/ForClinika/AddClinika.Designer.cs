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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClinikAddress = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBoxs = new System.Windows.Forms.TextBox();
            this.PhonenumberText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(15, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(168, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Clinik Name";
            // 
            // ClinikAddress
            // 
            this.ClinikAddress.AutoSize = true;
            this.ClinikAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinikAddress.Location = new System.Drawing.Point(15, 136);
            this.ClinikAddress.Name = "ClinikAddress";
            this.ClinikAddress.Size = new System.Drawing.Size(189, 25);
            this.ClinikAddress.TabIndex = 3;
            this.ClinikAddress.Text = "Enter Clinik Address";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(15, 239);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(178, 25);
            this.PhoneNumber.TabIndex = 4;
            this.PhoneNumber.Text = "Enter Clinik Phone ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(208, 43);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(379, 34);
            this.NameTextBox.TabIndex = 5;
            // 
            // AddressTextBoxs
            // 
            this.AddressTextBoxs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBoxs.Location = new System.Drawing.Point(208, 136);
            this.AddressTextBoxs.Multiline = true;
            this.AddressTextBoxs.Name = "AddressTextBoxs";
            this.AddressTextBoxs.Size = new System.Drawing.Size(379, 34);
            this.AddressTextBoxs.TabIndex = 6;
            // 
            // PhonenumberText
            // 
            this.PhonenumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonenumberText.Location = new System.Drawing.Point(208, 239);
            this.PhonenumberText.Multiline = true;
            this.PhonenumberText.Name = "PhonenumberText";
            this.PhonenumberText.Size = new System.Drawing.Size(379, 34);
            this.PhonenumberText.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Blue;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(129, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 57);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(486, 323);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 57);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddClinika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PhonenumberText);
            this.Controls.Add(this.AddressTextBoxs);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.ClinikAddress);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddClinika";
            this.Size = new System.Drawing.Size(803, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ClinikAddress;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AddressTextBoxs;
        private System.Windows.Forms.TextBox PhonenumberText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button OKButton;
    }
}

namespace WInforms.AdmilnChance
{
    partial class EditClinik
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
            EditNameLabel = new Label();
            ChangeCallSenter = new TextBox();
            ConfirmName = new Button();
            ConfirmCall = new Button();
            OKButton = new Button();
            EditPhoneNumberLabel = new Label();
            ChangeName = new TextBox();
            SuspendLayout();
            // 
            // EditNameLabel
            // 
            EditNameLabel.AutoSize = true;
            EditNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditNameLabel.Location = new Point(91, 130);
            EditNameLabel.Name = "EditNameLabel";
            EditNameLabel.Size = new Size(102, 25);
            EditNameLabel.TabIndex = 1;
            EditNameLabel.Text = "Edit Name";
            EditNameLabel.Click += EditNameLabel_Click;
            // 
            // ChangeCallSenter
            // 
            ChangeCallSenter.BackColor = SystemColors.InactiveBorder;
            ChangeCallSenter.Location = new Point(94, 370);
            ChangeCallSenter.Margin = new Padding(3, 4, 3, 4);
            ChangeCallSenter.Multiline = true;
            ChangeCallSenter.Name = "ChangeCallSenter";
            ChangeCallSenter.Size = new Size(182, 45);
            ChangeCallSenter.TabIndex = 2;
            ChangeCallSenter.TextChanged += ChangeCallSenter_TextChanged;
            // 
            // ConfirmName
            // 
            ConfirmName.BackColor = Color.Lime;
            ConfirmName.Location = new Point(342, 185);
            ConfirmName.Margin = new Padding(3, 4, 3, 4);
            ConfirmName.Name = "ConfirmName";
            ConfirmName.Size = new Size(102, 46);
            ConfirmName.TabIndex = 4;
            ConfirmName.Text = "Confirm";
            ConfirmName.UseVisualStyleBackColor = false;
            ConfirmName.Click += ConfirmName_Click;
            // 
            // ConfirmCall
            // 
            ConfirmCall.BackColor = Color.Lime;
            ConfirmCall.Location = new Point(342, 370);
            ConfirmCall.Margin = new Padding(3, 4, 3, 4);
            ConfirmCall.Name = "ConfirmCall";
            ConfirmCall.Size = new Size(102, 46);
            ConfirmCall.TabIndex = 5;
            ConfirmCall.Text = "Confirm";
            ConfirmCall.UseVisualStyleBackColor = false;
            ConfirmCall.Click += ConfirmCall_Click;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.Lime;
            OKButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.Location = new Point(674, 439);
            OKButton.Margin = new Padding(3, 4, 3, 4);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(102, 99);
            OKButton.TabIndex = 6;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // EditPhoneNumberLabel
            // 
            EditPhoneNumberLabel.AutoSize = true;
            EditPhoneNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditPhoneNumberLabel.Location = new Point(91, 331);
            EditPhoneNumberLabel.Name = "EditPhoneNumberLabel";
            EditPhoneNumberLabel.Size = new Size(178, 25);
            EditPhoneNumberLabel.TabIndex = 7;
            EditPhoneNumberLabel.Text = "Edit Phone number";
            EditPhoneNumberLabel.Click += EditPhoneNumberLabel_Click;
            // 
            // ChangeName
            // 
            ChangeName.BackColor = SystemColors.InactiveBorder;
            ChangeName.Location = new Point(94, 185);
            ChangeName.Margin = new Padding(3, 4, 3, 4);
            ChangeName.Multiline = true;
            ChangeName.Name = "ChangeName";
            ChangeName.Size = new Size(182, 45);
            ChangeName.TabIndex = 8;
            ChangeName.TextChanged += ChangeName_TextChanged;
            // 
            // EditClinik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChangeName);
            Controls.Add(EditPhoneNumberLabel);
            Controls.Add(OKButton);
            Controls.Add(ConfirmCall);
            Controls.Add(ConfirmName);
            Controls.Add(ChangeCallSenter);
            Controls.Add(EditNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditClinik";
            Size = new Size(803, 547);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EditNameLabel;
        private TextBox ChangeCallSenter;
        private Button ConfirmName;
        private Button ConfirmCall;
        private Button OKButton;
        private Label EditPhoneNumberLabel;
        private TextBox ChangeName;
    }
}

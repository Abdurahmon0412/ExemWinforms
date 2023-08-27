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
            this.EditNameLabel = new System.Windows.Forms.Label();
            this.ChangeCallSenter = new System.Windows.Forms.TextBox();
            this.ConfirmName = new System.Windows.Forms.Button();
            this.ConfirmCall = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.EditPhoneNumberLabel = new System.Windows.Forms.Label();
            this.ChangeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditNameLabel
            // 
            this.EditNameLabel.AutoSize = true;
            this.EditNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditNameLabel.Location = new System.Drawing.Point(91, 104);
            this.EditNameLabel.Name = "EditNameLabel";
            this.EditNameLabel.Size = new System.Drawing.Size(102, 25);
            this.EditNameLabel.TabIndex = 1;
            this.EditNameLabel.Text = "Edit Name";
            // 
            // ChangeCallSenter
            // 
            this.ChangeCallSenter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ChangeCallSenter.Location = new System.Drawing.Point(94, 296);
            this.ChangeCallSenter.Multiline = true;
            this.ChangeCallSenter.Name = "ChangeCallSenter";
            this.ChangeCallSenter.Size = new System.Drawing.Size(182, 37);
            this.ChangeCallSenter.TabIndex = 2;
            // 
            // ConfirmName
            // 
            this.ConfirmName.BackColor = System.Drawing.Color.Lime;
            this.ConfirmName.Location = new System.Drawing.Point(342, 148);
            this.ConfirmName.Name = "ConfirmName";
            this.ConfirmName.Size = new System.Drawing.Size(102, 37);
            this.ConfirmName.TabIndex = 4;
            this.ConfirmName.Text = "Confirm";
            this.ConfirmName.UseVisualStyleBackColor = false;
            // 
            // ConfirmCall
            // 
            this.ConfirmCall.BackColor = System.Drawing.Color.Lime;
            this.ConfirmCall.Location = new System.Drawing.Point(342, 296);
            this.ConfirmCall.Name = "ConfirmCall";
            this.ConfirmCall.Size = new System.Drawing.Size(102, 37);
            this.ConfirmCall.TabIndex = 5;
            this.ConfirmCall.Text = "Confirm";
            this.ConfirmCall.UseVisualStyleBackColor = false;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.Lime;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(674, 351);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(102, 79);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // EditPhoneNumberLabel
            // 
            this.EditPhoneNumberLabel.AutoSize = true;
            this.EditPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPhoneNumberLabel.Location = new System.Drawing.Point(91, 265);
            this.EditPhoneNumberLabel.Name = "EditPhoneNumberLabel";
            this.EditPhoneNumberLabel.Size = new System.Drawing.Size(178, 25);
            this.EditPhoneNumberLabel.TabIndex = 7;
            this.EditPhoneNumberLabel.Text = "Edit Phone number";
            // 
            // ChangeName
            // 
            this.ChangeName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ChangeName.Location = new System.Drawing.Point(94, 148);
            this.ChangeName.Multiline = true;
            this.ChangeName.Name = "ChangeName";
            this.ChangeName.Size = new System.Drawing.Size(182, 37);
            this.ChangeName.TabIndex = 8;
            // 
            // EditClinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChangeName);
            this.Controls.Add(this.EditPhoneNumberLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ConfirmCall);
            this.Controls.Add(this.ConfirmName);
            this.Controls.Add(this.ChangeCallSenter);
            this.Controls.Add(this.EditNameLabel);
            this.Name = "EditClinik";
            this.Size = new System.Drawing.Size(803, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EditNameLabel;
        private System.Windows.Forms.TextBox ChangeCallSenter;
        private System.Windows.Forms.Button ConfirmName;
        private System.Windows.Forms.Button ConfirmCall;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label EditPhoneNumberLabel;
        private System.Windows.Forms.TextBox ChangeName;
    }
}

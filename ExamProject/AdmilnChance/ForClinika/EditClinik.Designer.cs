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
            OKButton = new Button();
            EditPhoneNumberLabel = new Label();
            ChangeName = new TextBox();
            dataGridView1 = new DataGridView();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EditNameLabel
            // 
            EditNameLabel.AutoSize = true;
            EditNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditNameLabel.Location = new Point(37, 51);
            EditNameLabel.Name = "EditNameLabel";
            EditNameLabel.Size = new Size(102, 25);
            EditNameLabel.TabIndex = 1;
            EditNameLabel.Text = "Edit Name";
            EditNameLabel.Click += EditNameLabel_Click;
            // 
            // ChangeCallSenter
            // 
            ChangeCallSenter.BackColor = SystemColors.InactiveBorder;
            ChangeCallSenter.Location = new Point(51, 259);
            ChangeCallSenter.Margin = new Padding(3, 4, 3, 4);
            ChangeCallSenter.Multiline = true;
            ChangeCallSenter.Name = "ChangeCallSenter";
            ChangeCallSenter.Size = new Size(182, 45);
            ChangeCallSenter.TabIndex = 2;
            ChangeCallSenter.TextChanged += ChangeCallSenter_TextChanged;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.Lime;
            OKButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.Location = new Point(3, 457);
            OKButton.Margin = new Padding(3, 4, 3, 4);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(102, 68);
            OKButton.TabIndex = 6;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // EditPhoneNumberLabel
            // 
            EditPhoneNumberLabel.AutoSize = true;
            EditPhoneNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditPhoneNumberLabel.Location = new Point(37, 204);
            EditPhoneNumberLabel.Name = "EditPhoneNumberLabel";
            EditPhoneNumberLabel.Size = new Size(178, 25);
            EditPhoneNumberLabel.TabIndex = 7;
            EditPhoneNumberLabel.Text = "Edit Phone number";
            EditPhoneNumberLabel.Click += EditPhoneNumberLabel_Click;
            // 
            // ChangeName
            // 
            ChangeName.BackColor = SystemColors.InactiveBorder;
            ChangeName.Location = new Point(51, 81);
            ChangeName.Margin = new Padding(3, 4, 3, 4);
            ChangeName.Multiline = true;
            ChangeName.Name = "ChangeName";
            ChangeName.Size = new Size(182, 45);
            ChangeName.TabIndex = 8;
            ChangeName.TextChanged += ChangeName_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(565, 543);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Lime;
            CancelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(113, 457);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 68);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cansel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditClinik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(CancelButton);
            Controls.Add(dataGridView1);
            Controls.Add(ChangeName);
            Controls.Add(EditPhoneNumberLabel);
            Controls.Add(OKButton);
            Controls.Add(ChangeCallSenter);
            Controls.Add(EditNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditClinik";
            Size = new Size(803, 547);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button CancelButton;
    }
}

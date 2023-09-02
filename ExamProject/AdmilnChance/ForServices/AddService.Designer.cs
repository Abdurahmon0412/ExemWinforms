namespace WInforms.AdmilnChance.ForServices
{
    partial class AddService
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
            ServiceName = new Label();
            AddServiceName = new TextBox();
            ServicePrice = new Label();
            PriceTextBox = new TextBox();
            AddButton = new Button();
            ExitButton = new Button();
            ChooseClinikCombo = new ComboBox();
            ChooseClinik = new Label();
            SuspendLayout();
            // 
            // ServiceName
            // 
            ServiceName.AutoSize = true;
            ServiceName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ServiceName.Location = new Point(42, 265);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(141, 29);
            ServiceName.TabIndex = 0;
            ServiceName.Text = "Enter Name";
            // 
            // AddServiceName
            // 
            AddServiceName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddServiceName.Location = new Point(204, 274);
            AddServiceName.Margin = new Padding(3, 4, 3, 4);
            AddServiceName.Multiline = true;
            AddServiceName.Name = "AddServiceName";
            AddServiceName.Size = new Size(292, 46);
            AddServiceName.TabIndex = 1;
            // 
            // ServicePrice
            // 
            ServicePrice.AutoSize = true;
            ServicePrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ServicePrice.Location = new Point(42, 400);
            ServicePrice.Name = "ServicePrice";
            ServicePrice.Size = new Size(132, 29);
            ServicePrice.TabIndex = 2;
            ServicePrice.Text = "Enter Price";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTextBox.Location = new Point(204, 420);
            PriceTextBox.Margin = new Padding(3, 4, 3, 4);
            PriceTextBox.Multiline = true;
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(292, 46);
            PriceTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ActiveCaption;
            AddButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(561, 454);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 58);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Lime;
            ExitButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(689, 454);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 58);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ChooseClinikCombo
            // 
            ChooseClinikCombo.FormattingEnabled = true;
            ChooseClinikCombo.Location = new Point(204, 75);
            ChooseClinikCombo.Margin = new Padding(3, 4, 3, 4);
            ChooseClinikCombo.Name = "ChooseClinikCombo";
            ChooseClinikCombo.Size = new Size(292, 28);
            ChooseClinikCombo.TabIndex = 10;
            ChooseClinikCombo.SelectedIndexChanged += ChooseClinikCombo_SelectedIndexChanged;
            ChooseClinikCombo.MouseDown += ChooseClinikCombo_MouseDown;
            // 
            // ChooseClinik
            // 
            ChooseClinik.AutoSize = true;
            ChooseClinik.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseClinik.Location = new Point(33, 75);
            ChooseClinik.Name = "ChooseClinik";
            ChooseClinik.Size = new Size(163, 29);
            ChooseClinik.TabIndex = 11;
            ChooseClinik.Text = "Choose Clinik";
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChooseClinik);
            Controls.Add(ChooseClinikCombo);
            Controls.Add(ExitButton);
            Controls.Add(AddButton);
            Controls.Add(PriceTextBox);
            Controls.Add(ServicePrice);
            Controls.Add(AddServiceName);
            Controls.Add(ServiceName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddService";
            Size = new Size(803, 547);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ServiceName;
        private TextBox AddServiceName;
        private Label ServicePrice;
        private TextBox PriceTextBox;
        private Button AddButton;
        private Button ExitButton;
        private ComboBox ChooseClinikCombo;
        private Label ChooseClinik;
    }
}

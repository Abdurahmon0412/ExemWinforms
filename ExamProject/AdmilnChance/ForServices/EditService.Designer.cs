namespace WInforms.AdmilnChance.ForServices
{
    partial class EditService
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
            ExitButton = new Button();
            EditButton = new Button();
            ServicePrice = new Label();
            EditServicePrice = new TextBox();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Lime;
            ExitButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(696, 428);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 58);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = SystemColors.ActiveCaption;
            EditButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(568, 428);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 58);
            EditButton.TabIndex = 12;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += AddButton_Click;
            // 
            // ServicePrice
            // 
            ServicePrice.AutoSize = true;
            ServicePrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ServicePrice.Location = new Point(48, 125);
            ServicePrice.Name = "ServicePrice";
            ServicePrice.Size = new Size(132, 29);
            ServicePrice.TabIndex = 10;
            ServicePrice.Text = "Enter Price";
            // 
            // EditServicePrice
            // 
            EditServicePrice.BackColor = SystemColors.InactiveCaption;
            EditServicePrice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EditServicePrice.Location = new Point(246, 134);
            EditServicePrice.Margin = new Padding(3, 4, 3, 4);
            EditServicePrice.Multiline = true;
            EditServicePrice.Name = "EditServicePrice";
            EditServicePrice.Size = new Size(279, 75);
            EditServicePrice.TabIndex = 14;
            EditServicePrice.TextChanged += EditServicePrice_TextChanged;
            // 
            // EditService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditServicePrice);
            Controls.Add(ExitButton);
            Controls.Add(EditButton);
            Controls.Add(ServicePrice);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditService";
            Size = new Size(803, 547);
            Load += EditService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button EditButton;
        private Label ServicePrice;
        private TextBox EditServicePrice;
    }
}

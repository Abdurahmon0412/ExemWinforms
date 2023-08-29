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
            this.ServiceName = new System.Windows.Forms.Label();
            this.AddServiceName = new System.Windows.Forms.TextBox();
            this.ServicePrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChooseClinikCombo = new System.Windows.Forms.ComboBox();
            this.ChooseClinik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSize = true;
            this.ServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceName.Location = new System.Drawing.Point(42, 212);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(141, 29);
            this.ServiceName.TabIndex = 0;
            this.ServiceName.Text = "Enter Name";
            // 
            // AddServiceName
            // 
            this.AddServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServiceName.Location = new System.Drawing.Point(204, 219);
            this.AddServiceName.Multiline = true;
            this.AddServiceName.Name = "AddServiceName";
            this.AddServiceName.Size = new System.Drawing.Size(292, 38);
            this.AddServiceName.TabIndex = 1;
            // 
            // ServicePrice
            // 
            this.ServicePrice.AutoSize = true;
            this.ServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicePrice.Location = new System.Drawing.Point(42, 320);
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.Size = new System.Drawing.Size(132, 29);
            this.ServicePrice.TabIndex = 2;
            this.ServicePrice.Text = "Enter Price";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 336);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 38);
            this.textBox1.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(561, 363);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 46);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Lime;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(689, 363);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 46);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChooseClinikCombo
            // 
            this.ChooseClinikCombo.FormattingEnabled = true;
            this.ChooseClinikCombo.Location = new System.Drawing.Point(204, 60);
            this.ChooseClinikCombo.Name = "ChooseClinikCombo";
            this.ChooseClinikCombo.Size = new System.Drawing.Size(292, 24);
            this.ChooseClinikCombo.TabIndex = 10;
            // 
            // ChooseClinik
            // 
            this.ChooseClinik.AutoSize = true;
            this.ChooseClinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseClinik.Location = new System.Drawing.Point(33, 60);
            this.ChooseClinik.Name = "ChooseClinik";
            this.ChooseClinik.Size = new System.Drawing.Size(163, 29);
            this.ChooseClinik.TabIndex = 11;
            this.ChooseClinik.Text = "Choose Clinik";
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChooseClinik);
            this.Controls.Add(this.ChooseClinikCombo);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ServicePrice);
            this.Controls.Add(this.AddServiceName);
            this.Controls.Add(this.ServiceName);
            this.Name = "AddService";
            this.Size = new System.Drawing.Size(803, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceName;
        private System.Windows.Forms.TextBox AddServiceName;
        private System.Windows.Forms.Label ServicePrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox ChooseClinikCombo;
        private System.Windows.Forms.Label ChooseClinik;
    }
}

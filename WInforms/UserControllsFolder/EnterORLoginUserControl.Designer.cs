namespace WInforms.UserControllsFolder
{
    partial class EnterORLoginUserControl
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SugnUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(199, 93);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(280, 45);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(199, 327);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(280, 41);
            this.SignInButton.TabIndex = 4;
            this.SignInButton.Text = "SignIn";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SugnUpButton
            // 
            this.SugnUpButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.SugnUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SugnUpButton.Location = new System.Drawing.Point(199, 261);
            this.SugnUpButton.Name = "SugnUpButton";
            this.SugnUpButton.Size = new System.Drawing.Size(280, 41);
            this.SugnUpButton.TabIndex = 5;
            this.SugnUpButton.Text = "SignUp";
            this.SugnUpButton.UseVisualStyleBackColor = false;
            this.SugnUpButton.Click += new System.EventHandler(this.SugnUpButton_Click);
            // 
            // EnterORLoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SugnUpButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.EnterButton);
            this.Name = "EnterORLoginUserControl";
            this.Size = new System.Drawing.Size(803, 452);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SugnUpButton;
    }
}

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
            EnterButton = new Button();
            SignInButton = new Button();
            SugnUpButton = new Button();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.BackColor = SystemColors.MenuHighlight;
            EnterButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EnterButton.Location = new Point(199, 116);
            EnterButton.Margin = new Padding(3, 4, 3, 4);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(280, 56);
            EnterButton.TabIndex = 2;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = SystemColors.GrayText;
            SignInButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SignInButton.Location = new Point(199, 409);
            SignInButton.Margin = new Padding(3, 4, 3, 4);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(280, 51);
            SignInButton.TabIndex = 4;
            SignInButton.Text = "SignIn";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // SugnUpButton
            // 
            SugnUpButton.BackColor = SystemColors.GrayText;
            SugnUpButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SugnUpButton.Location = new Point(199, 326);
            SugnUpButton.Margin = new Padding(3, 4, 3, 4);
            SugnUpButton.Name = "SugnUpButton";
            SugnUpButton.Size = new Size(280, 51);
            SugnUpButton.TabIndex = 5;
            SugnUpButton.Text = "SignUp";
            SugnUpButton.UseVisualStyleBackColor = false;
            SugnUpButton.Click += SugnUpButton_Click;
            // 
            // EnterORLoginUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SugnUpButton);
            Controls.Add(SignInButton);
            Controls.Add(EnterButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EnterORLoginUserControl";
            Size = new Size(803, 547);
            ResumeLayout(false);
        }

        #endregion
        private Button EnterButton;
        private Button SignInButton;
        private Button SugnUpButton;
    }
}

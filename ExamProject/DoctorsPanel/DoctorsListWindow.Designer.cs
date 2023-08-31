namespace WInforms.DoctorsPanel
{
    partial class DoctorsListWindow
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
            SearchLabel = new Label();
            SearchTextBox = new TextBox();
            Confirm = new Button();
            BackButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchLabel.Location = new Point(78, 42);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(75, 25);
            SearchLabel.TabIndex = 0;
            SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = SystemColors.InactiveBorder;
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.Location = new Point(159, 42);
            SearchTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(481, 46);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // Confirm
            // 
            Confirm.BackColor = SystemColors.ActiveCaption;
            Confirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Confirm.Location = new Point(657, 48);
            Confirm.Margin = new Padding(3, 4, 3, 4);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(100, 42);
            Confirm.TabIndex = 4;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += Confirm_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Red;
            BackButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(0, 0);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 52);
            BackButton.TabIndex = 5;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 98);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(797, 402);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DoctorsListWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(BackButton);
            Controls.Add(Confirm);
            Controls.Add(SearchTextBox);
            Controls.Add(SearchLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorsListWindow";
            Size = new Size(803, 547);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchLabel;
        private TextBox SearchTextBox;
        private Button Confirm;
        private Button BackButton;
        private DataGridView dataGridView1;
    }
}

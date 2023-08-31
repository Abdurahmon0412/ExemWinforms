namespace WInforms.Clinicas
{
    partial class ClinikList
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
            BackButton = new Button();
            ClinikListDataGrid = new DataGridView();
            Enter = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinikListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.IndianRed;
            BackButton.Location = new Point(696, 4);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(88, 71);
            BackButton.TabIndex = 11;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ClinikListDataGrid
            // 
            ClinikListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClinikListDataGrid.Location = new Point(3, 3);
            ClinikListDataGrid.Name = "ClinikListDataGrid";
            ClinikListDataGrid.RowHeadersWidth = 51;
            ClinikListDataGrid.RowTemplate.Height = 29;
            ClinikListDataGrid.Size = new Size(677, 504);
            ClinikListDataGrid.TabIndex = 12;
            ClinikListDataGrid.CellContentClick += ClinikListDataGrid_CellContentClick;
            // 
            // Enter
            // 
            Enter.BackColor = Color.IndianRed;
            Enter.Location = new Point(696, 423);
            Enter.Margin = new Padding(3, 4, 3, 4);
            Enter.Name = "Enter";
            Enter.Size = new Size(88, 71);
            Enter.TabIndex = 13;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // ClinikList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            Controls.Add(Enter);
            Controls.Add(ClinikListDataGrid);
            Controls.Add(BackButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClinikList";
            Size = new Size(803, 547);
            ((System.ComponentModel.ISupportInitialize)ClinikListDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BackButton;
        private DataGridView ClinikListDataGrid;
        private Button Enter;
    }
}

namespace WInforms.AdmilnChance
{
    partial class ClinikListForAdmin
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
            ClinikListDataGrid = new DataGridView();
            EditClinikButton = new Button();
            DeleteCLinikButton = new Button();
            AddClinikButton = new Button();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinikListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ClinikListDataGrid
            // 
            ClinikListDataGrid.ColumnHeadersHeight = 29;
            ClinikListDataGrid.Location = new Point(3, 0);
            ClinikListDataGrid.Margin = new Padding(3, 4, 3, 4);
            ClinikListDataGrid.Name = "ClinikListDataGrid";
            ClinikListDataGrid.RowHeadersWidth = 51;
            ClinikListDataGrid.RowTemplate.Height = 24;
            ClinikListDataGrid.Size = new Size(716, 479);
            ClinikListDataGrid.TabIndex = 0;
            ClinikListDataGrid.CellContentClick += ClinikListDataGrid_CellContentClick;
            // 
            // EditClinikButton
            // 
            EditClinikButton.BackColor = Color.SteelBlue;
            EditClinikButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditClinikButton.Location = new Point(714, 129);
            EditClinikButton.Margin = new Padding(3, 4, 3, 4);
            EditClinikButton.Name = "EditClinikButton";
            EditClinikButton.Size = new Size(79, 141);
            EditClinikButton.TabIndex = 1;
            EditClinikButton.Text = "Edit";
            EditClinikButton.UseVisualStyleBackColor = false;
            EditClinikButton.Click += EditClinikButton_Click;
            // 
            // DeleteCLinikButton
            // 
            DeleteCLinikButton.BackColor = Color.Red;
            DeleteCLinikButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteCLinikButton.ForeColor = Color.Black;
            DeleteCLinikButton.Location = new Point(714, 0);
            DeleteCLinikButton.Margin = new Padding(3, 4, 3, 4);
            DeleteCLinikButton.Name = "DeleteCLinikButton";
            DeleteCLinikButton.Size = new Size(79, 133);
            DeleteCLinikButton.TabIndex = 2;
            DeleteCLinikButton.Text = "Delete";
            DeleteCLinikButton.UseVisualStyleBackColor = false;
            DeleteCLinikButton.Click += DeleteCLinikButton_Click;
            // 
            // AddClinikButton
            // 
            AddClinikButton.BackColor = Color.SeaGreen;
            AddClinikButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddClinikButton.Location = new Point(714, 266);
            AddClinikButton.Margin = new Padding(3, 4, 3, 4);
            AddClinikButton.Name = "AddClinikButton";
            AddClinikButton.Size = new Size(79, 139);
            AddClinikButton.TabIndex = 3;
            AddClinikButton.Text = "Add";
            AddClinikButton.UseVisualStyleBackColor = false;
            AddClinikButton.Click += AddClinikButton_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Gray;
            Back.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Back.Location = new Point(717, 400);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(79, 136);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // ClinikListForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(Back);
            Controls.Add(AddClinikButton);
            Controls.Add(DeleteCLinikButton);
            Controls.Add(EditClinikButton);
            Controls.Add(ClinikListDataGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClinikListForAdmin";
            Size = new Size(796, 536);
            ((System.ComponentModel.ISupportInitialize)ClinikListDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ClinikListDataGrid;
        private Button EditClinikButton;
        private Button DeleteCLinikButton;
        private Button AddClinikButton;
        private Button Back;
    }
}

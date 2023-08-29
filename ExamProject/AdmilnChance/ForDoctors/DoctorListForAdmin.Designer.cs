namespace WInforms.AdmilnChance.ForDoctors
{
    partial class DoctorListForAdmin
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
            DeleteCLinikButton = new Button();
            EditClinikButton = new Button();
            AddClinikButton = new Button();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinikListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ClinikListDataGrid
            // 
            ClinikListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClinikListDataGrid.Location = new Point(0, 0);
            ClinikListDataGrid.Margin = new Padding(3, 4, 3, 4);
            ClinikListDataGrid.Name = "ClinikListDataGrid";
            ClinikListDataGrid.RowHeadersWidth = 51;
            ClinikListDataGrid.RowTemplate.Height = 24;
            ClinikListDataGrid.Size = new Size(725, 565);
            ClinikListDataGrid.TabIndex = 1;
            // 
            // DeleteCLinikButton
            // 
            DeleteCLinikButton.BackColor = Color.Red;
            DeleteCLinikButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteCLinikButton.ForeColor = Color.Black;
            DeleteCLinikButton.Location = new Point(724, 0);
            DeleteCLinikButton.Margin = new Padding(3, 4, 3, 4);
            DeleteCLinikButton.Name = "DeleteCLinikButton";
            DeleteCLinikButton.Size = new Size(79, 136);
            DeleteCLinikButton.TabIndex = 3;
            DeleteCLinikButton.Text = "Delete";
            DeleteCLinikButton.UseVisualStyleBackColor = false;
            DeleteCLinikButton.Click += DeleteCLinikButton_Click;
            // 
            // EditClinikButton
            // 
            EditClinikButton.BackColor = Color.SteelBlue;
            EditClinikButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditClinikButton.Location = new Point(724, 128);
            EditClinikButton.Margin = new Padding(3, 4, 3, 4);
            EditClinikButton.Name = "EditClinikButton";
            EditClinikButton.Size = new Size(79, 154);
            EditClinikButton.TabIndex = 7;
            EditClinikButton.Text = "Edit";
            EditClinikButton.UseVisualStyleBackColor = false;
            EditClinikButton.Click += EditClinikButton_Click;
            // 
            // AddClinikButton
            // 
            AddClinikButton.BackColor = Color.SeaGreen;
            AddClinikButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddClinikButton.Location = new Point(724, 276);
            AddClinikButton.Margin = new Padding(3, 4, 3, 4);
            AddClinikButton.Name = "AddClinikButton";
            AddClinikButton.Size = new Size(79, 155);
            AddClinikButton.TabIndex = 8;
            AddClinikButton.Text = "Add";
            AddClinikButton.UseVisualStyleBackColor = false;
            AddClinikButton.Click += AddClinikButton_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Gray;
            Back.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Back.Location = new Point(724, 424);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(79, 123);
            Back.TabIndex = 9;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // DoctorListForAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Back);
            Controls.Add(AddClinikButton);
            Controls.Add(EditClinikButton);
            Controls.Add(DeleteCLinikButton);
            Controls.Add(ClinikListDataGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorListForAdmin";
            Size = new Size(803, 547);
            ((System.ComponentModel.ISupportInitialize)ClinikListDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ClinikListDataGrid;
        private Button DeleteCLinikButton;
        private Button EditClinikButton;
        private Button AddClinikButton;
        private Button Back;
    }
}

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
            this.ClinikListDataGrid = new System.Windows.Forms.DataGridView();
            this.EditClinikButton = new System.Windows.Forms.Button();
            this.DeleteCLinikButton = new System.Windows.Forms.Button();
            this.AddClinikButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClinikListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClinikListDataGrid
            // 
            this.ClinikListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClinikListDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ClinikListDataGrid.Name = "ClinikListDataGrid";
            this.ClinikListDataGrid.RowHeadersWidth = 51;
            this.ClinikListDataGrid.RowTemplate.Height = 24;
            this.ClinikListDataGrid.Size = new System.Drawing.Size(724, 452);
            this.ClinikListDataGrid.TabIndex = 0;
            // 
            // EditClinikButton
            // 
            this.EditClinikButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EditClinikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditClinikButton.Location = new System.Drawing.Point(724, 113);
            this.EditClinikButton.Name = "EditClinikButton";
            this.EditClinikButton.Size = new System.Drawing.Size(79, 113);
            this.EditClinikButton.TabIndex = 1;
            this.EditClinikButton.Text = "Edit";
            this.EditClinikButton.UseVisualStyleBackColor = false;
            this.EditClinikButton.Click += new System.EventHandler(this.EditClinikButton_Click);
            // 
            // DeleteCLinikButton
            // 
            this.DeleteCLinikButton.BackColor = System.Drawing.Color.Red;
            this.DeleteCLinikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCLinikButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteCLinikButton.Location = new System.Drawing.Point(724, 0);
            this.DeleteCLinikButton.Name = "DeleteCLinikButton";
            this.DeleteCLinikButton.Size = new System.Drawing.Size(79, 117);
            this.DeleteCLinikButton.TabIndex = 2;
            this.DeleteCLinikButton.Text = "Delete";
            this.DeleteCLinikButton.UseVisualStyleBackColor = false;
            this.DeleteCLinikButton.Click += new System.EventHandler(this.DeleteCLinikButton_Click);
            // 
            // AddClinikButton
            // 
            this.AddClinikButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddClinikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClinikButton.Location = new System.Drawing.Point(724, 222);
            this.AddClinikButton.Name = "AddClinikButton";
            this.AddClinikButton.Size = new System.Drawing.Size(79, 111);
            this.AddClinikButton.TabIndex = 3;
            this.AddClinikButton.Text = "Add";
            this.AddClinikButton.UseVisualStyleBackColor = false;
            this.AddClinikButton.Click += new System.EventHandler(this.AddClinikButton_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(724, 332);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(79, 117);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ClinikListForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddClinikButton);
            this.Controls.Add(this.DeleteCLinikButton);
            this.Controls.Add(this.EditClinikButton);
            this.Controls.Add(this.ClinikListDataGrid);
            this.Name = "ClinikListForAdmin";
            this.Size = new System.Drawing.Size(803, 452);
            ((System.ComponentModel.ISupportInitialize)(this.ClinikListDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClinikListDataGrid;
        private System.Windows.Forms.Button EditClinikButton;
        private System.Windows.Forms.Button DeleteCLinikButton;
        private System.Windows.Forms.Button AddClinikButton;
        private System.Windows.Forms.Button Back;
    }
}

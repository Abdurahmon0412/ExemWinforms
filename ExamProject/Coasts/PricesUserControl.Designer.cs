namespace WInforms.Coasts
{
    partial class PricesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PricesUserControl));
            BackButton = new Button();
            MedServiceDataGrid = new DataGridView();
            ServicePicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MedServiceDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServicePicture).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Brown;
            BackButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(0, 0);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(91, 54);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MedServiceDataGrid
            // 
            MedServiceDataGrid.BackgroundColor = Color.FromArgb(192, 64, 0);
            MedServiceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MedServiceDataGrid.Location = new Point(88, 3);
            MedServiceDataGrid.Name = "MedServiceDataGrid";
            MedServiceDataGrid.RowHeadersWidth = 51;
            MedServiceDataGrid.RowTemplate.Height = 29;
            MedServiceDataGrid.Size = new Size(369, 541);
            MedServiceDataGrid.TabIndex = 3;
            MedServiceDataGrid.CellContentClick += MedServiceDataGrid_CellContentClick;
            // 
            // ServicePicture
            // 
            ServicePicture.ErrorImage = ExamProject.Properties.Resources.ClinikPicture;
            ServicePicture.Image = ExamProject.Properties.Resources.ClinikPicture;
            ServicePicture.InitialImage = (Image)resources.GetObject("ServicePicture.InitialImage");
            ServicePicture.Location = new Point(463, 3);
            ServicePicture.Name = "ServicePicture";
            ServicePicture.Size = new Size(337, 559);
            ServicePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ServicePicture.TabIndex = 4;
            ServicePicture.TabStop = false;
            // 
            // PricesUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            Controls.Add(ServicePicture);
            Controls.Add(MedServiceDataGrid);
            Controls.Add(BackButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PricesUserControl";
            Size = new Size(803, 565);
            ((System.ComponentModel.ISupportInitialize)MedServiceDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServicePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BackButton;
        private DataGridView MedServiceDataGrid;
        private PictureBox ServicePicture;
    }
}

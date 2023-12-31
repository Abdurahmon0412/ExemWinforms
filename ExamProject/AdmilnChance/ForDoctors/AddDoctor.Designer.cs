﻿namespace WInforms.AdmilnChance.ForDoctors
{
    partial class AddDoctor
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
            OKButton = new Button();
            AddButton = new Button();
            EndTimeText = new TextBox();
            StartTimetext = new TextBox();
            NameTextBox = new TextBox();
            EndTime = new Label();
            Starttime = new Label();
            NameLabel = new Label();
            DoctorRoom = new TextBox();
            EnterRoom = new Label();
            DoctorFloorText = new TextBox();
            DoctorFloor = new Label();
            DoctorLavelText = new TextBox();
            DoctorLavel = new Label();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.FromArgb(0, 192, 0);
            OKButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OKButton.Location = new Point(406, 459);
            OKButton.Margin = new Padding(3, 4, 3, 4);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 51);
            OKButton.TabIndex = 17;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Blue;
            AddButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = SystemColors.ButtonHighlight;
            AddButton.Location = new Point(207, 459);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 51);
            AddButton.TabIndex = 16;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // EndTimeText
            // 
            EndTimeText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EndTimeText.Location = new Point(196, 182);
            EndTimeText.Margin = new Padding(3, 4, 3, 4);
            EndTimeText.Multiline = true;
            EndTimeText.Name = "EndTimeText";
            EndTimeText.Size = new Size(379, 42);
            EndTimeText.TabIndex = 15;
            // 
            // StartTimetext
            // 
            StartTimetext.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartTimetext.Location = new Point(196, 102);
            StartTimetext.Margin = new Padding(3, 4, 3, 4);
            StartTimetext.Multiline = true;
            StartTimetext.Name = "StartTimetext";
            StartTimetext.Size = new Size(379, 42);
            StartTimetext.TabIndex = 14;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(196, 22);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(379, 42);
            NameTextBox.TabIndex = 13;
            // 
            // EndTime
            // 
            EndTime.AutoSize = true;
            EndTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EndTime.Location = new Point(3, 182);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(139, 25);
            EndTime.TabIndex = 12;
            EndTime.Text = "Enter End time";
            // 
            // Starttime
            // 
            Starttime.AutoSize = true;
            Starttime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Starttime.Location = new Point(3, 102);
            Starttime.Name = "Starttime";
            Starttime.Size = new Size(145, 25);
            Starttime.TabIndex = 11;
            Starttime.Text = "Enter Start time";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(3, 22);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(177, 25);
            NameLabel.TabIndex = 10;
            NameLabel.Text = "Enter Doctor Name";
            // 
            // DoctorRoom
            // 
            DoctorRoom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorRoom.Location = new Point(196, 246);
            DoctorRoom.Margin = new Padding(3, 4, 3, 4);
            DoctorRoom.Multiline = true;
            DoctorRoom.Name = "DoctorRoom";
            DoctorRoom.Size = new Size(379, 42);
            DoctorRoom.TabIndex = 19;
            // 
            // EnterRoom
            // 
            EnterRoom.AutoSize = true;
            EnterRoom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterRoom.Location = new Point(3, 246);
            EnterRoom.Name = "EnterRoom";
            EnterRoom.Size = new Size(169, 25);
            EnterRoom.TabIndex = 18;
            EnterRoom.Text = "Enter Doctor room";
            // 
            // DoctorFloorText
            // 
            DoctorFloorText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorFloorText.Location = new Point(196, 321);
            DoctorFloorText.Margin = new Padding(3, 4, 3, 4);
            DoctorFloorText.Multiline = true;
            DoctorFloorText.Name = "DoctorFloorText";
            DoctorFloorText.Size = new Size(379, 42);
            DoctorFloorText.TabIndex = 21;
            // 
            // DoctorFloor
            // 
            DoctorFloor.AutoSize = true;
            DoctorFloor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorFloor.Location = new Point(3, 321);
            DoctorFloor.Name = "DoctorFloor";
            DoctorFloor.Size = new Size(162, 25);
            DoctorFloor.TabIndex = 20;
            DoctorFloor.Text = "Enter Doctor floor";
            // 
            // DoctorLavelText
            // 
            DoctorLavelText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorLavelText.Location = new Point(196, 409);
            DoctorLavelText.Margin = new Padding(3, 4, 3, 4);
            DoctorLavelText.Multiline = true;
            DoctorLavelText.Name = "DoctorLavelText";
            DoctorLavelText.Size = new Size(379, 42);
            DoctorLavelText.TabIndex = 23;
            // 
            // DoctorLavel
            // 
            DoctorLavel.AutoSize = true;
            DoctorLavel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DoctorLavel.Location = new Point(3, 409);
            DoctorLavel.Name = "DoctorLavel";
            DoctorLavel.Size = new Size(177, 25);
            DoctorLavel.TabIndex = 22;
            DoctorLavel.Text = "Enter Doctor Lavel ";
            // 
            // AddDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            Controls.Add(DoctorLavelText);
            Controls.Add(DoctorLavel);
            Controls.Add(DoctorFloorText);
            Controls.Add(DoctorFloor);
            Controls.Add(DoctorRoom);
            Controls.Add(EnterRoom);
            Controls.Add(OKButton);
            Controls.Add(AddButton);
            Controls.Add(EndTimeText);
            Controls.Add(StartTimetext);
            Controls.Add(NameTextBox);
            Controls.Add(EndTime);
            Controls.Add(Starttime);
            Controls.Add(NameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddDoctor";
            Size = new Size(803, 547);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKButton;
        private Button AddButton;
        private TextBox EndTimeText;
        private TextBox StartTimetext;
        private TextBox NameTextBox;
        private Label EndTime;
        private Label Starttime;
        private Label NameLabel;
        private TextBox DoctorRoom;
        private Label EnterRoom;
        private TextBox DoctorFloorText;
        private Label DoctorFloor;
        private TextBox DoctorLavelText;
        private Label DoctorLavel;
    }
}

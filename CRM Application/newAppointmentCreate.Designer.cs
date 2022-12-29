namespace CRM_Application
{
    partial class NewAppointmentCreate
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.patientNameTextbox = new System.Windows.Forms.TextBox();
            this.saveAppointmentButton = new System.Windows.Forms.Button();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.appDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientNameEmptyErrorLabel = new System.Windows.Forms.Label();
            this.roomNumberErrorLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(152, 132);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(48, 20);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.Location = new System.Drawing.Point(406, 184);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(76, 20);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "End Time";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomNumberLabel.Location = new System.Drawing.Point(144, 278);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(56, 20);
            roomNumberLabel.TabIndex = 5;
            roomNumberLabel.Text = "Room:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientNameLabel.Location = new System.Drawing.Point(91, 77);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(109, 20);
            patientNameLabel.TabIndex = 6;
            patientNameLabel.Text = "Patient Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startTimeLabel.Location = new System.Drawing.Point(226, 184);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(82, 20);
            startTimeLabel.TabIndex = 14;
            startTimeLabel.Text = "Start Time";
            // 
            // patientNameTextbox
            // 
            this.patientNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTextbox.Location = new System.Drawing.Point(211, 76);
            this.patientNameTextbox.Name = "patientNameTextbox";
            this.patientNameTextbox.Size = new System.Drawing.Size(288, 26);
            this.patientNameTextbox.TabIndex = 7;
            // 
            // saveAppointmentButton
            // 
            this.saveAppointmentButton.Location = new System.Drawing.Point(398, 326);
            this.saveAppointmentButton.Name = "saveAppointmentButton";
            this.saveAppointmentButton.Size = new System.Drawing.Size(100, 39);
            this.saveAppointmentButton.TabIndex = 9;
            this.saveAppointmentButton.Text = "Save";
            this.saveAppointmentButton.UseVisualStyleBackColor = true;
            this.saveAppointmentButton.Click += new System.EventHandler(this.saveAppointmentButton_Click);
            // 
            // roomBox
            // 
            this.roomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4",
            "Room 5",
            "Room 6",
            "Room 7",
            "Room 8",
            "Room 9"});
            this.roomBox.Location = new System.Drawing.Point(211, 278);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(287, 28);
            this.roomBox.TabIndex = 10;
            // 
            // appDatePicker
            // 
            this.appDatePicker.CustomFormat = "mm/dd/yyyy";
            this.appDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.appDatePicker.Location = new System.Drawing.Point(213, 132);
            this.appDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appDatePicker.Name = "appDatePicker";
            this.appDatePicker.Size = new System.Drawing.Size(287, 26);
            this.appDatePicker.TabIndex = 11;
            this.appDatePicker.Value = new System.DateTime(2022, 10, 11, 13, 6, 59, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(388, 215);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(111, 26);
            this.endTimePicker.TabIndex = 12;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(213, 215);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(111, 26);
            this.startTimePicker.TabIndex = 13;
            // 
            // patientNameEmptyErrorLabel
            // 
            this.patientNameEmptyErrorLabel.AutoSize = true;
            this.patientNameEmptyErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameEmptyErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.patientNameEmptyErrorLabel.Location = new System.Drawing.Point(208, 105);
            this.patientNameEmptyErrorLabel.Name = "patientNameEmptyErrorLabel";
            this.patientNameEmptyErrorLabel.Size = new System.Drawing.Size(154, 15);
            this.patientNameEmptyErrorLabel.TabIndex = 15;
            this.patientNameEmptyErrorLabel.Text = "* Field cannot be left empty";
            this.patientNameEmptyErrorLabel.Visible = false;
            // 
            // roomNumberErrorLabel
            // 
            this.roomNumberErrorLabel.AutoSize = true;
            this.roomNumberErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.roomNumberErrorLabel.Location = new System.Drawing.Point(210, 309);
            this.roomNumberErrorLabel.Name = "roomNumberErrorLabel";
            this.roomNumberErrorLabel.Size = new System.Drawing.Size(154, 15);
            this.roomNumberErrorLabel.TabIndex = 16;
            this.roomNumberErrorLabel.Text = "* Field cannot be left empty";
            this.roomNumberErrorLabel.Visible = false;
            // 
            // NewAppointmentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 404);
            this.Controls.Add(this.roomNumberErrorLabel);
            this.Controls.Add(this.patientNameEmptyErrorLabel);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.appDatePicker);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.saveAppointmentButton);
            this.Controls.Add(this.patientNameTextbox);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(roomNumberLabel);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(dateLabel);
            this.Name = "NewAppointmentCreate";
            this.Text = "newAppointmentCreate";
            this.Load += new System.EventHandler(this.newAppointmentCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox patientNameTextbox;
        private System.Windows.Forms.Button saveAppointmentButton;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.DateTimePicker appDatePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label patientNameEmptyErrorLabel;
        private System.Windows.Forms.Label roomNumberErrorLabel;
    }
}
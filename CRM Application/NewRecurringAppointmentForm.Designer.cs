
namespace CRM_Application {
    partial class NewRecurringAppointmentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startingDateLabel;
            System.Windows.Forms.Label endingDateLabel;
            this.patientNameTextbox = new System.Windows.Forms.TextBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.saveAppointmentButton = new System.Windows.Forms.Button();
            this.dateEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sundayCheckbox = new System.Windows.Forms.CheckBox();
            this.tuesdayCheckbox = new System.Windows.Forms.CheckBox();
            this.saturdayCheckbox = new System.Windows.Forms.CheckBox();
            this.mondayCheckbox = new System.Windows.Forms.CheckBox();
            this.fridayCheckbox = new System.Windows.Forms.CheckBox();
            this.thurdsayCheckbox = new System.Windows.Forms.CheckBox();
            this.wednesdayCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomNumberErrorLabel = new System.Windows.Forms.Label();
            this.patientNameEmptyErrorLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            startingDateLabel = new System.Windows.Forms.Label();
            endingDateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientNameTextbox
            // 
            this.patientNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTextbox.Location = new System.Drawing.Point(156, 26);
            this.patientNameTextbox.Name = "patientNameTextbox";
            this.patientNameTextbox.Size = new System.Drawing.Size(288, 26);
            this.patientNameTextbox.TabIndex = 8;
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientNameLabel.Location = new System.Drawing.Point(41, 29);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(109, 20);
            patientNameLabel.TabIndex = 9;
            patientNameLabel.Text = "Patient Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startTimeLabel.Location = new System.Drawing.Point(184, 277);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(82, 20);
            startTimeLabel.TabIndex = 23;
            startTimeLabel.Text = "Start Time";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(168, 304);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(111, 26);
            this.startTimePicker.TabIndex = 22;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(344, 304);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(111, 26);
            this.endTimePicker.TabIndex = 21;
            // 
            // appStartDatePicker
            // 
            this.appStartDatePicker.CustomFormat = "mm/dd/yyyy";
            this.appStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appStartDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.appStartDatePicker.Location = new System.Drawing.Point(157, 83);
            this.appStartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.appStartDatePicker.Name = "appStartDatePicker";
            this.appStartDatePicker.Size = new System.Drawing.Size(287, 26);
            this.appStartDatePicker.TabIndex = 20;
            this.appStartDatePicker.Value = new System.DateTime(2022, 10, 11, 13, 6, 59, 0);
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
            this.roomBox.Location = new System.Drawing.Point(168, 368);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(287, 28);
            this.roomBox.TabIndex = 19;
            // 
            // saveAppointmentButton
            // 
            this.saveAppointmentButton.Location = new System.Drawing.Point(490, 363);
            this.saveAppointmentButton.Name = "saveAppointmentButton";
            this.saveAppointmentButton.Size = new System.Drawing.Size(100, 39);
            this.saveAppointmentButton.TabIndex = 18;
            this.saveAppointmentButton.Text = "Save";
            this.saveAppointmentButton.UseVisualStyleBackColor = true;
            this.saveAppointmentButton.Click += new System.EventHandler(this.saveAppointmentButton_Click);
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomNumberLabel.Location = new System.Drawing.Point(96, 376);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(56, 20);
            roomNumberLabel.TabIndex = 17;
            roomNumberLabel.Text = "Room:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.Location = new System.Drawing.Point(368, 277);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(76, 20);
            endTimeLabel.TabIndex = 16;
            endTimeLabel.Text = "End Time";
            // 
            // startingDateLabel
            // 
            startingDateLabel.AutoSize = true;
            startingDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startingDateLabel.Location = new System.Drawing.Point(44, 83);
            startingDateLabel.Name = "startingDateLabel";
            startingDateLabel.Size = new System.Drawing.Size(108, 20);
            startingDateLabel.TabIndex = 15;
            startingDateLabel.Text = "Starting Date:";
            // 
            // dateEndTimePicker
            // 
            this.dateEndTimePicker.CustomFormat = "mm/dd/yyyy";
            this.dateEndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEndTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateEndTimePicker.Location = new System.Drawing.Point(157, 128);
            this.dateEndTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateEndTimePicker.Name = "dateEndTimePicker";
            this.dateEndTimePicker.Size = new System.Drawing.Size(287, 26);
            this.dateEndTimePicker.TabIndex = 25;
            this.dateEndTimePicker.Value = new System.DateTime(2022, 10, 11, 13, 6, 59, 0);
            // 
            // endingDateLabel
            // 
            endingDateLabel.AutoSize = true;
            endingDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endingDateLabel.Location = new System.Drawing.Point(44, 128);
            endingDateLabel.Name = "endingDateLabel";
            endingDateLabel.Size = new System.Drawing.Size(102, 20);
            endingDateLabel.TabIndex = 24;
            endingDateLabel.Text = "Ending Date:";
            // 
            // sundayCheckbox
            // 
            this.sundayCheckbox.AutoSize = true;
            this.sundayCheckbox.Location = new System.Drawing.Point(17, 26);
            this.sundayCheckbox.Name = "sundayCheckbox";
            this.sundayCheckbox.Size = new System.Drawing.Size(62, 17);
            this.sundayCheckbox.TabIndex = 26;
            this.sundayCheckbox.Text = "Sunday";
            this.sundayCheckbox.UseVisualStyleBackColor = true;
            // 
            // tuesdayCheckbox
            // 
            this.tuesdayCheckbox.AutoSize = true;
            this.tuesdayCheckbox.Location = new System.Drawing.Point(161, 26);
            this.tuesdayCheckbox.Name = "tuesdayCheckbox";
            this.tuesdayCheckbox.Size = new System.Drawing.Size(67, 17);
            this.tuesdayCheckbox.TabIndex = 27;
            this.tuesdayCheckbox.Text = "Tuesday";
            this.tuesdayCheckbox.UseVisualStyleBackColor = true;
            // 
            // saturdayCheckbox
            // 
            this.saturdayCheckbox.AutoSize = true;
            this.saturdayCheckbox.Location = new System.Drawing.Point(161, 49);
            this.saturdayCheckbox.Name = "saturdayCheckbox";
            this.saturdayCheckbox.Size = new System.Drawing.Size(68, 17);
            this.saturdayCheckbox.TabIndex = 28;
            this.saturdayCheckbox.Text = "Saturday";
            this.saturdayCheckbox.UseVisualStyleBackColor = true;
            // 
            // mondayCheckbox
            // 
            this.mondayCheckbox.AutoSize = true;
            this.mondayCheckbox.Location = new System.Drawing.Point(90, 26);
            this.mondayCheckbox.Name = "mondayCheckbox";
            this.mondayCheckbox.Size = new System.Drawing.Size(64, 17);
            this.mondayCheckbox.TabIndex = 29;
            this.mondayCheckbox.Text = "Monday";
            this.mondayCheckbox.UseVisualStyleBackColor = true;
            // 
            // fridayCheckbox
            // 
            this.fridayCheckbox.AutoSize = true;
            this.fridayCheckbox.Location = new System.Drawing.Point(90, 49);
            this.fridayCheckbox.Name = "fridayCheckbox";
            this.fridayCheckbox.Size = new System.Drawing.Size(54, 17);
            this.fridayCheckbox.TabIndex = 30;
            this.fridayCheckbox.Text = "Friday";
            this.fridayCheckbox.UseVisualStyleBackColor = true;
            // 
            // thurdsayCheckbox
            // 
            this.thurdsayCheckbox.AutoSize = true;
            this.thurdsayCheckbox.Location = new System.Drawing.Point(15, 49);
            this.thurdsayCheckbox.Name = "thurdsayCheckbox";
            this.thurdsayCheckbox.Size = new System.Drawing.Size(70, 17);
            this.thurdsayCheckbox.TabIndex = 31;
            this.thurdsayCheckbox.Text = "Thursday";
            this.thurdsayCheckbox.UseVisualStyleBackColor = true;
            // 
            // wednesdayCheckbox
            // 
            this.wednesdayCheckbox.AutoSize = true;
            this.wednesdayCheckbox.Location = new System.Drawing.Point(233, 26);
            this.wednesdayCheckbox.Name = "wednesdayCheckbox";
            this.wednesdayCheckbox.Size = new System.Drawing.Size(83, 17);
            this.wednesdayCheckbox.TabIndex = 32;
            this.wednesdayCheckbox.Text = "Wednesday";
            this.wednesdayCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wednesdayCheckbox);
            this.panel1.Controls.Add(this.thurdsayCheckbox);
            this.panel1.Controls.Add(this.fridayCheckbox);
            this.panel1.Controls.Add(this.mondayCheckbox);
            this.panel1.Controls.Add(this.saturdayCheckbox);
            this.panel1.Controls.Add(this.tuesdayCheckbox);
            this.panel1.Controls.Add(this.sundayCheckbox);
            this.panel1.Location = new System.Drawing.Point(139, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 91);
            this.panel1.TabIndex = 33;
            // 
            // roomNumberErrorLabel
            // 
            this.roomNumberErrorLabel.AutoSize = true;
            this.roomNumberErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.roomNumberErrorLabel.Location = new System.Drawing.Point(165, 399);
            this.roomNumberErrorLabel.Name = "roomNumberErrorLabel";
            this.roomNumberErrorLabel.Size = new System.Drawing.Size(154, 15);
            this.roomNumberErrorLabel.TabIndex = 35;
            this.roomNumberErrorLabel.Text = "* Field cannot be left empty";
            this.roomNumberErrorLabel.Visible = false;
            // 
            // patientNameEmptyErrorLabel
            // 
            this.patientNameEmptyErrorLabel.AutoSize = true;
            this.patientNameEmptyErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameEmptyErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.patientNameEmptyErrorLabel.Location = new System.Drawing.Point(154, 55);
            this.patientNameEmptyErrorLabel.Name = "patientNameEmptyErrorLabel";
            this.patientNameEmptyErrorLabel.Size = new System.Drawing.Size(154, 15);
            this.patientNameEmptyErrorLabel.TabIndex = 34;
            this.patientNameEmptyErrorLabel.Text = "* Field cannot be left empty";
            this.patientNameEmptyErrorLabel.Visible = false;
            // 
            // NewRecurringAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.roomNumberErrorLabel);
            this.Controls.Add(this.patientNameEmptyErrorLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateEndTimePicker);
            this.Controls.Add(endingDateLabel);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.appStartDatePicker);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.saveAppointmentButton);
            this.Controls.Add(roomNumberLabel);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(startingDateLabel);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextbox);
            this.Name = "NewRecurringAppointmentForm";
            this.Text = "Add Recurring Appointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox patientNameTextbox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker appStartDatePicker;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.Button saveAppointmentButton;
        private System.Windows.Forms.DateTimePicker dateEndTimePicker;
        private System.Windows.Forms.CheckBox sundayCheckbox;
        private System.Windows.Forms.CheckBox tuesdayCheckbox;
        private System.Windows.Forms.CheckBox saturdayCheckbox;
        private System.Windows.Forms.CheckBox mondayCheckbox;
        private System.Windows.Forms.CheckBox fridayCheckbox;
        private System.Windows.Forms.CheckBox thurdsayCheckbox;
        private System.Windows.Forms.CheckBox wednesdayCheckbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roomNumberErrorLabel;
        private System.Windows.Forms.Label patientNameEmptyErrorLabel;
    }
}
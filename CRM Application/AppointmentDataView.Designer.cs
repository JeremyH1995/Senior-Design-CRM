namespace CRM_Application {
    partial class AppointmentDataView {
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
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNameTextbox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.appDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberSelector = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cancelPopup = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.confirmCancelButton = new System.Windows.Forms.Button();
            this.cancelCancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteConfirmPanel = new System.Windows.Forms.Panel();
            this.deleteCancelButton = new System.Windows.Forms.Button();
            this.deleteConfirmButton = new System.Windows.Forms.Button();
            this.confirmDeleteLabel = new System.Windows.Forms.Label();
            this.deleteCornerXButton = new System.Windows.Forms.Button();
            this.cancelPopup.SuspendLayout();
            this.deleteConfirmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(66, 58);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(139, 26);
            this.clientNameLabel.TabIndex = 0;
            this.clientNameLabel.Text = "Client Name:";
            // 
            // clientNameTextbox
            // 
            this.clientNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTextbox.Location = new System.Drawing.Point(209, 59);
            this.clientNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientNameTextbox.Name = "clientNameTextbox";
            this.clientNameTextbox.ReadOnly = true;
            this.clientNameTextbox.Size = new System.Drawing.Size(259, 26);
            this.clientNameTextbox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(130, 103);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 26);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date:";
            // 
            // appDatePicker
            // 
            this.appDatePicker.CustomFormat = "mm/dd/yyyy";
            this.appDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.appDatePicker.Location = new System.Drawing.Point(209, 103);
            this.appDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appDatePicker.Name = "appDatePicker";
            this.appDatePicker.Size = new System.Drawing.Size(259, 26);
            this.appDatePicker.TabIndex = 3;
            this.appDatePicker.Value = new System.DateTime(2022, 10, 11, 13, 6, 59, 0);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(209, 172);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(111, 26);
            this.startTimePicker.TabIndex = 4;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(357, 172);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(111, 26);
            this.endTimePicker.TabIndex = 5;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(205, 146);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(94, 24);
            this.startTimeLabel.TabIndex = 6;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(353, 146);
            this.endTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(93, 24);
            this.endTimeLabel.TabIndex = 7;
            this.endTimeLabel.Text = "End Time";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(44, 219);
            this.roomNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(161, 26);
            this.roomNumberLabel.TabIndex = 8;
            this.roomNumberLabel.Text = "Room Number:";
            // 
            // roomNumberSelector
            // 
            this.roomNumberSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberSelector.FormattingEnabled = true;
            this.roomNumberSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.roomNumberSelector.Location = new System.Drawing.Point(209, 220);
            this.roomNumberSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomNumberSelector.Name = "roomNumberSelector";
            this.roomNumberSelector.Size = new System.Drawing.Size(91, 28);
            this.roomNumberSelector.TabIndex = 9;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(357, 291);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(98, 28);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(357, 291);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 28);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(467, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 28);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cancelPopup
            // 
            this.cancelPopup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cancelPopup.Controls.Add(this.cancelCancelButton);
            this.cancelPopup.Controls.Add(this.confirmCancelButton);
            this.cancelPopup.Controls.Add(this.confirmationLabel);
            this.cancelPopup.Controls.Add(this.closeButton);
            this.cancelPopup.Location = new System.Drawing.Point(49, 59);
            this.cancelPopup.Name = "cancelPopup";
            this.cancelPopup.Size = new System.Drawing.Size(497, 186);
            this.cancelPopup.TabIndex = 13;
            this.cancelPopup.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(462, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 37);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationLabel.Location = new System.Drawing.Point(93, 63);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(294, 48);
            this.confirmationLabel.TabIndex = 1;
            this.confirmationLabel.Text = "Are you sure you want to cancel? \r\nAll changes will be lost";
            this.confirmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmCancelButton
            // 
            this.confirmCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.confirmCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmCancelButton.Location = new System.Drawing.Point(97, 144);
            this.confirmCancelButton.Name = "confirmCancelButton";
            this.confirmCancelButton.Size = new System.Drawing.Size(98, 28);
            this.confirmCancelButton.TabIndex = 14;
            this.confirmCancelButton.Text = "Yes";
            this.confirmCancelButton.UseVisualStyleBackColor = false;
            this.confirmCancelButton.Click += new System.EventHandler(this.confirmCancelButton_Click);
            // 
            // cancelCancelButton
            // 
            this.cancelCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCancelButton.Location = new System.Drawing.Point(289, 144);
            this.cancelCancelButton.Name = "cancelCancelButton";
            this.cancelCancelButton.Size = new System.Drawing.Size(98, 28);
            this.cancelCancelButton.TabIndex = 14;
            this.cancelCancelButton.Text = "Cancel";
            this.cancelCancelButton.UseVisualStyleBackColor = false;
            this.cancelCancelButton.Click += new System.EventHandler(this.cancelCancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(467, 291);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 28);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteConfirmPanel
            // 
            this.deleteConfirmPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteConfirmPanel.Controls.Add(this.deleteCancelButton);
            this.deleteConfirmPanel.Controls.Add(this.deleteConfirmButton);
            this.deleteConfirmPanel.Controls.Add(this.confirmDeleteLabel);
            this.deleteConfirmPanel.Controls.Add(this.deleteCornerXButton);
            this.deleteConfirmPanel.Location = new System.Drawing.Point(49, 58);
            this.deleteConfirmPanel.Name = "deleteConfirmPanel";
            this.deleteConfirmPanel.Size = new System.Drawing.Size(497, 186);
            this.deleteConfirmPanel.TabIndex = 15;
            this.deleteConfirmPanel.Visible = false;
            // 
            // deleteCancelButton
            // 
            this.deleteCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCancelButton.Location = new System.Drawing.Point(289, 144);
            this.deleteCancelButton.Name = "deleteCancelButton";
            this.deleteCancelButton.Size = new System.Drawing.Size(98, 28);
            this.deleteCancelButton.TabIndex = 14;
            this.deleteCancelButton.Text = "Cancel";
            this.deleteCancelButton.UseVisualStyleBackColor = false;
            this.deleteCancelButton.Click += new System.EventHandler(this.deleteCancelButton_Click);
            // 
            // deleteConfirmButton
            // 
            this.deleteConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.deleteConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteConfirmButton.Location = new System.Drawing.Point(97, 144);
            this.deleteConfirmButton.Name = "deleteConfirmButton";
            this.deleteConfirmButton.Size = new System.Drawing.Size(98, 28);
            this.deleteConfirmButton.TabIndex = 14;
            this.deleteConfirmButton.Text = "Yes";
            this.deleteConfirmButton.UseVisualStyleBackColor = false;
            this.deleteConfirmButton.Click += new System.EventHandler(this.deleteConfirmButton_Click);
            // 
            // confirmDeleteLabel
            // 
            this.confirmDeleteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmDeleteLabel.AutoSize = true;
            this.confirmDeleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDeleteLabel.Location = new System.Drawing.Point(33, 64);
            this.confirmDeleteLabel.Name = "confirmDeleteLabel";
            this.confirmDeleteLabel.Size = new System.Drawing.Size(432, 48);
            this.confirmDeleteLabel.TabIndex = 1;
            this.confirmDeleteLabel.Text = "Are you sure you want to delete this appointment? \r\nThis action cannot be undone." +
    "";
            this.confirmDeleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteCornerXButton
            // 
            this.deleteCornerXButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCornerXButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteCornerXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCornerXButton.Location = new System.Drawing.Point(462, 0);
            this.deleteCornerXButton.Name = "deleteCornerXButton";
            this.deleteCornerXButton.Size = new System.Drawing.Size(34, 37);
            this.deleteCornerXButton.TabIndex = 0;
            this.deleteCornerXButton.Text = "X";
            this.deleteCornerXButton.UseVisualStyleBackColor = false;
            this.deleteCornerXButton.Click += new System.EventHandler(this.deleteCornerXButton_Click);
            // 
            // AppointmentDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(610, 329);
            this.Controls.Add(this.deleteConfirmPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelPopup);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.roomNumberSelector);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.appDatePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.clientNameTextbox);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AppointmentDataView";
            this.Text = "Appointment: ";
            this.cancelPopup.ResumeLayout(false);
            this.cancelPopup.PerformLayout();
            this.deleteConfirmPanel.ResumeLayout(false);
            this.deleteConfirmPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientNameTextbox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker appDatePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.ComboBox roomNumberSelector;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button cancelCancelButton;
        private System.Windows.Forms.Button confirmCancelButton;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Panel cancelPopup;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel deleteConfirmPanel;
        private System.Windows.Forms.Button deleteCancelButton;
        private System.Windows.Forms.Button deleteConfirmButton;
        private System.Windows.Forms.Label confirmDeleteLabel;
        private System.Windows.Forms.Button deleteCornerXButton;
    }
}
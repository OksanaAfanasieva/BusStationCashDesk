namespace BusStationCashDesk.Windows_Forms
{
    partial class Route
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddStop = new System.Windows.Forms.Button();
            this.maskedTextBoxTimeStop = new System.Windows.Forms.MaskedTextBox();
            this.labelTimeStop = new System.Windows.Forms.Label();
            this.labelNameStop = new System.Windows.Forms.Label();
            this.textBoxNameStop = new System.Windows.Forms.TextBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.textBoxNumberRoute = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTimeTo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTimeFrom = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxFreePlace = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFreePlace = new System.Windows.Forms.Label();
            this.labelTimeTo = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelTimeFrom = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(277, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 40);
            this.buttonCancel.TabIndex = 90;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(425, 392);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 40);
            this.buttonSave.TabIndex = 89;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAddStop
            // 
            this.buttonAddStop.Location = new System.Drawing.Point(440, 304);
            this.buttonAddStop.Name = "buttonAddStop";
            this.buttonAddStop.Size = new System.Drawing.Size(127, 30);
            this.buttonAddStop.TabIndex = 65;
            this.buttonAddStop.Text = "Додати зупинку";
            this.buttonAddStop.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTimeStop
            // 
            this.maskedTextBoxTimeStop.Location = new System.Drawing.Point(371, 262);
            this.maskedTextBoxTimeStop.Name = "maskedTextBoxTimeStop";
            this.maskedTextBoxTimeStop.Size = new System.Drawing.Size(196, 23);
            this.maskedTextBoxTimeStop.TabIndex = 88;
            // 
            // labelTimeStop
            // 
            this.labelTimeStop.AutoSize = true;
            this.labelTimeStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeStop.Location = new System.Drawing.Point(371, 238);
            this.labelTimeStop.Name = "labelTimeStop";
            this.labelTimeStop.Size = new System.Drawing.Size(36, 21);
            this.labelTimeStop.TabIndex = 87;
            this.labelTimeStop.Text = "Час";
            // 
            // labelNameStop
            // 
            this.labelNameStop.AutoSize = true;
            this.labelNameStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameStop.Location = new System.Drawing.Point(90, 238);
            this.labelNameStop.Name = "labelNameStop";
            this.labelNameStop.Size = new System.Drawing.Size(52, 21);
            this.labelNameStop.TabIndex = 86;
            this.labelNameStop.Text = "Назва";
            // 
            // textBoxNameStop
            // 
            this.textBoxNameStop.Location = new System.Drawing.Point(92, 262);
            this.textBoxNameStop.Name = "textBoxNameStop";
            this.textBoxNameStop.Size = new System.Drawing.Size(196, 23);
            this.textBoxNameStop.TabIndex = 85;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStop.Location = new System.Drawing.Point(17, 201);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(84, 25);
            this.labelStop.TabIndex = 84;
            this.labelStop.Text = "Зупинки:";
            // 
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.Location = new System.Drawing.Point(148, 27);
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.Size = new System.Drawing.Size(79, 23);
            this.textBoxNumberRoute.TabIndex = 83;
            // 
            // maskedTextBoxTimeTo
            // 
            this.maskedTextBoxTimeTo.Location = new System.Drawing.Point(371, 157);
            this.maskedTextBoxTimeTo.Name = "maskedTextBoxTimeTo";
            this.maskedTextBoxTimeTo.Size = new System.Drawing.Size(196, 23);
            this.maskedTextBoxTimeTo.TabIndex = 82;
            // 
            // maskedTextBoxTimeFrom
            // 
            this.maskedTextBoxTimeFrom.Location = new System.Drawing.Point(92, 157);
            this.maskedTextBoxTimeFrom.Name = "maskedTextBoxTimeFrom";
            this.maskedTextBoxTimeFrom.Size = new System.Drawing.Size(196, 23);
            this.maskedTextBoxTimeFrom.TabIndex = 81;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(371, 122);
            this.dateTimePickerTo.MinDate = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerTo.TabIndex = 80;
            this.dateTimePickerTo.Value = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(92, 120);
            this.dateTimePickerFrom.MinDate = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerFrom.TabIndex = 79;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(487, 358);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(80, 23);
            this.textBoxPrice.TabIndex = 78;
            // 
            // textBoxFreePlace
            // 
            this.textBoxFreePlace.Enabled = false;
            this.textBoxFreePlace.Location = new System.Drawing.Point(223, 355);
            this.textBoxFreePlace.Name = "textBoxFreePlace";
            this.textBoxFreePlace.Size = new System.Drawing.Size(51, 23);
            this.textBoxFreePlace.TabIndex = 77;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Enabled = false;
            this.textBoxTo.Location = new System.Drawing.Point(371, 82);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(196, 23);
            this.textBoxTo.TabIndex = 76;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Enabled = false;
            this.textBoxFrom.Location = new System.Drawing.Point(92, 82);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(196, 23);
            this.textBoxFrom.TabIndex = 75;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(429, 355);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 25);
            this.labelPrice.TabIndex = 74;
            this.labelPrice.Text = "Ціна:";
            // 
            // labelFreePlace
            // 
            this.labelFreePlace.AutoSize = true;
            this.labelFreePlace.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFreePlace.Location = new System.Drawing.Point(17, 355);
            this.labelFreePlace.Name = "labelFreePlace";
            this.labelFreePlace.Size = new System.Drawing.Size(200, 25);
            this.labelFreePlace.TabIndex = 73;
            this.labelFreePlace.Text = "Кількість вільних місць:";
            // 
            // labelTimeTo
            // 
            this.labelTimeTo.AutoSize = true;
            this.labelTimeTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeTo.Location = new System.Drawing.Point(320, 154);
            this.labelTimeTo.Name = "labelTimeTo";
            this.labelTimeTo.Size = new System.Drawing.Size(45, 25);
            this.labelTimeTo.TabIndex = 72;
            this.labelTimeTo.Text = "Час:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(312, 120);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(53, 25);
            this.labelDateTo.TabIndex = 71;
            this.labelDateTo.Text = "Дата:";
            // 
            // labelTimeFrom
            // 
            this.labelTimeFrom.AutoSize = true;
            this.labelTimeFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeFrom.Location = new System.Drawing.Point(41, 154);
            this.labelTimeFrom.Name = "labelTimeFrom";
            this.labelTimeFrom.Size = new System.Drawing.Size(45, 25);
            this.labelTimeFrom.TabIndex = 70;
            this.labelTimeFrom.Text = "Час:";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(33, 120);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(53, 25);
            this.labelDateFrom.TabIndex = 69;
            this.labelDateFrom.Text = "Дата:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(312, 79);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(55, 25);
            this.labelTo.TabIndex = 68;
            this.labelTo.Text = "Куди:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(17, 79);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(69, 25);
            this.labelFrom.TabIndex = 67;
            this.labelFrom.Text = "Звідки:";
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberRoute.Location = new System.Drawing.Point(17, 19);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(125, 28);
            this.labelNumberRoute.TabIndex = 66;
            this.labelNumberRoute.Text = "Маршрут №";
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddStop);
            this.Controls.Add(this.maskedTextBoxTimeStop);
            this.Controls.Add(this.labelTimeStop);
            this.Controls.Add(this.labelNameStop);
            this.Controls.Add(this.textBoxNameStop);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.textBoxNumberRoute);
            this.Controls.Add(this.maskedTextBoxTimeTo);
            this.Controls.Add(this.maskedTextBoxTimeFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxFreePlace);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelFreePlace);
            this.Controls.Add(this.labelTimeTo);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelTimeFrom);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelNumberRoute);
            this.Name = "Route";
            this.Text = "Маршрут";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonAddStop;
        private MaskedTextBox maskedTextBoxTimeStop;
        private Label labelTimeStop;
        private Label labelNameStop;
        private TextBox textBoxNameStop;
        private Label labelStop;
        private TextBox textBoxNumberRoute;
        private MaskedTextBox maskedTextBoxTimeTo;
        private MaskedTextBox maskedTextBoxTimeFrom;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private TextBox textBoxPrice;
        private TextBox textBoxFreePlace;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private Label labelPrice;
        private Label labelFreePlace;
        private Label labelTimeTo;
        private Label labelDateTo;
        private Label labelTimeFrom;
        private Label labelDateFrom;
        private Label labelTo;
        private Label labelFrom;
        private Label labelNumberRoute;
    }
}
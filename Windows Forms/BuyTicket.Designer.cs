namespace BusStationCashDesk.Windows_Forms
{
    partial class BuyTicket
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.numericUpDownPassenger = new System.Windows.Forms.NumericUpDown();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPassenger = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNumberRoute = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTimeTo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTimeFrom = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelTimeTo = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelTimeFrom = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(91, 381);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(99, 41);
            this.textBoxPrice.TabIndex = 86;
            // 
            // numericUpDownPassenger
            // 
            this.numericUpDownPassenger.Location = new System.Drawing.Point(196, 260);
            this.numericUpDownPassenger.Name = "numericUpDownPassenger";
            this.numericUpDownPassenger.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownPassenger.TabIndex = 85;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(373, 218);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(196, 23);
            this.textBoxSurname.TabIndex = 84;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 219);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 23);
            this.textBoxName.TabIndex = 83;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(286, 394);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 46);
            this.buttonCancel.TabIndex = 82;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuy.Location = new System.Drawing.Point(429, 394);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(137, 46);
            this.buttonBuy.TabIndex = 81;
            this.buttonBuy.Text = "Придбати";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(27, 394);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 28);
            this.labelPrice.TabIndex = 80;
            this.labelPrice.Text = "Ціна:";
            // 
            // labelPassenger
            // 
            this.labelPassenger.AutoSize = true;
            this.labelPassenger.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassenger.Location = new System.Drawing.Point(16, 260);
            this.labelPassenger.Name = "labelPassenger";
            this.labelPassenger.Size = new System.Drawing.Size(174, 25);
            this.labelPassenger.TabIndex = 79;
            this.labelPassenger.Text = "Кількість пасажирів:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(271, 216);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(96, 25);
            this.labelSurname.TabIndex = 78;
            this.labelSurname.Text = "Прізвище:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(16, 216);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 25);
            this.labelName.TabIndex = 77;
            this.labelName.Text = "Ім\'я:";
            // 
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.Location = new System.Drawing.Point(147, 18);
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.ReadOnly = true;
            this.textBoxNumberRoute.Size = new System.Drawing.Size(79, 23);
            this.textBoxNumberRoute.TabIndex = 76;
            // 
            // maskedTextBoxTimeTo
            // 
            this.maskedTextBoxTimeTo.Location = new System.Drawing.Point(370, 148);
            this.maskedTextBoxTimeTo.Name = "maskedTextBoxTimeTo";
            this.maskedTextBoxTimeTo.ReadOnly = true;
            this.maskedTextBoxTimeTo.Size = new System.Drawing.Size(196, 23);
            this.maskedTextBoxTimeTo.TabIndex = 75;
            // 
            // maskedTextBoxTimeFrom
            // 
            this.maskedTextBoxTimeFrom.Location = new System.Drawing.Point(91, 148);
            this.maskedTextBoxTimeFrom.Name = "maskedTextBoxTimeFrom";
            this.maskedTextBoxTimeFrom.ReadOnly = true;
            this.maskedTextBoxTimeFrom.Size = new System.Drawing.Size(196, 23);
            this.maskedTextBoxTimeFrom.TabIndex = 74;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Enabled = false;
            this.dateTimePickerTo.Location = new System.Drawing.Point(370, 113);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerTo.TabIndex = 73;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Enabled = false;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(91, 113);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerFrom.TabIndex = 72;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Enabled = false;
            this.textBoxTo.Location = new System.Drawing.Point(370, 73);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(196, 23);
            this.textBoxTo.TabIndex = 71;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Enabled = false;
            this.textBoxFrom.Location = new System.Drawing.Point(91, 73);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ReadOnly = true;
            this.textBoxFrom.Size = new System.Drawing.Size(196, 23);
            this.textBoxFrom.TabIndex = 70;
            // 
            // labelTimeTo
            // 
            this.labelTimeTo.AutoSize = true;
            this.labelTimeTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeTo.Location = new System.Drawing.Point(319, 145);
            this.labelTimeTo.Name = "labelTimeTo";
            this.labelTimeTo.Size = new System.Drawing.Size(45, 25);
            this.labelTimeTo.TabIndex = 69;
            this.labelTimeTo.Text = "Час:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTo.Location = new System.Drawing.Point(311, 111);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(53, 25);
            this.labelDateTo.TabIndex = 68;
            this.labelDateTo.Text = "Дата:";
            // 
            // labelTimeFrom
            // 
            this.labelTimeFrom.AutoSize = true;
            this.labelTimeFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeFrom.Location = new System.Drawing.Point(35, 145);
            this.labelTimeFrom.Name = "labelTimeFrom";
            this.labelTimeFrom.Size = new System.Drawing.Size(45, 25);
            this.labelTimeFrom.TabIndex = 67;
            this.labelTimeFrom.Text = "Час:";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateFrom.Location = new System.Drawing.Point(27, 111);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(53, 25);
            this.labelDateFrom.TabIndex = 66;
            this.labelDateFrom.Text = "Дата:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(309, 70);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(55, 25);
            this.labelTo.TabIndex = 65;
            this.labelTo.Text = "Куди:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(16, 70);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(69, 25);
            this.labelFrom.TabIndex = 64;
            this.labelFrom.Text = "Звідки:";
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberRoute.Location = new System.Drawing.Point(16, 10);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(125, 28);
            this.labelNumberRoute.TabIndex = 63;
            this.labelNumberRoute.Text = "Маршрут №";
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 451);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.numericUpDownPassenger);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPassenger);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNumberRoute);
            this.Controls.Add(this.maskedTextBoxTimeTo);
            this.Controls.Add(this.maskedTextBoxTimeFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelTimeTo);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelTimeFrom);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelNumberRoute);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPrice;
        private NumericUpDown numericUpDownPassenger;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonBuy;
        private Label labelPrice;
        private Label labelPassenger;
        private Label labelSurname;
        private Label labelName;
        private TextBox textBoxNumberRoute;
        private MaskedTextBox maskedTextBoxTimeTo;
        private MaskedTextBox maskedTextBoxTimeFrom;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private Label labelTimeTo;
        private Label labelDateTo;
        private Label labelTimeFrom;
        private Label labelDateFrom;
        private Label labelTo;
        private Label labelFrom;
        private Label labelNumberRoute;
    }
}
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
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.passengerNumeric = new System.Windows.Forms.NumericUpDown();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberRouteTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.timeToLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.timeFromLabel = new System.Windows.Forms.Label();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.numberRouteLabel = new System.Windows.Forms.Label();
            this.timeFromTextBox = new System.Windows.Forms.TextBox();
            this.timeToTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.passengerNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.BackColor = System.Drawing.Color.White;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.Location = new System.Drawing.Point(91, 399);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(99, 24);
            this.priceTextBox.TabIndex = 86;
            this.priceTextBox.TabStop = false;
            // 
            // passengerNumeric
            // 
            this.passengerNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passengerNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passengerNumeric.Location = new System.Drawing.Point(191, 268);
            this.passengerNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passengerNumeric.Name = "passengerNumeric";
            this.passengerNumeric.Size = new System.Drawing.Size(69, 29);
            this.passengerNumeric.TabIndex = 85;
            this.passengerNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passengerNumeric.ValueChanged += new System.EventHandler(this.numericPassenger_ValueChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameTextBox.Location = new System.Drawing.Point(411, 214);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(196, 29);
            this.surnameTextBox.TabIndex = 84;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(86, 214);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 29);
            this.nameTextBox.TabIndex = 83;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(331, 393);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(137, 46);
            this.cancel.TabIndex = 82;
            this.cancel.Text = "Скасувати";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buy
            // 
            this.buy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buy.ForeColor = System.Drawing.Color.White;
            this.buy.Location = new System.Drawing.Point(474, 393);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(137, 46);
            this.buy.TabIndex = 81;
            this.buy.Text = "Придбати";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.priceLabel.Location = new System.Drawing.Point(27, 394);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(60, 28);
            this.priceLabel.TabIndex = 80;
            this.priceLabel.Text = "Ціна:";
            // 
            // passengerLabel
            // 
            this.passengerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passengerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.passengerLabel.Location = new System.Drawing.Point(11, 269);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(171, 23);
            this.passengerLabel.TabIndex = 79;
            this.passengerLabel.Text = "Кількість пасажирів:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.surnameLabel.Location = new System.Drawing.Point(309, 216);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(92, 23);
            this.surnameLabel.TabIndex = 78;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.nameLabel.Location = new System.Drawing.Point(33, 216);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 23);
            this.nameLabel.TabIndex = 77;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // numberRouteTextBox
            // 
            this.numberRouteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberRouteTextBox.BackColor = System.Drawing.Color.White;
            this.numberRouteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberRouteTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteTextBox.Location = new System.Drawing.Point(147, 15);
            this.numberRouteTextBox.Name = "numberRouteTextBox";
            this.numberRouteTextBox.ReadOnly = true;
            this.numberRouteTextBox.Size = new System.Drawing.Size(79, 23);
            this.numberRouteTextBox.TabIndex = 76;
            this.numberRouteTextBox.TabStop = false;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toDateTimePicker.Location = new System.Drawing.Point(411, 105);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(196, 30);
            this.toDateTimePicker.TabIndex = 73;
            this.toDateTimePicker.TabStop = false;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromDateTimePicker.Location = new System.Drawing.Point(86, 107);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(196, 30);
            this.fromDateTimePicker.TabIndex = 72;
            this.fromDateTimePicker.TabStop = false;
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toTextBox.BackColor = System.Drawing.Color.White;
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.Location = new System.Drawing.Point(411, 71);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(196, 23);
            this.toTextBox.TabIndex = 71;
            this.toTextBox.TabStop = false;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromTextBox.BackColor = System.Drawing.Color.White;
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.Location = new System.Drawing.Point(86, 71);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(196, 23);
            this.fromTextBox.TabIndex = 70;
            this.fromTextBox.TabStop = false;
            // 
            // timeToLabel
            // 
            this.timeToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToLabel.AutoSize = true;
            this.timeToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeToLabel.Location = new System.Drawing.Point(360, 148);
            this.timeToLabel.Name = "timeToLabel";
            this.timeToLabel.Size = new System.Drawing.Size(43, 23);
            this.timeToLabel.TabIndex = 69;
            this.timeToLabel.Text = "Час:";
            // 
            // dateToLabel
            // 
            this.dateToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateToLabel.Location = new System.Drawing.Point(352, 111);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(51, 23);
            this.dateToLabel.TabIndex = 68;
            this.dateToLabel.Text = "Дата:";
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeFromLabel.AutoSize = true;
            this.timeFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeFromLabel.Location = new System.Drawing.Point(35, 148);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(43, 23);
            this.timeFromLabel.TabIndex = 67;
            this.timeFromLabel.Text = "Час:";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateFromLabel.Location = new System.Drawing.Point(27, 111);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(51, 23);
            this.dateFromLabel.TabIndex = 66;
            this.dateFromLabel.Text = "Дата:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.toLabel.Location = new System.Drawing.Point(350, 70);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(51, 23);
            this.toLabel.TabIndex = 65;
            this.toLabel.Text = "Куди:";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.fromLabel.Location = new System.Drawing.Point(11, 69);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(65, 23);
            this.fromLabel.TabIndex = 64;
            this.fromLabel.Text = "Звідки:";
            // 
            // numberRouteLabel
            // 
            this.numberRouteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberRouteLabel.AutoSize = true;
            this.numberRouteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.numberRouteLabel.Location = new System.Drawing.Point(16, 10);
            this.numberRouteLabel.Name = "numberRouteLabel";
            this.numberRouteLabel.Size = new System.Drawing.Size(129, 28);
            this.numberRouteLabel.TabIndex = 63;
            this.numberRouteLabel.Text = "Маршрут №";
            // 
            // timeFromTextBox
            // 
            this.timeFromTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeFromTextBox.BackColor = System.Drawing.Color.White;
            this.timeFromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeFromTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFromTextBox.Location = new System.Drawing.Point(86, 149);
            this.timeFromTextBox.Name = "timeFromTextBox";
            this.timeFromTextBox.ReadOnly = true;
            this.timeFromTextBox.Size = new System.Drawing.Size(196, 23);
            this.timeFromTextBox.TabIndex = 87;
            this.timeFromTextBox.TabStop = false;
            // 
            // timeToTextBox
            // 
            this.timeToTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToTextBox.BackColor = System.Drawing.Color.White;
            this.timeToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeToTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeToTextBox.Location = new System.Drawing.Point(411, 150);
            this.timeToTextBox.Name = "timeToTextBox";
            this.timeToTextBox.ReadOnly = true;
            this.timeToTextBox.Size = new System.Drawing.Size(196, 23);
            this.timeToTextBox.TabIndex = 88;
            this.timeToTextBox.TabStop = false;
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 451);
            this.Controls.Add(this.timeToTextBox);
            this.Controls.Add(this.timeFromTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.passengerNumeric);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numberRouteTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.timeToLabel);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.timeFromLabel);
            this.Controls.Add(this.dateFromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.numberRouteLabel);
            this.MinimumSize = new System.Drawing.Size(639, 490);
            this.Name = "BuyTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengerNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox priceTextBox;
        private NumericUpDown passengerNumeric;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Button cancel;
        private Button buy;
        private Label priceLabel;
        private Label passengerLabel;
        private Label surnameLabel;
        private Label nameLabel;
        private TextBox numberRouteTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private TextBox toTextBox;
        private TextBox fromTextBox;
        private Label timeToLabel;
        private Label dateToLabel;
        private Label timeFromLabel;
        private Label dateFromLabel;
        private Label toLabel;
        private Label fromLabel;
        private Label numberRouteLabel;
        private TextBox timeFromTextBox;
        private TextBox timeToTextBox;
    }
}
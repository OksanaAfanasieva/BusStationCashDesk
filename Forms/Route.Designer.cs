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
            this.timeStopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.addStop = new System.Windows.Forms.Button();
            this.timeStopLabel = new System.Windows.Forms.Label();
            this.nameStopLabel = new System.Windows.Forms.Label();
            this.nameStopTextBox = new System.Windows.Forms.TextBox();
            this.numberRouteTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.freePlaceLabel = new System.Windows.Forms.Label();
            this.timeToLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.timeFromLabel = new System.Windows.Forms.Label();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.numberRouteLabel = new System.Windows.Forms.Label();
            this.stopListView = new System.Windows.Forms.ListView();
            this.stop = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.removeStop = new System.Windows.Forms.Button();
            this.freeSeatNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.freeSeatNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // timeStopDateTimePicker
            // 
            this.timeStopDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeStopDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeStopDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStopDateTimePicker.Location = new System.Drawing.Point(201, 343);
            this.timeStopDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timeStopDateTimePicker.Name = "timeStopDateTimePicker";
            this.timeStopDateTimePicker.ShowUpDown = true;
            this.timeStopDateTimePicker.Size = new System.Drawing.Size(178, 29);
            this.timeStopDateTimePicker.TabIndex = 119;
            this.timeStopDateTimePicker.ValueChanged += new System.EventHandler(this.timePickerStop_ValueChanged);
            // 
            // timeToDateTimePicker
            // 
            this.timeToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeToDateTimePicker.Location = new System.Drawing.Point(371, 141);
            this.timeToDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timeToDateTimePicker.Name = "timeToDateTimePicker";
            this.timeToDateTimePicker.ShowUpDown = true;
            this.timeToDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.timeToDateTimePicker.TabIndex = 118;
            // 
            // timeFromDateTimePicker
            // 
            this.timeFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeFromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFromDateTimePicker.Location = new System.Drawing.Point(92, 141);
            this.timeFromDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timeFromDateTimePicker.Name = "timeFromDateTimePicker";
            this.timeFromDateTimePicker.ShowUpDown = true;
            this.timeFromDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.timeFromDateTimePicker.TabIndex = 117;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.AutoSize = true;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(277, 444);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(142, 40);
            this.cancel.TabIndex = 116;
            this.cancel.Text = "Скасувати";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.AutoSize = true;
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(425, 444);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(142, 40);
            this.save.TabIndex = 115;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // addStop
            // 
            this.addStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.addStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStop.ForeColor = System.Drawing.Color.White;
            this.addStop.Location = new System.Drawing.Point(385, 312);
            this.addStop.Name = "addStop";
            this.addStop.Size = new System.Drawing.Size(94, 60);
            this.addStop.TabIndex = 94;
            this.addStop.Text = "Додати зупинку";
            this.addStop.UseVisualStyleBackColor = false;
            this.addStop.Click += new System.EventHandler(this.buttonAddStop_Click_1);
            // 
            // timeStopLabel
            // 
            this.timeStopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeStopLabel.AutoSize = true;
            this.timeStopLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeStopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeStopLabel.Location = new System.Drawing.Point(201, 315);
            this.timeStopLabel.Name = "timeStopLabel";
            this.timeStopLabel.Size = new System.Drawing.Size(39, 23);
            this.timeStopLabel.TabIndex = 114;
            this.timeStopLabel.Text = "Час";
            this.timeStopLabel.Click += new System.EventHandler(this.labelTimeStop_Click);
            // 
            // nameStopLabel
            // 
            this.nameStopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameStopLabel.AutoSize = true;
            this.nameStopLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameStopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.nameStopLabel.Location = new System.Drawing.Point(17, 315);
            this.nameStopLabel.Name = "nameStopLabel";
            this.nameStopLabel.Size = new System.Drawing.Size(58, 23);
            this.nameStopLabel.TabIndex = 113;
            this.nameStopLabel.Text = "Назва";
            this.nameStopLabel.Click += new System.EventHandler(this.labelNameStop_Click);
            // 
            // nameStopTextBox
            // 
            this.nameStopTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameStopTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameStopTextBox.Location = new System.Drawing.Point(17, 343);
            this.nameStopTextBox.Name = "nameStopTextBox";
            this.nameStopTextBox.Size = new System.Drawing.Size(178, 29);
            this.nameStopTextBox.TabIndex = 112;
            this.nameStopTextBox.TextChanged += new System.EventHandler(this.textBoxNameStop_TextChanged);
            this.nameStopTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameStop_KeyPress);
            // 
            // numberRouteTextBox
            // 
            this.numberRouteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberRouteTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberRouteTextBox.Location = new System.Drawing.Point(148, 19);
            this.numberRouteTextBox.Name = "numberRouteTextBox";
            this.numberRouteTextBox.Size = new System.Drawing.Size(79, 29);
            this.numberRouteTextBox.TabIndex = 110;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toDateTimePicker.Location = new System.Drawing.Point(371, 106);
            this.toDateTimePicker.MinDate = new System.DateTime(2023, 6, 12, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.toDateTimePicker.TabIndex = 109;
            this.toDateTimePicker.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromDateTimePicker.Location = new System.Drawing.Point(92, 106);
            this.fromDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.fromDateTimePicker.TabIndex = 108;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.Location = new System.Drawing.Point(443, 388);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(80, 29);
            this.priceTextBox.TabIndex = 107;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.Location = new System.Drawing.Point(371, 68);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(196, 29);
            this.toTextBox.TabIndex = 105;
            this.toTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTo_KeyPress);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.Location = new System.Drawing.Point(92, 68);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(196, 29);
            this.fromTextBox.TabIndex = 104;
            this.fromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrom_KeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.priceLabel.Location = new System.Drawing.Point(385, 388);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 23);
            this.priceLabel.TabIndex = 103;
            this.priceLabel.Text = "Ціна:";
            // 
            // freePlaceLabel
            // 
            this.freePlaceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.freePlaceLabel.AutoSize = true;
            this.freePlaceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.freePlaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.freePlaceLabel.Location = new System.Drawing.Point(17, 388);
            this.freePlaceLabel.Name = "freePlaceLabel";
            this.freePlaceLabel.Size = new System.Drawing.Size(200, 23);
            this.freePlaceLabel.TabIndex = 102;
            this.freePlaceLabel.Text = "Кількість вільних місць:";
            // 
            // timeToLabel
            // 
            this.timeToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToLabel.AutoSize = true;
            this.timeToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeToLabel.Location = new System.Drawing.Point(320, 141);
            this.timeToLabel.Name = "timeToLabel";
            this.timeToLabel.Size = new System.Drawing.Size(45, 25);
            this.timeToLabel.TabIndex = 101;
            this.timeToLabel.Text = "Час:";
            // 
            // dateToLabel
            // 
            this.dateToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateToLabel.Location = new System.Drawing.Point(312, 107);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(55, 25);
            this.dateToLabel.TabIndex = 100;
            this.dateToLabel.Text = "Дата:";
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeFromLabel.AutoSize = true;
            this.timeFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeFromLabel.Location = new System.Drawing.Point(41, 141);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(45, 25);
            this.timeFromLabel.TabIndex = 99;
            this.timeFromLabel.Text = "Час:";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateFromLabel.Location = new System.Drawing.Point(33, 107);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(55, 25);
            this.dateFromLabel.TabIndex = 98;
            this.dateFromLabel.Text = "Дата:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.toLabel.Location = new System.Drawing.Point(310, 68);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(55, 25);
            this.toLabel.TabIndex = 97;
            this.toLabel.Text = "Куди:";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.fromLabel.Location = new System.Drawing.Point(17, 68);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(71, 25);
            this.fromLabel.TabIndex = 96;
            this.fromLabel.Text = "Звідки:";
            // 
            // numberRouteLabel
            // 
            this.numberRouteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberRouteLabel.AutoSize = true;
            this.numberRouteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.numberRouteLabel.Location = new System.Drawing.Point(17, 19);
            this.numberRouteLabel.Name = "numberRouteLabel";
            this.numberRouteLabel.Size = new System.Drawing.Size(129, 28);
            this.numberRouteLabel.TabIndex = 95;
            this.numberRouteLabel.Text = "Маршрут №";
            // 
            // stopListView
            // 
            this.stopListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stop,
            this.time});
            this.stopListView.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopListView.FullRowSelect = true;
            this.stopListView.GridLines = true;
            this.stopListView.Location = new System.Drawing.Point(17, 195);
            this.stopListView.Name = "stopListView";
            this.stopListView.Size = new System.Drawing.Size(556, 111);
            this.stopListView.TabIndex = 120;
            this.stopListView.UseCompatibleStateImageBehavior = false;
            this.stopListView.View = System.Windows.Forms.View.Details;
            // 
            // stop
            // 
            this.stop.Text = "Зупинки";
            this.stop.Width = 350;
            // 
            // time
            // 
            this.time.Text = "Час";
            this.time.Width = 190;
            // 
            // removeStop
            // 
            this.removeStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.removeStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeStop.ForeColor = System.Drawing.Color.White;
            this.removeStop.Location = new System.Drawing.Point(479, 312);
            this.removeStop.Name = "removeStop";
            this.removeStop.Size = new System.Drawing.Size(94, 59);
            this.removeStop.TabIndex = 121;
            this.removeStop.Text = "Видалити зупинку";
            this.removeStop.UseVisualStyleBackColor = false;
            this.removeStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // freeSeatNumeric
            // 
            this.freeSeatNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.freeSeatNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.freeSeatNumeric.Location = new System.Drawing.Point(223, 388);
            this.freeSeatNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.freeSeatNumeric.Name = "freeSeatNumeric";
            this.freeSeatNumeric.Size = new System.Drawing.Size(69, 29);
            this.freeSeatNumeric.TabIndex = 122;
            this.freeSeatNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 504);
            this.Controls.Add(this.freeSeatNumeric);
            this.Controls.Add(this.removeStop);
            this.Controls.Add(this.stopListView);
            this.Controls.Add(this.timeStopDateTimePicker);
            this.Controls.Add(this.timeToDateTimePicker);
            this.Controls.Add(this.timeFromDateTimePicker);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addStop);
            this.Controls.Add(this.timeStopLabel);
            this.Controls.Add(this.nameStopLabel);
            this.Controls.Add(this.nameStopTextBox);
            this.Controls.Add(this.numberRouteTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.freePlaceLabel);
            this.Controls.Add(this.timeToLabel);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.timeFromLabel);
            this.Controls.Add(this.dateFromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.numberRouteLabel);
            this.MinimumSize = new System.Drawing.Size(600, 543);
            this.Name = "Route";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрут";
            this.Load += new System.EventHandler(this.Route_Load);
            ((System.ComponentModel.ISupportInitialize)(this.freeSeatNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker timeStopDateTimePicker;
        private DateTimePicker timeToDateTimePicker;
        private DateTimePicker timeFromDateTimePicker;
        private Button cancel;
        private Button save;
        private Button addStop;
        private Label timeStopLabel;
        private Label nameStopLabel;
        private TextBox nameStopTextBox;
        private TextBox numberRouteTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private TextBox priceTextBox;
        private TextBox toTextBox;
        private TextBox fromTextBox;
        private Label priceLabel;
        private Label freePlaceLabel;
        private Label timeToLabel;
        private Label dateToLabel;
        private Label timeFromLabel;
        private Label dateFromLabel;
        private Label toLabel;
        private Label fromLabel;
        private Label numberRouteLabel;
        private ListView stopListView;
        private ColumnHeader stop;
        private ColumnHeader time;
        private Button removeStop;
        private NumericUpDown freeSeatNumeric;
    }
}
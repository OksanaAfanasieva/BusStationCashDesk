namespace BusStationCashDesk.Forms
{
    partial class Edit
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
            this.removeStop = new System.Windows.Forms.Button();
            this.stopList = new System.Windows.Forms.ListView();
            this.stop = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
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
            this.dateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.freeSeatNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.freeSeatNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // removeStop
            // 
            this.removeStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.removeStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeStop.ForeColor = System.Drawing.Color.White;
            this.removeStop.Location = new System.Drawing.Point(497, 298);
            this.removeStop.Name = "removeStop";
            this.removeStop.Size = new System.Drawing.Size(99, 59);
            this.removeStop.TabIndex = 148;
            this.removeStop.Text = "Видалити зупинку";
            this.removeStop.UseVisualStyleBackColor = false;
            this.removeStop.Click += new System.EventHandler(this.buttonRemoveStop_Click);
            // 
            // stopList
            // 
            this.stopList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stop,
            this.time});
            this.stopList.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopList.FullRowSelect = true;
            this.stopList.GridLines = true;
            this.stopList.Location = new System.Drawing.Point(35, 181);
            this.stopList.Name = "stopList";
            this.stopList.Size = new System.Drawing.Size(561, 111);
            this.stopList.TabIndex = 147;
            this.stopList.UseCompatibleStateImageBehavior = false;
            this.stopList.View = System.Windows.Forms.View.Details;
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
            // timeStopDateTimePicker
            // 
            this.timeStopDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeStopDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeStopDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStopDateTimePicker.Location = new System.Drawing.Point(219, 329);
            this.timeStopDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timeStopDateTimePicker.Name = "timeStopDateTimePicker";
            this.timeStopDateTimePicker.ShowUpDown = true;
            this.timeStopDateTimePicker.Size = new System.Drawing.Size(178, 29);
            this.timeStopDateTimePicker.TabIndex = 146;
            // 
            // timeToDateTimePicker
            // 
            this.timeToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeToDateTimePicker.Location = new System.Drawing.Point(400, 147);
            this.timeToDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timeToDateTimePicker.Name = "timeToDateTimePicker";
            this.timeToDateTimePicker.ShowUpDown = true;
            this.timeToDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.timeToDateTimePicker.TabIndex = 145;
            // 
            // timeFromDateTimePicker
            // 
            this.timeFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeFromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFromDateTimePicker.Location = new System.Drawing.Point(110, 147);
            this.timeFromDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.timeFromDateTimePicker.Name = "timeFromDateTimePicker";
            this.timeFromDateTimePicker.ShowUpDown = true;
            this.timeFromDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.timeFromDateTimePicker.TabIndex = 144;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(306, 452);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(142, 40);
            this.cancel.TabIndex = 143;
            this.cancel.Text = "Скасувати";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(454, 452);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(142, 40);
            this.save.TabIndex = 142;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // addStop
            // 
            this.addStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.addStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStop.ForeColor = System.Drawing.Color.White;
            this.addStop.Location = new System.Drawing.Point(403, 298);
            this.addStop.Name = "addStop";
            this.addStop.Size = new System.Drawing.Size(99, 60);
            this.addStop.TabIndex = 122;
            this.addStop.Text = "Додати зупинку";
            this.addStop.UseVisualStyleBackColor = false;
            this.addStop.Click += new System.EventHandler(this.buttonAddStop_Click);
            // 
            // timeStopLabel
            // 
            this.timeStopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeStopLabel.AutoSize = true;
            this.timeStopLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeStopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeStopLabel.Location = new System.Drawing.Point(219, 301);
            this.timeStopLabel.Name = "timeStopLabel";
            this.timeStopLabel.Size = new System.Drawing.Size(39, 23);
            this.timeStopLabel.TabIndex = 141;
            this.timeStopLabel.Text = "Час";
            // 
            // nameStopLabel
            // 
            this.nameStopLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameStopLabel.AutoSize = true;
            this.nameStopLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameStopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.nameStopLabel.Location = new System.Drawing.Point(35, 301);
            this.nameStopLabel.Name = "nameStopLabel";
            this.nameStopLabel.Size = new System.Drawing.Size(58, 23);
            this.nameStopLabel.TabIndex = 140;
            this.nameStopLabel.Text = "Назва";
            // 
            // nameStopTextBox
            // 
            this.nameStopTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameStopTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameStopTextBox.Location = new System.Drawing.Point(35, 329);
            this.nameStopTextBox.Name = "nameStopTextBox";
            this.nameStopTextBox.Size = new System.Drawing.Size(178, 29);
            this.nameStopTextBox.TabIndex = 139;
            // 
            // numberRouteTextBox
            // 
            this.numberRouteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberRouteTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberRouteTextBox.Location = new System.Drawing.Point(166, 22);
            this.numberRouteTextBox.Name = "numberRouteTextBox";
            this.numberRouteTextBox.Size = new System.Drawing.Size(79, 29);
            this.numberRouteTextBox.TabIndex = 138;
            // 
            // dateToDateTimePicker
            // 
            this.dateToDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateToDateTimePicker.Location = new System.Drawing.Point(400, 111);
            this.dateToDateTimePicker.MinDate = new System.DateTime(2023, 6, 12, 0, 0, 0, 0);
            this.dateToDateTimePicker.Name = "dateToDateTimePicker";
            this.dateToDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.dateToDateTimePicker.TabIndex = 137;
            this.dateToDateTimePicker.Value = new System.DateTime(2023, 6, 29, 0, 0, 0, 0);
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(110, 111);
            this.dateFromDateTimePicker.MinDate = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            this.dateFromDateTimePicker.Name = "dateFromDateTimePicker";
            this.dateFromDateTimePicker.Size = new System.Drawing.Size(196, 29);
            this.dateFromDateTimePicker.TabIndex = 136;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.Location = new System.Drawing.Point(461, 380);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(80, 29);
            this.priceTextBox.TabIndex = 135;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.Location = new System.Drawing.Point(400, 68);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(196, 29);
            this.toTextBox.TabIndex = 133;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.Location = new System.Drawing.Point(110, 68);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(196, 29);
            this.fromTextBox.TabIndex = 132;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.priceLabel.Location = new System.Drawing.Point(403, 378);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 23);
            this.priceLabel.TabIndex = 131;
            this.priceLabel.Text = "Ціна:";
            // 
            // freePlaceLabel
            // 
            this.freePlaceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.freePlaceLabel.AutoSize = true;
            this.freePlaceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.freePlaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.freePlaceLabel.Location = new System.Drawing.Point(35, 378);
            this.freePlaceLabel.Name = "freePlaceLabel";
            this.freePlaceLabel.Size = new System.Drawing.Size(200, 23);
            this.freePlaceLabel.TabIndex = 130;
            this.freePlaceLabel.Text = "Кількість вільних місць:";
            // 
            // timeToLabel
            // 
            this.timeToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToLabel.AutoSize = true;
            this.timeToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeToLabel.Location = new System.Drawing.Point(349, 147);
            this.timeToLabel.Name = "timeToLabel";
            this.timeToLabel.Size = new System.Drawing.Size(45, 25);
            this.timeToLabel.TabIndex = 129;
            this.timeToLabel.Text = "Час:";
            // 
            // dateToLabel
            // 
            this.dateToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateToLabel.Location = new System.Drawing.Point(341, 111);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(55, 25);
            this.dateToLabel.TabIndex = 128;
            this.dateToLabel.Text = "Дата:";
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeFromLabel.AutoSize = true;
            this.timeFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeFromLabel.Location = new System.Drawing.Point(59, 147);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(45, 25);
            this.timeFromLabel.TabIndex = 127;
            this.timeFromLabel.Text = "Час:";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateFromLabel.Location = new System.Drawing.Point(51, 111);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(55, 25);
            this.dateFromLabel.TabIndex = 126;
            this.dateFromLabel.Text = "Дата:";
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.toLabel.Location = new System.Drawing.Point(339, 70);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(55, 25);
            this.toLabel.TabIndex = 125;
            this.toLabel.Text = "Куди:";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.fromLabel.Location = new System.Drawing.Point(35, 70);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(71, 25);
            this.fromLabel.TabIndex = 124;
            this.fromLabel.Text = "Звідки:";
            // 
            // numberRouteLabel
            // 
            this.numberRouteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberRouteLabel.AutoSize = true;
            this.numberRouteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.numberRouteLabel.Location = new System.Drawing.Point(35, 19);
            this.numberRouteLabel.Name = "numberRouteLabel";
            this.numberRouteLabel.Size = new System.Drawing.Size(129, 28);
            this.numberRouteLabel.TabIndex = 123;
            this.numberRouteLabel.Text = "Маршрут №";
            // 
            // freeSeatNumeric
            // 
            this.freeSeatNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.freeSeatNumeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.freeSeatNumeric.Location = new System.Drawing.Point(241, 381);
            this.freeSeatNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.freeSeatNumeric.Name = "freeSeatNumeric";
            this.freeSeatNumeric.Size = new System.Drawing.Size(69, 29);
            this.freeSeatNumeric.TabIndex = 149;
            this.freeSeatNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 504);
            this.Controls.Add(this.freeSeatNumeric);
            this.Controls.Add(this.removeStop);
            this.Controls.Add(this.stopList);
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
            this.Controls.Add(this.dateToDateTimePicker);
            this.Controls.Add(this.dateFromDateTimePicker);
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
            this.MinimumSize = new System.Drawing.Size(607, 543);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.freeSeatNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button removeStop;
        private ListView stopList;
        private ColumnHeader stop;
        private ColumnHeader time;
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
        private DateTimePicker dateToDateTimePicker;
        private DateTimePicker dateFromDateTimePicker;
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
        private NumericUpDown freeSeatNumeric;
    }
}
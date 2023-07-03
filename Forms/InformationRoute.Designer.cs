namespace BusStationCashDesk.Windows_Forms
{
    partial class InformationRoute
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
            this.numberRouteTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.freePlaceTextBox = new System.Windows.Forms.TextBox();
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
            this.listStop = new System.Windows.Forms.ListView();
            this.stop = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.timeFromTextBox = new System.Windows.Forms.TextBox();
            this.timeToTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberRouteTextBox
            // 
            this.numberRouteTextBox.BackColor = System.Drawing.Color.White;
            this.numberRouteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberRouteTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteTextBox.Location = new System.Drawing.Point(148, 24);
            this.numberRouteTextBox.Name = "numberRouteTextBox";
            this.numberRouteTextBox.ReadOnly = true;
            this.numberRouteTextBox.Size = new System.Drawing.Size(79, 23);
            this.numberRouteTextBox.TabIndex = 109;
            this.numberRouteTextBox.TabStop = false;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toDateTimePicker.Location = new System.Drawing.Point(371, 116);
            this.toDateTimePicker.MinDate = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(196, 30);
            this.toDateTimePicker.TabIndex = 106;
            this.toDateTimePicker.TabStop = false;
            this.toDateTimePicker.Value = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromDateTimePicker.Location = new System.Drawing.Point(92, 116);
            this.fromDateTimePicker.MinDate = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(196, 30);
            this.fromDateTimePicker.TabIndex = 105;
            this.fromDateTimePicker.TabStop = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.White;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceTextBox.Location = new System.Drawing.Point(487, 348);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(80, 23);
            this.priceTextBox.TabIndex = 104;
            this.priceTextBox.TabStop = false;
            // 
            // freePlaceTextBox
            // 
            this.freePlaceTextBox.BackColor = System.Drawing.Color.White;
            this.freePlaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.freePlaceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.freePlaceTextBox.ForeColor = System.Drawing.Color.Black;
            this.freePlaceTextBox.Location = new System.Drawing.Point(223, 348);
            this.freePlaceTextBox.Name = "freePlaceTextBox";
            this.freePlaceTextBox.ReadOnly = true;
            this.freePlaceTextBox.Size = new System.Drawing.Size(51, 23);
            this.freePlaceTextBox.TabIndex = 103;
            this.freePlaceTextBox.TabStop = false;
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.Color.White;
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toTextBox.Location = new System.Drawing.Point(371, 80);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(196, 23);
            this.toTextBox.TabIndex = 102;
            this.toTextBox.TabStop = false;
            // 
            // fromTextBox
            // 
            this.fromTextBox.BackColor = System.Drawing.Color.White;
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromTextBox.Location = new System.Drawing.Point(92, 79);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(196, 23);
            this.fromTextBox.TabIndex = 101;
            this.fromTextBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.priceLabel.Location = new System.Drawing.Point(429, 346);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 23);
            this.priceLabel.TabIndex = 100;
            this.priceLabel.Text = "Ціна:";
            // 
            // freePlaceLabel
            // 
            this.freePlaceLabel.AutoSize = true;
            this.freePlaceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.freePlaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.freePlaceLabel.Location = new System.Drawing.Point(17, 346);
            this.freePlaceLabel.Name = "freePlaceLabel";
            this.freePlaceLabel.Size = new System.Drawing.Size(200, 23);
            this.freePlaceLabel.TabIndex = 99;
            this.freePlaceLabel.Text = "Кількість вільних місць:";
            // 
            // timeToLabel
            // 
            this.timeToLabel.AutoSize = true;
            this.timeToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeToLabel.Location = new System.Drawing.Point(320, 154);
            this.timeToLabel.Name = "timeToLabel";
            this.timeToLabel.Size = new System.Drawing.Size(43, 23);
            this.timeToLabel.TabIndex = 98;
            this.timeToLabel.Text = "Час:";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateToLabel.Location = new System.Drawing.Point(312, 120);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(51, 23);
            this.dateToLabel.TabIndex = 97;
            this.dateToLabel.Text = "Дата:";
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.AutoSize = true;
            this.timeFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.timeFromLabel.Location = new System.Drawing.Point(41, 154);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(43, 23);
            this.timeFromLabel.TabIndex = 96;
            this.timeFromLabel.Text = "Час:";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateFromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.dateFromLabel.Location = new System.Drawing.Point(33, 120);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(51, 23);
            this.dateFromLabel.TabIndex = 95;
            this.dateFromLabel.Text = "Дата:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.toLabel.Location = new System.Drawing.Point(312, 79);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(51, 23);
            this.toLabel.TabIndex = 94;
            this.toLabel.Text = "Куди:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.fromLabel.Location = new System.Drawing.Point(17, 79);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(65, 23);
            this.fromLabel.TabIndex = 93;
            this.fromLabel.Text = "Звідки:";
            // 
            // numberRouteLabel
            // 
            this.numberRouteLabel.AutoSize = true;
            this.numberRouteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberRouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.numberRouteLabel.Location = new System.Drawing.Point(17, 19);
            this.numberRouteLabel.Name = "numberRouteLabel";
            this.numberRouteLabel.Size = new System.Drawing.Size(129, 28);
            this.numberRouteLabel.TabIndex = 92;
            this.numberRouteLabel.Text = "Маршрут №";
            // 
            // listStop
            // 
            this.listStop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stop,
            this.time});
            this.listStop.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listStop.Location = new System.Drawing.Point(17, 199);
            this.listStop.Name = "listStop";
            this.listStop.Size = new System.Drawing.Size(550, 137);
            this.listStop.TabIndex = 110;
            this.listStop.TabStop = false;
            this.listStop.UseCompatibleStateImageBehavior = false;
            this.listStop.View = System.Windows.Forms.View.Details;
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
            // timeFromTextBox
            // 
            this.timeFromTextBox.BackColor = System.Drawing.Color.White;
            this.timeFromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeFromTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFromTextBox.Location = new System.Drawing.Point(92, 154);
            this.timeFromTextBox.Name = "timeFromTextBox";
            this.timeFromTextBox.ReadOnly = true;
            this.timeFromTextBox.Size = new System.Drawing.Size(196, 23);
            this.timeFromTextBox.TabIndex = 111;
            this.timeFromTextBox.TabStop = false;
            // 
            // timeToTextBox
            // 
            this.timeToTextBox.BackColor = System.Drawing.Color.White;
            this.timeToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeToTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeToTextBox.Location = new System.Drawing.Point(371, 155);
            this.timeToTextBox.Name = "timeToTextBox";
            this.timeToTextBox.ReadOnly = true;
            this.timeToTextBox.Size = new System.Drawing.Size(196, 23);
            this.timeToTextBox.TabIndex = 112;
            this.timeToTextBox.TabStop = false;
            // 
            // InformationRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.timeToTextBox);
            this.Controls.Add(this.timeFromTextBox);
            this.Controls.Add(this.listStop);
            this.Controls.Add(this.numberRouteTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.freePlaceTextBox);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 430);
            this.MinimumSize = new System.Drawing.Size(600, 430);
            this.Name = "InformationRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маршрут";
            this.Load += new System.EventHandler(this.InformationRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numberRouteTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private TextBox priceTextBox;
        private TextBox freePlaceTextBox;
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
        private ListView listStop;
        private ColumnHeader stop;
        private ColumnHeader time;
        private TextBox timeFromTextBox;
        private TextBox timeToTextBox;
    }
}